using AutoMapper;

using JobStation.Dto;
using JobStation.Model;
using JobStation.Utility;
using JobStationUI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace JobStationUI.Controllers
{
    public class JobOfferController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public JobOfferController(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var jobOffer = new List<JobOfferDto>();
            var response = await unitOfWork.JobOfferService.Get();
            if (response != null && response.StatusCode == HttpStatusCode.OK && response.Data.Data != null)
                jobOffer = response.Data.Data;
            return View(jobOffer);
        }
        [HttpGet]
        public async Task<IActionResult> Manage([FromQuery] string guid)
        {
            var model = new JobOfferModel() { };
            var jobOfferResponse = await unitOfWork.JobOfferService.GetByGuid(guid);
            if (jobOfferResponse != null && jobOfferResponse.StatusCode == HttpStatusCode.OK && jobOfferResponse.Data.Data != null)
                model = mapper.Map<JobOfferModel>(jobOfferResponse.Data.Data);

            await SelectListData(model);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Manage(JobOfferModel model)
        {
            await SelectListData(model);
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Fill required fields!");
                return View(model);
            }

            IRestResponse<Response<JobOfferDto>> JobOfferResponse;
            var message = "";
            var jobOfferDetails = await unitOfWork.JobOfferService.GetByGuid(model.UniqueGuid);
            if (jobOfferDetails != null && jobOfferDetails.StatusCode == HttpStatusCode.OK && jobOfferDetails.Data.Data != null)
                JobOfferResponse = await unitOfWork.JobOfferService.Update(jobOfferDetails.Data.Data.Id, model);
            else
                JobOfferResponse = await unitOfWork.JobOfferService.Add(model);

            if (JobOfferResponse != null && (JobOfferResponse.StatusCode == HttpStatusCode.Created ||
                JobOfferResponse.StatusCode == HttpStatusCode.OK) && JobOfferResponse.Data.Data != null)
            {
                message = "Record saved successfully.";
                TempData["type"] = "success";
                return Json(new { success = true, msg = @message });
            }

            return Json(new { success = false, msg = "Some error occured" });
        }

       
        private async Task SelectListData(JobOfferModel model)
        {
            model.CategoryItems = new List<SelectListItem>() { new SelectListItem("Select Category", "") };
            var categoryResponse = await unitOfWork.CategoryService.Get();
            if (categoryResponse != null && categoryResponse.StatusCode == HttpStatusCode.OK && categoryResponse.Data.Data != null)
                model.CategoryItems.AddRange(categoryResponse.Data.Data.Select(e => new SelectListItem() { Text = e.CategoryName, Value = e.Id.ToString() }).ToList());

            model.JobTypeItems = new List<SelectListItem>() { new SelectListItem("Select Job type", "") };
            var JobTypeResponse = await unitOfWork.JobTypeService.Get();
            if (JobTypeResponse != null && JobTypeResponse.StatusCode == HttpStatusCode.OK && JobTypeResponse.Data.Data != null)
                model.JobTypeItems.AddRange(JobTypeResponse.Data.Data
                    .Select(e => new SelectListItem() { Text = e.TypeName, Value = e.Id.ToString() }).ToList());

            model.CompanyItems = new List<SelectListItem>() { new SelectListItem("Select Organisation", "") };
            var companyResponse = await unitOfWork.OrganisationDetailService.Get();
            if (companyResponse != null && companyResponse.StatusCode == HttpStatusCode.OK && companyResponse.Data.Data != null)
                model.CompanyItems.AddRange(companyResponse.Data.Data.Select(e => new SelectListItem() { Text = e.OrganisationName, Value = e.Id.ToString() }).ToList());

            model.LocationItems = new List<SelectListItem>() { new SelectListItem("Select Location", "") };
            var jobLocationResponse = await unitOfWork.JobLocationService.Get();
            if (jobLocationResponse != null && jobLocationResponse.StatusCode == HttpStatusCode.OK && jobLocationResponse.Data.Data != null)
                model.LocationItems.AddRange(jobLocationResponse.Data.Data
                    .Select(e => new SelectListItem() { Text = e.City, Value = e.Id.ToString() }).ToList());
        }
    }
}
