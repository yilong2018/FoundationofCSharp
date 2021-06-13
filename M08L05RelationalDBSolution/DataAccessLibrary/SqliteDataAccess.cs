using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Dapper;
using System.Linq;

namespace DataAccessLibrary
{
    public class SqliteDataAccess
    {
        public List<T> LoadData<T, U>(string sqlStatement, U patameters, string connectionString)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatement, patameters).ToList();
                return rows;
            }
        }

        public void SavaData<T>(string sqlStatement, T parameters, string connectionString)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Execute(sqlStatement, parameters);
            }
        }
    }
}
