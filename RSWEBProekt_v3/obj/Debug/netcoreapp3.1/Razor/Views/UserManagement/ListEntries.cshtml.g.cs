#pragma checksum "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListEntries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c4d9fa06b7ce3d2de871849ed5dba815969730e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserManagement_ListEntries), @"mvc.1.0.view", @"/Views/UserManagement/ListEntries.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserManagement/ListEntries.cshtml", typeof(AspNetCore.Views_UserManagement_ListEntries))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c4d9fa06b7ce3d2de871849ed5dba815969730e", @"/Views/UserManagement/ListEntries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab68be648d29f7f002119bd8378afc08e3f7da1b", @"/Views/_ViewImports.cshtml")]
    public class Views_UserManagement_ListEntries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RSWEBProekt_v1.ViewModels.UserEntries>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:5px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditEntryCar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteEntryCar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListEntries.cshtml"
  
    ViewBag.Title = "Current entries";

#line default
#line hidden
            BeginContext(95, 41, true);
            WriteLiteral("\r\n<h1>List of all entries by you</h1>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListEntries.cshtml"
 if (Model.carEntries.Any())
{
    foreach (var car in Model.carEntries)
    {

#line default
#line hidden
            BeginContext(219, 88, true);
            WriteLiteral("    <div class=\"card mb-3\">\r\n        <div class=\"card-header\">\r\n            Car title : ");
            EndContext();
            BeginContext(308, 12, false);
#line 15 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListEntries.cshtml"
                   Write(car.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(320, 32, true);
            WriteLiteral(" <br />\r\n            Produced : ");
            EndContext();
            BeginContext(353, 12, false);
#line 16 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListEntries.cshtml"
                  Write(car.ProdDate);

#line default
#line hidden
            EndContext();
            BeginContext(365, 88, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
            EndContext();
            BeginContext(454, 12, false);
#line 20 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListEntries.cshtml"
                              Write(car.Location);

#line default
#line hidden
            EndContext();
            BeginContext(466, 22, true);
            WriteLiteral("</h5>\r\n            <p>");
            EndContext();
            BeginContext(489, 15, false);
#line 21 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListEntries.cshtml"
          Write(car.Description);

#line default
#line hidden
            EndContext();
            BeginContext(504, 76, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"card-footer\">\r\n           Price : ");
            EndContext();
            BeginContext(581, 9, false);
#line 24 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListEntries.cshtml"
              Write(car.Price);

#line default
#line hidden
            EndContext();
            BeginContext(590, 25, true);
            WriteLiteral(" MKD <br />\r\n            ");
            EndContext();
            BeginContext(615, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c4d9fa06b7ce3d2de871849ed5dba815969730e8320", async() => {
                BeginContext(752, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-carId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListEntries.cshtml"
                                                                                                                                WriteLiteral(car.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["carId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-carId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["carId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(760, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(774, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c4d9fa06b7ce3d2de871849ed5dba815969730e11132", async() => {
                BeginContext(880, 92, true);
                WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-carId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListEntries.cshtml"
                                     WriteLiteral(car.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["carId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-carId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["carId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(979, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 31 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListEntries.cshtml"
    }
}
else
{

#line default
#line hidden
            BeginContext(1028, 236, true);
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            No entries found.\r\n        </div>\r\n        <div class=\"card-body\">\r\n            You must make entries first in order to view them here.\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 43 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListEntries.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RSWEBProekt_v1.ViewModels.UserEntries> Html { get; private set; }
    }
}
#pragma warning restore 1591
