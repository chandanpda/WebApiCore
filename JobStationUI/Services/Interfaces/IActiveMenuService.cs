using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobStationUI.Services.Interfaces
{
    public interface IActiveMenuService
    {
        bool DropDownActive(string pageUrl, List<string> urlsToCheck);
        string ActivateMenu(params string[] pageUrl);
        string ActivateMenuStartWith(params string[] pageUrl);
    }
}
