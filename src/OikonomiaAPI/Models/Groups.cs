using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Groups
    {
        public int Groupid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Grouptypecd { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
