using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaAPI.Dtos
{
    public class AffiliationUpdateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Affiliationtypecd { get; set; }
        public string Statuscd { get; set; }
    }
}
