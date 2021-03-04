#pragma checksum "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab849954664951f0221481258a5badd9954d4dd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Reports_PeopleReport), @"mvc.1.0.razor-page", @"/Pages/Reports/PeopleReport.cshtml")]
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
#line 1 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\_ViewImports.cshtml"
using EFCore5WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\_ViewImports.cshtml"
using EFCore5WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab849954664951f0221481258a5badd9954d4dd8", @"/Pages/Reports/PeopleReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c306e538090b6959aa2db070e4565fa50e182552", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Reports_PeopleReport : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Reports/PeopleReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml"
  
    ViewData["Title"] = "PeopleByState";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>People</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml"
           Write(Html.DisplayNameFor(model => Model.ReportData.First().LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml"
           Write(Html.DisplayNameFor(model => Model.ReportData.First().FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml"
           Write(Html.DisplayNameFor(model => Model.ReportData.First().EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml"
           Write(Html.DisplayNameFor(model => Model.ReportData.First().Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml"
         foreach (var record in Model.ReportData)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml"
               Write(Html.DisplayFor(modelItem => record.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml"
               Write(Html.DisplayFor(modelItem => record.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml"
               Write(Html.DisplayFor(modelItem => record.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml"
               Write(Html.DisplayFor(modelItem => record.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 47 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 51 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml"
  
    var prevDisabled = !Model.ReportData.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.ReportData.HasNextPage ? "disabled" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab849954664951f0221481258a5badd9954d4dd87928", async() => {
                WriteLiteral("\r\n    Previous\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml"
             WriteLiteral(Model.ReportData.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1627, "btn", 1627, 3, true);
            AddHtmlAttributeValue(" ", 1630, "btn-primary", 1631, 12, true);
#nullable restore
#line 58 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml"
AddHtmlAttributeValue(" ", 1642, prevDisabled, 1643, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab849954664951f0221481258a5badd9954d4dd810791", async() => {
                WriteLiteral("\r\n    Next\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml"
             WriteLiteral(Model.ReportData.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1787, "btn", 1787, 3, true);
            AddHtmlAttributeValue(" ", 1790, "btn-primary", 1791, 12, true);
#nullable restore
#line 63 "C:\Users\vogel\OneDrive\Book_Revised\Code\Chapter21\EFCore5WebApp\EFCore5WebApp\Pages\Reports\PeopleReport.cshtml"
AddHtmlAttributeValue(" ", 1802, nextDisabled, 1803, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EFCore5WebApp.Pages.Reports.PeopleReportModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EFCore5WebApp.Pages.Reports.PeopleReportModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EFCore5WebApp.Pages.Reports.PeopleReportModel>)PageContext?.ViewData;
        public EFCore5WebApp.Pages.Reports.PeopleReportModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
