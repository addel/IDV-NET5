using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDV_NET5_WEB.Models
{
    public class Asso_movie_version
    {
        public int Id { set; get; }

        public int MoviesId { set; get; }
        public Movie Movies { set; get; }
        
        public int VersionId { set; get; }
        public Version Version { set; get; }

        // product.Categories
        // var categories = movie.Asso_movie_version.Select(c => c.Version);
    }
}
