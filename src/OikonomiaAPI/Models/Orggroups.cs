using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Orggroups
    {
        public int Orggroupid { get; set; }
        public int Groupid { get; set; }
        public int OwnerOrganizationid { get; set; }
        public int? ParticipantPersonid { get; set; }
        public int? ParticipantOrganizationid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Groups Group { get; set; }
        public virtual Organization OwnerOrganization { get; set; }
        public virtual Organization ParticipantOrganization { get; set; }
        public virtual Person ParticipantPerson { get; set; }
        public virtual Codevalues Status { get; set; }
    }
}
