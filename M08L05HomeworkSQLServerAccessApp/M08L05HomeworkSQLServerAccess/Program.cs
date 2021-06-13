using System;
using System.IO;
using DataAccess.Library;
using DataAccess.Library.Models;
using Microsoft.Extensions.Configuration;

namespace M08L05HomeworkSQLServerAccess
{
    class Program
    {

        static void Main(string[] args)
        {
            var db = new SqlCrud(GetDbString());

            PersonModel person = new PersonModel { FirstName = "CoCo", LastName = "Peng"};
            CreatePerson(db,person);

            Console.WriteLine("Finished processing...");

            Console.ReadLine();
        }

        private static void CreatePerson(SqlCrud db, PersonModel person)
        {
            db.CreatePerson(person);
        }
        private static string GetDbString(string connectionStringName = "Default")
        {
            var build = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var config = build.Build();
            var output = config.GetConnectionString(connectionStringName);
            return output;
        }
    }
}
