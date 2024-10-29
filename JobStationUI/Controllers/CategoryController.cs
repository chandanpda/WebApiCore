using AutoMapper;
using JobStation.Dto;
using JobStation.Model;
using JobStation.Parameters;
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
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategoryController(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index([FromQuery] string q = "", int page = 1, int count = 10, string sortBy = "updateddate", string sortDirection = "desc")
        {
            var p = new JobCategoryListParams()
            {
                Q = q ?? "",
               
                Page = page,
                RecordPerPage = count,
                SortBy = sortBy ?? "updateddate",
                SortDirection = sortDirection ?? "desc"
            };
            var jobCategories = new JobCategoryListingResponseDto();
            var response = await unitOfWork.CategoryService.GetAll(p);
            if (response != null && response.StatusCode == HttpStatusCode.OK && response.Data.Data != null)
                jobCategories = response.Data.Data;

            jobCategories.Params = p;

            return View(jobCategories);
        }


        [HttpGet]
        public async Task<IActionResult> Manage([FromQuery] string guid)
        {
            var model = new JobCategoryModel()
            {
                
            };

            var jobCategoryResponse = await unitOfWork.CategoryService.GetByGuid(guid);
            if (jobCategoryResponse != null && jobCategoryResponse.StatusCode == HttpStatusCode.OK && jobCategoryResponse.Data.Data != null)
                model = mapper.Map<JobCategoryModel>(jobCategoryResponse.Data.Data);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Manage(JobCategoryModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Fill all required fields");
                return View(model);
            }

            IRestResponse<Response<JobCategoryDto>> jobCategoryResponse;
            var jobCategoryDetails = await unitOfWork.CategoryService.GetByGuid(model.UniqueGuid);

            if (jobCategoryDetails != null || jobCategoryDetails.Data.Data != null)
                jobCategoryResponse = await unitOfWork.CategoryService.Add(model);
            else
                        jobCategoryResponse = await unitOfWork.CategoryService.Update(model.Id, model);
           



            if (jobCategoryResponse != null && (jobCategoryResponse.StatusCode == HttpStatusCode.Created || jobCategoryResponse.StatusCode == HttpStatusCode.OK) && jobCategoryResponse.Data.Data != null)
            {
                TempData["type"] = "success";
                TempData["message"] = "Record saved successfully";

                return RedirectToAction("Index", "Category");
            }

            if (jobCategoryResponse != null && jobCategoryResponse.StatusCode == HttpStatusCode.BadRequest)
            {
                var errorMessage = jobCategoryResponse.Data.ErrorCode;
                if (jobCategoryResponse.Data.Errors != null)
                {
                    errorMessage = "";
                    foreach (var error in jobCategoryResponse.Data.Errors)
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
