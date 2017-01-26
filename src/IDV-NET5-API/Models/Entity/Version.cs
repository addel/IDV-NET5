using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDV_NET5_API.Models.Entity
{
    public class Version: IEntityBase
    {
        public int Id { get; set; }
        public string Quality { get; set; }
        public string Language { get; set; }
        public string Edition { get; set; }
        public string Download_link { get; set;}
        public DateTime created_at { get; set; }

        public List<Comment> Comments { set; get; }
    }
}
