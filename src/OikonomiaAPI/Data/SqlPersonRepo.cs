﻿using OikonomiaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OikonomiaAPI.Data
{
    public class SqlPersonRepo : IPersonRepo
    {
        private readonly OikonomiaContext _context;

        public SqlPersonRepo(OikonomiaContext context)
        {
            _context = context;
        }
        public bool PersonExists(int id)
        {
            return _context
                .Person.Any(a => a.Personid == id);
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

            _context.Person
                .Remove(cmd);
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return _context.Person
                .ToList();
        }

        public Person GetPersonByID(int id)
        {
            var person = _context.Person
                .Include(s => s.Sex)
                .Include(e => e.Ethnicity)
                .FirstOrDefault(p => p.Personid == id);

            return person;
        }

        public ICollection<Organization> GetOrgsByPerson(int personID)
        {
            return _context.Orgpersons
                .Where(p => p.Person.Personid == personID)
                .Select(o => o.Organization)
                .ToList();
        }

        public ICollection<Person> GetPersonsByOrg(int organizationID)
        {
            return _context.Orgpersons
                .Where(o => o.Organization.Organizationid == organizationID)
                .Select(p => p.Person)
                .ToList();
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
