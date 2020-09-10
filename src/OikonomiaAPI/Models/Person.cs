using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Person
    {
        public Person()
        {
            Orggroups = new HashSet<Orggroups>();
            Orgpersons = new HashSet<Orgpersons>();
            Personaddress = new HashSet<Personaddress>();
            Persongoods = new HashSet<Persongoods>();
            Personphonenumber = new HashSet<Personphonenumber>();
            PersonrelativesPerson = new HashSet<Personrelatives>();
            PersonrelativesRelatedtoperson = new HashSet<Personrelatives>();
            Personservices = new HashSet<Personservices>();
        }

        public int Personid { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDt { get; set; }
        public int? Sexid { get; set; }
        public int? Ethnicityid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual Codevalues Ethnicity { get; set; }
        public virtual Codevalues Sex { get; set; }
        public virtual ICollection<Orggroups> Orggroups { get; set; }
        public virtual ICollection<Orgpersons> Orgpersons { get; set; }
        public virtual ICollection<Personaddress> Personaddress { get; set; }
        public virtual ICollection<Persongoods> Persongoods { get; set; }
        public virtual ICollection<Personphonenumber> Personphonenumber { get; set; }
        public virtual ICollection<Personrelatives> PersonrelativesPerson { get; set; }
        public virtual ICollection<Personrelatives> PersonrelativesRelatedtoperson { get; set; }
        public virtual ICollection<Personservices> Personservices { get; set; }
    }
}
