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
            try
            {
                _context.Movie.Add(value);
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

        // GET api/movies/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var movie = _context.Movie.FirstOrDefault(p => p.Id == id);
            if (movie != null)
                return Ok(movie);

            return NotFound();
        }

    }
}
