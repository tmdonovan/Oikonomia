using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Phonenumber
    {
        public int Phonenumberid { get; set; }
        public int Ownerid { get; set; }
        public string Ownertypecd { get; set; }
        public int Countrycode { get; set; }
        public int Areacode { get; set; }
        public int Phonenumber1 { get; set; }
        public string Phonetypecd { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
