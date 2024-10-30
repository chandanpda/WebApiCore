using AutoMapper;
using JobStation.Dto;
using JobStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStationUI.DtoMapping
{
    public class JobLocationProfile : Profile
    {
        public JobLocationProfile()
        {
            CreateMap<JobLocationDto, JobLocationModel>().ReverseMap();
        }
    }
}
