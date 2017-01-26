﻿using System;
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
        public string Realisator { get; set; }
        public int Rating { get; set; }
        public string Actor_principal { get; set; }
    }
}
