using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JobStationUI.Services.Interfaces
{
    public interface IClaimsService
    {

        string GetToken();
        JwtSecurityToken ReadToken(string token);
        string GetUserId();
        string GetUserName();
        string GetEmail();
     
        List<Claim> GetRoles();
    }
}
