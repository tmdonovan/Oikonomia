using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class Codevalues
    {
        public Codevalues()
        {
            GoodGoodsubtype = new HashSet<Good>();
            GoodGoodtype = new HashSet<Good>();
            GoodStatus = new HashSet<Good>();
            GroupsGrouptype = new HashSet<Groups>();
            GroupsStatus = new HashSet<Groups>();
            OrgaddressAddresstype = new HashSet<Orgaddress>();
            OrgaddressCountry = new HashSet<Orgaddress>();
            OrgaddressState = new HashSet<Orgaddress>();
            OrgaddressStatus = new HashSet<Orgaddress>();
            Organization = new HashSet<Organization>();
            OrgconnectionsConnectiontype = new HashSet<Orgconnections>();
            OrgconnectionsStatus = new HashSet<Orgconnections>();
            Orggoods = new HashSet<Orggoods>();
            Orggroups = new HashSet<Orggroups>();
            OrgpersonsParticipationtype = new HashSet<Orgpersons>();
            OrgpersonsStatus = new HashSet<Orgpersons>();
            OrgphonenumberPhonetype = new HashSet<Orgphonenumber>();
            OrgphonenumberStatus = new HashSet<Orgphonenumber>();
            Orgservices = new HashSet<Orgservices>();
            PersonEthnicity = new HashSet<Person>();
            PersonSex = new HashSet<Person>();
            PersonaddressAddresstype = new HashSet<Personaddress>();
            PersonaddressCountry = new HashSet<Personaddress>();
            PersonaddressState = new HashSet<Personaddress>();
            PersonaddressStatus = new HashSet<Personaddress>();
            Persongoods = new HashSet<Persongoods>();
            PersonphonenumberPhonetype = new HashSet<Personphonenumber>();
            PersonphonenumberStatus = new HashSet<Personphonenumber>();
            PersonrelativesRelationshiptype = new HashSet<Personrelatives>();
            PersonrelativesStatus = new HashSet<Personrelatives>();
            Personservices = new HashSet<Personservices>();
            ProjecttemplateProjectsubtype = new HashSet<Projecttemplate>();
            ProjecttemplateProjecttype = new HashSet<Projecttemplate>();
            ProjecttemplateStatus = new HashSet<Projecttemplate>();
            Projecttemplategoods = new HashSet<Projecttemplategoods>();
            Projecttemplateservices = new HashSet<Projecttemplateservices>();
            ServiceServicesubtype = new HashSet<Service>();
            ServiceServicetype = new HashSet<Service>();
            ServiceStatus = new HashSet<Service>();
        }

        public int Codeid { get; set; }
        public string Codegroup { get; set; }
        public string Description { get; set; }
        public string Longdescription { get; set; }
        public int Statusid { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }

        public virtual ICollection<Good> GoodGoodsubtype { get; set; }
        public virtual ICollection<Good> GoodGoodtype { get; set; }
        public virtual ICollection<Good> GoodStatus { get; set; }
        public virtual ICollection<Groups> GroupsGrouptype { get; set; }
        public virtual ICollection<Groups> GroupsStatus { get; set; }
        public virtual ICollection<Orgaddress> OrgaddressAddresstype { get; set; }
        public virtual ICollection<Orgaddress> OrgaddressCountry { get; set; }
        public virtual ICollection<Orgaddress> OrgaddressState { get; set; }
        public virtual ICollection<Orgaddress> OrgaddressStatus { get; set; }
        public virtual ICollection<Organization> Organization { get; set; }
        public virtual ICollection<Orgconnections> OrgconnectionsConnectiontype { get; set; }
        public virtual ICollection<Orgconnections> OrgconnectionsStatus { get; set; }
        public virtual ICollection<Orggoods> Orggoods { get; set; }
        public virtual ICollection<Orggroups> Orggroups { get; set; }
        public virtual ICollection<Orgpersons> OrgpersonsParticipationtype { get; set; }
        public virtual ICollection<Orgpersons> OrgpersonsStatus { get; set; }
        public virtual ICollection<Orgphonenumber> OrgphonenumberPhonetype { get; set; }
        public virtual ICollection<Orgphonenumber> OrgphonenumberStatus { get; set; }
        public virtual ICollection<Orgservices> Orgservices { get; set; }
        public virtual ICollection<Person> PersonEthnicity { get; set; }
        public virtual ICollection<Person> PersonSex { get; set; }
        public virtual ICollection<Personaddress> PersonaddressAddresstype { get; set; }
        public virtual ICollection<Personaddress> PersonaddressCountry { get; set; }
        public virtual ICollection<Personaddress> PersonaddressState { get; set; }
        public virtual ICollection<Personaddress> PersonaddressStatus { get; set; }
        public virtual ICollection<Persongoods> Persongoods { get; set; }
        public virtual ICollection<Personphonenumber> PersonphonenumberPhonetype { get; set; }
        public virtual ICollection<Personphonenumber> PersonphonenumberStatus { get; set; }
        public virtual ICollection<Personrelatives> PersonrelativesRelationshiptype { get; set; }
        public virtual ICollection<Personrelatives> PersonrelativesStatus { get; set; }
        public virtual ICollection<Personservices> Personservices { get; set; }
        public virtual ICollection<Projecttemplate> ProjecttemplateProjectsubtype { get; set; }
        public virtual ICollection<Projecttemplate> ProjecttemplateProjecttype { get; set; }
        public virtual ICollection<Projecttemplate> ProjecttemplateStatus { get; set; }
        public virtual ICollection<Projecttemplategoods> Projecttemplategoods { get; set; }
        public virtual ICollection<Projecttemplateservices> Projecttemplateservices { get; set; }
        public virtual ICollection<Service> ServiceServicesubtype { get; set; }
        public virtual ICollection<Service> ServiceServicetype { get; set; }
        public virtual ICollection<Service> ServiceStatus { get; set; }
    }
}
