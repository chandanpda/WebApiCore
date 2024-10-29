using AutoMapper;
using JobStation.Core.Domain;
using JobStation.Dto;
using JobStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStation.API.DtoMapping
{
    public class JobTypeProfile : Profile
    {
        public JobTypeProfile()
        {
            CreateMap<JobType, JobTypeDto>().ReverseMap();
            CreateMap<JobType, JobTypeModel>().ReverseMap();
        }
    }
}
