using IDV_NET5_API.Models;
using IDV_NET5_API.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace IDV_NET5_API.Controllers
{
    [Route("api/[controller]")]
    public class VersionController : MasterController<Models.Entity.Version>
    {
        private IVersionRepository _versionRepository;

        public VersionController(IVersionRepository versionRepository)
        {
            _versionRepository = versionRepository;
        }


        // POST api/version
        [HttpPost]
        public override void Post([FromBody]Models.Entity.Version value)
        {
            _versionRepository.Add(value);
            _versionRepository.Commit();

        }

        // GET api/version/
        [HttpGet]
        public override IActionResult Get()
        {
            //useless comment
            IEnumerable<Models.Entity.Version> _version = _versionRepository.GetAll();
    
            return CheckAllResult(_version);
        }

        // GET api/version/5
        [HttpGet("{id}")]
        public override IActionResult Get(int id)
        {
            Models.Entity.Version _version = _versionRepository.GetSingle(id);

            return CheckResult(_version);
        }

        public override void Put(int id, [FromBody] Models.Entity.Version value)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
