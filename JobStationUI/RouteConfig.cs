using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStationUI
{
    public class RouteConfig
    {
        public static IEndpointRouteBuilder Use(IEndpointRouteBuilder route)
        {
            route.MapControllerRoute("HomePage", "", new { controller = "Home", action = "Index" });
            route.MapControllerRoute("AccountController", "Account/{action}/{id?}", new { controller = "Account", action = "Index" });
            route.MapControllerRoute("AdminController", "Admin/{action}/{id?}", new { controller = "Admin", action = "Index" });

            route.MapControllerRoute("Category", "Category/{action}/{id?}", new { controller = "Category", action = "Index" });
            route.MapControllerRoute("JobType", "JobType/{action}/{id?}", new { controller = "JobType", action = "Index" });
            route.MapControllerRoute("JobLocation", "JobLocation/{action}/{id?}", new { controller = "JobLocation", action = "Index" });
            return route;
        }
    }
}
