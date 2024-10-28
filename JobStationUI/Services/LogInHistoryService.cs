using JobStation.Dto;
using JobStation.Utility;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStationUI.Services.Interfaces
{
    public class LogInHistoryService : ILogInHistoryService
    {
        private readonly IHttpService httpService;
        public LogInHistoryService(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<IRestResponse<Response<LogInHistoryDto>>> Add(string UserId)
        {
            var (restClient, restRequest) = httpService.Call($"LogInHistory/{UserId}", Method.POST);
            var response = await restClient.ExecuteAsync<Response<LogInHistoryDto>>(restRequest);
            return response;
        }
    }
}
