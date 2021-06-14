using System;
using System.Collections.Generic;
using System.IO;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace TextFileUI
{
    class Program
    {
        private static IConfiguration _config;
        private static string textFile;
        private static TextFileDataAccess db = new TextFileDataAccess();
        static void Main(string[] args)
        {
            InitializeConfiguration();
            textFile = _config.GetValue<string>("TextFile");

            ContactModel user1 = new ContactModel();
            user1.FirstName = "Yi";
            user1.LastName = "Long";
            user1.EmailAddresses.Add("yi@long.com");
            user1.EmailAddresses.Add("yilong@gmail.com");
            user1.PhoneNumbers.Add("111111");
            user1.PhoneNumbers.Add("222222");

            ContactModel user2 = new ContactModel();
            user2.FirstName = "Sue";
            user2.LastName = "Storm";
            user2.EmailAddresses.Add("sue@storm.com");
            user2.EmailAddresses.Add("yilong@gmail.com");
            user2.PhoneNumbers.Add("111111");
            user2.PhoneNumbers.Add("333333");

            // CreateContact(user1);
            // CreateContact(user2);
            // GetAllContacts();

            // UpdateContactsFirstName("Yu");
            // GetAllContacts();

            // Console.WriteLine();

            // RemovePhoneNumberFromUser("111111");
            // GetAllContacts();

            RemoveUser();
            GetAllContacts();

            
            System.Console.WriteLine("Done processing TextFile.");
            Console.ReadLine();
        }

        public static void RemoveUser()
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts.RemoveAt(0);
            db.WriteAllRecords(contacts, textFile);
        }

        public static void RemovePhoneNumberFromUser(string phoneNumber)
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts[0].PhoneNumbers.Remove(phoneNumber);
            db.WriteAllRecords(contacts,textFile);
        }

        private static void UpdateContactsFirstName(string firstName)
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts[0].FirstName = firstName;
            db.WriteAllRecords(contacts, textFile);
        }

        private static void GetAllContacts()
        {
            var contacts = db.ReadAllRecords(textFile);

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{ contact.FirstName } { contact.LastName }");
            }
        }

        private static void CreateContact(ContactModel contact)
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts.Add(contact);
            db.WriteAllRecords(contacts,textFile);
        }
        
        private static void InitializeConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            _config = builder.Build();             
        }
    }
}
