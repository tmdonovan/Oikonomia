using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Affiliation
    {
        public int Affiliationid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Affilationtypecd { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
