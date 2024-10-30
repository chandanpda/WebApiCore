using JobStation.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStation.Core
{
    public class UnitOfWork :IUnitOfWork
    {
        public AppDbContext _context { get; }
        public IJobCategoryRepository JobCategory { get; }
        public IUserRepository UserRepository { get; }
        public ILogInHistoryRepository LogInHistoryRepository { get; }
        public IErrorLogHistoryRepository ErrorLogHistory { get; }
        public IJobTypeRepository JobTypeRepository { get; }
        public IJobLocationRepository JobLocationRepository { get; }

        public UnitOfWork(AppDbContext context,
            IJobCategoryRepository jobCategory,
            IUserRepository userRepository,
            ILogInHistoryRepository logInHistoryRepository,
            IErrorLogHistoryRepository errorLogHistoryRepository,
            IJobTypeRepository jobTypeRepository,
            IJobLocationRepository jobLocationRepository)
        {
            _context = context;
            JobCategory =  jobCategory;
            UserRepository = userRepository;
            LogInHistoryRepository = logInHistoryRepository;
            ErrorLogHistory = errorLogHistoryRepository;
            JobTypeRepository = jobTypeRepository;
            JobLocationRepository = jobLocationRepository;
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }
    }
}
