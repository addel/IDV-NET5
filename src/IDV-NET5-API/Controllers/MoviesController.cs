using IDV_NET5_API.Models;
using IDV_NET5_API.Models.Entity;
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
        private IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        // POST api/movies
        [HttpPost]
        public void Post([FromBody]Movie value)
        {      
           

        }

        // GET api/movies/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Movie _movie = _movieRepository.GetSingle(u => u.Id == id);

            if (_movie != null)
            {
                return new OkObjectResult(_movie);  
            }
            else
            {
                return NotFound();
            }
        }

    }
}
