using CatalogApplication.Repositories.Features;
using CatalogApplication.Types._Common.Geography;
using CatalogApplication.Types.Orders;
using CatalogApplication.Types.Products.Dtos;
using CatalogApplication.Types.Products.Models;
using CatalogApplication.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace CatalogApplication;

internal static class Endpoints
{
    const string ProductIds = "ProductIds";
    const string PosX = "PosX";
    const string PosY = "PosY";
    const string Page = "Page";
    const string PageSize = "PageSize";
    const string SortBy = "SortBy";
    const int FallBackPageSize = 5;
    
    internal static void MapEndpoints( this IEndpointRouteBuilder app )
    {
        app.MapPost( "api/checkOrder",
            static async (
                    [FromBody] CatalogOrderDto dto,
                    InventoryRepository inventory,
                    ProductSearchRepository search ) =>
                await CheckOrderItems(
                    dto,
                    inventory,
                    search ) );
        
        app.MapGet( "api/categories",
            static async ( 
                    CategoryRepository repository ) =>
                await GetCategories( 
                    repository ) );
        
        app.MapGet( "api/brands",
            static async ( 
                    BrandRepository repository ) =>
                await GetBrands( 
                    repository ) );

        app.MapGet( "api/specials",
            static async ( 
                    ProductSpecialsRepository specials ) =>
                await GetSpecials( 
                    specials ) );

        app.MapGet( "api/searchSuggestions",
            static async ( 
                    [FromQuery] string searchText, 
                    ProductSearchRepository products ) =>
                await SearchSuggestions( 
                    searchText, 
                    products ) );

        app.MapGet( "api/searchSimilar",
            static async (
                    [FromQuery] Guid productId,
                    [FromQuery] Guid brandId,
                    HttpContext http,
                    ProductSearchRepository products,
                    InventoryRepository inventory ) =>
                await SearchSimilar(
                    productId,
                    brandId,
                    http,
                    products,
                    inventory ) );
        
        app.MapGet( "api/searchIds",
            static async ( 
                    HttpContext http, 
                    ProductSearchRepository products, 
                    InventoryRepository inventory ) =>
                await SearchIds( 
                    http, 
                    products, 
                    inventory ) );

        app.MapGet( "api/searchFull",
            static async (
                    HttpContext http,
                    ProductSearchRepository products,
                    InventoryRepository inventory ) =>
                await SearchFull(
                    http,
                    products,
                    inventory ) );
        
        app.MapGet( "api/shippingEstimates",
            static async ( 
                    HttpContext http, 
                    InventoryRepository inventory ) =>
                await GetEstimates( 
                    http, 
                    inventory ) );

        app.MapGet( "api/productDetails",
            static async (
                    HttpContext http,
                    ProductDetailsRepository details,
                    InventoryRepository inventory ) =>
                await GetDetails(
                    http,
                    details,
                    inventory ) );
    }

    static async Task<IResult> CheckOrderItems( CatalogOrderDto dto, InventoryRepository inventory, ProductSearchRepository search )
    {
        var inventoryReply = await inventory.ValidateOrder( dto );
        if (!inventoryReply)
            return Results.Problem( inventoryReply.GetMessage() );

        var productIds = dto.Items.Select( 
            static i => i.ProductId ).ToList();

        var products = await search.SearchIds( productIds );
        if (!products)
            return Results.Problem( products.GetMessage() );

        foreach ( OrderCatalogItemDto item in inventoryReply.Data )
        {
            ProductSummaryDto p = products.Enumerable.First( p => p.Id == item.ProductId );
            item.UnitName = p.Name;
            item.UnitPrice = p.SalePrice ?? p.Price;
            item.UnitDiscount = p.SalePrice.HasValue ? p.Price - p.SalePrice.Value : 0;
            item.ShippingCost = p.ShippingPrice ?? 0;
        }

        return Results.Ok( inventoryReply.Data );
    }
    static async Task<IResult> GetCategories( CategoryRepository repository )
    {
        var result = (await repository.GetCategories()).Data;
        
        return result.Count > 0
            ? Results.Ok( result )
            : Results.NotFound();
    }
    static async Task<IResult> GetBrands( BrandRepository repository )
    {
        var reply = await repository.GetBrands();
        
        return reply
            ? Results.Ok( reply.Data )
            : Results.NotFound();
    }
    static async Task<IResult> GetSpecials( ProductSpecialsRepository specials )
    {
        var specialsReply = await specials.GetSpecials();
        
        return specialsReply
            ? Results.Ok( specialsReply.Data )
            : Results.NotFound();
    }
    static async Task<IResult> SearchSuggestions( string searchText, ProductSearchRepository products )
    {
        var reply = await products.SearchSuggestions( searchText );
        
        return reply
            ? Results.Ok( reply.Enumerable.ToList() )
            : Results.NotFound( reply.GetMessage() );
    }
    static async Task<IResult> SearchIds( HttpContext http, ProductSearchRepository products, InventoryRepository inventory )
    {
        var query = http.Request.Query;
        var productIds = Utils.ParseGuidList( query[ProductIds] );
        if (productIds is null)
            return Results.BadRequest( "Invalid Product Ids." );

        var searchReply = await products.SearchIds( productIds );
        if (!searchReply)
            return Results.Problem( searchReply.GetMessage() );

        var results = searchReply.Enumerable.ToList();
        await Utils.ApplyShippingEstimates( productIds, results, http.Request.Query, inventory );
        return Results.Ok( results );
    }
    static async Task<IResult> SearchSimilar( Guid productId, Guid brandId, HttpContext http, ProductSearchRepository products, InventoryRepository inventory )
    {
        var searchReply = await products.SearchSimilar( productId, brandId );
        if (!searchReply)
            return Results.Problem( searchReply.GetMessage() );

        var results1 = searchReply.Data.SimilarToBrand;
        var results2 = searchReply.Data.SimilarToProduct;
        var task1 = Utils.ApplyShippingEstimates( [productId], results1, http.Request.Query, inventory );
        var task2 = Utils.ApplyShippingEstimates( [productId], results2, http.Request.Query, inventory );

        await Task.WhenAll( task1, task2 );
        return Results.Ok( searchReply.Data );
    }
    static async Task<IResult> SearchFull( HttpContext http, ProductSearchRepository products, InventoryRepository inventory )
    {
        // FILTERS
        IQueryCollection query = http.Request.Query;
        SearchFilters filters = new(
            query["SearchText"],
            Utils.ParseGuid( query["CategoryId"] ),
            Utils.ParseGuidList( query["BrandIds"] ),
            Utils.ParseInt( query["MinPrice"] ),
            Utils.ParseInt( query["MaxPrice"] ),
            Utils.ParseBool( query["IsFeatured"] ),
            Utils.ParseBool( query["IsInStock"] ),
            Utils.ParseBool( query["IsOnSale"] ),
            Utils.ParseBool( query["IsFreeShipping"] ),
            Utils.ParseInt( query[Page] ) ?? 0,
            Utils.ParseInt( query[PageSize] ) ?? FallBackPageSize,
            Utils.ParseInt( query[SortBy] ) ?? 0,
            Utils.ParseInt( query[PosX] ),
            Utils.ParseInt( query[PosY] )
        );

        // SEARCH
        var searchReply = await products.SearchFull( filters );
        if (!searchReply)
            return Results.Problem( searchReply.GetMessage() );
        var search = searchReply.Data;

        // SHIPPING
        var productIds = search.Results.Select( static p => p.Id ).ToList();
        await Utils.ApplyShippingEstimates( productIds, search.Results, http.Request.Query, inventory );
        
        return Results.Ok( ProductsSearchDto.With( search.TotalMatches, search.Results ) );
    }
    static async Task<IResult> GetEstimates( HttpContext http, InventoryRepository inventory )
    {
        var query = http.Request.Query;
        var productIds = Utils.ParseGuidList( query[ProductIds] );
        var posX = Utils.ParseInt( query[PosX] );
        var posY = Utils.ParseInt( query[PosY] );
        AddressDto? address = null;

        if (productIds is null)
            return Results.BadRequest( "Invalid Product Ids." );
        if (posX is not null && posY is not null)
            address = new AddressDto( posX.Value, posY.Value );

        var estimates = await inventory.GetShippingEstimates( productIds, address );
        return Results.Ok( estimates );
    }
    static async Task<IResult> GetDetails( HttpContext http, ProductDetailsRepository repository, InventoryRepository inventory )
    {
        var query = http.Request.Query;
        var productId = Utils.ParseGuid( query["ProductId"] );
        var posX = Utils.ParseInt( query[PosX] );
        var posY = Utils.ParseInt( query[PosY] );
        
        if (productId is null)
            return Results.BadRequest( "Invalid Product Id." );

        var reply = await repository.GetDetails( productId.Value );
        AddressDto? address = posX is null || posY is null
            ? null
            : new AddressDto( posX.Value, posY.Value );
        if (!reply)
            return reply
                ? Results.Ok( reply.Data )
                : Results.Problem( reply.GetMessage() );

        var shippingDays = await inventory.GetShippingEstimates( [reply.Data.Id], address );
        reply.Data.ShippingDays = shippingDays.FirstOrDefault();
        return Results.Ok( reply.Data );
    }
}