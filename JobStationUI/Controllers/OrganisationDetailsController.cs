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
    public class OrganisationDetailsController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public OrganisationDetailsController(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index([FromQuery] string q= "")
        {
            var OrganisationDetails = new List<OrganisationDetailsDto>();
            var response = await unitOfWork.OrganisationDetailService.Get(q);

            if (response != null && response.StatusCode == System.Net.HttpStatusCode.OK && response.Data.Data != null)
                OrganisationDetails = response.Data.Data;

            return View(OrganisationDetails);
        }

        [HttpGet]
        public async Task<IActionResult> Manage([FromQuery] string guid)
        {
            var model = new OrganisationDetailsModel()
            {
            };
            var organisationDetailsResponse = await unitOfWork.OrganisationDetailService.GetByGuid(guid);
            if (organisationDetailsResponse != null && organisationDetailsResponse.StatusCode == HttpStatusCode.OK && organisationDetailsResponse.Data.Data != null)
            {
                 model = mapper.Map<OrganisationDetailsModel>(organisationDetailsResponse.Data.Data);
                
            }
            
            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> Manage(OrganisationDetailsModel model)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Fill required fields!");
                return View(model);
            }

            IRestResponse<Response<OrganisationDetailsDto>> OrganisationDetailsResponse;
            var message = "";
            var organisationDetails = await unitOfWork.OrganisationDetailService.GetByGuid(model.UniqueGuid);
            if (organisationDetails != null && organisationDetails.StatusCode == HttpStatusCode.OK && organisationDetails.Data.Data != null)
                OrganisationDetailsResponse = await unitOfWork.OrganisationDetailService.Update(model.Id, model);
            else
                OrganisationDetailsResponse = await unitOfWork.OrganisationDetailService.Add(model);

            if (OrganisationDetailsResponse != null && (OrganisationDetailsResponse.StatusCode == HttpStatusCode.Created || 
                OrganisationDetailsResponse.StatusCode == HttpStatusCode.OK) && OrganisationDetailsResponse.Data.Data != null)
            {
                //TempData["type"] = "success";
                //TempData["message"] = "Record saved successfully";

                //return RedirectToAction("Index", "OrganisationDetails");
                message = "Record saved successfully.";
                TempData["type"] = "success";
                return Json(new { success = true, msg = @message });
            }
          
            return Json(new { success = false, msg = "Some error occured" });
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var organisation = await unitOfWork.OrganisationDetailService.GetById(id);
            if (organisation == null || organisation.StatusCode != HttpStatusCode.OK || organisation.Data.Data == null)
                return Json(new { success = false, msg = "Invalid Organisation" });

            var organisationResponse = await unitOfWork.OrganisationDetailService.Delete(id);

            if (organisationResponse != null && organisationResponse.StatusCode == HttpStatusCode.NoContent)
                return Json(new { success = true, msg = "Organisation deleted successfully" });

            if (organisationResponse != null && organisationResponse.Data != null)
            {
                if (organisationResponse.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorMessage = organisationResponse.Data.ErrorCode;
                    if (organisationResponse.Data.Errors != null)
                    {
                        errorMessage = "";
                        foreach (var error in organisationResponse.Data.Errors)
                        {
                            errorMessage = string.IsNullOrWhiteSpace(errorMessage) ? error : $"<br/>{error}";
                        }
                    }

                    return Json(new { success = false, msg = errorMessage });
                }

                return Json(new { success = false, msg = organisationResponse.Data.ErrorCode });
            }

            return Json(new { success = false, msg = "Some error occured" });
        }
    }
}
