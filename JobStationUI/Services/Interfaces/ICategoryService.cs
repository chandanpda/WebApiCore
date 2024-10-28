using RestSharp;
using JobStation.Dto;
using JobStation.Parameters;
using JobStation.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobStation.Model;

namespace JobStationUI.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IRestResponse<Response<List<JobCategoryDto>>>> Get(string q = "");
        //Task<IRestResponse<Response<List<BlogCategoryBasicDto>>>> GetCategoryForLeftSidebar();
        Task<IRestResponse<Response<JobCategoryListingResponseDto>>> GetAll(JobCategoryListParams p);

        Task<IRestResponse<Response<JobCategoryDto>>> GetByGuid(string UniqueGuid);
        //Task<IRestResponse<Response<BlogCategoryDto>>> GetByUrl(string categoryUrl);
        Task<IRestResponse<Response<JobCategoryDto>>> Add(JobCategoryModel model);
        Task<IRestResponse<Response<JobCategoryDto>>> Update(int id, JobCategoryModel model);
    }
}
