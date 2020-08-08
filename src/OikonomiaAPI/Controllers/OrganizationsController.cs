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
    public class OrganizationsController : ControllerBase
    {

        private readonly IOrganizationRepo _repository;
        private readonly IMapper _mapper;

        public OrganizationsController(IOrganizationRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/Organizations
        [HttpGet]
        public ActionResult<IEnumerable<OrganizationReadDto>> GetAllOrganizations()
        {
            var OrganizationItems = _repository.GetAllOrganizations();

            return Ok(_mapper.Map<IEnumerable<OrganizationReadDto>>(OrganizationItems));
        }

        //GET api/Organizations/{id}
        [HttpGet("{id}", Name = "GetOrganizationById")]
        public ActionResult<OrganizationReadDto> GetOrganizationById(int id)
        {
            var OrganizationItem = _repository.GetOrganizationByID(id);
            if (OrganizationItem != null)
            {
                return Ok(_mapper.Map<OrganizationReadDto>(OrganizationItem));
            }
            return NotFound();
        }

        //POST api/commands
        [HttpPost]
        public ActionResult<OrganizationReadDto> CreateOrganization(OrganizationCreateDto OrganizationCreateDto)
        {
            var OrganizationModel = _mapper.Map<Organization>(OrganizationCreateDto);
            _repository.CreateOrganization(OrganizationModel);
            _repository.SaveChanges();

            var OrganizationReadDto = _mapper.Map<OrganizationReadDto>(OrganizationModel);

            //Look at Microsoft documentation on CreatedAtRoute method
            return CreatedAtRoute(nameof(GetOrganizationById), new { Id = OrganizationReadDto.Organizationid }, OrganizationReadDto);
        }

        //PUT api/commnds/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateOrganization(int id, OrganizationUpdateDto OrganizationUpdateDto)
        {
            var OrganizationModelFromRepo = _repository.GetOrganizationByID(id);
            if (OrganizationModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(OrganizationUpdateDto, OrganizationModelFromRepo);

            _repository.UpdateOrganization(OrganizationModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/commands/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialOrganizationUpdate(int id, JsonPatchDocument<OrganizationUpdateDto> patchDoc)
        {
            var OrganizationModelFromRepo = _repository.GetOrganizationByID(id);
            if (OrganizationModelFromRepo == null)
            {
                return NotFound();
            }

            var OrganizationToPatch = _mapper.Map<OrganizationUpdateDto>(OrganizationModelFromRepo);
            patchDoc.ApplyTo(OrganizationToPatch, ModelState);

            if (!TryValidateModel(OrganizationToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(OrganizationToPatch, OrganizationModelFromRepo);

            _repository.UpdateOrganization(OrganizationModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/commands/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteOrganization(int id)
        {
            var OrganizationModelFromRepo = _repository.GetOrganizationByID(id);
            if (OrganizationModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteOrganization(OrganizationModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

    }
}
