
using JobStation.Model;
using JobStationUI.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JobStationUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IConfiguration configuration;

        public AccountController(IUnitOfWork unitOfWork,
            IConfiguration configuration)
        {
            this.unitOfWork = unitOfWork;
            this.configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Login
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            var returnUrl = Request.Query["ReturnUrl"];
            if (string.IsNullOrWhiteSpace(returnUrl) || !Url.IsLocalUrl(returnUrl))
                returnUrl = "";

            ViewBag.ReturnUrl = returnUrl.ToString();

            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var returnUrl = Request.Form["ReturnUrl"];
            if (string.IsNullOrWhiteSpace(returnUrl) || !Url.IsLocalUrl(returnUrl))
                returnUrl = "";

            ViewBag.ReturnUrl = returnUrl.ToString();


            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Fill all required fields");
                return View(model);
            }

            var response = await unitOfWork.AccountService.LoginAsync(model);

            if (response == null)
            {
                ModelState.AddModelError("", "Some error occured");
                return View(model);
            }

            if (response.StatusCode == HttpStatusCode.OK && !string.IsNullOrWhiteSpace(response.Data.Token))
            {
                var returnedToken = unitOfWork.ClaimsService.ReadToken(response.Data.Token);
                if (returnedToken == null)
                {
                    ModelState.AddModelError("", "Username or password provided is incorrect");
                    return View(model);
                }

                var userId = returnedToken.Id;
                var userName = returnedToken.Claims.First(claim => claim.Type == ClaimTypes.Name)?.Value;

                var userEmail = returnedToken.Claims.First(claim => claim.Type == ClaimTypes.Email)?.Value;
                //var fullName = returnedToken.Claims.First(claim => claim.Type == "FullName")?.Value;
                //var profilePicture = returnedToken.Claims.First(claim => claim.Type == "ProfilePicture")?.Value;
                //var timeZoneId = returnedToken.Claims.First(claim => claim.Type == "TimeZoneId")?.Value;

                var userRoles = returnedToken.Claims.Where(claim => claim.Type == ClaimTypes.Role)?.ToList();

                var claims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Jti, userId),
                    new Claim(ClaimTypes.Name, userName),
                    new Claim(ClaimTypes.Email, userEmail),                                     
                    new Claim("Token", response.Data.Token)
                   
                };

                if (userRoles != null)
                {
                    foreach (var role in userRoles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role.Value));
                    }
                }

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    new AuthenticationProperties
                    {
                        ExpiresUtc = response.Data.Expiration,
                        //AllowRefresh = false,                        
                        //IsPersistent = true
                    });

                if (!string.IsNullOrWhiteSpace(returnUrl))
                    return LocalRedirect(returnUrl);
                else
                {
                    var LogInHistory = await unitOfWork.LogInHistoryService.Add(userId);
                    return RedirectToAction("Index", "Admin");
                }

            }

            ModelState.AddModelError("", $"Username or password provided is incorrect.");
            return View(model);
        }

        #endregion


        

        #region Register
        //[Authorize(Roles = "SuperAdmin")]
        public IActionResult Register()
        {

            return View();
        }

        //[Authorize(Roles = "SuperAdmin")]
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Fill all required fields");
                return View(model);
            }

            //"************** To be Implemented Later ******************"
            //var googleRecaptchaSecretKey = "";
            //var websiteSettingServiceResponse = await unitOfWork.WebsiteSettingService.GetById(1);
            //if (websiteSettingServiceResponse != null && websiteSettingServiceResponse.StatusCode == System.Net.HttpStatusCode.OK && websiteSettingServiceResponse.Data.Data != null)
            //{
            //    var globalData = websiteSettingServiceResponse.Data.Data;
            //    googleRecaptchaSecretKey = globalData.GoogleRecaptchaSecretKey ?? "";
            //}

            //var googleReCaptcha = new GoogleReCaptcha(configuration, httpContextAccessor, googleRecaptchaSecretKey);
            //if (!googleReCaptcha.IsSuccess)
            //{
            //    ModelState.AddModelError("", "Verify you are not a robot!");
            //    return View(model);
            //}


            model.RoleName = model.RoleName;
            var response = await unitOfWork.AccountService.RegisterAsync(model);

            if (response == null)
            {
                ModelState.AddModelError("", "Some error occured");
                return View(model);
            }

            if (response.StatusCode == HttpStatusCode.Created)
            {
                var user = response.Data.Data;
                TempData["userId"] = user.Id;
                return RedirectToAction("Thanks", "Account");
            }

            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                var errorMessage = response.Data.ErrorCode;
                if (response.Data.Errors != null)
                {
                    errorMessage = "";
                    foreach (var error in response.Data.Errors)
                    {
                        errorMessage = string.IsNullOrWhiteSpace(errorMessage) ? error : $"<br/>{error}";
                    }
                }

                ModelState.AddModelError("", errorMessage);
                return View(model);
            }

            ModelState.AddModelError("", $"Some error occured. Please try again later");
            return View(model);
        }
        #endregion

        #region Thanks
        public IActionResult Thanks()
        {
            if (TempData["userId"] == null)
                return RedirectToAction("Register", "Account");

            return View();
        }

        #endregion    
    }
}
