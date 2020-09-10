using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OikonomiaAPI.Models;

namespace OikonomiaAPI.Data
{
    public partial class OikonomiaContext : DbContext
    {
        public OikonomiaContext()
        {
        }

        public OikonomiaContext(DbContextOptions<OikonomiaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Codevalues> Codevalues { get; set; }
        public virtual DbSet<Good> Good { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Orgaddress> Orgaddress { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<Orgconnections> Orgconnections { get; set; }
        public virtual DbSet<Orggoods> Orggoods { get; set; }
        public virtual DbSet<Orggroups> Orggroups { get; set; }
        public virtual DbSet<Orgpersons> Orgpersons { get; set; }
        public virtual DbSet<Orgphonenumber> Orgphonenumber { get; set; }
        public virtual DbSet<Orgservices> Orgservices { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Personaddress> Personaddress { get; set; }
        public virtual DbSet<Persongoods> Persongoods { get; set; }
        public virtual DbSet<Personphonenumber> Personphonenumber { get; set; }
        public virtual DbSet<Personrelatives> Personrelatives { get; set; }
        public virtual DbSet<Personservices> Personservices { get; set; }
        public virtual DbSet<Projecttemplate> Projecttemplate { get; set; }
        public virtual DbSet<Projecttemplategoods> Projecttemplategoods { get; set; }
        public virtual DbSet<Projecttemplateservices> Projecttemplateservices { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Codevalues>(entity =>
            {
                entity.HasKey(e => e.Codeid)
                    .HasName("codevalues_pkey");

                entity.ToTable("codevalues", "sys");

                entity.Property(e => e.Codeid).HasColumnName("codeid");

                entity.Property(e => e.Codegroup)
                    .IsRequired()
                    .HasColumnName("codegroup")
                    .HasMaxLength(25);

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(25);

                entity.Property(e => e.Longdescription)
                    .HasColumnName("longdescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Good>(entity =>
            {
                entity.ToTable("good", "sys");

                entity.Property(e => e.Goodid).HasColumnName("goodid");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.Goodsubtypeid).HasColumnName("goodsubtypeid");

                entity.Property(e => e.Goodtypeid).HasColumnName("goodtypeid");

                entity.Property(e => e.Longdescription)
                    .HasColumnName("longdescription")
                    .HasMaxLength(355);

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Goodsubtype)
                    .WithMany(p => p.GoodGoodsubtype)
                    .HasForeignKey(d => d.Goodsubtypeid)
                    .HasConstraintName("fk_good_to_codevalues_goodsubtypeid");

                entity.HasOne(d => d.Goodtype)
                    .WithMany(p => p.GoodGoodtype)
                    .HasForeignKey(d => d.Goodtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_good_to_codevalues_goodtypeid");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.GoodStatus)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_good_to_codevalues_statusid");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.Groupid)
                    .HasName("group_pkey");

                entity.ToTable("groups", "sys");

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasDefaultValueSql("nextval('sys.group_groupid_seq'::regclass)");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.Grouptypeid).HasColumnName("grouptypeid");

                entity.Property(e => e.Longdescription)
                    .HasColumnName("longdescription")
                    .HasMaxLength(355);

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Grouptype)
                    .WithMany(p => p.GroupsGrouptype)
                    .HasForeignKey(d => d.Grouptypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_groups_to_codevalues_grouptypeid");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.GroupsStatus)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_groups_to_codevalues_statusid");
            });

            modelBuilder.Entity<Orgaddress>(entity =>
            {
                entity.ToTable("orgaddress", "sys");

                entity.Property(e => e.Orgaddressid).HasColumnName("orgaddressid");

                entity.Property(e => e.Addressln1)
                    .IsRequired()
                    .HasColumnName("addressln1")
                    .HasMaxLength(50);

                entity.Property(e => e.Addressln2)
                    .HasColumnName("addressln2")
                    .HasMaxLength(50);

                entity.Property(e => e.Addresstypeid).HasColumnName("addresstypeid");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Countryid).HasColumnName("countryid");

                entity.Property(e => e.County)
                    .HasColumnName("county")
                    .HasMaxLength(25);

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Organizationid).HasColumnName("organizationid");

                entity.Property(e => e.Stateid).HasColumnName("stateid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnName("zip")
                    .HasMaxLength(10);

                entity.HasOne(d => d.Addresstype)
                    .WithMany(p => p.OrgaddressAddresstype)
                    .HasForeignKey(d => d.Addresstypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgaddress_to_codevalues_addresstypeid");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.OrgaddressCountry)
                    .HasForeignKey(d => d.Countryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgaddress_to_codevalues_countryid");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Orgaddress)
                    .HasForeignKey(d => d.Organizationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgaddress_to_org");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.OrgaddressState)
                    .HasForeignKey(d => d.Stateid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgaddress_to_codevalues_stateid");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.OrgaddressStatus)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgaddress_to_codevalues_statusid");
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.ToTable("organization", "sys");

                entity.Property(e => e.Organizationid).HasColumnName("organizationid");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.Longdescription)
                    .HasColumnName("longdescription")
                    .HasMaxLength(355);

                entity.Property(e => e.Organizationtypeid).HasColumnName("organizationtypeid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Organization)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_organization_to_codevalues_statusid");
            });

            modelBuilder.Entity<Orgconnections>(entity =>
            {
                entity.HasKey(e => e.Orgconnectionid)
                    .HasName("orgconnectionid_pkey");

                entity.ToTable("orgconnections", "sys");

                entity.Property(e => e.Orgconnectionid).HasColumnName("orgconnectionid");

                entity.Property(e => e.Connectedtoorgid).HasColumnName("connectedtoorgid");

                entity.Property(e => e.Connectiontypeid).HasColumnName("connectiontypeid");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Organizationid).HasColumnName("organizationid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Connectedtoorg)
                    .WithMany(p => p.OrgconnectionsConnectedtoorg)
                    .HasForeignKey(d => d.Connectedtoorgid)
                    .HasConstraintName("fk_orgconnections_to_connectedtoorg");

                entity.HasOne(d => d.Connectiontype)
                    .WithMany(p => p.OrgconnectionsConnectiontype)
                    .HasForeignKey(d => d.Connectiontypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgconnections_to_codevalues_connectiontypeid");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OrgconnectionsOrganization)
                    .HasForeignKey(d => d.Organizationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgconnections_to_org");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.OrgconnectionsStatus)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgconnections_to_codevalues_statusid");
            });

            modelBuilder.Entity<Orggoods>(entity =>
            {
                entity.HasKey(e => e.Orggoodid)
                    .HasName("orggoodid_pkey");

                entity.ToTable("orggoods", "sys");

                entity.Property(e => e.Orggoodid).HasColumnName("orggoodid");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Goodid).HasColumnName("goodid");

                entity.Property(e => e.Organizationid).HasColumnName("organizationid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Good)
                    .WithMany(p => p.Orggoods)
                    .HasForeignKey(d => d.Goodid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orggoods_to_good");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Orggoods)
                    .HasForeignKey(d => d.Organizationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orggoods_to_org");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Orggoods)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orggoods_to_codevalues_statusid");
            });

            modelBuilder.Entity<Orggroups>(entity =>
            {
                entity.HasKey(e => e.Orggroupid)
                    .HasName("orggroup_pkey");

                entity.ToTable("orggroups", "sys");

                entity.Property(e => e.Orggroupid).HasColumnName("orggroupid");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.OwnerOrganizationid).HasColumnName("owner_organizationid");

                entity.Property(e => e.ParticipantOrganizationid).HasColumnName("participant_organizationid");

                entity.Property(e => e.ParticipantPersonid).HasColumnName("participant_personid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Orggroups)
                    .HasForeignKey(d => d.Groupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orggroups_to_groups");

                entity.HasOne(d => d.OwnerOrganization)
                    .WithMany(p => p.OrggroupsOwnerOrganization)
                    .HasForeignKey(d => d.OwnerOrganizationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orggroups_to_ownerorg");

                entity.HasOne(d => d.ParticipantOrganization)
                    .WithMany(p => p.OrggroupsParticipantOrganization)
                    .HasForeignKey(d => d.ParticipantOrganizationid)
                    .HasConstraintName("fk_orggroups_to_participantorg");

                entity.HasOne(d => d.ParticipantPerson)
                    .WithMany(p => p.Orggroups)
                    .HasForeignKey(d => d.ParticipantPersonid)
                    .HasConstraintName("fk_orggroups_to_participantperson");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Orggroups)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orggroups_to_codevalues_statusid");
            });

            modelBuilder.Entity<Orgpersons>(entity =>
            {
                entity.HasKey(e => e.Orgpersonid)
                    .HasName("orgperson_pkey");

                entity.ToTable("orgpersons", "sys");

                entity.Property(e => e.Orgpersonid).HasColumnName("orgpersonid");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Organizationid).HasColumnName("organizationid");

                entity.Property(e => e.Participationtypeid).HasColumnName("participationtypeid");

                entity.Property(e => e.Personid).HasColumnName("personid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Orgpersons)
                    .HasForeignKey(d => d.Organizationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgpersons_to_org");

                entity.HasOne(d => d.Participationtype)
                    .WithMany(p => p.OrgpersonsParticipationtype)
                    .HasForeignKey(d => d.Participationtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgpersons_to_codevalues_participationtypeid");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Orgpersons)
                    .HasForeignKey(d => d.Personid)
                    .HasConstraintName("fk_orgpersons_to_person");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.OrgpersonsStatus)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgpersons_to_codevalues_statusid");
            });

            modelBuilder.Entity<Orgphonenumber>(entity =>
            {
                entity.ToTable("orgphonenumber", "sys");

                entity.Property(e => e.Orgphonenumberid).HasColumnName("orgphonenumberid");

                entity.Property(e => e.Areacode).HasColumnName("areacode");

                entity.Property(e => e.Countrycode).HasColumnName("countrycode");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Organizationid).HasColumnName("organizationid");

                entity.Property(e => e.Phonenumber).HasColumnName("phonenumber");

                entity.Property(e => e.Phonetypeid).HasColumnName("phonetypeid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Orgphonenumber)
                    .HasForeignKey(d => d.Organizationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgphonenumber_to_org");

                entity.HasOne(d => d.Phonetype)
                    .WithMany(p => p.OrgphonenumberPhonetype)
                    .HasForeignKey(d => d.Phonetypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgphonenumber_to_codevalues_phonetypeid");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.OrgphonenumberStatus)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgphonenumber_to_codevalues_statusid");
            });

            modelBuilder.Entity<Orgservices>(entity =>
            {
                entity.HasKey(e => e.Orgserviceid)
                    .HasName("orgserviceid_pkey");

                entity.ToTable("orgservices", "sys");

                entity.Property(e => e.Orgserviceid).HasColumnName("orgserviceid");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Organizationid).HasColumnName("organizationid");

                entity.Property(e => e.Serviceid).HasColumnName("serviceid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Orgservices)
                    .HasForeignKey(d => d.Organizationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgservices_to_org");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Orgservices)
                    .HasForeignKey(d => d.Serviceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgservices_to_service");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Orgservices)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgservices_to_codevalues_statusid");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("person", "sys");

                entity.HasIndex(e => e.Email)
                    .HasName("person_email_key")
                    .IsUnique();

                entity.HasIndex(e => e.Username)
                    .HasName("person_username_key")
                    .IsUnique();

                entity.Property(e => e.Personid).HasColumnName("personid");

                entity.Property(e => e.BirthDt)
                    .HasColumnName("birth_dt")
                    .HasColumnType("date");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(355);

                entity.Property(e => e.Ethnicityid).HasColumnName("ethnicityid");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(50);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(50);

                entity.Property(e => e.Middlename)
                    .HasColumnName("middlename")
                    .HasMaxLength(50);

                entity.Property(e => e.Sexid).HasColumnName("sexid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Ethnicity)
                    .WithMany(p => p.PersonEthnicity)
                    .HasForeignKey(d => d.Ethnicityid)
                    .HasConstraintName("fk_person_to_codevalues_ethnicityid");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.PersonSex)
                    .HasForeignKey(d => d.Sexid)
                    .HasConstraintName("fk_person_to_codevalues_sexid");
            });

            modelBuilder.Entity<Personaddress>(entity =>
            {
                entity.ToTable("personaddress", "sys");

                entity.Property(e => e.Personaddressid).HasColumnName("personaddressid");

                entity.Property(e => e.Addressln1)
                    .IsRequired()
                    .HasColumnName("addressln1")
                    .HasMaxLength(50);

                entity.Property(e => e.Addressln2)
                    .HasColumnName("addressln2")
                    .HasMaxLength(50);

                entity.Property(e => e.Addresstypeid).HasColumnName("addresstypeid");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Countryid).HasColumnName("countryid");

                entity.Property(e => e.County)
                    .HasColumnName("county")
                    .HasMaxLength(25);

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Personid).HasColumnName("personid");

                entity.Property(e => e.Stateid).HasColumnName("stateid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnName("zip")
                    .HasMaxLength(10);

                entity.HasOne(d => d.Addresstype)
                    .WithMany(p => p.PersonaddressAddresstype)
                    .HasForeignKey(d => d.Addresstypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personaddress_to_codevalues_addresstypeid");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.PersonaddressCountry)
                    .HasForeignKey(d => d.Countryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personaddress_to_codevalues_countryid");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Personaddress)
                    .HasForeignKey(d => d.Personid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personaddress_to_org");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.PersonaddressState)
                    .HasForeignKey(d => d.Stateid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personaddress_to_codevalues_stateid");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.PersonaddressStatus)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personaddress_to_codevalues_statusid");
            });

            modelBuilder.Entity<Persongoods>(entity =>
            {
                entity.HasKey(e => e.Persongoodid)
                    .HasName("persongoodid_pkey");

                entity.ToTable("persongoods", "sys");

                entity.Property(e => e.Persongoodid).HasColumnName("persongoodid");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Goodid).HasColumnName("goodid");

                entity.Property(e => e.Personid).HasColumnName("personid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Good)
                    .WithMany(p => p.Persongoods)
                    .HasForeignKey(d => d.Goodid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_persongoods_to_good");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Persongoods)
                    .HasForeignKey(d => d.Personid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_persongoods_to_person");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Persongoods)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_persongoods_to_codevalues_statusid");
            });

            modelBuilder.Entity<Personphonenumber>(entity =>
            {
                entity.ToTable("personphonenumber", "sys");

                entity.Property(e => e.Personphonenumberid).HasColumnName("personphonenumberid");

                entity.Property(e => e.Areacode).HasColumnName("areacode");

                entity.Property(e => e.Countrycode).HasColumnName("countrycode");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Personid).HasColumnName("personid");

                entity.Property(e => e.Phonenumber).HasColumnName("phonenumber");

                entity.Property(e => e.Phonetypeid).HasColumnName("phonetypeid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Personphonenumber)
                    .HasForeignKey(d => d.Personid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personphonenumber_to_person");

                entity.HasOne(d => d.Phonetype)
                    .WithMany(p => p.PersonphonenumberPhonetype)
                    .HasForeignKey(d => d.Phonetypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personphonenumber_to_codevalues_phonetypeid");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.PersonphonenumberStatus)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personphonenumber_to_codevalues_statusid");
            });

            modelBuilder.Entity<Personrelatives>(entity =>
            {
                entity.HasKey(e => e.Personrelativeid)
                    .HasName("personrelativeid_pkey");

                entity.ToTable("personrelatives", "sys");

                entity.Property(e => e.Personrelativeid).HasColumnName("personrelativeid");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Personid).HasColumnName("personid");

                entity.Property(e => e.Relatedtopersonid).HasColumnName("relatedtopersonid");

                entity.Property(e => e.Relationshiptypeid).HasColumnName("relationshiptypeid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonrelativesPerson)
                    .HasForeignKey(d => d.Personid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personrelatives_to_person");

                entity.HasOne(d => d.Relatedtoperson)
                    .WithMany(p => p.PersonrelativesRelatedtoperson)
                    .HasForeignKey(d => d.Relatedtopersonid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personrelatives_to_relative");

                entity.HasOne(d => d.Relationshiptype)
                    .WithMany(p => p.PersonrelativesRelationshiptype)
                    .HasForeignKey(d => d.Relationshiptypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personrelatives_to_codevalues_relationshiptypeid");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.PersonrelativesStatus)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personrelatives_to_codevalues_statusid");
            });

            modelBuilder.Entity<Personservices>(entity =>
            {
                entity.HasKey(e => e.Personserviceid)
                    .HasName("personserviceid_pkey");

                entity.ToTable("personservices", "sys");

                entity.Property(e => e.Personserviceid).HasColumnName("personserviceid");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Personid).HasColumnName("personid");

                entity.Property(e => e.Serviceid).HasColumnName("serviceid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Personservices)
                    .HasForeignKey(d => d.Personid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personservices_to_person");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Personservices)
                    .HasForeignKey(d => d.Serviceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personservices_to_service");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Personservices)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_personservices_to_codevalues_statusid");
            });

            modelBuilder.Entity<Projecttemplate>(entity =>
            {
                entity.ToTable("projecttemplate", "sys");

                entity.Property(e => e.Projecttemplateid).HasColumnName("projecttemplateid");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(355);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Projectsubtypeid).HasColumnName("projectsubtypeid");

                entity.Property(e => e.Projecttypeid).HasColumnName("projecttypeid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Projectsubtype)
                    .WithMany(p => p.ProjecttemplateProjectsubtype)
                    .HasForeignKey(d => d.Projectsubtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_projecttemplate_to_codevalues_projectsubtypeid");

                entity.HasOne(d => d.Projecttype)
                    .WithMany(p => p.ProjecttemplateProjecttype)
                    .HasForeignKey(d => d.Projecttypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_projecttemplate_to_codevalues_projecttypeid");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ProjecttemplateStatus)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_projecttemplate_to_codevalues_statusid");
            });

            modelBuilder.Entity<Projecttemplategoods>(entity =>
            {
                entity.HasKey(e => e.Projecttempgoodid)
                    .HasName("projecttempgoodid_pkey");

                entity.ToTable("projecttemplategoods", "sys");

                entity.Property(e => e.Projecttempgoodid).HasColumnName("projecttempgoodid");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Goodid).HasColumnName("goodid");

                entity.Property(e => e.Projecttemplateid).HasColumnName("projecttemplateid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Good)
                    .WithMany(p => p.Projecttemplategoods)
                    .HasForeignKey(d => d.Goodid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_projecttemplategoods_to_good");

                entity.HasOne(d => d.Projecttemplate)
                    .WithMany(p => p.Projecttemplategoods)
                    .HasForeignKey(d => d.Projecttemplateid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_projecttemplategoods_to_projecttemplate");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Projecttemplategoods)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_projecttemplategoods_to_codevalues_statusid");
            });

            modelBuilder.Entity<Projecttemplateservices>(entity =>
            {
                entity.HasKey(e => e.Projecttempserviceid)
                    .HasName("projecttempserviceid_pkey");

                entity.ToTable("projecttemplateservices", "sys");

                entity.Property(e => e.Projecttempserviceid).HasColumnName("projecttempserviceid");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Projecttemplateid).HasColumnName("projecttemplateid");

                entity.Property(e => e.Serviceid).HasColumnName("serviceid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Projecttemplate)
                    .WithMany(p => p.Projecttemplateservices)
                    .HasForeignKey(d => d.Projecttemplateid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_projecttemplateservices_to_projecttemplate");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Projecttemplateservices)
                    .HasForeignKey(d => d.Serviceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_projecttemplateservices_to_service");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Projecttemplateservices)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_projecttemplateservices_to_codevalues_statusid");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("service", "sys");

                entity.Property(e => e.Serviceid).HasColumnName("serviceid");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(355);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Servicesubtypeid).HasColumnName("servicesubtypeid");

                entity.Property(e => e.Servicetypeid).HasColumnName("servicetypeid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.Servicesubtype)
                    .WithMany(p => p.ServiceServicesubtype)
                    .HasForeignKey(d => d.Servicesubtypeid)
                    .HasConstraintName("fk_service_to_codevalues_servicesubtypeid");

                entity.HasOne(d => d.Servicetype)
                    .WithMany(p => p.ServiceServicetype)
                    .HasForeignKey(d => d.Servicetypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_service_to_codevalues_servicetypeid");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ServiceStatus)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_service_to_codevalues_statusid");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user", "sys");

                entity.HasIndex(e => e.Email)
                    .HasName("user_email_key")
                    .IsUnique();

                entity.HasIndex(e => e.Password)
                    .HasName("user_password_key")
                    .IsUnique();

                entity.HasIndex(e => e.Username)
                    .HasName("user_username_key")
                    .IsUnique();

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(355);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
