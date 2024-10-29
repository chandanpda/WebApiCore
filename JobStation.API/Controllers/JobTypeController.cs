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
    public class JobTypeController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public JobTypeController(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string q = "")
        {
            var jobTypeList = await unitOfWork.JobTypeRepository.GetAllAsync(q);
            return Ok(new Response<List<JobTypeDto>>(jobTypeList));
        }

        [HttpGet("GetByGuid/{UniqueGuid}")]
        public async Task<IActionResult> GetByGuid(string UniqueGuid)
        {
            var jobType = await unitOfWork.JobTypeRepository.FirstOrDefaultAsync(e => e.UniqueGuid == UniqueGuid);
            var jobTypeResponse = mapper.Map<JobTypeDto>(jobType);
            return StatusCode(StatusCodes.Status200OK, new Response<JobTypeDto>(jobTypeResponse));
        }

        [HttpPost]
        public async Task<IActionResult> Post(JobTypeModel model)
        {
            var jobType = mapper.Map<JobType>(model);
            jobType.CreatedOn = DateTime.Now;
            jobType.UpdatedOn = DateTime.Now;

            unitOfWork.JobTypeRepository.Add(jobType);
            var result = await unitOfWork.SaveChangesAsync();
            if(result > 0)
            {
                return StatusCode(StatusCodes.Status201Created, new Response<JobTypeDto>(mapper.Map<JobTypeDto>(jobType)));
            }
            return StatusCode(StatusCodes.Status400BadRequest);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, JobTypeModel model)
        {
            var jobType = await unitOfWork.JobTypeRepository.FirstOrDefaultAsync(e => e.Id == id);
            if (jobType == null)
                JobTypeNotFound();

            var OldValue = jobType;

            jobType.TypeName = model.TypeName;
            jobType.UpdatedOn = DateTime.Now;

            unitOfWork.JobTypeRepository.Update(jobType);
            var result = await unitOfWork.SaveChangesAsync();
            if(result > 0)
            {
                return StatusCode(StatusCodes.Status200OK, new Response<JobTypeDto>(mapper.Map<JobTypeDto>(jobType)));
            }
            return StatusCode(StatusCodes.Status400BadRequest);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var jobType = await unitOfWork.JobTypeRepository.FirstOrDefaultAsync(e => e.Id == id);
            if (jobType == null)
                JobTypeNotFound();

            unitOfWork.JobTypeRepository.Remove(jobType);
            var result = await unitOfWork.SaveChangesAsync();
            if(result > 0)
            {
                return StatusCode(StatusCodes.Status204NoContent, new Response<JobTypeDto>(null));
            }

            return JobTypeInValidInput();
        }



        [NonAction]
        public ObjectResult JobTypeInValidInput()
        {
            return StatusCode(StatusCodes.Status400BadRequest, new Response<JobTypeModel>()
            {
                Success = false,
                ErrorCode = ErrorCode.ERROR_4,
                Message = "",
                Errors = new List<string> { "Bad input. Some error occured" }
            });
        }

        [NonAction]
        public ObjectResult JobTypeNotFound()
        {
            return StatusCode(StatusCodes.Status404NotFound, new Response<JobTypeModel>()
            {
                Success = false,
                ErrorCode = ErrorCode.ERROR_5,
                Message = "Job type not found",
                Errors = new List<string> { "Job Type not found" }
            });
        }
    }
}
