#pragma checksum "C:\PROJECT\BlogProject.Web\Areas\Member\Views\AppUser\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b1268a7ba5044f5e8c64c42bf853948ec82b6e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_AppUser_Detail), @"mvc.1.0.view", @"/Areas/Member/Views/AppUser/Detail.cshtml")]
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
#line 1 "C:\PROJECT\BlogProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROJECT\BlogProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\PROJECT\BlogProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject.Web.Models.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\PROJECT\BlogProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject.Model.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\PROJECT\BlogProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject.Web.Areas.Member.Models.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\PROJECT\BlogProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject.Web.Areas.Member.Models.VMs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b1268a7ba5044f5e8c64c42bf853948ec82b6e1", @"/Areas/Member/Views/AppUser/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b63b9cd1b39ee6526acd2223b92fc69eff7e9661", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_AppUser_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n    <div class=\"card-body box-profile\">\r\n        <div class=\"text-center\">\r\n            <img class=\"profile-user-img img-fluid img-circle\"");
            BeginWriteAttribute("src", " src=\"", 160, "\"", 182, 1);
#nullable restore
#line 7 "C:\PROJECT\BlogProject.Web\Areas\Member\Views\AppUser\Detail.cshtml"
WriteAttributeValue("", 166, Model.ImagePath, 166, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"User profile picture\">\r\n        </div>\r\n\r\n        <h3 class=\"profile-username text-center\">");
#nullable restore
#line 10 "C:\PROJECT\BlogProject.Web\Areas\Member\Views\AppUser\Detail.cshtml"
                                            Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

        <p class=""text-muted text-center"">Software Engineer</p>

        <ul class=""list-group list-group-unbordered mb-3"">
            <li class=""list-group-item"">
                <b>Comments</b> <a class=""float-right"">2,500</a>
            </li>
            <li class=""list-group-item"">
                <b>Following</b> <a class=""float-right"">543</a>
            </li>
            <li class=""list-group-item"">
                <b>Friends</b> <a class=""float-right"">13,287</a>
            </li>
        </ul>


    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
