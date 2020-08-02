using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class InGroup
    {
        public int InGroupid { get; set; }
        public int Ownerid { get; set; }
        public string Ownertypecd { get; set; }
        public int Groupid { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
