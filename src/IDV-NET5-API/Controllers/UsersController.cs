using IDV_NET5_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            try
            {
                _context.User.Add(value);
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

        }

        // GET api/users/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _context.User.FirstOrDefault(p => p.Id == id);
            if (user != null)
                return Ok(user);

            return NotFound();
        }

    }
}
