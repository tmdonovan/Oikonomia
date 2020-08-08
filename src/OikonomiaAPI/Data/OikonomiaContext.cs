using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OikonomiaAPI.Models
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

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Affiliation> Affiliation { get; set; }
        public virtual DbSet<Good> Good { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Phonenumber> Phonenumber { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address", "sys");

                entity.Property(e => e.Addressid).HasColumnName("addressid");

                entity.Property(e => e.Addressln1)
                    .IsRequired()
                    .HasColumnName("addressln1")
                    .HasMaxLength(50);

                entity.Property(e => e.Addressln2)
                    .HasColumnName("addressln2")
                    .HasMaxLength(50);

                entity.Property(e => e.Addresstypecd)
                    .IsRequired()
                    .HasColumnName("addresstypecd")
                    .HasMaxLength(10);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Countrycd)
                    .IsRequired()
                    .HasColumnName("countrycd")
                    .HasMaxLength(10);

                entity.Property(e => e.County)
                    .HasColumnName("county")
                    .HasMaxLength(25);

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Ownerid).HasColumnName("ownerid");

                entity.Property(e => e.Ownertypecd)
                    .IsRequired()
                    .HasColumnName("ownertypecd")
                    .HasMaxLength(10);

                entity.Property(e => e.Statecd)
                    .IsRequired()
                    .HasColumnName("statecd")
                    .HasMaxLength(10);

                entity.Property(e => e.Statuscd)
                    .IsRequired()
                    .HasColumnName("statuscd")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnName("zip")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Affiliation>(entity =>
            {
                entity.ToTable("affiliation", "sys");

                entity.Property(e => e.Affiliationid).HasColumnName("affiliationid");

                entity.Property(e => e.Affiliationtypecd)
                    .IsRequired()
                    .HasColumnName("affiliationtypecd")
                    .HasMaxLength(10);

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

                entity.Property(e => e.Statuscd)
                    .IsRequired()
                    .HasColumnName("statuscd")
                    .HasMaxLength(10);

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
                    .HasColumnName("description")
                    .HasMaxLength(355);

                entity.Property(e => e.Goodtypecd)
                    .IsRequired()
                    .HasColumnName("goodtypecd")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Statuscd)
                    .IsRequired()
                    .HasColumnName("statuscd")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("group", "sys");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(355);

                entity.Property(e => e.Grouptypecd)
                    .IsRequired()
                    .HasColumnName("grouptypecd")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Statuscd)
                    .IsRequired()
                    .HasColumnName("statuscd")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");
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
                    .HasColumnName("description")
                    .HasMaxLength(355);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Organizationtypecd)
                    .IsRequired()
                    .HasColumnName("organizationtypecd")
                    .HasMaxLength(10);

                entity.Property(e => e.Statuscd)
                    .IsRequired()
                    .HasColumnName("statuscd")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");
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

                entity.Property(e => e.Ethnicitycd)
                    .HasColumnName("ethnicitycd")
                    .HasMaxLength(10);

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

                entity.Property(e => e.Sexcd)
                    .HasColumnName("sexcd")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Phonenumber>(entity =>
            {
                entity.ToTable("phonenumber", "sys");

                entity.Property(e => e.Phonenumberid).HasColumnName("phonenumberid");

                entity.Property(e => e.Areacode).HasColumnName("areacode");

                entity.Property(e => e.Countrycode).HasColumnName("countrycode");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Ownerid).HasColumnName("ownerid");

                entity.Property(e => e.Ownertypecd)
                    .IsRequired()
                    .HasColumnName("ownertypecd")
                    .HasMaxLength(10);

                entity.Property(e => e.Phonenumber1).HasColumnName("phonenumber");

                entity.Property(e => e.Phonetypecd)
                    .IsRequired()
                    .HasColumnName("phonetypecd")
                    .HasMaxLength(10);

                entity.Property(e => e.Statuscd)
                    .IsRequired()
                    .HasColumnName("statuscd")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");
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

                entity.Property(e => e.Servicetypecd)
                    .IsRequired()
                    .HasColumnName("servicetypecd")
                    .HasMaxLength(10);

                entity.Property(e => e.Statuscd)
                    .IsRequired()
                    .HasColumnName("statuscd")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("update_dt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("now()");
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
