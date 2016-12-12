using IDV_NET5_API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDV_NET5_API.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private readonly APIdbContext _context;

        public MoviesController(APIdbContext context)
        {
            _context = context;
        }

        // POST api/movies
        [HttpPost]
        public void Post([FromBody]Movie value)
        {
            // TODO check insert
            _context.Movies.Add(value);
        }

        // GET api/movies/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var movie = _context.Movies.FirstOrDefault(p => p.Id == id);
            if (movie != null)
                return Ok(movie);

            return NotFound();
        }

    }
}
