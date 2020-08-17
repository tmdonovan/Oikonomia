using Microsoft.AspNetCore.Mvc;
using OikonomiaAPI.Dtos;
using OikonomiaGUI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaGUI.Controllers
{
    public class PersonsController : Controller
    {
        IPersonRepo _personRepo;

        public PersonsController(IPersonRepo personRepo)
        {
            _personRepo = personRepo;
        }

        public IActionResult Index()
        {
            var persons = _personRepo.GetPersons();

            if(persons.Count() <= 0)
            {
                ViewBag.Message = "There was a problem retrieving persons from " +
                    "the database or no person exists";
            }

            return View(persons);
        }

        public IActionResult GetPersonByID(int personId)
        {
            var person = _personRepo.GetPersonByID(personId);

            if (person == null)
            {
                ModelState.AddModelError("", "Error Getting a person");
                ViewBag.Message = @"There was a problem retrieving person with id {personId} " +
                    $"from the database or no person with that id exists";
                person = new PersonReadDto();
            }

            return View(person);
        }
    }
}
