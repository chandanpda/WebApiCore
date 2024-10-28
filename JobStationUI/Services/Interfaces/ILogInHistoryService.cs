using JobStation.Dto;
using JobStation.Utility;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStationUI.Services.Interfaces
{
    public interface ILogInHistoryService
    {

        Task<IRestResponse<Response<LogInHistoryDto>>> Add(string UserId);
    }
}
