using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaAPI.Dtos
{
    public class OrganizationUpdateDto
    {
        public string Description { get; set; }
        public string Longdescription { get; set; }
        public string Organizationtypeid{ get; set; }
        public string Statusid { get; set; }
    }
}
