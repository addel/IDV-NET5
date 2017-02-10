using IDV_NET5_API.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDV_NET5_API.Models.Repository
{
    public class CommentRepository : EntityBaseRepository<Comment>, ICommentRepository
    {
        private APIdbContext _context;

        public CommentRepository(APIdbContext context) : base(context)
        {
            _context = context;
        }

        public override List<Comment> GetByMovie(int id)
        {
            return _context.Set<Comment>().Where(x => x.MovieId == id).ToList();
        }
    }
}
