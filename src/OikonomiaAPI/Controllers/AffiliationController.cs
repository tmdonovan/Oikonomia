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
    public class AffiliationsController : ControllerBase
    {

        private readonly IAffiliationRepo _repository;
        private readonly IMapper _mapper;

        public AffiliationsController(IAffiliationRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/Affiliations
        [HttpGet]
        public ActionResult<IEnumerable<AffiliationReadDto>> GetAllAffiliations()
        {
            var AffiliationItems = _repository.GetAllAffiliations();

            return Ok(_mapper.Map<IEnumerable<AffiliationReadDto>>(AffiliationItems));
        }

        //GET api/Affiliations/{id}
        [HttpGet("{id}", Name = "GetAffiliationById")]
        public ActionResult<AffiliationReadDto> GetAffiliationById(int id)
        {
            var AffiliationItem = _repository.GetAffiliationByID(id);
            if (AffiliationItem != null)
            {
                return Ok(_mapper.Map<AffiliationReadDto>(AffiliationItem));
            }
            return NotFound();
        }

        //POST api/commands
        [HttpPost]
        public ActionResult<AffiliationReadDto> CreateAffiliation(AffiliationCreateDto AffiliationCreateDto)
        {
            var AffiliationModel = _mapper.Map<Affiliation>(AffiliationCreateDto);
            _repository.CreateAffiliation(AffiliationModel);
            _repository.SaveChanges();

            var AffiliationReadDto = _mapper.Map<AffiliationReadDto>(AffiliationModel);

            //Look at Microsoft documentation on CreatedAtRoute method
            return CreatedAtRoute(nameof(GetAffiliationById), new { Id = AffiliationReadDto.Affiliationid }, AffiliationReadDto);
        }

        //PUT api/commnds/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateAffiliation(int id, AffiliationUpdateDto AffiliationUpdateDto)
        {
            var AffiliationModelFromRepo = _repository.GetAffiliationByID(id);
            if (AffiliationModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(AffiliationUpdateDto, AffiliationModelFromRepo);

            _repository.UpdateAffiliation(AffiliationModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/commands/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialAffiliationUpdate(int id, JsonPatchDocument<AffiliationUpdateDto> patchDoc)
        {
            var AffiliationModelFromRepo = _repository.GetAffiliationByID(id);
            if (AffiliationModelFromRepo == null)
            {
                return NotFound();
            }

            var AffiliationToPatch = _mapper.Map<AffiliationUpdateDto>(AffiliationModelFromRepo);
            patchDoc.ApplyTo(AffiliationToPatch, ModelState);

            if (!TryValidateModel(AffiliationToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(AffiliationToPatch, AffiliationModelFromRepo);

            _repository.UpdateAffiliation(AffiliationModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/commands/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteAffiliation(int id)
        {
            var AffiliationModelFromRepo = _repository.GetAffiliationByID(id);
            if (AffiliationModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteAffiliation(AffiliationModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

    }
}