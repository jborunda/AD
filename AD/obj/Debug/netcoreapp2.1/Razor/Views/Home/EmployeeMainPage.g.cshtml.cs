#pragma checksum "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a49a1aede94de3d96924e27c7d49be1d0ba5c3f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EmployeeMainPage), @"mvc.1.0.view", @"/Views/Home/EmployeeMainPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/EmployeeMainPage.cshtml", typeof(AspNetCore.Views_Home_EmployeeMainPage))]
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
#line 1 "C:\Users\owner\source\repos\AD\AD\Views\_ViewImports.cshtml"
using AD;

#line default
#line hidden
#line 2 "C:\Users\owner\source\repos\AD\AD\Views\_ViewImports.cshtml"
using AD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a49a1aede94de3d96924e27c7d49be1d0ba5c3f6", @"/Views/Home/EmployeeMainPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dad7273ca53b600e77a120603dff4df4df6910d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EmployeeMainPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AD.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
  
    ViewData["Title"] = "EmployeeMainPage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(121, 131, true);
            WriteLiteral("\r\n<h2>EmployeeMainPage</h2>\r\n\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(253, 47, false);
#line 15 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee_ID));

#line default
#line hidden
            EndContext();
            BeginContext(300, 44, true);
            WriteLiteral(" \r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(345, 43, false);
#line 18 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Employee_ID));

#line default
#line hidden
            EndContext();
            BeginContext(388, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(432, 51, false);
#line 21 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee_Number));

#line default
#line hidden
            EndContext();
            BeginContext(483, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(527, 47, false);
#line 24 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Employee_Number));

#line default
#line hidden
            EndContext();
            BeginContext(574, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(618, 46, false);
#line 27 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.First_Name));

#line default
#line hidden
            EndContext();
            BeginContext(664, 44, true);
            WriteLiteral(" \r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(709, 42, false);
#line 30 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.First_Name));

#line default
#line hidden
            EndContext();
            BeginContext(751, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(795, 45, false);
#line 33 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Last_Name));

#line default
#line hidden
            EndContext();
            BeginContext(840, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(884, 41, false);
#line 36 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Last_Name));

#line default
#line hidden
            EndContext();
            BeginContext(925, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(969, 47, false);
#line 39 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Middle_Name));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1060, 43, false);
#line 42 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Middle_Name));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1147, 41, false);
#line 45 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 44, true);
            WriteLiteral(" \r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1233, 37, false);
#line 48 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1270, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1272, 11, false);
#line 48 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
                                              Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1283, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1327, 46, false);
#line 51 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1417, 42, false);
#line 54 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1503, 51, false);
#line 57 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Department_Code));

#line default
#line hidden
            EndContext();
            BeginContext(1554, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1598, 47, false);
#line 60 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Department_Code));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1689, 42, false);
#line 63 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Bureau));

#line default
#line hidden
            EndContext();
            BeginContext(1731, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1775, 38, false);
#line 66 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Bureau));

#line default
#line hidden
            EndContext();
            BeginContext(1813, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1857, 40, false);
#line 69 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Unit));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1941, 36, false);
#line 72 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Unit));

#line default
#line hidden
            EndContext();
            BeginContext(1977, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2021, 48, false);
#line 75 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Work_address));

#line default
#line hidden
            EndContext();
            BeginContext(2069, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2113, 44, false);
#line 78 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Work_address));

#line default
#line hidden
            EndContext();
            BeginContext(2157, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2201, 46, false);
#line 81 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Work_Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2247, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2291, 42, false);
#line 84 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Work_Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2333, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2377, 46, false);
#line 87 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Admin_Flag));

#line default
#line hidden
            EndContext();
            BeginContext(2423, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2467, 42, false);
#line 90 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Admin_Flag));

#line default
#line hidden
            EndContext();
            BeginContext(2509, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2553, 45, false);
#line 93 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Work_City));

#line default
#line hidden
            EndContext();
            BeginContext(2598, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2642, 41, false);
#line 96 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Work_City));

#line default
#line hidden
            EndContext();
            BeginContext(2683, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2727, 46, false);
#line 99 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Work_State));

#line default
#line hidden
            EndContext();
            BeginContext(2773, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2817, 42, false);
#line 102 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Work_State));

#line default
#line hidden
            EndContext();
            BeginContext(2859, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2903, 44, false);
#line 105 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Work_Zip));

#line default
#line hidden
            EndContext();
            BeginContext(2947, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2991, 40, false);
#line 108 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Work_Zip));

#line default
#line hidden
            EndContext();
            BeginContext(3031, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3075, 49, false);
#line 111 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Work_Location));

#line default
#line hidden
            EndContext();
            BeginContext(3124, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3168, 45, false);
#line 114 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Work_Location));

#line default
#line hidden
            EndContext();
            BeginContext(3213, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3257, 46, false);
#line 117 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Cell_Phone));

#line default
#line hidden
            EndContext();
            BeginContext(3303, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3347, 42, false);
#line 120 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Cell_Phone));

#line default
#line hidden
            EndContext();
            BeginContext(3389, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3433, 44, false);
#line 123 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(3477, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3521, 40, false);
#line 126 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(3561, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3605, 49, false);
#line 129 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayNameFor(model => model.Payroll_Title));

#line default
#line hidden
            EndContext();
            BeginContext(3654, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3698, 45, false);
#line 132 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
       Write(Html.DisplayFor(model => model.Payroll_Title));

#line default
#line hidden
            EndContext();
            BeginContext(3743, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3791, 68, false);
#line 137 "C:\Users\owner\source\repos\AD\AD\Views\Home\EmployeeMainPage.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(3859, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3867, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5e39d309107432db0c0e9d340bdd436", async() => {
                BeginContext(3889, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3905, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AD.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
