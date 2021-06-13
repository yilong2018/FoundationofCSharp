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

        public void DeletePerson(int Id)
        {
            string sqlStr = "delete from dbo.people where Id=@Id";
            _db.SaveData(sqlStr, new { Id }, _connectionString);
        }
        public void UpdatePerson(PersonModel person)
        {
            string sqlstr = "update dbo.People Set FirstName = @FirstName, LastName = @LastName where Id=@Id;";
            _db.SaveData(sqlstr, person, _connectionString);
        }
        public List<PersonModel> GetAllPeople()
        {
            string sql = "select Id,FirstName,LastName from dbo.people";
            return _db.LoadData<PersonModel, dynamic>(sql, new { }, _connectionString);
        }
        public void CreatePerson(PersonModel person)
        {
            string sql = "insert into dbo.people (FirstName, LastName) values (@FirstName, @LastName)";
            _db.SaveData(sql, new { person.FirstName, person.LastName }, _connectionString);
        }
    }
}
