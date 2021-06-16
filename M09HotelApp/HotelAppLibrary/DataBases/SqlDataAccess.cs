﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace HotelAppLibrary.DataBases
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public List<T> LoadData<T, U>(string sqlStatement,
                                      U parameters,
                                      string connectionStringName,
                                      bool isStoreProcedure = false)
        {
            string connectionString = _config.GetConnectionString(connectionStringName);

            CommandType commandType = CommandType.Text;

            if (isStoreProcedure == true)
            {
                commandType = CommandType.StoredProcedure;
            }

            using (IDbConnection conneciton = new SqlConnection())
            {
                List<T> rows = conneciton.Query<T>(sqlStatement, parameters, commandType: commandType).ToList();
                return rows;
            }

        }

        public void SaveData<T>(string sqlStatement,
                                T parameters,
                                string connectionStringName,
                                bool isStoreProcedure = false)
        {
            string connectionString = _config.GetConnectionString(connectionStringName);

            CommandType commandType = CommandType.Text;

            if (isStoreProcedure == true)
            {
                commandType = CommandType.StoredProcedure;
            }

            using (IDbConnection conneciton = new SqlConnection())
            {
                conneciton.Execute(sqlStatement, parameters, commandType: commandType);
            }


        }
    }
}
