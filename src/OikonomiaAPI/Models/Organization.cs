using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Organization
    {
        public Organization()
        {
            InAffiliation = new HashSet<InAffiliation>();
            InOrganization = new HashSet<InOrganization>();
        }

        public int Organizationid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Organizationtypecd { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual ICollection<InAffiliation> InAffiliation { get; set; }
        public virtual ICollection<InOrganization> InOrganization { get; set; }
    }
}
