using System;
using IDV_NET5_API.Models;
using IDV_NET5_API.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IDV_NET5_API.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : MasterController<User>
    {
        private IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // POST api/users
        [HttpPost]
        public override void Post([FromBody]User value)
        {
               _userRepository.Add(value);
               _userRepository.Commit();
        }

        // POST api/users/login
        [HttpPost("login")]
        public User Login([FromBody]User value)
        {
            return _userRepository.GetUserByLogin(value);
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public override IActionResult Get(int id)
        {
            var user = _userRepository.GetSingle(id);
            return CheckResult(user);
        }

        // GET api/users/list
        [HttpGet("list")]
        public List<User> To_list()
        {
            return _userRepository.To_List();

        }

        // GET api/users/
        [HttpGet]
        public override IActionResult Get()
        {
            IEnumerable<User> _user = _userRepository.GetAll();

            return CheckAllResult(_user);
        }

        // PUT api/users/1
        [HttpPut]
        public override void Put(int id, [FromBody] User value)
        {
             value.Id = id;
            _userRepository.Update(value);
            _userRepository.Commit();
        }

        // Patch api/users/5
        [HttpPatch("{id}")]
        public void Patch(int id, [FromBody] User value)
        {
            value.Id = id;
            _userRepository.Update(value);
            _userRepository.Commit();
        
        }

        // delete api/users/name
        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            User user = _userRepository.GetUserByName(name);
            _userRepository.Delete(user);
            _userRepository.Commit();
        }

        // delete api/movies/5
        [HttpDelete("{id}")]
        public override void Delete(int id)
        {
            User user = _userRepository.GetSingle(id);
            _userRepository.Delete(user);
            _userRepository.Commit();
        }
    }
}
