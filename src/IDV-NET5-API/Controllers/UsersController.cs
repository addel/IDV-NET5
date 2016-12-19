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
            // TODO check insert
            _userRepository.Add(value);
            _userRepository.Commit();

        }

        // GET api/users/5
        [HttpGet("{id}")]
        public override IActionResult Get(int id)
        {
            var user = _userRepository.GetSingle(id);
            return CheckResult(user);
        }

        // GET api/users/
        [HttpGet]
        public override IActionResult Get()
        {
            IEnumerable<User> _user = _userRepository.GetAll();

            return CheckAllResult(_user);
        }

        // viens de la class abstraite (MasterController) pour vous amis dev vous dire qu'il faut absolument codé ces methodes
        public override void Put(int id, [FromBody] User value)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
