using JobStation.Core.Domain;
using JobStation.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStation.Core.IRepository
{
    public interface IJobOfferRepository : IRepository<JobOffer>
    {
        Task<List<JobOfferDto>> GetAllAsync();
    }
}
