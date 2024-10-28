using AutoMapper;
using JobStation.Dto;
using JobStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStationUI.DtoMapping
{
    public class JobCategoryProfile : Profile
    {
        public JobCategoryProfile()
        {
            CreateMap<JobCategoryDto, JobCategoryModel>().ReverseMap();
        }
    }
}
