using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class IsRelated
    {
        public int IsRelatedid { get; set; }
        public int Personid { get; set; }
        public int Relatedtopersonid { get; set; }
        public string Relationshipcd { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Person Person { get; set; }
        public virtual Person Relatedtoperson { get; set; }
    }
}
