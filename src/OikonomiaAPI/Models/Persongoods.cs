using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Persongoods
    {
        public int Persongoodid { get; set; }
        public int Personid { get; set; }
        public int Goodid { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Good Good { get; set; }
        public virtual Person Person { get; set; }
        public virtual Codevalues Status { get; set; }
    }
}
