using IDV_NET5_API.Models.Entity;
using IDV_NET5_API.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDV_NET5_API.Models
{
    // ici je creé encore des interface pour mes entity pour bien que vous mes amis dev emplémentier bien toute les methode de EntityBaseRepository
    public interface IMovieRepository : IEntityBaseRepository<Movie> { }

    public interface IVersionRepository : IEntityBaseRepository<Entity.Version> { }

    public interface IUserRepository : IEntityBaseRepository<User> {
        User GetUserByLogin(User user);
    }

    public interface ICommentRepository : IEntityBaseRepository<Comment> { }
}
