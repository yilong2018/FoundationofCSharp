using M07L15WebApiMiniProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace M07L15WebApiMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }
       
        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] PersonModel data)
        {
            _logger.LogInformation("Ther person was logged as {Person}", data);
        }
    }
}
