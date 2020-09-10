using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Good
    {
        public Good()
        {
            Orggoods = new HashSet<Orggoods>();
            Persongoods = new HashSet<Persongoods>();
            Projecttemplategoods = new HashSet<Projecttemplategoods>();
        }

        public int Goodid { get; set; }
        public string Description { get; set; }
        public string Longdescription { get; set; }
        public int Goodtypeid { get; set; }
        public int? Goodsubtypeid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Codevalues Goodsubtype { get; set; }
        public virtual Codevalues Goodtype { get; set; }
        public virtual Codevalues Status { get; set; }
        public virtual ICollection<Orggoods> Orggoods { get; set; }
        public virtual ICollection<Persongoods> Persongoods { get; set; }
        public virtual ICollection<Projecttemplategoods> Projecttemplategoods { get; set; }
    }
}
