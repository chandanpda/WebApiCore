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
    public interface IJobLocationService
    {
        Task<IRestResponse<Response<List<JobLocationDto>>>> Get();
        Task<IRestResponse<Response<JobLocationDto>>> GetByGuid(string guid);
        Task<IRestResponse<Response<JobLocationDto>>> Add(JobLocationModel model);
        Task<IRestResponse<Response<JobLocationDto>>> Update(int id, JobLocationModel model);
        Task<IRestResponse<Response<JobLocationDto>>> Delete(int id);
    }
}
