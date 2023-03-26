using Microsoft.Data.SqlClient;
using System.Data;

namespace Repository.Database;

public class DatabaseHelper : IDatabaseHelper
{
    private readonly string _connectionString;

    public DatabaseHelper(string connectionString)
    {
        _connectionString = connectionString;
    }

    /// <summary>
    /// 取得連線
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public IDbConnection GetConnection()
    {
        var conn = new SqlConnection(_connectionString);

        return conn;
    }
}