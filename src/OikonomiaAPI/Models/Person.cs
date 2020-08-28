using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Person
    {
        public Person()
        {
            InOrganization = new HashSet<InOrganization>();
            IsRelatedPerson = new HashSet<IsRelated>();
            IsRelatedRelatedtoperson = new HashSet<IsRelated>();
        }

        public int Personid { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDt { get; set; }
        public string Sexcd { get; set; }
        public string Ethnicitycd { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual ICollection<InOrganization> InOrganization { get; set; }
        public virtual ICollection<IsRelated> IsRelatedPerson { get; set; }
        public virtual ICollection<IsRelated> IsRelatedRelatedtoperson { get; set; }
    }
}
