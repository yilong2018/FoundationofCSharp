using M7L14HomeworkWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace M7L14HomeworkWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public PersonModel person { get; set; } = new PersonModel();
        // GET: api/<PersonController>
        [HttpGet]
        public IEnumerable<string> Get(string fn, string ln)
        {
            person.FirstName = fn;
            person.LastName = ln;

            return new string[] { $"Hi {person.FullName} " };
        }

    }
}
