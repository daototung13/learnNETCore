#pragma checksum "C:\Users\emsih\source\repos\tung8\tung8\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c975118a2ebed11a87316363ac138345be37e3a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\emsih\source\repos\tung8\tung8\Views\_ViewImports.cshtml"
using tung8.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c975118a2ebed11a87316363ac138345be37e3a0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c0dca7207b713a502fc94ab18687c2463748611", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\emsih\source\repos\tung8\tung8\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(69, 27, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n<table>\r\n");
            EndContext();
#line 9 "C:\Users\emsih\source\repos\tung8\tung8\Views\Home\Index.cshtml"
     foreach (var employee in Model.Employees)
    {

#line default
#line hidden
            BeginContext(151, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(182, 13, false);
#line 12 "C:\Users\emsih\source\repos\tung8\tung8\Views\Home\Index.cshtml"
           Write(employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(195, 113, true);
            WriteLiteral("</td>\r\n\r\n            <td>\r\n                <a style=\"color: orangered\" asp-controller=\"Home\" asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-routeid", "\r\n                   asp-routeid=\"", 308, "\"", 354, 1);
#line 16 "C:\Users\emsih\source\repos\tung8\tung8\Views\Home\Index.cshtml"
WriteAttributeValue("", 342, employee.ID, 342, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(355, 103, true);
            WriteLiteral(">Details</a>\r\n\r\n                <a style=\"color: darkslateblue\" asp-controller=\"Home\" asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-routeid", "\r\n                   asp-routeid=\"", 458, "\"", 504, 1);
#line 19 "C:\Users\emsih\source\repos\tung8\tung8\Views\Home\Index.cshtml"
WriteAttributeValue("", 492, employee.ID, 492, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(505, 47, true);
            WriteLiteral(">Edit</a>\r\n\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 23 "C:\Users\emsih\source\repos\tung8\tung8\Views\Home\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(561, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomePageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
