using IDV_NET5_API.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace IDV_NET5_API.Models.Repository
{
    public class VersionRepository : EntityBaseRepository<Entity.Version>, IVersionRepository
    {
        public VersionRepository(APIdbContext context) : base(context)
        {
        }
    }
}
