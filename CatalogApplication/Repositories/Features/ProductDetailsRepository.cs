using System.Data;
using CatalogApplication.Database;
using CatalogApplication.Types.Products.Dtos;
using Dapper;
using Microsoft.Data.SqlClient;

namespace CatalogApplication.Repositories.Features;

internal sealed class ProductDetailsRepository : BaseRepository<ProductDetailsRepository>
{
    readonly TimeSpan _cacheLifeMinutes = TimeSpan.FromMinutes( 5 );
    readonly object _cacheLock = new();
    
    Timer _timer;
    Dictionary<Guid, CacheEntry> _cache = [];
    
    // language=sql
    const string sql =
        """
        SELECT CategoryId FROM CatalogApi.ProductCategories
                  WHERE ProductId = @productId;
        SELECT
            p.Id, p.BrandId, p.Name, p.Image, p.IsFeatured, p.IsInStock, p.Price, p.SalePrice, p.NumberSold, p.NumberRatings, p.Rating,
            pd.Description,
            px.Xml
        FROM CatalogApi.Products p
            INNER JOIN CatalogApi.ProductDescriptions pd ON p.Id = pd.ProductId
            INNER JOIN CatalogApi.ProductXmls px ON p.Id = px.ProductId
            WHERE p.Id = @productId;
        """;
    
    public ProductDetailsRepository( IDapperContext dapper, ILogger<ProductDetailsRepository> logger ) : base( dapper, logger )
    {
        _timer = new Timer( _ => Cleanup(), null, TimeSpan.Zero, _cacheLifeMinutes );
    }

    internal async Task<ProductDto?> GetDetails( Guid productId )
    {
        if (_cache.TryGetValue( productId, out CacheEntry entry ) && DateTime.Now - entry.Timestamp < _cacheLifeMinutes)
            return entry.Dto; 

        await FetchDetails( productId );
        bool has = _cache.TryGetValue( productId, out entry );
        return has
            ? entry.Dto
            : null;
    }
    async Task<bool> FetchDetails( Guid productId )
    {
        try {
            await using SqlConnection connection = await Dapper.GetOpenConnection();

            if (connection.State != ConnectionState.Open) {
                LogError( $"Invalid connection state: {connection.State}" );
                return false;
            }

            DynamicParameters p = new();
            p.Add( "productId", productId );
            await using SqlMapper.GridReader reader = await connection.QueryMultipleAsync( sql, p, commandType: CommandType.Text );
            IEnumerable<Guid> categories = await reader.ReadAsync<Guid>();
            var details = await reader.ReadSingleAsync<ProductDto>();
            ProductDto result = details with { Id = productId, CategoryIds = categories.ToList() };
            CacheEntry entry = new( result, DateTime.Now );
            _cache.TryAdd( result.Id, entry );
            return true;
        }
        catch ( Exception e ) {
            LogException( e, $"Error while attempting to fetch product details from repository: {e.Message}" );
            return false;
        }
    }
    void Cleanup()
    {
        lock ( _cacheLock ) {
            List<Guid> toRemove = [];
            foreach ( Guid id in _cache.Keys ) {
                bool condition =
                    _cache.TryGetValue( id, out CacheEntry entry ) &&
                    DateTime.Now - entry.Timestamp > _cacheLifeMinutes;
                if (!condition)
                    toRemove.Add( id );
            }

            foreach ( Guid id in toRemove )
                _cache.Remove( id );

            Dictionary<Guid, CacheEntry> newCache = [];
            foreach ( KeyValuePair<Guid, CacheEntry> kvp in _cache )
                newCache.TryAdd( kvp.Key, kvp.Value );
            _cache = newCache;
        }
    }
    
    readonly record struct CacheEntry(
        ProductDto Dto,
        DateTime Timestamp );
}