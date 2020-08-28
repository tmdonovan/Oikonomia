using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Affiliation
    {
        public Affiliation()
        {
            InAffiliation = new HashSet<InAffiliation>();
        }

        public int Affiliationid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Affiliationtypecd { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual ICollection<InAffiliation> InAffiliation { get; set; }
    }
}
