﻿using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Service
    {
        public int Serviceid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Servicetypecd { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
