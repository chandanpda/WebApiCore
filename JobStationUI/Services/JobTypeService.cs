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
using System.Threading.Tasks;

namespace JobStationUI.Services
{
    public class JobTypeService : IJobTypeService
    {
        private readonly IHttpService httpService;
        
        public JobTypeService(IHttpService httpService)
        {
            this.httpService = httpService;

        }

        
        public async Task<IRestResponse<Response<List<JobTypeDto>>>> Get(string q = "")
        {
            var (restClient, restRequest) = httpService.Call("JobType", Method.GET);
            restRequest.AddQueryParameter("q", q);
            var response = await restClient.ExecuteAsync<Response<List<JobTypeDto>>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobTypeDto>>> GetByGuid(string UniqueGuid)
        {
            var (restClient, restRequest) = httpService.Call($"JobType/GetByGuid/{UniqueGuid}", Method.GET);
            var response = await restClient.ExecuteAsync<Response<JobTypeDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobTypeDto>>> Add(JobTypeModel model)
        {
            var (restClient, restRequest) = httpService.Call("JobType", Method.POST);
            restRequest.AddJsonBody(model);
            var response = await restClient.ExecuteAsync<Response<JobTypeDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobTypeDto>>> Update(int id, JobTypeModel model)
        {
            var (restClient, restRequest) = httpService.Call($"JobType/{id}", Method.PUT);
            restRequest.AddJsonBody(model);
            var response = await restClient.ExecuteAsync<Response<JobTypeDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<JobTypeDto>>> Delete(int id)
        {
            var (restClient, restRequest) = httpService.Call($"JobType/{id}", Method.DELETE);
            var response = await restClient.ExecuteAsync<Response<JobTypeDto>>(restRequest);
            return response;
        }

    }
}
