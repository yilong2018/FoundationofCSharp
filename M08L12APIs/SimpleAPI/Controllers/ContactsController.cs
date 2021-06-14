using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

//Note: The SWAPI url has changed to https://swapi.dev
namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private IConfiguration _config;
        private MongoDBDataAccess db;
        private readonly string tableName = "Contacts";

        public ContactsController(IConfiguration config)
        {
            _config = config;
            db= new MongoDBDataAccess("MongoContactsDB", _config.GetConnectionString("Default"));
        }

        [HttpGet]
        public List<ContactModel> GetAll(){
            return db.LoadRecords<ContactModel>(tableName);
        }
        [HttpPost]
        public void InsertRecord(ContactModel contact){
            db.UpsertRecord(tableName, contact.Id, contact);
        }
    }
}
