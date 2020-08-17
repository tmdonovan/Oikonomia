using OikonomiaAPI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaGUI.Data
{
    public interface IPersonRepo
    {
        IEnumerable<PersonReadDto> GetPersons();
        PersonReadDto GetPersonByID(int personId);
    }
}
