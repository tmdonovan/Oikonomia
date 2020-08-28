using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class InProjecttemplate
    {
        public int InProjecttemplateid { get; set; }
        public int Projecttemplateid { get; set; }
        public int Resourceid { get; set; }
        public string Resourcetypecd { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
