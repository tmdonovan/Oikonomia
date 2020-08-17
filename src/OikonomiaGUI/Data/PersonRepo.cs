using OikonomiaAPI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace OikonomiaGUI.Data
{
    public class PersonRepo : IPersonRepo
    {
        public PersonReadDto GetPersonByID(int personId)
        {
            PersonReadDto person = new PersonReadDto();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5001/api/");

                var response = client.GetAsync($"persons/{personId}");
                response.Wait();

                var result = response.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<PersonReadDto>();
                    readTask.Wait();

                    person = readTask.Result;
                }
            }

            return person;
        }

        public IEnumerable<PersonReadDto> GetPersons()
        {
            IEnumerable<PersonReadDto> persons = new List<PersonReadDto>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5001/api/");

                var response = client.GetAsync("persons");
                response.Wait();

                var result = response.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<PersonReadDto>>();
                    readTask.Wait();

                    persons = readTask.Result;
                }
            }

            return persons;
        }
    }
}
