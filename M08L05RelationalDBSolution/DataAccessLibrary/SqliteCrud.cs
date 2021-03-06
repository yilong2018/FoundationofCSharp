using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLibrary
{
    public class SqliteCrud
    {
        private readonly string _connectionString;
        private SqliteDataAccess db = new SqliteDataAccess();

        public SqliteCrud(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<BasicContactModel> GetAllContact()
        {
            string sql = "select Id, FirstName, LastName from Contacts";
            return db.LoadData<BasicContactModel, dynamic>(sql, new { }, _connectionString);
        }

        public FullContanctModel GetAllContactById(int id)
        {
            string sql = "select Id, FirstName, LastName from Contacts where Id = @id";
            FullContanctModel output = new FullContanctModel();

            output.BasicInfo = db.LoadData<BasicContactModel, dynamic>(sql, new { Id = id }, _connectionString).FirstOrDefault();

            if (output.BasicInfo == null)
            {
                //do something to tell the user that the record was not found
                return null;
            }

            sql = @"select e.*
                        from EmailAddresses e
                        inner
                        join ContactEmail ce on ce.EmailAddressId = e.Id
                        where ce.ContactId = @Id";

            output.EmailAddresses = db.LoadData<EmailAddressModel, dynamic>(sql, new { Id = id }, _connectionString);

            sql = @"select p.*
                        from PhoneNumbers p
                        inner join ContactPhoneNumbers cp on cp.PhoneNumberId = p.Id
                        where cp.ContactId = @Id";

            output.PhoneNumber = db.LoadData<PhoneNumberModel, dynamic>(sql, new { Id = id }, _connectionString);

            return output;
        }

        public void CreateContact(FullContanctModel contact)
        {
            // Save the basic Concat
            string sql = "insert into Contacts (FirstName, LastName) values (@FirstName, @LastName);";
            db.SavaData(sql,
                        new { contact.BasicInfo.FirstName, contact.BasicInfo.LastName },
                        _connectionString);

            // Get the Id number of the concat
            sql = "select Id from Contacts where FirstName = @FirstName and LastName = @LastName;";
            int contactId = db.LoadData<IdLookupModel, dynamic>(sql,
                                                            new { contact.BasicInfo.FirstName, contact.BasicInfo.LastName },
                                                            _connectionString).First().Id;
            // Identify the Phone number exists
            //       Y: Insert into the link table for that number
            //       N: Insert the new phone number, and get the id. Do the link table insert.
            foreach (var phoneNumber in contact.PhoneNumber)
            {
                if (phoneNumber.Id == 0)
                {
                    sql = "insert into PhoneNumbers (PhoneNumber) values (@PhoneNumber);";
                    db.SavaData(sql, new { phoneNumber.PhoneNumber }, _connectionString);

                    sql = "select Id from PhoneNumbers where PhoneNumber = @PhoneNumber;";
                    phoneNumber.Id = db.LoadData<IdLookupModel, dynamic>(sql, new { phoneNumber.PhoneNumber }, _connectionString).First().Id;
                }

                sql = "insert into ContactPhoneNumbers (ContactId,PhoneNumberId) values (@ContactId, @PhoneNumberId)";
                db.SavaData(sql, new { ContactId = contactId, PhoneNumberId = phoneNumber.Id }, _connectionString);

            }

            // Do the same thing in email.
            foreach (var emailAddress in contact.EmailAddresses)
            {
                if (emailAddress.Id == 0)
                {
                    sql = "insert into EmailAddresses (EmailAddress) values (@EmailAddress);";
                    db.SavaData(sql, new { emailAddress.EmailAddress }, _connectionString);

                    sql = "select Id from EmailAddresses where EmailAddress = @EmailAddress;";
                    emailAddress.Id = db.LoadData<IdLookupModel, dynamic>(sql, new { emailAddress.EmailAddress }, _connectionString).First().Id;
                }

                sql = "insert into ContactEmail (ContactId,EmailAddressId) values (@ContactId, @EmailAddressId)";
                db.SavaData(sql, new { ContactId = contactId, EmailAddressId = emailAddress.Id }, _connectionString);

            }

        }
        public void UpdateContactName(BasicContactModel contact)
        {
            //string sql = "select Id from Contacts where FirstName=@Firstname, LastName=@LastName";
            //int contactId = db.LoadData<BasicContactModel, dynamic>(sql, new { contact.FirstName, contact.LastName }, _connectionString).First().Id;
            string sql = "update Contacts set FirstName=@FirstName, LastName=@LastName where Id=@Id";
            db.SavaData(sql, contact, _connectionString);
        }
        public void RemovePhoneNumberFromContact(int contactId, int phoneNumberId)
        {
            // Find all of the usage of phone number id
            //        if 1 delete the link and phone number
            //        else delete the link for contact

            string sql = "select Id,ContactId,PhoneNumberId from ContactPhoneNumbers  where PhoneNumberId=@PhoneNumberId";
            var links = db.LoadData<ContactPhoneNumberModel, dynamic>(sql,
                                                                      new { PhoneNumberId = phoneNumberId },
                                                                      _connectionString);
            sql = " delete from ContactPhoneNumbers where PhoneNumberId=@PhoneNumberId and ContactId=@ContactId";
            db.SavaData(sql, new { PhoneNumberId = phoneNumberId, ContactId = contactId }, _connectionString);

            if (links.Count == 1)
            {
                sql = " delete from PhoneNumbers where Id=@PhoneNumberId";
                db.SavaData(sql, new { PhoneNumberId = phoneNumberId }, _connectionString);
            }
        }
    }
}
