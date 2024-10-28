using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStationUI.Services.Interfaces
{
    public interface IUnitOfWork
    {
        IActiveMenuService ActiveMenuService { get; }
        IClaimsService ClaimsService { get; }
        IHttpService HttpService { get; }
        ICategoryService CategoryService { get; }
        IAccountService AccountService { get; }
        ILogInHistoryService LogInHistoryService { get; }
    }
}
