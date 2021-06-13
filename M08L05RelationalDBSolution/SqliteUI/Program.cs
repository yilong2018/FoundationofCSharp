using DataAccessLibrary;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using DataAccessLibrary.Models;


namespace SqliteUI
{
    class Program
    {
        static void Main(string[] args)
        {
            SqliteCrud sql = new SqliteCrud(GetConnectionString());

            //ReadAllContacts(sql);

            //ReadContact(sql, 1);

            //CreateNewContact(sql);

            //UpdateContact(sql);

            RemovePhoneNumberFromContact(sql, 1, 1);

            Console.WriteLine("Done processing Sqlite.");

            Console.ReadLine();
        }
        private static void RemovePhoneNumberFromContact(SqliteCrud sql, int contactId, int phoneNumberId)
        {
            sql.RemovePhoneNumberFromContact(contactId, phoneNumberId);

        }
        private static void UpdateContact(SqliteCrud sql)
        {
            BasicContactModel contact = new BasicContactModel { Id = 1, FirstName = "Yu", LastName = "Long" };
            sql.UpdateContactName(contact);
        }
        private static void CreateNewContact(SqliteCrud sql)
        {
            FullContanctModel user = new FullContanctModel
            {
                BasicInfo = new BasicContactModel { FirstName = "Sue", LastName = "Storm" }
            };
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "Sue@storm.com" });
            user.EmailAddresses.Add(new EmailAddressModel { Id = 2, EmailAddress = "yi@long.com" });

            user.PhoneNumber.Add(new PhoneNumberModel { Id = 1, PhoneNumber = "13808033900" });
            user.PhoneNumber.Add(new PhoneNumberModel { PhoneNumber = "13888033900" });

            sql.CreateContact(user);
        }
        private static void ReadAllContacts(SqliteCrud sql)
        {
            var rows = sql.GetAllContact();
            foreach (var row in rows)
            {
                Console.WriteLine($" {row.Id}: {row.FirstName} {row.LastName}");
            }
        }
        private static void ReadContact(SqliteCrud sql, int contactId)
        {
            var contanct = sql.GetAllContactById(contactId);
            Console.WriteLine($" {contanct.BasicInfo.Id}: {contanct.BasicInfo.FirstName} {contanct.BasicInfo.LastName}");
        }
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var config = builder.Build();

            output = config.GetConnectionString(connectionStringName);

            return output;


        }
    }
}
