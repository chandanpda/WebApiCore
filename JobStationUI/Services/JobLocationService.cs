using JobStation.Dto;
using JobStation.Model;
using JobStation.Utility;
using JobStationUI.Services.Interfaces;
using RestSharp;
using System.Collections.Generic;
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

        public async Task<IRestResponse<Response<JobLocationDto>>> GetById(int Id)
        {
            var (restClient, restRequest) = httpService.Call($"JobLocation/GetById/{Id}", Method.GET);
            var response = await restClient.ExecuteAsync<Response<JobLocationDto>>(restRequest);
            return response;
        }
        public async Task<IRestResponse<Response<JobLocationDto>>> GetByGuid(string UniqueGuid)
        {
            var (restClient, restRequest) = httpService.Call($"JobLocation/GetByGuid/{UniqueGuid}", Method.GET);
            var response = await restClient.ExecuteAsync<Response<JobLocationDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobLocationDto>>> Add(JobLocationModel model)
        {
            var (restClient, restRequest) = httpService.Call("JobLocation", Method.POST);
            restRequest.AddJsonBody(model);
            var response = await restClient.ExecuteAsync<Response<JobLocationDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobLocationDto>>> Update(int id, JobLocationModel model)
        {
            var (restClient, restRequest) = httpService.Call($"JobLocation/{id}", Method.PUT);
            restRequest.AddJsonBody(model);
            var response = await restClient.ExecuteAsync<Response<JobLocationDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobLocationDto>>> Delete(int id)
        {
            var (restClient, restRequest) = httpService.Call($"JobLocation/{id}", Method.DELETE);
            var response = await restClient.ExecuteAsync<Response<JobLocationDto>>(restRequest);
            return response;
        }
    }
}
