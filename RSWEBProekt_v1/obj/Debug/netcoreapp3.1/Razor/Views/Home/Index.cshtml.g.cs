#pragma checksum "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11b9f9d976366bfb2ac4361cfe3503705ffdc5a4"
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
#line 1 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\_ViewImports.cshtml"
using RSWEBProekt_v1;

#line default
#line hidden
#line 2 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\_ViewImports.cshtml"
using RSWEBProekt_v1.Models;

#line default
#line hidden
#line 3 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml"
using PagedList;

#line default
#line hidden
#line 2 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml"
using PagedList.Mvc;

#line default
#line hidden
#line 3 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#line 4 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml"
using X.PagedList.Mvc;

#line default
#line hidden
#line 5 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml"
using X.PagedList.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11b9f9d976366bfb2ac4361cfe3503705ffdc5a4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab68be648d29f7f002119bd8378afc08e3f7da1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.IPagedList<Cars>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(114, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(151, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(198, 179, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to #SiteName#</h1>\r\n</div>\r\n<div class=\"text-left\">\r\n    <p>Feel free to browse our website.</p>\r\n</div>\r\n<br />\r\n\r\n");
            EndContext();
            BeginContext(377, 224, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11b9f9d976366bfb2ac4361cfe3503705ffdc5a45570", async() => {
                BeginContext(437, 157, true);
                WriteLiteral("\r\n    <b> Search filter:  </b> <input type=\"text\" id=\"SearchQuery\" name=\"SearchQuery\" />\r\n    <button type=\"submit\" class=\"btn btn-primary\">Search</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(601, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 26 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml"
 if (Model.Any())
{

    

#line default
#line hidden
#line 29 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml"
     foreach (var car in Model)
    {

#line default
#line hidden
            BeginContext(669, 100, true);
            WriteLiteral("        <div class=\"card mb-3\">\r\n            <div class=\"card-header\">\r\n                Car title : ");
            EndContext();
            BeginContext(770, 12, false);
#line 33 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml"
                       Write(car.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(782, 36, true);
            WriteLiteral(" <br />\r\n                Produced : ");
            EndContext();
            BeginContext(819, 12, false);
#line 34 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml"
                      Write(car.ProdDate);

#line default
#line hidden
            EndContext();
            BeginContext(831, 144, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"card-body\">\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                Price : ");
            EndContext();
            BeginContext(976, 9, false);
#line 40 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml"
                   Write(car.Price);

#line default
#line hidden
            EndContext();
            BeginContext(985, 49, true);
            WriteLiteral(" MKD <br />\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 43 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#line 43 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml"
     
}
else
{

#line default
#line hidden
            BeginContext(1053, 249, true);
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            No results found.\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\"> Try seaching with different parameters.</h5>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 55 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1305, 9, true);
            WriteLiteral("\r\n\r\nPage ");
            EndContext();
            BeginContext(1316, 56, false);
#line 58 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml"
 Write(Model.PageCount <Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1373, 4, true);
            WriteLiteral(" of ");
            EndContext();
            BeginContext(1378, 15, false);
#line 58 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\Home\Index.cshtml"
                                                               Write(Model.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(1393, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.IPagedList<Cars>> Html { get; private set; }
    }
}
#pragma warning restore 1591
