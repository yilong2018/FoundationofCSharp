using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;

namespace DataAccess.Library
{
    public class SqlDataAccess
    {
        public void SaveData<T>(string sqlStatement, T sqlParameters, string connectionstring)
        {
            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                connection.Execute(sqlStatement, sqlParameters);
            }
        }

        public List<T> LoadData<T,U>(string sqlStatement, U sqlParameters, string connectionstring)
        {
            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                var rows = connection.Query<T>(sqlStatement, sqlParameters).ToList();
                return rows;
            }
        }
    }
}
