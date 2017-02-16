using IDV_NET5_API.Models;
using IDV_NET5_API.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace IDV_NET5_API.Controllers
{
    [Route("api/[controller]")]
    public class CommentsController : MasterController<Comment>
    {
        private ICommentRepository _commentRepository;

        public CommentsController(ICommentRepository movieRepository)
        {
            _commentRepository = movieRepository;
        }


        // POST api/comments
        [HttpPost]
        public override void Post([FromBody]Comment value)
        {
            _commentRepository.Add(value);
            _commentRepository.Commit();

        }

        // GET api/comments/
        [HttpGet]
        public override IActionResult Get()
        {
            IEnumerable<Comment> _comment = _commentRepository.GetAll();
    
            return CheckAllResult(_comment);
        }

        // GET api/comments/5
        [HttpGet("{id}")]
        public override IActionResult Get(int id)
        {
            Comment _comment = _commentRepository.GetSingle(id);

            return CheckResult(_comment);
        }

        // GET api/comments/movie/1
        [HttpGet("movie/{id}")]
        public IActionResult GetByMovie(int id)
        {
            IEnumerable<Comment> _comment = _commentRepository.GetAll();
            _comment = _commentRepository.GetByMovie(id);

            return CheckAllResult(_comment);
        }

        // Put api/comments/5
        [HttpPut("{id}")]
        public override void Put(int id, [FromBody] Comment value)
        {
            value.Id = id;
            _commentRepository.Update(value);
            _commentRepository.Commit();
        }

        // Patch api/comments/5
        [HttpPatch("{id}")]
        public void Patch(int id, [FromBody] Comment value)
        {
            value.Id = id;
            _commentRepository.Update(value);
            _commentRepository.Commit();
        }

        // Delete /api/comments/5
        [HttpDelete("{id}")]
        public override void Delete(int id)
        {
            Comment comment = _commentRepository.GetSingle(id);
            _commentRepository.Delete(comment);
            _commentRepository.Commit();
        }
    }
}
