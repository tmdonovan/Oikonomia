using OikonomiaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaAPI.Data
{
    public class SqlPersonRepo : IPersonRepo
    {
        private readonly OikonomiaContext _context;

        public SqlPersonRepo(OikonomiaContext context)
        {
            _context = context;
        }

        public void CreatePerson(Person cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Person.Add(cmd);
        }

        public void DeletePerson(Person cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Person.Remove(cmd);
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return _context.Person.ToList();
        }

        public Person GetPersonByID(int id)
        {
            return _context.Person.FirstOrDefault(p => p.Personid == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdatePerson(Person cmd)
        {
            //Nothing Needed; DB Context handles updates
        }
    }
}
