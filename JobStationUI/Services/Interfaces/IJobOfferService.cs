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
    public interface IJobOfferService
    {
        Task<IRestResponse<Response<List<JobOfferDto>>>> Get();
        Task<IRestResponse<Response<JobOfferDto>>> GetByGuid(string guid);
        Task<IRestResponse<Response<JobOfferDto>>> GetById(int Id);
        Task<IRestResponse<Response<JobOfferDto>>> Add(JobOfferModel model);
        Task<IRestResponse<Response<JobOfferDto>>> Update(int id, JobOfferModel model);
        Task<IRestResponse<Response<JobOfferDto>>> Delete(int id);
    }
}
