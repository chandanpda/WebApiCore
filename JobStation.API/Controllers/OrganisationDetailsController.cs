using AutoMapper;
using JobStation.Core;
using JobStation.Core.Domain;
using JobStation.Dto;
using JobStation.Model;
using JobStation.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStation.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrganisationDetailsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public OrganisationDetailsController(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var organisationDetails = await unitOfWork.OrganisationRepository.GetAllAsync();
            return Ok(new Response<List<OrganisationDetailsDto>>(organisationDetails));
        }

        [HttpGet("GetById/{Id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var organisation = await unitOfWork.OrganisationRepository.FirstOrDefaultAsync(e => e.Id == id);
            var orgresponse = mapper.Map<OrganisationDetailsDto>(organisation);
            return StatusCode(StatusCodes.Status200OK, new Response<OrganisationDetailsDto>(orgresponse));
        }

        [HttpGet("GetByGuid/{UniqueGuid}")]
        public async Task<IActionResult> GetByGuid(string UniqueGuid)
        {
            var organisation = await unitOfWork.OrganisationRepository.FirstOrDefaultAsync(e => e.UniqueGuid == UniqueGuid);
            var orgresponse = mapper.Map<OrganisationDetailsDto>(organisation);
            return StatusCode(StatusCodes.Status200OK, new Response<OrganisationDetailsDto>(orgresponse));
        }

        [HttpPost]
        public async Task<IActionResult> Post(OrganisationDetailsModel model)
        {
            var organisation = mapper.Map<OrganisationDetails>(model);
            organisation.CreatedOn = DateTime.Now;
            organisation.UpdatedOn = DateTime.Now;

            unitOfWork.OrganisationRepository.Add(organisation);
            var result = await unitOfWork.SaveChangesAsync();
            if(result > 0)
            {
                return StatusCode(StatusCodes.Status201Created, new Response<OrganisationDetailsDto>(mapper.Map<OrganisationDetailsDto>(organisation)));
            }
            return StatusCode(StatusCodes.Status400BadRequest);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, OrganisationDetailsModel model)
        {
            var organisationDetail = await unitOfWork.OrganisationRepository.FirstOrDefaultAsync(e => e.Id == id);
            if (organisationDetail == null)
                OrganisationNotFound();

            var oldValue = organisationDetail;
            organisationDetail.OrganisationName = model.OrganisationName;
            organisationDetail.Domain = model.Domain;
            organisationDetail.EstablishedYear = model.EstablishedYear;
            organisationDetail.Url = model.Url;
            organisationDetail.Email = model.Email;
            organisationDetail.UpdatedOn = DateTime.Now;

            unitOfWork.OrganisationRepository.Update(organisationDetail);
            var result = await unitOfWork.SaveChangesAsync();
            if(result > 0)
            {
                return StatusCode(StatusCodes.Status200OK, new Response<OrganisationDetailsDto>(mapper.Map<OrganisationDetailsDto>(organisationDetail)));
            }
            return StatusCode(StatusCodes.Status400BadRequest);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var organisation = await unitOfWork.OrganisationRepository.FirstOrDefaultAsync(e => e.Id == id);
            if(organisation == null)            
                return OrganisationNotFound();

            unitOfWork.OrganisationRepository.Remove(organisation);
            var result = await unitOfWork.SaveChangesAsync();
            if (result > 0)
                return StatusCode(StatusCodes.Status204NoContent, new Response<OrganisationDetailsDto>(null));
            
            return OrganisationInValidInput();
        }

        [NonAction]
        public ObjectResult OrganisationNotFound()
        {
            return StatusCode(StatusCodes.Status404NotFound, new Response<OrganisationDetailsModel>()
            {
                Success = false,
                ErrorCode = ErrorCode.ERROR_5,
                Message = "Organisation not found",
                Errors = new List<string> { "Organisation not found" }
            });
        }

        [NonAction]
        public ObjectResult OrganisationInValidInput()
        {
            return StatusCode(StatusCodes.Status400BadRequest, new Response<OrganisationDetailsModel>()
            {
                Success = false,
                ErrorCode = ErrorCode.ERROR_4,
                Message = "",
                Errors = new List<string> { "Bad input. Some error occured" }
            });
        }

    }
}
