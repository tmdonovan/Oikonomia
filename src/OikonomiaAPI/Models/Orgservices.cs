using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Orgservices
    {
        public int Orgserviceid { get; set; }
        public int Organizationid { get; set; }
        public int Serviceid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual Service Service { get; set; }
        public virtual Codevalues Status { get; set; }
    }
}
