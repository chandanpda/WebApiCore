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
    public class AccountService :IAccountService
    {
        private readonly IHttpService httpService;

        public AccountService(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task<IRestResponse<LoginDto>> LoginAsync(LoginModel model)
        {
            var (restClient, restRequest) = httpService.Call("Account/Login", Method.POST);
            restRequest.AddJsonBody(model);
            var response = await restClient.ExecuteAsync<LoginDto>(restRequest);
            return response;
        }

        public async Task<IRestResponse<Response<RegisterDto>>> RegisterAsync(RegisterModel model)
        {
            var (restClient, restRequest) = httpService.Call("Account/Create", Method.POST);
            restRequest.AddJsonBody(model);
            var response = await restClient.ExecuteAsync<Response<RegisterDto>>(restRequest);
            return response;
        }
    }
}
