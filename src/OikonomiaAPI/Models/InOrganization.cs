using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class InOrganization
    {
        public int InOrganizationid { get; set; }
        public int Organizationid { get; set; }
        public int Participantid { get; set; }
        public string Participanttypecd { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual Person Participant { get; set; }
    }
}
