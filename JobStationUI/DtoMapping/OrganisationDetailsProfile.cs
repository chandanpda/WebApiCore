using AutoMapper;
using JobStation.Core.Domain;
using JobStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStationUI.DtoMapping
{
    public class OrganisationDetailsProfile : Profile
    {
        public OrganisationDetailsProfile()
        {
            CreateMap<OrganisationDetails, OrganisationDetailsModel>().ReverseMap();
        }
    }
}
