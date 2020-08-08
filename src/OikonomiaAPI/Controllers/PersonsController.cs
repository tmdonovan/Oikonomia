﻿using Microsoft.AspNetCore.Mvc;
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

        private readonly IPersonRepo _repository;
        private readonly IMapper _mapper;

        public PersonsController(IPersonRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/persons
        [HttpGet]
        public ActionResult<IEnumerable<PersonReadDto>> GetAllPersons()
        {
            var personItems = _repository.GetAllPersons();

            return Ok(_mapper.Map<IEnumerable<PersonReadDto>>(personItems));
        }

        //GET api/persons/{id}
        [HttpGet("{id}", Name = "GetPersonById")]
        public ActionResult<PersonReadDto> GetPersonById(int id)
        {
            var personItem = _repository.GetPersonByID(id);
            if (personItem != null)
            {
                return Ok(_mapper.Map<PersonReadDto>(personItem));
            }
            return NotFound();
        }

        //POST api/commands
        [HttpPost]
        public ActionResult<PersonReadDto> CreatePerson(PersonCreateDto personCreateDto)
        {
            var personModel = _mapper.Map<Person>(personCreateDto);
            _repository.CreatePerson(personModel);
            _repository.SaveChanges();

            var personReadDto = _mapper.Map<PersonReadDto>(personModel);

            //Look at Microsoft documentation on CreatedAtRoute method
            return CreatedAtRoute(nameof(GetPersonById), new { Id = personReadDto.Personid }, personReadDto);
        }

        //PUT api/commnds/{id}
        [HttpPut("{id}")]
        public ActionResult UpdatePerson(int id, PersonUpdateDto personUpdateDto)
        {
            var personModelFromRepo = _repository.GetPersonByID(id);
            if (personModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(personUpdateDto, personModelFromRepo);

            _repository.UpdatePerson(personModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/commands/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialPersonUpdate(int id, JsonPatchDocument<PersonUpdateDto> patchDoc)
        {
            var personModelFromRepo = _repository.GetPersonByID(id);
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

            _repository.UpdatePerson(personModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/commands/{id}
        [HttpDelete("{id}")]
        public ActionResult DeletePerson(int id)
        {
            var personModelFromRepo = _repository.GetPersonByID(id);
            if (personModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeletePerson(personModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

    }
}
