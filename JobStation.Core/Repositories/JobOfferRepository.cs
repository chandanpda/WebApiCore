using JobStation.Core.Domain;
using JobStation.Core.IRepository;
using JobStation.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStation.Core.Repositories
{
    public class JobOfferRepository : Repository<JobOffer>, IJobOfferRepository
    {
        public JobOfferRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<List<JobOfferDto>> GetAllAsync()
        {
            var jobOffers = _context.JobOffers.AsQueryable();
            var query = from offers in jobOffers
                        select (new JobOfferDto
                        {
                            Id = offers.Id,
                            UniqueGuid = offers.UniqueGuid,
                            Title = offers.Title,
                            Description = offers.Description,
                            JobCategoryId = offers.JobCategoryId,
                            CompanyId = offers.CompanyId,
                            JobTypeId = offers.JobTypeId,
                            LocationId = offers.LocationId,
                            Salary = offers.Salary,
                            Experience = offers.Experience,
                            CreatedOn = offers.CreatedOn,
                            UpdatedOn = offers.UpdatedOn
                        });
            var result = await query.OrderByDescending(e => e.CreatedOn).ToListAsync();

            return result;
        }
    }
}
