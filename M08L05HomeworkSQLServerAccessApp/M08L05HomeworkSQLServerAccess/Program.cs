using System;
using System.Collections.Generic;
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

            //PersonModel person = new PersonModel { FirstName = "Sue", LastName = "Storm"};
            //CreatePerson(db,person);

            //var people = ReadAllPeople(db);
            //foreach (var person in people)
            //{
            //    Console.WriteLine($"${person.Id} : {person.FirstName} {person.LastName}");
            //}

            //var person = new PersonModel { FirstName = "Yulong", LastName = "Peng", Id=2 };
            //UpdatePeople(db, person);

            int personId = 4;
            DeletePeople(db, personId);

            Console.WriteLine("Finished processing...");

            Console.ReadLine();
        }

        private static void DeletePeople(SqlCrud db, int id)
        {
            db.DeletePerson(id);
        }
        private static void UpdatePeople(SqlCrud db, PersonModel person)
        {
            db.UpdatePerson(person);
        }
        private static List<PersonModel> ReadAllPeople(SqlCrud db)
        {
            return db.GetAllPeople();
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
