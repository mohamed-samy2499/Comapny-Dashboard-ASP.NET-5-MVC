#pragma checksum "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\Employee\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54e99f58ec2bd04deaf28d148390f148c90d0857"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
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
#line 1 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\_ViewImports.cshtml"
using Presentaion_Layer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\_ViewImports.cshtml"
using Data_Access_Layer.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\_ViewImports.cshtml"
using Presentaion_Layer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54e99f58ec2bd04deaf28d148390f148c90d0857", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb16cfc956f3486c071bcbb8fb7aaa95c086f4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\Employee\Details.cshtml"
  
    ViewData["Title"] = "Details";
    string DeptName = ViewData["DeptName"] as string;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n<br />\r\n<br />\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">");
#nullable restore
#line 13 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-10\">");
#nullable restore
#line 14 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">");
#nullable restore
#line 17 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-10\">");
#nullable restore
#line 18 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">");
#nullable restore
#line 21 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(m => m.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-10\">");
#nullable restore
#line 22 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(m => m.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">");
#nullable restore
#line 25 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-10\">");
#nullable restore
#line 26 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">");
#nullable restore
#line 29 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(m => m.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-10\">");
#nullable restore
#line 30 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(m => m.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">");
#nullable restore
#line 33 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(m => m.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-10\">");
#nullable restore
#line 34 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(m => m.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">");
#nullable restore
#line 37 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(m => m.DepartmentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-md-10\">");
#nullable restore
#line 38 "C:\Users\mohamed\source\repos\Presentaion_Layer\Presentaion_Layer\Views\Employee\Details.cshtml"
                          Write(DeptName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54e99f58ec2bd04deaf28d148390f148c90d08579087", async() => {
                WriteLiteral("Return to Employees");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
