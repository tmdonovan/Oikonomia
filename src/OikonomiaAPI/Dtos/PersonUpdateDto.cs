using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaAPI.Dtos
{
    public class PersonUpdateDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDt { get; set; }
        public string Sexcd { get; set; }
        public string Ethnicitycd { get; set; }
    }
}
