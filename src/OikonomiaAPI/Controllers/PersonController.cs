using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OikonomiaAPI.Models;

namespace OikonomiaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController: ControllerBase
    {
        private readonly OikonomiaContext _context;

        public PersonController(OikonomiaContext context) => _context = context;

        [HttpGet]
        public ActionResult<IEnumerable<Person>>GetPersons()
        {
            return _context.Person;
        }
    }
}
