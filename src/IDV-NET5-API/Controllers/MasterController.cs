using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDV_NET5_API.Controllers
{
    public abstract class MasterController<MyObject>:Controller where MyObject : class, new()
    {
        protected IActionResult CheckResult(MyObject obje)
        {
            if (obje != null)
            {
                return new OkObjectResult(obje);
            }
            else
            {
                return NotFound();
            }
        }

        protected IActionResult CheckAllResult(IEnumerable<MyObject> obj)
        {
            if (obj != null)
            {
                return new OkObjectResult(obj);
            }
            else
            {
                return NotFound();
            }
        }

        public abstract void Post([FromBody]MyObject value);
        public abstract IActionResult Get();
        public abstract IActionResult Get(int id);
        public abstract void Put(int id, [FromBody]MyObject value);
        public abstract void Delete(int id);
    }
}
