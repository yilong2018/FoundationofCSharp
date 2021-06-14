using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace CosmosDBUI
{
    class Program
    {
        private static CosmosDataAccess db;
        static async Task Main(string[] args)
        {
            var c = GetCosmosInfo();
            db = new CosmosDataAccess(c.endpointUrl, c.primaryKey, c.databaseName, c.containerName);
            
            ContactModel user1 = new ContactModel
            {
                FirstName = "Yi",
                LastName = "Long"
            };

            user1.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "yilong@gmail.com" });
            user1.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "yi@long.com" });
            user1.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "111111" });
            user1.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "222222" });

            ContactModel user2 = new ContactModel
            {
                FirstName = "Sue",
                LastName = "Storm"
            };

            user2.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "yilong@gmail.com" });
            user2.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "sue@storm.com" });
            user2.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "111111" });
            user2.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "333333" });

            // await CreateContact(user1);
            // await CreateContact(user2);

            // await GetAllContacts();

            //798c42b9-c3de-4153-bbfe-d9d2ea692323
            // await GetContactById("798c42b9-c3de-4153-bbfe-d9d2ea692323");

            // await UpdateContactsFirstName("Yulong", "798c42b9-c3de-4153-bbfe-d9d2ea692323");
            // await GetContactById("798c42b9-c3de-4153-bbfe-d9d2ea692323");
            
            // await RemovePhoneNumberFromUser("111111", "798c42b9-c3de-4153-bbfe-d9d2ea692323");

            await RemoveUser("798c42b9-c3de-4153-bbfe-d9d2ea692323", "Long");

            Console.WriteLine("Done processing CosmosDB");
            Console.ReadLine();
        }

        public static async Task RemoveUser(string id, string lastName)
        {
            await db.DelketeRecordAsync<ContactModel>(id, lastName);
        }

        public static async Task RemovePhoneNumberFromUser(string phoneNumber, string id)
        {
            var contact = await db.LoadRecordByIdAysnc<ContactModel>(id);

            contact.PhoneNumbers = contact.PhoneNumbers.Where(x => x.PhoneNumber != phoneNumber).ToList();

            await db.UpsertRecordAsync(contact);
        }

        private static async Task UpdateContactsFirstName(string firstName, string id)
        {
            var contact = await db.LoadRecordByIdAysnc<ContactModel>(id);

            contact.FirstName = firstName;

            await db.UpsertRecordAsync(contact);
        }

        private static async Task GetContactById(string id)
        {
            var contact = await db.LoadRecordByIdAysnc<ContactModel>(id);
            Console.WriteLine($"{ contact.Id}: { contact.FirstName } { contact.LastName }");

        }

        private static async Task GetAllContacts()
        {
            var contacts = await db.LoadRecordsAsync<ContactModel>();

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{ contact.Id}: { contact.FirstName } { contact.LastName }");
            }
        }

        private static async Task CreateContact(ContactModel contact)
        {
            await db.UpsertRecordAsync(contact);
        }

        private static (string endpointUrl,string primaryKey,string databaseName,string containerName) GetCosmosInfo()
        {

            (string endpointUrl,string primaryKey,string databaseName,string containerName) output;

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();

            output.endpointUrl = config.GetValue<string>("CosmosDB:EndpointUrl");
            output.primaryKey = config.GetValue<string>("CosmosDB:PrimaryKey");
            output.databaseName = config.GetValue<string>("CosmosDB:DatabaseName");
            output.containerName = config.GetValue<string>("CosmosDB:ContainerName");
            
            return output;
        }
    }
}
