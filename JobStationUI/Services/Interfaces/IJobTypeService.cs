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
    public interface IJobTypeService
    {
        Task<IRestResponse<Response<List<JobTypeDto>>>> Get(string q = "");
        Task<IRestResponse<Response<JobTypeDto>>> GetByGuid(string UniqueGuid);
        Task<IRestResponse<Response<JobTypeDto>>> Add(JobTypeModel model);
        Task<IRestResponse<Response<JobTypeDto>>> Update(int id, JobTypeModel model);
        Task<IRestResponse<Response<JobTypeDto>>> Delete(int id);
    }
}
