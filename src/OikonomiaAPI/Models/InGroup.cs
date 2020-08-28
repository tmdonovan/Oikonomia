using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class InGroup
    {
        public int InGroupid { get; set; }
        public int Groupownerid { get; set; }
        public string Groupownertypecd { get; set; }
        public int Groupid { get; set; }
        public int Participantid { get; set; }
        public string Participanttypecd { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
