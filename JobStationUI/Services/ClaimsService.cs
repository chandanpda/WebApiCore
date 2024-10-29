using JobStationUI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JobStationUI.Services
{
    public class ClaimsService : IClaimsService
    {

        private readonly IEnumerable<Claim> claims;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IServiceProvider serviceProvider;

        public ClaimsService(IHttpContextAccessor httpContextAccessor, IServiceProvider serviceProvider)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.serviceProvider = serviceProvider;
            this.claims = this.httpContextAccessor.HttpContext.User.Claims;
        }

        public string GetToken()
        {
            try
            {
                var token = claims?.First(claim => claim.Type == "Token")?.Value;
                return token;
            }
            catch
            {
                return "";
            }
        }

        public JwtSecurityToken ReadToken(string token)
        {
            try
            {
                var securityToken = new JwtSecurityTokenHandler().ReadJwtToken(token);
                return securityToken;
            }
            catch
            {
                return null;
            }
        }

        public string GetUserId()
        {
            try
            {
                var userId = claims?.First(claim => claim.Type == JwtRegisteredClaimNames.Jti)?.Value;
                return userId;
            }
            catch
            {
                return "";
            }
        }

        public string GetUserName()
        {
            var userName = claims?.First(claim => claim.Type == ClaimTypes.Name)?.Value;
            return userName;
        }

        public string GetEmail()
        {
            var email = claims?.First(claim => claim.Type == ClaimTypes.Email)?.Value;
            return email;
        }

       

        public List<Claim> GetRoles()
        {
            var roles = claims?.Where(claim => claim.Type == ClaimTypes.Role)?.ToList();
            return roles;
        }

        public string GetTimeZone(string timeZoneId = "")
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(timeZoneId))
                    return timeZoneId;

                return claims?.First(claim => claim.Type == "TimeZoneId")?.Value;
            }
            catch
            {
                return "";
            }
        }
        //private UserDto GetUserDetails()
        //{
        //    var user = new UserDto();

        //    var userService = serviceProvider.GetRequiredService<IUserService>();
        //    var userResponse = userService.GetByIdWithoutAsync(GetUserId());
        //    if (userResponse != null && userResponse.StatusCode == HttpStatusCode.OK && userResponse.Data.Data != null)
        //        user = userResponse.Data.Data;

        //    return user;
        //}

    }
}
