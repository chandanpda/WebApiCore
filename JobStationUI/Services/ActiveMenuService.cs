using JobStationUI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStationUI.Services
{
    public class ActiveMenuService : IActiveMenuService
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly string currentPageUrl;

        public ActiveMenuService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.currentPageUrl = this.httpContextAccessor.HttpContext.Request.Path.ToString().ToLower();
        }

        public bool DropDownActive(string pageUrl, List<string> urlsToCheck)
        {
            var result = urlsToCheck.FirstOrDefault(e => e.ToLower().Equals(pageUrl.ToLower()));
            return string.IsNullOrWhiteSpace(result) ? false : true;
        }

        public string ActivateMenu(params string[] pageUrl)
        {
            if (pageUrl == null || pageUrl.Length <= 0) return "";

            var isFound = false;
            foreach (var url in pageUrl)
            {
                if (currentPageUrl == url.ToLower())
                {
                    isFound = true;
                    break;
                }
            }

            return isFound ? "active" : "";
        }

        public string ActivateMenuStartWith(params string[] pageUrl)
        {
            if (pageUrl == null || pageUrl.Length <= 0) return "";

            var isFound = false;
            foreach (var url in pageUrl)
            {
                if (currentPageUrl.StartsWith(url.ToLower()))
                {
                    isFound = true;
                    break;
                }
            }

            return isFound ? "active" : "";
        }
    }
}
