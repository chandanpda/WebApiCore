using JobStationUI.Services;
using JobStationUI.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStationUI
{
    public static class DIExtension
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IActiveMenuService, ActiveMenuService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IHttpService, HttpService>();
            services.AddScoped<IClaimsService, ClaimsService>();
            services.AddScoped<ILogInHistoryService, LogInHistoryService>();
            services.AddScoped<IAccountService, AccountService>();
            return services;
        }
    }
}
