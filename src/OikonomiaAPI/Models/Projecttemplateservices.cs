using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Projecttemplateservices
    {
        public int Projecttempserviceid { get; set; }
        public int Projecttemplateid { get; set; }
        public int Serviceid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Projecttemplate Projecttemplate { get; set; }
        public virtual Service Service { get; set; }
        public virtual Codevalues Status { get; set; }
    }
}
