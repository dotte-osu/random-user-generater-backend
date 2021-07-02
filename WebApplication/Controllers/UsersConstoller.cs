using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserApi.Models;

namespace UserApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // Route to api/user/random
        [HttpGet("{random}")]
        public ActionResult<User> GetAllUsers()
        {
            var random = new Random();

            // Get a list of names
            var firstNames = System.IO.File.ReadAllLines(@".\data\firstName.txt");
            var lastNames = System.IO.File.ReadAllLines(@".\data\lastName.txt");

            var lastIndex = random.Next(lastNames.Count());
            var firstIndex = random.Next(firstNames.Count());
            Guid uuid = Guid.NewGuid();

            var user = new User()
            {
                Name = firstNames[firstIndex] + " " + lastNames[lastIndex],
                Id = uuid,
                Url = "https://i.pravatar.cc/150?u=" + uuid + ".jpg"
            };

            return user;
        }


    }
}
