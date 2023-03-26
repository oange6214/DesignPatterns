using System.Data;

namespace Repository.Database;

public interface IDatabaseHelper
{
    /// <summary>
    /// 取得連線
    /// </summary>
    /// <returns></returns>
    IDbConnection GetConnection();
}
