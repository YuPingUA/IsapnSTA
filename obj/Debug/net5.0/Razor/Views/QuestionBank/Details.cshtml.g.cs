#pragma checksum "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f88070efec3108b7c699f6bc564c1a489b388dfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuestionBank_Details), @"mvc.1.0.view", @"/Views/QuestionBank/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f88070efec3108b7c699f6bc564c1a489b388dfa", @"/Views/QuestionBank/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69998c8599af2eb48f9d385e2706b13e7e5975ad", @"/Views/_ViewImports.cshtml")]
    public class Views_QuestionBank_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ISpanSTA.ViewModel.CExamViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("    </br></br></br>\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>CExamViewModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FSujectId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayFor(model => model.FSujectId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          \r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FCourseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayFor(model => model.FCourseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FCourseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayFor(model => model.FCourseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayFor(model => model.FCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FCategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayFor(model => model.FCategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayFor(model => model.FTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FTypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayFor(model => model.FTypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FQuestion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayFor(model => model.FQuestion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FOption1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayFor(model => model.FOption1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FOption2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayFor(model => model.FOption2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FOption3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayFor(model => model.FOption3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FOption4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayFor(model => model.FOption4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FAns));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayFor(model => model.FAns));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FAnsAnalyze));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
       Write(Html.DisplayFor(model => model.FAnsAnalyze));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 100 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\QuestionBank\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f88070efec3108b7c699f6bc564c1a489b388dfa13794", async() => {
                WriteLiteral("Back to List");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ISpanSTA.ViewModel.CExamViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
