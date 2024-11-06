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
    public class JobOfferController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public JobOfferController(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var jobOffersList = await unitOfWork.JobOfferRepository.GetAllAsync();
            return Ok(new Response<List<JobOfferDto>>(jobOffersList));
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var jobOffer = await unitOfWork.JobOfferRepository.FirstOrDefaultAsync(e => e.Id == id);
            var jobLocationResponse = mapper.Map<JobOfferDto>(jobOffer);
            return StatusCode(StatusCodes.Status200OK, new Response<JobOfferDto>(jobLocationResponse));
        }

        [HttpGet("GetByGuid/{UniqueGuid}")]
        public async Task<IActionResult> GetByGuid(string UniqueGuid)
        {
            var jobOffer = await unitOfWork.JobOfferRepository.FirstOrDefaultAsync(e => e.UniqueGuid == UniqueGuid);
            var jobLocationResponse = mapper.Map<JobOfferDto>(jobOffer);
            return StatusCode(StatusCodes.Status200OK, new Response<JobOfferDto>(jobLocationResponse));
        }

        [HttpPost]
        public async Task<IActionResult> Post(JobOfferModel model)
        {
            var jobOffer = mapper.Map<JobOffer>(model);
            jobOffer.CreatedOn = DateTime.Now;
            jobOffer.UpdatedOn = DateTime.Now;

            unitOfWork.JobOfferRepository.Add(jobOffer);
            var result = await unitOfWork.SaveChangesAsync();
            if(result > 0)
            {
                return StatusCode(StatusCodes.Status201Created, new Response<JobOfferDto>(mapper.Map<JobOfferDto>(jobOffer)));
            }
            return StatusCode(StatusCodes.Status400BadRequest);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, JobOfferModel model)
        {
            var jobOffer = await unitOfWork.JobOfferRepository.FirstOrDefaultAsync(e => e.Id == id);
            if(jobOffer == null)
            {

            }
            var oldValue = jobOffer;
            jobOffer.Id = model.Id;
            jobOffer.Title = model.Title;
            jobOffer.Description = model.Description;
            jobOffer.JobCategoryId = model.JobCategoryId;
            jobOffer.CompanyId = model.CompanyId;
            jobOffer.JobTypeId = model.JobTypeId;
            jobOffer.LocationId = model.LocationId;
            jobOffer.Experience = model.Experience;
            jobOffer.Salary = model.Salary;
            jobOffer.UpdatedOn = DateTime.Now;
            jobOffer.IsActive = model.IsActive;

            unitOfWork.JobOfferRepository.Update(jobOffer);
            var result = await unitOfWork.SaveChangesAsync();
            if(result > 0)
            {
                return StatusCode(StatusCodes.Status204NoContent, new Response<JobOfferDto>(mapper.Map<JobOfferDto>(jobOffer)));
            }
            return StatusCode(StatusCodes.Status400BadRequest);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult>Delete(int id)
        {
            var JobOffer = await unitOfWork.JobOfferRepository.FirstOrDefaultAsync(e => e.Id == id);
            if (JobOffer == null)
                JobOfferNotFound();
            unitOfWork.JobOfferRepository.Remove(JobOffer);
            var result = await unitOfWork.SaveChangesAsync();
            if (result > 0)
            {
                return StatusCode(StatusCodes.Status204NoContent, new Response<JobOfferDto>(null));
            }

            return JobOfferInValidInput();

        }

        [NonAction]
        public ObjectResult JobOfferNotFound()
        {
            return StatusCode(StatusCodes.Status404NotFound, new Response<JobOfferModel>()
            {
                Success = false,
                ErrorCode = ErrorCode.ERROR_5,
                Message = "Job Offer not found",
                Errors = new List<string> { "Job Offer not found" }
            });
        }

        [NonAction]
        public ObjectResult JobOfferInValidInput()
        {
            return StatusCode(StatusCodes.Status400BadRequest, new Response<JobOfferModel>()
            {
                Success = false,
                ErrorCode = ErrorCode.ERROR_4,
                Message = "",
                Errors = new List<string> { "Bad input. Some error occured" }
            });
        }
    }
}
