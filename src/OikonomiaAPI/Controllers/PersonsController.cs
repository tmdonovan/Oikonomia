using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OikonomiaAPI.Models;
using AutoMapper;
using OikonomiaAPI.Data;
using OikonomiaAPI.Dtos;
using Microsoft.AspNetCore.JsonPatch;

namespace OikonomiaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController: ControllerBase
    {

        private readonly IPersonRepo _personRepository;
        private readonly IOrganizationRepo _organizationRepository;
        private readonly IMapper _mapper;

        public PersonsController(IPersonRepo personRepository, IOrganizationRepo organizationRepo, IMapper mapper)
        {
            _personRepository = personRepository;
            _organizationRepository = organizationRepo;
            _mapper = mapper;
        }

        //GET api/persons
        [HttpGet]
        public ActionResult<IEnumerable<PersonReadDto>> GetAllPersons()
        {
            var personItems = _personRepository.GetAllPersons();

            return Ok(_mapper.Map<IEnumerable<PersonReadDto>>(personItems));
        }

        //GET api/persons/{id}
        [HttpGet("{id}", Name = "GetPersonById")]
        public ActionResult<PersonReadDto> GetPersonById(int id)
        {
            var personItem = _personRepository.GetPersonByID(id);
            if (personItem != null)
            {
                return Ok(_mapper.Map<PersonReadDto>(personItem));
            }
            return NotFound();
        }

        //api/persons/personId/organizations
        [HttpGet("{personId}/organizations")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<OrganizationReadDto>))]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<OrganizationReadDto>> GetOrgsByPerson(int personID)
        {
            if (!_personRepository.PersonExists(personID))
                return NotFound();

            var orgs = _personRepository.GetOrgsByPerson(personID);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(_mapper.Map<IEnumerable<OrganizationReadDto>>(orgs));
        }

        //api/persons/organizations/organizationId
        [HttpGet("organizations/{organizationId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<PersonReadDto>))]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<PersonReadDto>> GetPersonsByOrg(int organizationId)
        {
            if (!_organizationRepository.OrganizationExists(organizationId))
                return NotFound();

            var persons = _personRepository.GetPersonsByOrg(organizationId);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(_mapper.Map<IEnumerable<PersonReadDto>>(persons));
        }

        //POST api/commands
        [HttpPost]
        public ActionResult<PersonReadDto> CreatePerson(PersonCreateDto personCreateDto)
        {
            var personModel = _mapper.Map<Person>(personCreateDto);
            _personRepository.CreatePerson(personModel);
            _personRepository.SaveChanges();

            var personReadDto = _mapper.Map<PersonReadDto>(personModel);

            //Look at Microsoft documentation on CreatedAtRoute method
            return CreatedAtRoute(nameof(GetPersonById), new { Id = personReadDto.Personid }, personReadDto);
        }

        //PUT api/commands/{id}
        [HttpPut("{id}")]
        public ActionResult UpdatePerson(int id, PersonUpdateDto personUpdateDto)
        {
            var personModelFromRepo = _personRepository.GetPersonByID(id);
            if (personModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(personUpdateDto, personModelFromRepo);

            _personRepository.UpdatePerson(personModelFromRepo);

            _personRepository.SaveChanges();

            return NoContent();
        }

        //PATCH api/commands/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialPersonUpdate(int id, JsonPatchDocument<PersonUpdateDto> patchDoc)
        {
            var personModelFromRepo = _personRepository.GetPersonByID(id);
            if (personModelFromRepo == null)
            {
                return NotFound();
            }

            var personToPatch = _mapper.Map<PersonUpdateDto>(personModelFromRepo);
            patchDoc.ApplyTo(personToPatch, ModelState);

            if (!TryValidateModel(personToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(personToPatch, personModelFromRepo);

            _personRepository.UpdatePerson(personModelFromRepo);

            _personRepository.SaveChanges();

            return NoContent();
        }

        //DELETE api/commands/{id}
        [HttpDelete("{id}")]
        public ActionResult DeletePerson(int id)
        {
            var personModelFromRepo = _personRepository.GetPersonByID(id);
            if (personModelFromRepo == null)
            {
                return NotFound();
            }

            _personRepository.DeletePerson(personModelFromRepo);
            _personRepository.SaveChanges();

            return NoContent();
        }

    }
}
