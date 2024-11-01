using JobStationUI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStationUI.Services
{
    public class UnitOfWork : IUnitOfWork
    {       

        public IActiveMenuService ActiveMenuService { get; }
        public ICategoryService CategoryService { get; }
        public IClaimsService ClaimsService { get; }
        public IHttpService HttpService { get; }
        public IAccountService AccountService { get; }
        public ILogInHistoryService LogInHistoryService { get; }
        public IJobTypeService JobTypeService { get; }

        public IJobLocationService JobLocationService { get; }
        public IOrganisationDetailService OrganisationDetailService { get; }


        public UnitOfWork( IActiveMenuService activeMenuService,
            ICategoryService categoryService,
            IClaimsService claimsService,
            IHttpService httpService,
            IAccountService accountService,
            ILogInHistoryService logInHistoryService,
            IJobTypeService jobTypeService,
            IJobLocationService jobLocationService,
            IOrganisationDetailService organisationDetailService)
        {
            ActiveMenuService = activeMenuService;
            CategoryService = categoryService;
            ClaimsService = claimsService;
            AccountService = accountService;
            LogInHistoryService = logInHistoryService;
            JobTypeService = jobTypeService;
            JobLocationService = jobLocationService;
            OrganisationDetailService = organisationDetailService;
        }
             
    }
}
