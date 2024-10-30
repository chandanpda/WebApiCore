using JobStation.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStation.Core
{
    public interface IUnitOfWork :IDisposable
    {
        IJobCategoryRepository JobCategory { get; }

        IUserRepository UserRepository { get; }
        ILogInHistoryRepository LogInHistoryRepository { get; }
        IErrorLogHistoryRepository ErrorLogHistory { get; }
        IJobTypeRepository JobTypeRepository { get; }
        IJobLocationRepository JobLocationRepository { get; }
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
