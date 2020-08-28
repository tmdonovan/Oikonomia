using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Projecttemplate
    {
        public int Projecttemplateid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Projecttypecd { get; set; }
        public string Projectsubtypecd { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
