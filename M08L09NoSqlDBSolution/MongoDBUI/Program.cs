using System;
using System.IO;
using System.Linq;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace MongoDBUI
{
    class Program
    {
        private static MongoDBDataAccess db;
        private static readonly string tableName = "Contacts";
        static void Main(string[] args)
        {
            db = new MongoDBDataAccess("MongoContactsDB", GetConnectionString());

            ContactModel user = new ContactModel
            {
                FirstName = "Sue",
                LastName = "Storm"
            };

            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "suestorm@gmail.com" });
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "yi@long.com" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "11111" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "33333" });

            //CraeteContact(user);

            //GetAllContacts();

            //3968088f-06f8-4693-8f08-9522904fbeba
            //f9bb4f68-c6b0-408d-912a-aa6a68b9f3ad

            //GetContactById("f9bb4f68-c6b0-408d-912a-aa6a68b9f3ad");

            //string firstName = "Yi";
            //string idStr = "3968088f-06f8-4693-8f08-9522904fbeba";
            //UpdateContactFirstName(firstName, idStr);

            //RemovePhoenNumberFromUser("11111", "3968088f-06f8-4693-8f08-9522904fbeba");

            RemoveUser("3968088f-06f8-4693-8f08-9522904fbeba");
            GetAllContacts();

            Console.WriteLine("Done Processing MongoDB");
            Console.ReadLine();
        }

        public static void RemoveUser(string idStr)
        {
            Guid guid = new Guid(idStr);
            var contact = db.LoadRecordById<ContactModel>(tableName, guid);

            db.DeleteRecord<ContactModel>(tableName, guid);
        }
        public static void RemovePhoenNumberFromUser(string phoneNumber, string idStr)
        {
            Guid guid = new Guid(idStr);
            var contact = db.LoadRecordById<ContactModel>(tableName, guid);

            contact.PhoneNumbers = contact.PhoneNumbers.Where(x => x.PhoneNumber != phoneNumber).ToList();

            db.UpsertRecord(tableName, contact.Id, contact);

        }
        private static void UpdateContactFirstName(string FirstName, string idStr)
        {
            Guid guid = new Guid(idStr);
            var contact = db.LoadRecordById<ContactModel>(tableName, guid);
            contact.FirstName = FirstName;

            db.UpsertRecord<ContactModel>(tableName, guid, contact);
        }

        private static void GetContactById(string id)
        {
            Guid guid = new Guid(id);
            var contact = db.LoadRecordById<ContactModel>(tableName, guid);

            Console.WriteLine($"{contact.Id}: { contact.FirstName } {contact.LastName } ");

        }

        private static void GetAllContacts()
        {
            var contacts = db.LoadRecords<ContactModel>(tableName);
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Id}: { contact.FirstName } {contact.LastName } ");
            }
        }

        private static void CraeteContact(ContactModel contact)
        {
            db.UpsertRecord(tableName, contact.Id, contact);
        }

        private static string GetConnectionString(string connectionString = "Default")
        {
            var output = "";
            var build = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json");
            var config = build.Build();
            output = config.GetConnectionString(connectionString);
            return output;

        }
    }
}
