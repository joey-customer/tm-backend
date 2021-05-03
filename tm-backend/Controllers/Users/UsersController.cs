using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Its.TM.Backend.Models;

namespace Its.TM.Backend.Users
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new User
            {
                Name = "Seubpong",
                Id = rng.Next(-20, 55),
                Description = "Test"
            })
            .ToArray();
        }
    }
}
