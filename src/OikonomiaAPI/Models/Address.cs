using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Address
    {
        public int Addressid { get; set; }
        public int Ownerid { get; set; }
        public string Ownertypecd { get; set; }
        public string Addressln1 { get; set; }
        public string Addressln2 { get; set; }
        public string City { get; set; }
        public string Statecd { get; set; }
        public string Countrycd { get; set; }
        public string County { get; set; }
        public string Zip { get; set; }
        public string Addresstypecd { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
