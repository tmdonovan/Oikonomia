using OikonomiaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaAPI.Data
{
    public interface IPersonRepo
    {
        bool SaveChanges();
        IEnumerable<Person> GetAllPersons();
        Person GetPersonByID(int id);
        void CreatePerson(Person cmd);
        void UpdatePerson(Person cmd);
        void DeletePerson(Person cmd);
    }
}
