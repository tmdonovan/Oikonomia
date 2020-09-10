using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Projecttemplategoods
    {
        public int Projecttempgoodid { get; set; }
        public int Projecttemplateid { get; set; }
        public int Goodid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Good Good { get; set; }
        public virtual Projecttemplate Projecttemplate { get; set; }
        public virtual Codevalues Status { get; set; }
    }
}
