﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDV_NET5_WEB.Models
{
    public class Comment
    {
        public int Id { set; get; }
        public string Text { set; get; }
        public string Username { get; set; }
        public DateTime DateOfPost { set; get; }
        public int MovieId { get; set; }
    }
}
