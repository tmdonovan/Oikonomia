using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Service
    {
        public Service()
        {
            Orgservices = new HashSet<Orgservices>();
            Personservices = new HashSet<Personservices>();
            Projecttemplateservices = new HashSet<Projecttemplateservices>();
        }

        public int Serviceid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Servicetypeid { get; set; }
        public int? Servicesubtypeid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Codevalues Servicesubtype { get; set; }
        public virtual Codevalues Servicetype { get; set; }
        public virtual Codevalues Status { get; set; }
        public virtual ICollection<Orgservices> Orgservices { get; set; }
        public virtual ICollection<Personservices> Personservices { get; set; }
        public virtual ICollection<Projecttemplateservices> Projecttemplateservices { get; set; }
    }
}
