using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Personservices
    {
        public int Personserviceid { get; set; }
        public int Personid { get; set; }
        public int Serviceid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Person Person { get; set; }
        public virtual Service Service { get; set; }
        public virtual Codevalues Status { get; set; }
    }
}
