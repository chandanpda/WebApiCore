using JobStation.Dto;
using JobStation.Model;
using JobStation.Parameters;
using JobStation.Utility;
using JobStationUI.Services.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStationUI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IHttpService httpService;

        public CategoryService(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task<IRestResponse<Response<List<JobCategoryDto>>>> Get(string q = "")
        {
            var (restClient, restRequest) = httpService.Call("Category", Method.GET);
            restRequest.AddQueryParameter("q", q);
            var response = await restClient.ExecuteAsync<Response<List<JobCategoryDto>>>(restRequest);
            return response;
        }

        //public async Task<IRestResponse<Response<List<BlogCategoryBasicDto>>>> GetCategoryForLeftSidebar()
        //{
        //    var (restClient, restRequest) = httpService.Call("BlogCategory/GetCategoryForLeftSidebar", Method.GET);
        //    var response = await restClient.ExecuteAsync<Response<List<BlogCategoryBasicDto>>>(restRequest);
        //    return response;
        //}

        public async Task<IRestResponse<Response<JobCategoryListingResponseDto>>> GetAll(JobCategoryListParams p)
        {
            var (restClient, restRequest) = httpService.Call($"Category/GetAll", Method.GET);
            restRequest.AddObject(p);
            var response = await restClient.ExecuteAsync<Response<JobCategoryListingResponseDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobCategoryDto>>> GetByGuid(string UniqueGuid)
        {
            var (restClient, restRequest) = httpService.Call($"Category/GetByGuid/{UniqueGuid}", Method.GET);
            var response = await restClient.ExecuteAsync<Response<JobCategoryDto>>(restRequest);
            return response;
        }

        //public async Task<IRestResponse<Response<BlogCategoryDto>>> GetByUrl(string categoryUrl)
        //{
        //    var (restClient, restRequest) = httpService.Call($"BlogCategory/GetByUrl/{categoryUrl}", Method.GET);
        //    var response = await restClient.ExecuteAsync<Response<BlogCategoryDto>>(restRequest);
        //    return response;
        //}

        public async Task<IRestResponse<Response<JobCategoryDto>>> Add(JobCategoryModel model)
        {
            var (restClient, restRequest) = httpService.Call("Category", Method.POST);
            restRequest.AddJsonBody(model);
            var response = await restClient.ExecuteAsync<Response<JobCategoryDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobCategoryDto>>> Update(int id, JobCategoryModel model)
        {
            var (restClient, restRequest) = httpService.Call($"Category/{id}", Method.PUT);
            restRequest.AddJsonBody(model);
            var response = await restClient.ExecuteAsync<Response<JobCategoryDto>>(restRequest);
            return response;
        }
    }
}
