using System.Collections.Generic;
using System.Linq;
using IDV_NET5_API.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace IDV_NET5_API.Models.Entity
{
    public class Movie : IEntityBase
    {
        public Movie()
        {
            Comments = new List<Comment>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Realisator { get; set; }
        public int Rating { get; set; }
        public string Actor_principal { get; set; }
        public string Picture_link { get; set; }
        public string File_link { get; set; }
        public string Language { get; set; }
        //public List<Comment> Comments { set; get; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
