using IDV_NET5_API.Models;
using IDV_NET5_API.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace IDV_NET5_API.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : MasterController<Movie>
    {
        private IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }


        // POST api/movies
        [HttpPost]
        public override void Post([FromBody]Movie value)
        {
            _movieRepository.Add(value);
            _movieRepository.Commit();

        }

        // GET api/movies/
        [HttpGet]
        public override IActionResult Get()
        {
            IEnumerable<Movie> _movie = _movieRepository.GetAll();
    
            return CheckAllResult(_movie);
        }

        // GET api/movies/5
        [HttpGet("{id}")]
        public override IActionResult Get(int id)
        {
            Movie _movie = _movieRepository.GetSingle(id);

            return CheckResult(_movie);
        }

        public override void Put(int id, [FromBody] Movie value)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
