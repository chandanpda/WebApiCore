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
    public class JobLocationRepository : Repository<JobLocation>, IJobLocationRepository
    {
        public JobLocationRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<JobLocationDto>> GetAllAsync()
        {
            var jobLocations = _context.JobLocations.AsQueryable();
            
                

            var query = from locations in jobLocations
                        select (new JobLocationDto
                        {
                            Id = locations.Id,
                            UniqueGuid = locations.UniqueGuid,
                            City = locations.City,
                            State = locations.State,
                           AddedOn = locations.AddedOn
                        });
            var result = await query.OrderByDescending(e => e.AddedOn).ToListAsync();

            return result;
        }
    }
}
