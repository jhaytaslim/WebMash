#pragma checksum "c:\users\jhay\source\repos\WebMash\WebMash\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0338e833aa41e113265ee77c90dddd2aee85b705"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Profile.cshtml", typeof(AspNetCore.Views_Home_Profile))]
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
#line 1 "c:\users\jhay\source\repos\WebMash\WebMash\Views\_ViewImports.cshtml"
using WebMash;

#line default
#line hidden
#line 2 "c:\users\jhay\source\repos\WebMash\WebMash\Views\_ViewImports.cshtml"
using WebMash.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0338e833aa41e113265ee77c90dddd2aee85b705", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d919270333d34e4a16d646d4b7a22bc87b5ddbe2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebMash.ViewModel.ProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "c:\users\jhay\source\repos\WebMash\WebMash\Views\Home\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(86, 92, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h2>User claims</h2>\r\n        <h3>");
            EndContext();
            BeginContext(179, 10, false);
#line 9 "c:\users\jhay\source\repos\WebMash\WebMash\Views\Home\Profile.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(189, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 10 "c:\users\jhay\source\repos\WebMash\WebMash\Views\Home\Profile.cshtml"
         if (Model.Claims.Any())
        {
            foreach (var claim in Model.Claims)
            {

#line default
#line hidden
            BeginContext(305, 148, true);
            WriteLiteral("                <div class=\"panel panel-default\">\r\n                    <div class=\"panel-heading\">\r\n                        <h3 class=\"panel-title\">");
            EndContext();
            BeginContext(454, 10, false);
#line 16 "c:\users\jhay\source\repos\WebMash\WebMash\Views\Home\Profile.cshtml"
                                           Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(464, 105, true);
            WriteLiteral("</h3>\r\n                    </div>\r\n                    <div class=\"panel-body\">\r\n                        ");
            EndContext();
            BeginContext(570, 11, false);
#line 19 "c:\users\jhay\source\repos\WebMash\WebMash\Views\Home\Profile.cshtml"
                   Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(581, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 22 "c:\users\jhay\source\repos\WebMash\WebMash\Views\Home\Profile.cshtml"
            }
        }
        else
        {

#line default
#line hidden
            BeginContext(686, 110, true);
            WriteLiteral("            <div class=\"alert alert-danger\">\r\n                <p>User has no claims.</p>\r\n            </div>\r\n");
            EndContext();
#line 29 "c:\users\jhay\source\repos\WebMash\WebMash\Views\Home\Profile.cshtml"
        }

#line default
#line hidden
            BeginContext(807, 18, true);
            WriteLiteral("    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebMash.ViewModel.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
