#pragma checksum "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61c98ed384911a29a33a214e054d6fb10198b6d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Details), @"mvc.1.0.view", @"/Views/Employees/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Details.cshtml", typeof(AspNetCore.Views_Employees_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61c98ed384911a29a33a214e054d6fb10198b6d6", @"/Views/Employees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dad7273ca53b600e77a120603dff4df4df6910d", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AD.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(112, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(235, 51, false);
#line 15 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee_Number));

#line default
#line hidden
            EndContext();
            BeginContext(286, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(330, 47, false);
#line 18 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee_Number));

#line default
#line hidden
            EndContext();
            BeginContext(377, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(421, 46, false);
#line 21 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.First_Name));

#line default
#line hidden
            EndContext();
            BeginContext(467, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(511, 42, false);
#line 24 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.First_Name));

#line default
#line hidden
            EndContext();
            BeginContext(553, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(597, 45, false);
#line 27 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Last_Name));

#line default
#line hidden
            EndContext();
            BeginContext(642, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(686, 41, false);
#line 30 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Last_Name));

#line default
#line hidden
            EndContext();
            BeginContext(727, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(771, 47, false);
#line 33 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Middle_Name));

#line default
#line hidden
            EndContext();
            BeginContext(818, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(862, 43, false);
#line 36 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Middle_Name));

#line default
#line hidden
            EndContext();
            BeginContext(905, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(949, 41, false);
#line 39 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(990, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1034, 37, false);
#line 42 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1115, 46, false);
#line 45 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1161, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1205, 42, false);
#line 48 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1291, 51, false);
#line 51 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Department_Code));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1386, 47, false);
#line 54 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Department_Code));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1477, 42, false);
#line 57 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bureau));

#line default
#line hidden
            EndContext();
            BeginContext(1519, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1563, 38, false);
#line 60 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bureau));

#line default
#line hidden
            EndContext();
            BeginContext(1601, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1645, 40, false);
#line 63 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Unit));

#line default
#line hidden
            EndContext();
            BeginContext(1685, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1729, 36, false);
#line 66 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Unit));

#line default
#line hidden
            EndContext();
            BeginContext(1765, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1809, 48, false);
#line 69 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Work_address));

#line default
#line hidden
            EndContext();
            BeginContext(1857, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1901, 44, false);
#line 72 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Work_address));

#line default
#line hidden
            EndContext();
            BeginContext(1945, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1989, 46, false);
#line 75 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Work_Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2035, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2079, 42, false);
#line 78 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Work_Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2121, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2165, 46, false);
#line 81 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Admin_Flag));

#line default
#line hidden
            EndContext();
            BeginContext(2211, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2255, 42, false);
#line 84 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Admin_Flag));

#line default
#line hidden
            EndContext();
            BeginContext(2297, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2341, 45, false);
#line 87 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Work_City));

#line default
#line hidden
            EndContext();
            BeginContext(2386, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2430, 41, false);
#line 90 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Work_City));

#line default
#line hidden
            EndContext();
            BeginContext(2471, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2515, 46, false);
#line 93 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Work_State));

#line default
#line hidden
            EndContext();
            BeginContext(2561, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2605, 42, false);
#line 96 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Work_State));

#line default
#line hidden
            EndContext();
            BeginContext(2647, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2691, 44, false);
#line 99 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Work_Zip));

#line default
#line hidden
            EndContext();
            BeginContext(2735, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2779, 40, false);
#line 102 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Work_Zip));

#line default
#line hidden
            EndContext();
            BeginContext(2819, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2863, 49, false);
#line 105 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Work_Location));

#line default
#line hidden
            EndContext();
            BeginContext(2912, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2956, 45, false);
#line 108 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Work_Location));

#line default
#line hidden
            EndContext();
            BeginContext(3001, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3045, 46, false);
#line 111 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cell_Phone));

#line default
#line hidden
            EndContext();
            BeginContext(3091, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3135, 42, false);
#line 114 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cell_Phone));

#line default
#line hidden
            EndContext();
            BeginContext(3177, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3221, 44, false);
#line 117 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(3265, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3309, 40, false);
#line 120 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(3349, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3393, 49, false);
#line 123 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Payroll_Title));

#line default
#line hidden
            EndContext();
            BeginContext(3442, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3486, 45, false);
#line 126 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Payroll_Title));

#line default
#line hidden
            EndContext();
            BeginContext(3531, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3578, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4eccbdfc4dd34094893d7ec1060f26d3", async() => {
                BeginContext(3633, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 131 "C:\Users\owner\source\repos\AD\AD\Views\Employees\Details.cshtml"
                           WriteLiteral(Model.Employee_ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3641, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3649, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0fc3dd8cf654639ac030fd9d4201dc0", async() => {
                BeginContext(3671, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3687, 10, true);
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