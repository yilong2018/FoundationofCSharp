using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace MySQLUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlCrud sql = new MySqlCrud(GetConnectionString());

            //ReadAllContacts(sql);

            //ReadContact(sql, 2);

            //CreateNewContact(sql);

            //UpdateContact(sql);
            //ReadAllContacts(sql);

            RemovePhoneNumberFromContact(sql, 1, 1);

            Console.WriteLine("Done processing MySql.");

            Console.ReadLine();
        }

        private static void RemovePhoneNumberFromContact(MySqlCrud sql, int contactId, int phoneNumberId)
        {
            sql.RemovePhoneNumberFromContact(contactId, phoneNumberId);

        }
        private static void UpdateContact(MySqlCrud sql)
        {
            BasicContactModel contact = new BasicContactModel { Id = 1, FirstName = "Yu", LastName = "Long" };
            sql.UpdateContactName(contact);
        }
        private static void CreateNewContact(MySqlCrud sql)
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
        private static void ReadAllContacts(MySqlCrud sql)
        {
            var rows = sql.GetAllContact();
            foreach (var row in rows)
            {
                Console.WriteLine($" {row.Id}: {row.FirstName} {row.LastName}");
            }
        }
        private static void ReadContact(MySqlCrud sql, int contactId)
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
