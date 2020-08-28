using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Codevalues
    {
        public int Codevaluesid { get; set; }
        public string Codegroup { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
