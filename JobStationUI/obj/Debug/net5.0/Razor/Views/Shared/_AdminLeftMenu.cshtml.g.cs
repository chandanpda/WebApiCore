#pragma checksum "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\Shared\_AdminLeftMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec97c1b9f6255f3ecb1c502d32d5d97f3453932c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLeftMenu), @"mvc.1.0.view", @"/Views/Shared/_AdminLeftMenu.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\_ViewImports.cshtml"
using JobStation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\_ViewImports.cshtml"
using JobStation.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\_ViewImports.cshtml"
using JobStationUI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\_ViewImports.cshtml"
using JobStationUI.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\_ViewImports.cshtml"
using JobStation.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\_ViewImports.cshtml"
using JobStation.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\_ViewImports.cshtml"
using JobStation.Extension;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec97c1b9f6255f3ecb1c502d32d5d97f3453932c", @"/Views/Shared/_AdminLeftMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7cb5424cb8951ce934b989c63b4574fd41bf626", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminLeftMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:crimson"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("JobStation : Your Right Platform to board a Suitable Job"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-current", new global::Microsoft.AspNetCore.Html.HtmlString("page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "JobType", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "JobLocation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OrganisationDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "JobOffer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\Shared\_AdminLeftMenu.cshtml"
   var currentPageUrl = httpContextAccessor.HttpContext.Request.Path.ToString().ToLower();
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\Shared\_AdminLeftMenu.cshtml"
                                                                                                                                                                                                            

var openJobDropDownMenu = unitOfWork.ActiveMenuService.DropDownActive(currentPageUrl, new List<String>() { "/Category", "/Category/Index", "/Category/Manage", "/JobType", "/JobType/Index", "/JobType/Manage", "/JobLocation", "/JobLocation/Index", "/JobLocation/Manage", "/JobLocation/Delete" }) ? "show" : "";
var openJobOfferDropDownMenu = unitOfWork.ActiveMenuService.DropDownActive(currentPageUrl, new List<String>() { "/JobOffer", "/JobOffer/Index", "/JobOffer/Manage" }) ? "show" : "";
var openOrganisationDropDownMenu = unitOfWork.ActiveMenuService.DropDownActive(currentPageUrl, new List<String>() { "/OrganisationDetails", "/OrganisationDetails/Index", "/OrganisationDetails/Manage", "/OrganisationDetails/Delete" }) ? "show" : "";

//var profilePicture = unitOfWork.ClaimsService.GetProfilePicture();
//var fullName = unitOfWork.ClaimsService.GetFullName();
// var role = unitOfWork.ClaimsService.GetRoles(); }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"sidebar_nav scrollable-content\">\r\n\r\n        <div class=\"db_brand\">\r\n            <div class=\"brand_logo\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec97c1b9f6255f3ecb1c502d32d5d97f3453932c9754", async() => {
                WriteLiteral("\r\n                           JOBStation\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""hamburger_btn"">
                <span class=""nav_toggle"" type=""button"" data-bs-toggle=""offcanvas"" data-bs-target=""#navbarNav"" aria-controls=""navbarNav"" aria-label=""Toggle navigation""><i class=""fas fa-bars""></i></span>
            </div>
        </div>

        <nav class=""navbar"" data-bs-scroll=""true"" data-bs-backdrop=""false"" id=""navbarNav"">
            <div class=""navbar-collapse"">

                <ul class=""navbar-nav"">
                    <li class=""nav-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec97c1b9f6255f3ecb1c502d32d5d97f3453932c12172", async() => {
                WriteLiteral("\r\n                            <i class=\"fal fa-tachometer-alt-fast\"></i> Dashboard\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 5950, "nav-link", 5950, 8, true);
#nullable restore
#line 47 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\Shared\_AdminLeftMenu.cshtml"
AddHtmlAttributeValue(" ", 5958, unitOfWork.ActiveMenuService.ActivateMenu("/Admin", "/Admin/Index"), 5959, 70, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n\r\n                    <li class=\"nav-item dropdown\">\r\n                        <a");
            BeginWriteAttribute("class", " class=\"", 6272, "\"", 6325, 3);
            WriteAttributeValue("", 6280, "nav-link", 6280, 8, true);
            WriteAttributeValue(" ", 6288, "dropdown-toggle", 6289, 16, true);
#nullable restore
#line 53 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\Shared\_AdminLeftMenu.cshtml"
WriteAttributeValue(" ", 6304, openJobDropDownMenu, 6305, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" href=""#"" id=""navbarDropdownProfileLink"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""fal fa-money-bill""></i>  Job
                            <span aria-expanded=""false"" class=""drp-arrow dropdown-toggle"" data-toggle=""dropdown""> <i class=""fal fa-angle-down""></i></span>
                        </a>
                        <ul");
            BeginWriteAttribute("class", " class=\"", 6712, "\"", 6754, 2);
            WriteAttributeValue("", 6720, "dropdown-menu", 6720, 13, true);
#nullable restore
#line 57 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\Shared\_AdminLeftMenu.cshtml"
WriteAttributeValue(" ", 6733, openJobDropDownMenu, 6734, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-labelledby=\"navbarDropdownProfileLink\">\r\n                            <li>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec97c1b9f6255f3ecb1c502d32d5d97f3453932c16187", async() => {
                WriteLiteral("\r\n                                    <i class=\"fal fa-list-squares\"></i> Category\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 6878, "dropdown-item", 6878, 13, true);
#nullable restore
#line 59 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\Shared\_AdminLeftMenu.cshtml"
AddHtmlAttributeValue("  ", 6891, unitOfWork.ActiveMenuService.ActivateMenu("/Category", "/Category/Index","/Category/Manage"), 6893, 95, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n                            <li>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec97c1b9f6255f3ecb1c502d32d5d97f3453932c18611", async() => {
                WriteLiteral("\r\n                                    <i class=\"fal fa-clipboard-list-check\"></i> Type List\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 7316, "dropdown-item", 7316, 13, true);
#nullable restore
#line 65 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\Shared\_AdminLeftMenu.cshtml"
AddHtmlAttributeValue("  ", 7329, unitOfWork.ActiveMenuService.ActivateMenu("/JobType", "/JobType/Index","/JobType/Manage"), 7331, 92, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n                            <li>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec97c1b9f6255f3ecb1c502d32d5d97f3453932c21041", async() => {
                WriteLiteral("\r\n                                    <i class=\"fal fa-location-circle\"></i> Locations List\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 7759, "dropdown-item", 7759, 13, true);
#nullable restore
#line 71 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\Shared\_AdminLeftMenu.cshtml"
AddHtmlAttributeValue("  ", 7772, unitOfWork.ActiveMenuService.ActivateMenu("/JobLocation", "/JobLocation/Index","/JobLocation/Manage","/JobLocation/Delete"), 7774, 126, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n\r\n                        </ul>\r\n                    </li>\r\n\r\n                    <li class=\"nav-item dropdown\">\r\n                        <a");
            BeginWriteAttribute("class", " class=\"", 8304, "\"", 8366, 3);
            WriteAttributeValue("", 8312, "nav-link", 8312, 8, true);
            WriteAttributeValue(" ", 8320, "dropdown-toggle", 8321, 16, true);
#nullable restore
#line 81 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\Shared\_AdminLeftMenu.cshtml"
WriteAttributeValue(" ", 8336, openOrganisationDropDownMenu, 8337, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" href=""#"" id=""navbarDropdownProfileLink"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""fal fa-building""></i>  Organisation
                            <span aria-expanded=""false"" class=""drp-arrow dropdown-toggle"" data-toggle=""dropdown""> <i class=""fal fa-angle-down""></i></span>
                        </a>
                        <ul");
            BeginWriteAttribute("class", " class=\"", 8760, "\"", 8811, 2);
            WriteAttributeValue("", 8768, "dropdown-menu", 8768, 13, true);
#nullable restore
#line 85 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\Shared\_AdminLeftMenu.cshtml"
WriteAttributeValue(" ", 8781, openOrganisationDropDownMenu, 8782, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-labelledby=\"navbarDropdownProfileLink\">\r\n                            <li>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec97c1b9f6255f3ecb1c502d32d5d97f3453932c25153", async() => {
                WriteLiteral("\r\n                                    <i class=\"fal fa-building\"></i> Organisation List\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 8935, "dropdown-item", 8935, 13, true);
#nullable restore
#line 87 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\Shared\_AdminLeftMenu.cshtml"
AddHtmlAttributeValue("  ", 8948, unitOfWork.ActiveMenuService.ActivateMenu("/OrganisationDetails", "/OrganisationDetails/Index"), 8950, 98, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n                           \r\n\r\n                        </ul>\r\n                    </li>\r\n\r\n                   \r\n                   \r\n                    <li class=\"nav-item dropdown\">\r\n                        <a");
            BeginWriteAttribute("class", " class=\"", 9527, "\"", 9585, 3);
            WriteAttributeValue("", 9535, "nav-link", 9535, 8, true);
            WriteAttributeValue(" ", 9543, "dropdown-toggle", 9544, 16, true);
#nullable restore
#line 100 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\Shared\_AdminLeftMenu.cshtml"
WriteAttributeValue(" ", 9559, openJobOfferDropDownMenu, 9560, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" href=""#"" id=""navbarDropdownProfileLink"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""fal fa-page""></i>  Offer
                            <span aria-expanded=""false"" class=""drp-arrow dropdown-toggle"" data-toggle=""dropdown""> <i class=""fal fa-angle-down""></i></span>
                        </a>
                        <ul");
            BeginWriteAttribute("class", " class=\"", 9968, "\"", 10015, 2);
            WriteAttributeValue("", 9976, "dropdown-menu", 9976, 13, true);
#nullable restore
#line 104 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\Shared\_AdminLeftMenu.cshtml"
WriteAttributeValue(" ", 9989, openJobOfferDropDownMenu, 9990, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-labelledby=\"navbarDropdownProfileLink\">\r\n                            <li>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec97c1b9f6255f3ecb1c502d32d5d97f3453932c29293", async() => {
                WriteLiteral("\r\n                                    <i class=\"fal fa-list\"></i> Job Offers\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 10139, "dropdown-item", 10139, 13, true);
#nullable restore
#line 106 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStationUI\Views\Shared\_AdminLeftMenu.cshtml"
AddHtmlAttributeValue("  ", 10152, unitOfWork.ActiveMenuService.ActivateMenu("/JobOffer", "/JobOffer/Index","JobOffer/Manage"), 10154, 94, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n\r\n                        </ul>\r\n                    </li>\r\n\r\n\r\n\r\n");
            WriteLiteral("                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n    </div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor httpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUnitOfWork unitOfWork { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
