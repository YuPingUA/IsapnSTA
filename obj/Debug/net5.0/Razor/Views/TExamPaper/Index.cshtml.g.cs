#pragma checksum "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b3c4aaf096fb731253b73c98a90b54f1f968bbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TExamPaper_Index), @"mvc.1.0.view", @"/Views/TExamPaper/Index.cshtml")]
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
#line 1 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\_ViewImports.cshtml"
using ISpanSTA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\_ViewImports.cshtml"
using ISpanSTA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b3c4aaf096fb731253b73c98a90b54f1f968bbc", @"/Views/TExamPaper/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69998c8599af2eb48f9d385e2706b13e7e5975ad", @"/Views/_ViewImports.cshtml")]
    public class Views_TExamPaper_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ISpanSTA.ViewModel.CExamPaperViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b3c4aaf096fb731253b73c98a90b54f1f968bbc3762", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 25 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FCourseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 34 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FBegin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FTimeLimit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FReveal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 52 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 64 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FCourseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 73 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FBegin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FTimeLimit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FReveal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 88 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 89 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 90 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 93 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TExamPaper\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ISpanSTA.ViewModel.CExamPaperViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591