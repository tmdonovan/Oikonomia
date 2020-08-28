using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class InAffiliation
    {
        public int InAffiliationid { get; set; }
        public int Affiliationid { get; set; }
        public int Participantid { get; set; }
        public string Participanttypecd { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Affiliation Affiliation { get; set; }
        public virtual Organization Participant { get; set; }
    }
}
