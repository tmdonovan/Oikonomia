using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaAPI.Dtos
{
    public class AffiliationReadDto
    {
        public int Affiliationid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Affiliationtypecd { get; set; }
        public string Statuscd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
