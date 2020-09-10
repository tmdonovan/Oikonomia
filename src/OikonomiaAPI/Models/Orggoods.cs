using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Orggoods
    {
        public int Orggoodid { get; set; }
        public int Organizationid { get; set; }
        public int Goodid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Good Good { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Codevalues Status { get; set; }
    }
}
