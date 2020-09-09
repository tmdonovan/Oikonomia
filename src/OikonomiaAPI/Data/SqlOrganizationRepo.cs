using OikonomiaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaAPI.Data
{
    public class SqlOrganizationRepo : IOrganizationRepo
    {
        private readonly OikonomiaContext _context;

        public SqlOrganizationRepo(OikonomiaContext context)
        {
            _context = context;
        }

        public bool OrganizationExists(int id)
        {
            return _context.Organization.Any(a => a.Organizationid == id);
        }

        public void CreateOrganization(Organization cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Organization.Add(cmd);
        }

        public void DeleteOrganization(Organization cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Organization.Remove(cmd);
        }

        public IEnumerable<Organization> GetAllOrganizations()
        {
            return _context.Organization.ToList();
        }

        public Organization GetOrganizationByID(int id)
        {
            return _context.Organization.FirstOrDefault(p => p.Organizationid == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateOrganization(Organization cmd)
        {
            //Nothing Needed; DB Context handles updates
        }
    }
}
