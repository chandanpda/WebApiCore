using JobStation.Core.Domain;
using JobStation.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStation.Core.Repositories
{
    public class ErrorLogHistoryRepository : Repository<ErrorLogHistory>, IErrorLogHistoryRepository
    {
        public ErrorLogHistoryRepository(AppDbContext context)
           : base(context)
        {

        }
    }

}
