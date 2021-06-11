using M07L15WebApiMiniProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M07L15WebApiMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private ILogger<AddressController> _logger;

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] AddressModel data)
        {
            _logger.LogInformation("Ther person was logged as {Address}", data);
        }
    }
}
