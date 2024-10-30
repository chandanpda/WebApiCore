using JobStation.Dto;
using JobStation.Model;
using JobStation.Utility;
using JobStationUI.Services.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStationUI.Services
{
    public class JobLocationService : IJobLocationService
    {
        private readonly IHttpService httpService;

        public JobLocationService(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task<IRestResponse<Response<List<JobLocationDto>>>> Get()
        {
            var (restClient, restRequest) = httpService.Call("JobLocation", Method.GET);            
            var response = await restClient.ExecuteAsync<Response<List<JobLocationDto>>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobLocationDto>>> GetByGuid(string UniqueGuid)
        {
            var (restClient, restRequest) = httpService.Call($"JobType/GetByGuid/{UniqueGuid}", Method.GET);
            var response = await restClient.ExecuteAsync<Response<JobLocationDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobLocationDto>>> Add(JobLocationModel model)
        {
            var (restClient, restRequest) = httpService.Call("JobType", Method.POST);
            restRequest.AddJsonBody(model);
            var response = await restClient.ExecuteAsync<Response<JobLocationDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobLocationDto>>> Update(int id, JobLocationModel model)
        {
            var (restClient, restRequest) = httpService.Call($"JobType/{id}", Method.PUT);
            restRequest.AddJsonBody(model);
            var response = await restClient.ExecuteAsync<Response<JobLocationDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobLocationDto>>> Delete(int id)
        {
            var (restClient, restRequest) = httpService.Call($"JobType/{id}", Method.DELETE);
            var response = await restClient.ExecuteAsync<Response<JobLocationDto>>(restRequest);
            return response;
        }
    }
}
