using IDV_NET5_API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDV_NET5_API.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly APIdbContext _context;

        public UsersController(APIdbContext context)
        {
            _context = context;
        }

        // POST api/users
        [HttpPost]
        public void Post([FromBody]User value)
        {
            // TODO check insert
            _context.Users.Add(value);
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _context.Users.FirstOrDefault(p => p.Id == id);
            if (user != null)
                return Ok(user);

            return NotFound();
        }

    }
}
