using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDV_NET5_API.Models.Entity
{
    public class Movie : IEntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public string Quality { get; set; }
        public string Link { get; set; }
        public float SizeFile { get; set; }
        public ICollection<Comment> Comment { get; set; }
    }
}
