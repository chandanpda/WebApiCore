using JobStation.Dto;
using JobStation.Model;
using JobStation.Utility;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStationUI.Services.Interfaces
{
    public interface IAccountService
    {
        Task<IRestResponse<LoginDto>> LoginAsync(LoginModel model);
        Task<IRestResponse<Response<RegisterDto>>> RegisterAsync(RegisterModel model);
    }
}
