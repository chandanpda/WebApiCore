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
    public interface IOrganisationDetailService
    {
        Task<IRestResponse<Response<List<OrganisationDetailsDto>>>> Get(string q);
        Task<IRestResponse<Response<OrganisationDetailsDto>>> GetByGuid(string Uniqueguid);
        Task<IRestResponse<Response<OrganisationDetailsDto>>> Add(OrganisationDetailsModel model);
        Task<IRestResponse<Response<OrganisationDetailsDto>>> Update(int id, OrganisationDetailsModel model);
        Task<IRestResponse<Response<OrganisationDetailsDto>>> Delete(int id);
    }
}
