using OikonomiaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaAPI.Data
{
    public interface IAffiliationRepo
    {
        bool SaveChanges();
        IEnumerable<Affiliation> GetAllAffiliations();
        Affiliation GetAffiliationByID(int id);
        void CreateAffiliation(Affiliation cmd);
        void UpdateAffiliation(Affiliation cmd);
        void DeleteAffiliation(Affiliation cmd);
    }
}
