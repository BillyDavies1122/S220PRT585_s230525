﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace theatreMovie.Models
{
    public class Catagory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public ICollection<Catagory> Catagories { get; set; }

    }
}
