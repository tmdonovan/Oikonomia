using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Orgpersons
    {
        public int Orgpersonid { get; set; }
        public int Organizationid { get; set; }
        public int? Personid { get; set; }
        public int Participationtypeid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual Codevalues Participationtype { get; set; }
        public virtual Person Person { get; set; }
        public virtual Codevalues Status { get; set; }
    }
}
