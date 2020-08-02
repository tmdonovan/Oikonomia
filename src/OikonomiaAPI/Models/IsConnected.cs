using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class IsConnected
    {
        public int IsConnectectedid { get; set; }
        public int Ownerid { get; set; }
        public string Ownertypecd { get; set; }
        public int Connectionid { get; set; }
        public string Connectiontypecd { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
