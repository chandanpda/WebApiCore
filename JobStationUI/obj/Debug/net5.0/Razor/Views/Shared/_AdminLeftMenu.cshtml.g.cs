#pragma checksum "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\Shared\_AdminLeftMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a181f9e5241d45a91c402f5abbfc3c2a51c92a9a"
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
#line 1 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\_ViewImports.cshtml"
using JobStation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\_ViewImports.cshtml"
using JobStation.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\_ViewImports.cshtml"
using JobStationUI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\_ViewImports.cshtml"
using JobStationUI.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\_ViewImports.cshtml"
using JobStation.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\_ViewImports.cshtml"
using JobStation.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a181f9e5241d45a91c402f5abbfc3c2a51c92a9a", @"/Views/Shared/_AdminLeftMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c12f242b9fd833d9aa6b6961159d836cb8d8af0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminLeftMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:crimson"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("JobStation : Your Right Platform to board a Suitable Job"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-current", new global::Microsoft.AspNetCore.Html.HtmlString("page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Manage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Type", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Offer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\Shared\_AdminLeftMenu.cshtml"
   var currentPageUrl = httpContextAccessor.HttpContext.Request.Path.ToString().ToLower();
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\Shared\_AdminLeftMenu.cshtml"
                                                                                                                                                                                                            

    var openJobCategoryDropDownMenu = unitOfWork.ActiveMenuService.DropDownActive(currentPageUrl, new List<String>() { "/Category", "/Category/Index" }) ? "show" : "";
    var openJobTypeDropDownMenu = unitOfWork.ActiveMenuService.DropDownActive(currentPageUrl, new List<String>() { "/Type", "/Type/Index" }) ? "show" : "";
    var openJobOfferDropDownMenu = unitOfWork.ActiveMenuService.DropDownActive(currentPageUrl, new List<String>() { "/Offer", "/Offer/Index" }) ? "show" : "";

    //var profilePicture = unitOfWork.ClaimsService.GetProfilePicture();
    //var fullName = unitOfWork.ClaimsService.GetFullName();
    // var role = unitOfWork.ClaimsService.GetRoles(); }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"sidebar_nav scrollable-content\">\r\n\r\n        <div class=\"db_brand\">\r\n            <div class=\"brand_logo\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a181f9e5241d45a91c402f5abbfc3c2a51c92a9a8958", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a181f9e5241d45a91c402f5abbfc3c2a51c92a9a11376", async() => {
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
            AddHtmlAttributeValue("", 5706, "nav-link", 5706, 8, true);
#nullable restore
#line 47 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\Shared\_AdminLeftMenu.cshtml"
AddHtmlAttributeValue(" ", 5714, unitOfWork.ActiveMenuService.ActivateMenu("/Admin", "/Admin/Index"), 5715, 70, false);

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
            BeginWriteAttribute("class", " class=\"", 6028, "\"", 6089, 3);
            WriteAttributeValue("", 6036, "nav-link", 6036, 8, true);
            WriteAttributeValue(" ", 6044, "dropdown-toggle", 6045, 16, true);
#nullable restore
#line 53 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\Shared\_AdminLeftMenu.cshtml"
WriteAttributeValue(" ", 6060, openJobCategoryDropDownMenu, 6061, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" href=""#"" id=""navbarDropdownProfileLink"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""fal fa-page""></i>  Category
                            <span aria-expanded=""false"" class=""drp-arrow dropdown-toggle"" data-toggle=""dropdown""> <i class=""fal fa-angle-down""></i></span>
                        </a>
                        <ul");
            BeginWriteAttribute("class", " class=\"", 6475, "\"", 6525, 2);
            WriteAttributeValue("", 6483, "dropdown-menu", 6483, 13, true);
#nullable restore
#line 57 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\Shared\_AdminLeftMenu.cshtml"
WriteAttributeValue(" ", 6496, openJobCategoryDropDownMenu, 6497, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-labelledby=\"navbarDropdownProfileLink\">\r\n                            <li>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a181f9e5241d45a91c402f5abbfc3c2a51c92a9a15400", async() => {
                WriteLiteral("\r\n                                    <i class=\"fal fa-list\"></i> Category List\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 6649, "dropdown-item", 6649, 13, true);
#nullable restore
#line 59 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\Shared\_AdminLeftMenu.cshtml"
AddHtmlAttributeValue("  ", 6662, unitOfWork.ActiveMenuService.ActivateMenu("/Category", "/Category/Index"), 6664, 76, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a181f9e5241d45a91c402f5abbfc3c2a51c92a9a17800", async() => {
                WriteLiteral("\r\n                                    <i class=\"fal fa-plus-circle\"></i> Add Category\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 7065, "dropdown-item", 7065, 13, true);
#nullable restore
#line 65 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\Shared\_AdminLeftMenu.cshtml"
AddHtmlAttributeValue("  ", 7078, unitOfWork.ActiveMenuService.ActivateMenu("/Category/Manage"), 7080, 64, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n                        </ul>\r\n                    </li>\r\n\r\n                    <li class=\"nav-item dropdown\">\r\n                        <a");
            BeginWriteAttribute("class", " class=\"", 7538, "\"", 7595, 3);
            WriteAttributeValue("", 7546, "nav-link", 7546, 8, true);
            WriteAttributeValue(" ", 7554, "dropdown-toggle", 7555, 16, true);
#nullable restore
#line 74 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\Shared\_AdminLeftMenu.cshtml"
WriteAttributeValue(" ", 7570, openJobTypeDropDownMenu, 7571, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" href=""#"" id=""navbarDropdownProfileLink"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""fal fa-page""></i>  Type
                            <span aria-expanded=""false"" class=""drp-arrow dropdown-toggle"" data-toggle=""dropdown""> <i class=""fal fa-angle-down""></i></span>
                        </a>
                        <ul");
            BeginWriteAttribute("class", " class=\"", 7977, "\"", 8023, 2);
            WriteAttributeValue("", 7985, "dropdown-menu", 7985, 13, true);
#nullable restore
#line 78 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\Shared\_AdminLeftMenu.cshtml"
WriteAttributeValue(" ", 7998, openJobTypeDropDownMenu, 7999, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-labelledby=\"navbarDropdownProfileLink\">\r\n                            <li>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a181f9e5241d45a91c402f5abbfc3c2a51c92a9a21811", async() => {
                WriteLiteral("\r\n                                    <i class=\"fal fa-list\"></i> Type List\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 8147, "dropdown-item", 8147, 13, true);
#nullable restore
#line 80 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\Shared\_AdminLeftMenu.cshtml"
AddHtmlAttributeValue("  ", 8160, unitOfWork.ActiveMenuService.ActivateMenu("/Type", "/Type/Index"), 8162, 68, false);

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
            WriteLiteral("\r\n                            </li>\r\n                          \r\n                        </ul>\r\n                    </li>\r\n\r\n                    <li class=\"nav-item dropdown\">\r\n                        <a");
            BeginWriteAttribute("class", " class=\"", 8637, "\"", 8695, 3);
            WriteAttributeValue("", 8645, "nav-link", 8645, 8, true);
            WriteAttributeValue(" ", 8653, "dropdown-toggle", 8654, 16, true);
#nullable restore
#line 90 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\Shared\_AdminLeftMenu.cshtml"
WriteAttributeValue(" ", 8669, openJobOfferDropDownMenu, 8670, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" href=""#"" id=""navbarDropdownProfileLink"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""fal fa-page""></i>  Offer
                            <span aria-expanded=""false"" class=""drp-arrow dropdown-toggle"" data-toggle=""dropdown""> <i class=""fal fa-angle-down""></i></span>
                        </a>
                        <ul");
            BeginWriteAttribute("class", " class=\"", 9078, "\"", 9125, 2);
            WriteAttributeValue("", 9086, "dropdown-menu", 9086, 13, true);
#nullable restore
#line 94 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\Shared\_AdminLeftMenu.cshtml"
WriteAttributeValue(" ", 9099, openJobOfferDropDownMenu, 9100, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-labelledby=\"navbarDropdownProfileLink\">\r\n                            <li>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a181f9e5241d45a91c402f5abbfc3c2a51c92a9a25849", async() => {
                WriteLiteral("\r\n                                    <i class=\"fal fa-list\"></i> Offer List\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 9249, "dropdown-item", 9249, 13, true);
#nullable restore
#line 96 "C:\Users\chandan kumar\source\repos\JobStation_V1\JobStation\Views\Shared\_AdminLeftMenu.cshtml"
AddHtmlAttributeValue("  ", 9262, unitOfWork.ActiveMenuService.ActivateMenu("/Offer", "/Offer/Index"), 9264, 70, false);

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
            WriteLiteral("\r\n                            </li>\r\n                          \r\n                        </ul>\r\n                    </li>\r\n\r\n\r\n\r\n");
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