using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Orgphonenumber
    {
        public int Orgphonenumberid { get; set; }
        public int Organizationid { get; set; }
        public int Countrycode { get; set; }
        public int Areacode { get; set; }
        public int Phonenumber { get; set; }
        public int Phonetypeid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual Codevalues Phonetype { get; set; }
        public virtual Codevalues Status { get; set; }
    }
}
