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
    public class OrganisationRepository : Repository<OrganisationDetails>, IOrganisationRepository
    {
        public OrganisationRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<OrganisationDetailsDto>> GetAllAsync()
        {
            var organisations = _context.OrganisationDetails.AsQueryable();
            var query = from org in organisations
                        select (new OrganisationDetailsDto
                        {
                            Id = org.Id,
                            UniqueGuid = org.UniqueGuid,
                            OrganisationName = org.OrganisationName,
                            Domain = org.Domain,
                            EstablishedYear = org.EstablishedYear,
                            Email = org.Email,
                            Url = org.Url,
                            CreatedOn = org.CreatedOn,
                            UpdatedOn = org.UpdatedOn
                        });
            var result = await query.OrderByDescending(e => e.CreatedOn).ToListAsync();
            return result;
        }
    }
}
