using IDV_NET5_API.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace IDV_NET5_API.Models.Repository
{
    public class UserRepository : EntityBaseRepository<User>, IUserRepository
    {
        private APIdbContext _context;
        public UserRepository(APIdbContext context) : base(context)
        {
            _context = context;
        }

        public User GetUserByLogin(User user)
        {
            User res = _context.User.Where(u => u.UserName == user.UserName && u.Password == user.Password).FirstOrDefault();
            return res;
        }

        public User GetUserByName(string name)
        {
            User res = _context.User.Where(u => u.UserName == name).FirstOrDefault();
            return res;
        }


    }
}
