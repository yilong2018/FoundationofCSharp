﻿using M07L14MessageWallAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace M07L14MessageWallAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageWallController : ControllerBase
    {
        private ILogger<MessageWallController> _logger;
        public MessageWallController(ILogger<MessageWallController> logger)
        {
            _logger = logger;
        }
        // GET: api/<MessageWallController>
        // api/MessageWall?message=Test&id=4
        [HttpGet]
        public IEnumerable<string> Get(string message)
        {
            List<string> output = new List<string> { 
                "Hello World",
                "How are you?"
            };
            if (string.IsNullOrWhiteSpace(message) == false)
            {
                output.Add(message);
            }
            return output;
        }

        // GET api/<MessageWallController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MessageWallController>
        [HttpPost]
        public void Post([FromBody] MessageModel message)
        {
            _logger.LogInformation("Our message was {Message}", message.Message);
        }

        // PUT api/<MessageWallController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MessageWallController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
