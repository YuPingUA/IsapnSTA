#pragma checksum "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\AHome\Leave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39efa803ca2b9dd7bd32557c5f576f037222779d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AHome_Leave), @"mvc.1.0.view", @"/Views/AHome/Leave.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39efa803ca2b9dd7bd32557c5f576f037222779d", @"/Views/AHome/Leave.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69998c8599af2eb48f9d385e2706b13e7e5975ad", @"/Views/_ViewImports.cshtml")]
    public class Views_AHome_Leave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AHome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ArrangeCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("Style", async() => {
                WriteLiteral(@"
    <style>
        h1 {
            color: black;
            font-family: ""微軟正黑體"";
            font-size: 60px;
            font-weight: 800;
            border: solid 3px gold;
            border-radius: 10px;
            padding: 3px;
        }
    </style>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
            DefineSection("Header", async() => {
                WriteLiteral(@"
    <!-- Main Navigation -->
    <nav class=""main_nav_container,align-items-center"">
        <div class=""main_nav"">
            <ul id=""main_nav_list"" class=""main_nav_list"">
                <li class=""main_nav_item"">
                    <a href=""Shome.html"">主頁面</a>
                </li>
                <li class=""main_nav_item"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39efa803ca2b9dd7bd32557c5f576f037222779d4589", async() => {
                    WriteLiteral("排課系統");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </li>
                <li class=""main_nav_item"">
                    <h1 style=""font-size:20px"">請假系統</h1>
                </li>
                <li class=""main_nav_item"">
                    <a href=""Shomework.html"">作業平台</a>
                </li>
                <li class=""main_nav_item"">
                    <a href=""Stest.html"">考試平台</a>
                </li>
                <li class=""main_nav_item"">
                    <a href=""Svideo.html"">影片平台</a>
                </li>
                <li class=""main_nav_item"">
                    <a href=""Squestionaire.html"">問卷調查</a>
                </li>
                <li class=""main_nav_item"">
                    <a href=""Slearning.html"">學習歷程後台</a>
                </li>
                <li class=""main_nav_item"">
                    <a href=""Sforum.html"">討論區後台</a>
                </li>
                <li class=""main_nav_item"">
                    <a href=""Sworking.html"">就業追蹤</a>
                </li>
            </ul>
     ");
                WriteLiteral("   </div>\r\n    </nav>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
