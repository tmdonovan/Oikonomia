using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Personphonenumber
    {
        public int Personphonenumberid { get; set; }
        public int Personid { get; set; }
        public int Countrycode { get; set; }
        public int Areacode { get; set; }
        public int Phonenumber { get; set; }
        public int Phonetypeid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Person Person { get; set; }
        public virtual Codevalues Phonetype { get; set; }
        public virtual Codevalues Status { get; set; }
    }
}
