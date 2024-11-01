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
    public class JobLocationController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public JobLocationController(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var jobLocationList = await unitOfWork.JobLocationRepository.GetAllAsync();
            return Ok(new Response<List<JobLocationDto>>(jobLocationList));
        }

        [HttpGet("GetByGuid/{UniqueGuid}")]
        public async Task<IActionResult> GetByGuid(string UniqueGuid)
        {
            var jobLocation = await unitOfWork.JobLocationRepository.FirstOrDefaultAsync(e => e.UniqueGuid == UniqueGuid);
            var jobLocationResponse = mapper.Map<JobLocationDto>(jobLocation);
            return StatusCode(StatusCodes.Status200OK, new Response<JobLocationDto>(jobLocationResponse));
        }

        [HttpPost]
        public async Task<IActionResult> Post(JobLocationModel model)
        {
            var jobLocation = mapper.Map<JobLocation>(model);
            jobLocation.AddedOn = DateTime.Now;
          

            unitOfWork.JobLocationRepository.Add(jobLocation);
            var result = await unitOfWork.SaveChangesAsync();
            if (result > 0)
            {
                return StatusCode(StatusCodes.Status201Created, new Response<JobLocationDto>(mapper.Map<JobLocationDto>(jobLocation)));
            }
            return StatusCode(StatusCodes.Status400BadRequest);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, JobLocationModel model)
        {
            var jobLocation = await unitOfWork.JobLocationRepository.FirstOrDefaultAsync(e => e.Id == id);
            if (jobLocation == null)
                JobLocationNotFound();

            var OldValue = jobLocation;

            
            jobLocation.City = model.City;
            jobLocation.State = model.State;
           

            unitOfWork.JobLocationRepository.Update(jobLocation);
            var result = await unitOfWork.SaveChangesAsync();
            if (result > 0)
            {
                return StatusCode(StatusCodes.Status200OK, new Response<JobLocationDto>(mapper.Map<JobLocationDto>(jobLocation)));
            }
            return StatusCode(StatusCodes.Status400BadRequest);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var jobLocation = await unitOfWork.JobLocationRepository.FirstOrDefaultAsync(e => e.Id == id);
            if (jobLocation == null)
                JobLocationNotFound();

            unitOfWork.JobLocationRepository.Remove(jobLocation);
            var result = await unitOfWork.SaveChangesAsync();
            if (result > 0)
            {
                return StatusCode(StatusCodes.Status204NoContent, new Response<JobLocationDto>(null));
            }

            return JobLocationInValidInput();
        }

        [NonAction]
        public ObjectResult JobLocationInValidInput()
        {
            return StatusCode(StatusCodes.Status400BadRequest, new Response<JobLocationModel>()
            {
                Success = false,
                ErrorCode = ErrorCode.ERROR_4,
                Message = "",
                Errors = new List<string> { "Bad input. Some error occured" }
            });
        }

        [NonAction]
        public ObjectResult JobLocationNotFound()
        {
            return StatusCode(StatusCodes.Status404NotFound, new Response<JobLocationModel>()
            {
                Success = false,
                ErrorCode = ErrorCode.ERROR_5,
                Message = "Job Location not found",
                Errors = new List<string> { "Job Location not found" }
            });
        }

    }
}
