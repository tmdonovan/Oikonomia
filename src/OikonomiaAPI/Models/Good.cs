﻿using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Good
    {
        public int Goodid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Goodtypecd { get; set; }
        public string Goodsubtypecd { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
