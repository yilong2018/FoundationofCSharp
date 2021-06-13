using DataAccess.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Library
{
    public class SqlCrud
    {
        private string _connectionString;
        private SqlDataAccess _db;

        public SqlCrud(string connectionString)
        {
            _connectionString = connectionString;
            _db = new SqlDataAccess();
        }

        public void CreatePerson(PersonModel person)
        {
            string sql = "insert into dbo.people (FirstName, LastName) values (@FirstName, @LastName)";
            _db.SaveData(sql, new { person.FirstName, person.LastName }, _connectionString);
        }
    }
}
