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
    public class JobTypeRepository : Repository<JobType>, IJobTypeRepository
    {
       
        public JobTypeRepository(AppDbContext context): base(context)
        {
            
        }

        public async Task<List<JobTypeDto>> GetAllAsync(string q= "")
        {
            var jobTypes = _context.JobTypes.AsQueryable();
            if (!string.IsNullOrWhiteSpace(q))
                jobTypes = jobTypes.Where(e => e.TypeName.Contains(q));

            var query = from types in jobTypes
                        select (new JobTypeDto
                        {
                            Id = types.Id,
                            UniqueGuid = types.UniqueGuid,
                            TypeName = types.TypeName,
                            CreatedOn = types.CreatedOn,
                            UpdatedOn = types.UpdatedOn,
                        });
            var result = await query.OrderByDescending(e => e.CreatedOn).ToListAsync();

            return result;
        }
    }
}
