using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDV_NET5_API.Models
{
    public class User
    {
        public int Id { set; get; }
        public string Username { set; get; }
        public string Email { set; get; }
        public string Firstname { set; get; }
        public string Lastname { set; get; }

    }
}
