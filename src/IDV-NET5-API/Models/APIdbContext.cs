using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IDV_NET5_API.Models
{
    public class APIdbContext : DbContext
    {
        public APIdbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movie { set; get; }
        public DbSet<User> User { set; get; }

    }
}
