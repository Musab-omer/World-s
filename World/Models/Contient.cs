﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Models
{
    public class Contient
    {
        public Guid Id { get; set; }
        public string EName { get; set; }
        public string AName { get; set; }
        public List<Region> Regions  { get; set; }
    }
}
