using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Organization
    {
        public Organization()
        {
            Orgaddress = new HashSet<Orgaddress>();
            OrgconnectionsConnectedtoorg = new HashSet<Orgconnections>();
            OrgconnectionsOrganization = new HashSet<Orgconnections>();
            Orggoods = new HashSet<Orggoods>();
            OrggroupsOwnerOrganization = new HashSet<Orggroups>();
            OrggroupsParticipantOrganization = new HashSet<Orggroups>();
            Orgpersons = new HashSet<Orgpersons>();
            Orgphonenumber = new HashSet<Orgphonenumber>();
            Orgservices = new HashSet<Orgservices>();
        }

        public int Organizationid { get; set; }
        public string Description { get; set; }
        public string Longdescription { get; set; }
        public int Organizationtypeid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Codevalues Status { get; set; }
        public virtual ICollection<Orgaddress> Orgaddress { get; set; }
        public virtual ICollection<Orgconnections> OrgconnectionsConnectedtoorg { get; set; }
        public virtual ICollection<Orgconnections> OrgconnectionsOrganization { get; set; }
        public virtual ICollection<Orggoods> Orggoods { get; set; }
        public virtual ICollection<Orggroups> OrggroupsOwnerOrganization { get; set; }
        public virtual ICollection<Orggroups> OrggroupsParticipantOrganization { get; set; }
        public virtual ICollection<Orgpersons> Orgpersons { get; set; }
        public virtual ICollection<Orgphonenumber> Orgphonenumber { get; set; }
        public virtual ICollection<Orgservices> Orgservices { get; set; }
    }
}
