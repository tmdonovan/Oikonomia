using OikonomiaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaAPI.Data
{
    public interface IOrganizationRepo
    {
        bool SaveChanges();
        IEnumerable<Organization> GetAllOrganizations();
        Organization GetOrganizationByID(int id);
        bool OrganizationExists(int id);
        void CreateOrganization(Organization cmd);
        void UpdateOrganization(Organization cmd);
        void DeleteOrganization(Organization cmd);
    }
}
