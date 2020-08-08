using OikonomiaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaAPI.Data
{
    public class SqlAffiliationRepo : IAffiliationRepo
    {
        private readonly OikonomiaContext _context;

        public SqlAffiliationRepo(OikonomiaContext context)
        {
            _context = context;
        }

        public void CreateAffiliation(Affiliation cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Affiliation.Add(cmd);
        }

        public void DeleteAffiliation(Affiliation cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Affiliation.Remove(cmd);
        }

        public IEnumerable<Affiliation> GetAllAffiliations()
        {
            return _context.Affiliation.ToList();
        }

        public Affiliation GetAffiliationByID(int id)
        {
            return _context.Affiliation.FirstOrDefault(p => p.Affiliationid == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateAffiliation(Affiliation cmd)
        {
            //Nothing Needed; DB Context handles updates
        }
    }
}
