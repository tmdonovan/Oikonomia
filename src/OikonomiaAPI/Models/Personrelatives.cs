using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Personrelatives
    {
        public int Personrelativeid { get; set; }
        public int Personid { get; set; }
        public int Relatedtopersonid { get; set; }
        public int Relationshiptypeid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Person Person { get; set; }
        public virtual Person Relatedtoperson { get; set; }
        public virtual Codevalues Relationshiptype { get; set; }
        public virtual Codevalues Status { get; set; }
    }
}
