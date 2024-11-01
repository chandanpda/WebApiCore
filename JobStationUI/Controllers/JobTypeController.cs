using AutoMapper;
using JobStation.Core;
using JobStation.Dto;
using JobStation.Model;
using JobStation.Utility;
using JobStationUI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using IUnitOfWork = JobStationUI.Services.Interfaces.IUnitOfWork;

namespace JobStationUI.Controllers
{
    public class JobTypeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IMapper mapper;

        public JobTypeController(IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.httpContextAccessor = httpContextAccessor;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index([FromQuery]string q = "")
        {
            var jobTypes = new List<JobTypeDto>();
            var response = await unitOfWork.JobTypeService.Get(q);

            if (response != null && response.StatusCode == HttpStatusCode.OK && response.Data.Data != null)
                jobTypes = response.Data.Data;

            return View(jobTypes);            
        }

        [HttpGet]
        public async Task<IActionResult> Manage([FromQuery] string guid)
        {
            var model = new JobTypeModel() { };
            var jobTypeResponse = await unitOfWork.JobTypeService.GetByGuid(guid);
            if (jobTypeResponse != null && jobTypeResponse.StatusCode == HttpStatusCode.OK && jobTypeResponse.Data.Data != null)
                model = mapper.Map<JobTypeModel>(jobTypeResponse.Data.Data);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Manage (JobTypeModel model)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Fill Required fields!");
                return View(model);
            }

            IRestResponse<Response<JobTypeDto>> jobTypeResponse;
            var jobTypeDetails = await unitOfWork.JobTypeService.GetByGuid(model.UniqueGuid);
            if (jobTypeDetails != null && jobTypeDetails.StatusCode == HttpStatusCode.OK && jobTypeDetails.Data.Data != null)
                jobTypeResponse = await unitOfWork.JobTypeService.Update(model.Id, model);
            else
                jobTypeResponse = await unitOfWork.JobTypeService.Add(model);


            if (jobTypeResponse != null && (jobTypeResponse.StatusCode == HttpStatusCode.Created || jobTypeResponse.StatusCode == HttpStatusCode.OK) && jobTypeResponse.Data.Data != null)
            {
                TempData["type"] = "success";
                TempData["message"] = "Record saved successfully";

                return RedirectToAction("Index", "JobType");
            }

            if (jobTypeResponse != null && jobTypeResponse.StatusCode == HttpStatusCode.BadRequest)
            {
                var errorMessage = jobTypeResponse.Data.ErrorCode;
                if (jobTypeResponse.Data.Errors != null)
                {
                    errorMessage = "";
                    foreach (var error in jobTypeResponse.Data.Errors)
                    {
                        errorMessage = string.IsNullOrWhiteSpace(errorMessage) ? error : $"<br/>{error}";
                    }
                }

                ModelState.AddModelError("", errorMessage);
                return View(model);
            }

            ModelState.AddModelError("", "Some error occured");
            return View(model);
        }
    }
}
