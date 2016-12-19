using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDV_NET5_API.Models
{
    // création d'une interface pour toute les entités
    public interface IEntityBase
    {
        int Id { get; set; }
    }
}
