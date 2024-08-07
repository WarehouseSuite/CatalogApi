using System.Data;
using CatalogApplication.Types._Common.ReplyTypes;
using Dapper;
using Microsoft.Data.SqlClient;

namespace CatalogApplication.Database;

internal sealed class DapperContext : IDapperContext
{
    // Fields
    const string InvalidConnectionMessage = "Invalid Connection State: ";
    const string ExceptionMessage = "An internal server error occured.";
    readonly string _connectionString;
    readonly bool _noString = true;

    readonly ILogger<DapperContext> _logger;

    // Public Methods
    public DapperContext( IConfiguration config, ILogger<DapperContext> logger )
    {
        _logger = logger;
        try
        {
            _connectionString = config["SqlString"] ?? throw new Exception( "DapperContext failed to get SqlString from configuration." );

            if (!string.IsNullOrEmpty( _connectionString ))
                _noString = false;
        }
        catch ( Exception e )
        {
            throw new Exception( $"DapperContext unexpected exception thrown in constructor. {e}" );
        }
    }
    public async Task<SqlConnection> GetOpenConnection()
    {
        if (_noString)
        {
            _logger.LogError( "No connection string." );
            return new SqlConnection( string.Empty );
        }

        SqlConnection connection = new( _connectionString );
        await connection.OpenAsync();
        return connection;
    }
    public async Task<Replies<T>> QueryAsync<T>( string sql, DynamicParameters? parameters = null )
    {
        await using SqlConnection c = await GetOpenConnection();
        if (c.State != ConnectionState.Open)
        {
            _logger.LogError( "Sql connection failed." );
            return Replies<T>.ServerError( InvalidConnectionMessage + c.State );
        }

        try 
        {
            IEnumerable<T> enumerable = await c.QueryAsync<T>( sql, parameters, commandType: CommandType.Text );
            return Replies<T>.Success( enumerable );
        }
        catch ( Exception e ) 
        {
            _logger.LogError( e, e.Message );
            return Replies<T>.ServerError( ExceptionMessage );
        }
    }
    public async Task<Reply<T>> QueryFirstOrDefaultAsync<T>( string sql, DynamicParameters? parameters = null )
    {
        await using SqlConnection c = await GetOpenConnection();
        if (c.State != ConnectionState.Open)
        {
            _logger.LogError( "Sql connection failed." );
            return Reply<T>.ServerError( InvalidConnectionMessage + c.State );
        }
        
        try 
        {
            var item = await c.QueryFirstOrDefaultAsync<T>( sql, parameters, commandType: CommandType.Text );
            return item is not null
                ? Reply<T>.Success( item )
                : Reply<T>.Failure( "Not Found." );
        }
        catch ( Exception e ) 
        {
            _logger.LogError( e, e.Message );
            return Reply<T>.ServerError( ExceptionMessage );
        }
    }
    public async Task<Reply<int>> ExecuteAsync( string sql, DynamicParameters? parameters = null )
    {
        await using SqlConnection c = await GetOpenConnection();
        if (c.State != ConnectionState.Open)
        {
            _logger.LogError( "Sql connection failed." );
            return Reply<int>.ServerError( InvalidConnectionMessage + c.State );
        }

        SqlTransaction? transaction = null;
        try
        {
            transaction = c.BeginTransaction();

            int result = await c.ExecuteAsync( sql, parameters, transaction, commandType: CommandType.Text );

            if (result > 0)
            {
                await transaction.CommitAsync();
                return Reply<int>.Success( result );
            }
            
            await transaction.RollbackAsync();
            return Reply<int>.ServerError( "No rows altered." );
        }
        catch ( Exception e )
        {
            if (transaction != null)
                await transaction.RollbackAsync();
            _logger.LogError( e, e.Message );
            return Reply<int>.ServerError( e.Message );
        }
    }

    public async Task<Reply<int>> ExecuteStoredProcedure( string procedureName, DynamicParameters? parameters = null )
    {
        await using SqlConnection c = await GetOpenConnection();
        if (c.State != ConnectionState.Open)
        {
            _logger.LogError( "Sql connection failed." );
            return Reply<int>.ServerError( InvalidConnectionMessage + c.State );
        }

        try 
        {
            int result = await c.ExecuteAsync( procedureName, parameters, commandType: CommandType.StoredProcedure );
            return result > 0
                ? Reply<int>.Success( result )
                : Reply<int>.ServerError( "No rows altered." );
        }
        catch ( Exception e ) 
        {
            _logger.LogError( e, e.Message );
            return Reply<int>.ServerError( ExceptionMessage );
        }
    }
}