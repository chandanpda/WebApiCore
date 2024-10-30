
using AutoMapper;
using JobStation.Dto;
using JobStation.Model;
using JobStation.Utility;
using JobStationUI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace JobStationUI.Controllers
{
    public class JobLocationController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public JobLocationController(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var jobLocation = new List<JobLocationDto>();
            var response = await unitOfWork.JobLocationService.Get();

            if (response != null && response.StatusCode == HttpStatusCode.OK && response.Data.Data != null)
                jobLocation = response.Data.Data;

            return View(jobLocation);
        }

        [HttpGet]
        public async Task<IActionResult> Manage([FromQuery] string guid)
        {
            var model = new JobLocationModel() { };
            var jobLocationResponse = await unitOfWork.JobLocationService.GetByGuid(guid);
            if (jobLocationResponse != null && jobLocationResponse.StatusCode == HttpStatusCode.OK && jobLocationResponse.Data.Data != null)
                model = mapper.Map<JobLocationModel>(jobLocationResponse.Data.Data);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Manage(JobLocationModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Fill Required fields!");
                return View(model);
            }

            IRestResponse<Response<JobLocationDto>> jobLocationResponse;
            var jobLocationDetails = await unitOfWork.JobLocationService.GetByGuid(model.UniqueGuid);

            if (jobLocationDetails != null || jobLocationDetails.Data.Data != null)
                jobLocationResponse = await unitOfWork.JobLocationService.Add(model);
            else
                jobLocationResponse = await unitOfWork.JobLocationService.Update(model.Id, model);



            if (jobLocationResponse != null && (jobLocationResponse.StatusCode == HttpStatusCode.Created || jobLocationResponse.StatusCode == HttpStatusCode.OK) && jobLocationResponse.Data.Data != null)
            {
                TempData["type"] = "success";
                TempData["message"] = "Record saved successfully";

                return RedirectToAction("Index", "JobType");
            }

            if (jobLocationResponse != null && jobLocationResponse.StatusCode == HttpStatusCode.BadRequest)
            {
                var errorMessage = jobLocationResponse.Data.ErrorCode;
                if (jobLocationResponse.Data.Errors != null)
                {
                    errorMessage = "";
                    foreach (var error in jobLocationResponse.Data.Errors)
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
