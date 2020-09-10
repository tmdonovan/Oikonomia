using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Groups
    {
        public Groups()
        {
            Orggroups = new HashSet<Orggroups>();
        }

        public int Groupid { get; set; }
        public string Description { get; set; }
        public string Longdescription { get; set; }
        public int Grouptypeid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Codevalues Grouptype { get; set; }
        public virtual Codevalues Status { get; set; }
        public virtual ICollection<Orggroups> Orggroups { get; set; }
    }
}
