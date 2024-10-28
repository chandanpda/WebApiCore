
using JobStation.Utility;
using JobStationUI.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStationUI.Services
{
    public class HttpService : IHttpService
    {
        private readonly string apiBaseUrl;
        private readonly string clientId;
        private readonly IConfiguration configuration;
        private readonly IClaimsService claimsService;

        public HttpService(IConfiguration configuration, IClaimsService claimsService)
        {
            this.configuration = configuration;
            this.claimsService = claimsService;
            this.apiBaseUrl = this.configuration["ApiEndpoint_URL"];
            this.clientId = this.configuration["ClientIds:UI"];
        }

        public (RestClient, IRestRequest) Call(string url, Method method, string contentType = ContentTypes.Json, string token = "")
        {
            RestClient restClient = new RestClient(this.apiBaseUrl);
            IRestRequest restRequest = new RestRequest(url, method);

            restRequest.AddHeader("clientId", this.clientId);
            restRequest.AddHeader("Authorization", string.Format("Bearer {0}", string.IsNullOrWhiteSpace(token) ? claimsService.GetToken() : token));

            //contentType = string.IsNullOrWhiteSpace(contentType) ? ContentTypes.Json : contentType;
            //restRequest.AddHeader("Content-Type", contentType);

            return (restClient, restRequest);
        }
    }
}
