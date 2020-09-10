using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Orgconnections
    {
        public int Orgconnectionid { get; set; }
        public int Organizationid { get; set; }
        public int? Connectedtoorgid { get; set; }
        public int Connectiontypeid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Organization Connectedtoorg { get; set; }
        public virtual Codevalues Connectiontype { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Codevalues Status { get; set; }
    }
}
