﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaAPI.Dtos
{
    public class OrganizationReadDto
    {
        public int Organizationid { get; set; }
        public string Description { get; set; }
        public string Longdescription { get; set; }
        public string Organizationtypeid { get; set; }
        public string Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
