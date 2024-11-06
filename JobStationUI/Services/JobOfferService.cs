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
    public class JobOfferService : IJobOfferService
    {
        private readonly IHttpService httpService;

        public JobOfferService(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<IRestResponse<Response<List<JobOfferDto>>>> Get()
        {
            var (restClient, restRequest) = httpService.Call("JobOffer", Method.GET);
            var response = await restClient.ExecuteAsync<Response<List<JobOfferDto>>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobOfferDto>>> GetById(int Id)
        {
            var (restClient, restRequest) = httpService.Call($"JobOffer/GetById/{Id}", Method.GET);
            var response = await restClient.ExecuteAsync<Response<JobOfferDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobOfferDto>>> GetByGuid(string guid)
        {
            var (restClient, restRequest) = httpService.Call($"JobOffer/GetByGuid/{guid}", Method.GET);
            var response = await restClient.ExecuteAsync<Response<JobOfferDto>>(restRequest);
            return response;
        }
        public async Task<IRestResponse<Response<JobOfferDto>>> Add(JobOfferModel model)
        {
            var (restClient, restRequest) = httpService.Call("JobOffer", Method.POST);
            restRequest.AddJsonBody(model);
            var response = await restClient.ExecuteAsync<Response<JobOfferDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobOfferDto>>> Update(int id, JobOfferModel model)
        {
            var (restClient, restRequest) = httpService.Call($"JobOffer/{id}", Method.PUT);
            restRequest.AddJsonBody(model);
            var response = await restClient.ExecuteAsync<Response<JobOfferDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobOfferDto>>> Delete(int id)
        {
            var (restClient, restRequest) = httpService.Call($"JobOffer/{id}", Method.DELETE);
            var response = await restClient.ExecuteAsync<Response<JobOfferDto>>(restRequest);
            return response;
        }
    }

}
