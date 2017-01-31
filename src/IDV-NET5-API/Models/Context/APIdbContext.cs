using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IDV_NET5_API.Models.Entity;

namespace IDV_NET5_API.Models
{
    public class APIdbContext : DbContext
    {
        public APIdbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movie { set; get; }
        public DbSet<User> User { set; get; }
        public DbSet<Comment> Comment { set; get; }
        public DbSet<Asso_movie_version> Asso_movie_version { set; get; }
        public DbSet<Entity.Version> Version { set; get; }
        public object MyEntity { get; internal set; }
    }
}
