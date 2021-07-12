using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SqlAccess : ISqlAccess
    {
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            // The connectionString is used to open a connection to the SQL DB.
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                // A query is passed through the DB connection.
                // Await is used to account for the async query.
                // The query output is stored in rows and returned.
                var rows = await connection.QueryAsync<T>(sql, parameters);

                return rows.ToList();
            }
        }
        public async Task SaveData<U>(string sql, U parameters, string connectionString)
        {
            // The connectionString is used to open a connection to the SQL DB.
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                // A query is passed through the DB connection.
                connection.Open();
                await connection.ExecuteAsync(sql, parameters);

            }
        }
    }
}
