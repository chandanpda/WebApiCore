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
    public class OrganisationDetailService : IOrganisationDetailService
    {
        private readonly IHttpService httpService;
        public OrganisationDetailService(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        
        public async Task<IRestResponse<Response<List<OrganisationDetailsDto>>>> Get(string q)
        {
            var(restClient, restRequest) = httpService.Call("OrganisationDetails", Method.GET);
            restRequest.AddQueryParameter("q", q);
            var response = await restClient.ExecuteAsync<Response<List<OrganisationDetailsDto>>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<OrganisationDetailsDto>>> GetByGuid(string UniqueGuid)
        {
            var (restClient, restRequest) = httpService.Call($"OrganisationDetails/GetByGuid/{UniqueGuid}", Method.GET);
            var response = await restClient.ExecuteAsync<Response<OrganisationDetailsDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<OrganisationDetailsDto>>> Add(OrganisationDetailsModel model)
        {
            var (restClient, restRequest) = httpService.Call("OrganisationDetails", Method.POST);
            restRequest.AddJsonBody(model);
            var response = await restClient.ExecuteAsync<Response<OrganisationDetailsDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<OrganisationDetailsDto>>> Update(int id, OrganisationDetailsModel model)
        {
            var (restClient, restRequest) = httpService.Call($"OrganisationDetails/{id}", Method.PUT);
            restRequest.AddJsonBody(model);
            var response = await restClient.ExecuteAsync<Response<OrganisationDetailsDto>>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<OrganisationDetailsDto>>> Delete(int id)
        {
            var (restClient, restRequest) = httpService.Call($"OrganisationDetails/{id}", Method.DELETE);
            var response = await restClient.ExecuteAsync<Response<OrganisationDetailsDto>>(restRequest);
            return response;
        }

    }
}
