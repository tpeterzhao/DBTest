using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface ISqlAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString);
        Task SaveData<U>(string sql, U parameters, string connectionString);
    }
}