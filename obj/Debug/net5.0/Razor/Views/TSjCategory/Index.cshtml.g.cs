#pragma checksum "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0166a8c0ef7ea511d07c7ac42717be7df7ac93e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TSjCategory_Index), @"mvc.1.0.view", @"/Views/TSjCategory/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0166a8c0ef7ea511d07c7ac42717be7df7ac93e2", @"/Views/TSjCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69998c8599af2eb48f9d385e2706b13e7e5975ad", @"/Views/_ViewImports.cshtml")]
    public class Views_TSjCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ISpanSTA.Models.TCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
  
    ViewData["Title"] = "Index";
    //Layout = null;


#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br /><br />\r\n<h1>課程類別管理</h1>\r\n\r\n<p>\r\n    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 164, "\"", 262, 3);
            WriteAttributeValue("", 174, "showInPopup(\'", 174, 13, true);
#nullable restore
#line 12 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
WriteAttributeValue("", 187, Url.Action("AddOrEdit","TSjCategory",null,Context.Request.Scheme), 187, 66, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 253, "\',\'新增類別\')", 253, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\">新增</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FCourseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FCourseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1385, "\"", 1508, 3);
            WriteAttributeValue("", 1395, "showInPopup(\'", 1395, 13, true);
#nullable restore
#line 49 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
WriteAttributeValue("", 1408, Url.Action("AddOrEdit","TSjCategory",new { id = item.FCategoryId },Context.Request.Scheme), 1408, 91, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1499, "\',\'編輯類別\')", 1499, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\">編輯</a>\r\n                    ");
#nullable restore
#line 50 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 51 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 52 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.FCategoryId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <button type=\"button\" class=\"btn btn-outline-danger\"><i class=\"fas fa-trash-alt\">");
#nullable restore
#line 53 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
                                                                                                Write(Html.ActionLink("刪除", "Delete", "TSjCategory", new { id = item.FCategoryId }, new { onclick = "return confirm('確定要刪除嗎?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 56 "E:\專題製作第二組\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\TSjCategory\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div class=""modal"" tabindex=""-1"" id=""form-modal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h1 class=""modal-title""></h1>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">

            </div>

        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
    showInPopup = (url, title) => {
        $.ajax({
            type: ""GET"",
            url: url,
            success: function (res) {
                $(""#form-modal .modal-body"").html(res);
                $(""#form-modal .modal-title"").html(title);
                $(""#form-modal"").modal('show');
            }
        })
    };

    jQueryAjaxPost = from => {
       // console.log(document.myForm)
        try {
            $.ajax({
                type: 'POST',
                url:  document.myForm.action,    ");
                WriteLiteral(@"
                data: new FormData(document.myForm),
                contentType: false,
                processData: false,
                success: function (res) {
                   // console.log(res)
                    if (res.isValid) {
                       /* $(""#view-all"").html(res.html);*/
                        $(""#form-modal .modal-body"").html('');
                        $(""#form-modal .modal-title"").html('');
                        $(""#form-modal"").modal('hide');
                        location.reload();
                    }
                    else {
                        $(""#form-modal .modal-body"").html(res.html);
                    }
                      
                },
                error: function (err) {
                    console.log(err);
                }
            })
        } catch (e) {
            console.log(e);
        }
        //to prevent default form submit event
        return false;
        }


    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ISpanSTA.Models.TCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
