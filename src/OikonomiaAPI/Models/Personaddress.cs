using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Personaddress
    {
        public int Personaddressid { get; set; }
        public int Personid { get; set; }
        public string Addressln1 { get; set; }
        public string Addressln2 { get; set; }
        public string City { get; set; }
        public int Stateid { get; set; }
        public int Countryid { get; set; }
        public string County { get; set; }
        public string Zip { get; set; }
        public int Addresstypeid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Codevalues Addresstype { get; set; }
        public virtual Codevalues Country { get; set; }
        public virtual Person Person { get; set; }
        public virtual Codevalues State { get; set; }
        public virtual Codevalues Status { get; set; }
    }
}
