using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Projecttemplate
    {
        public Projecttemplate()
        {
            Projecttemplategoods = new HashSet<Projecttemplategoods>();
            Projecttemplateservices = new HashSet<Projecttemplateservices>();
        }

        public int Projecttemplateid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Projecttypeid { get; set; }
        public int Projectsubtypeid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Codevalues Projectsubtype { get; set; }
        public virtual Codevalues Projecttype { get; set; }
        public virtual Codevalues Status { get; set; }
        public virtual ICollection<Projecttemplategoods> Projecttemplategoods { get; set; }
        public virtual ICollection<Projecttemplateservices> Projecttemplateservices { get; set; }
    }
}
