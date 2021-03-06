#pragma checksum "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70145febbbaa9f604d6d9e7252a82392851abacd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserManagement_ListRequests), @"mvc.1.0.view", @"/Views/UserManagement/ListRequests.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserManagement/ListRequests.cshtml", typeof(AspNetCore.Views_UserManagement_ListRequests))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70145febbbaa9f604d6d9e7252a82392851abacd", @"/Views/UserManagement/ListRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab68be648d29f7f002119bd8378afc08e3f7da1b", @"/Views/_ViewImports.cshtml")]
    public class Views_UserManagement_ListRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CarCart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCartItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListRequests.cshtml"
  
    ViewBag.Title = "User requests";

#line default
#line hidden
            BeginContext(69, 47, true);
            WriteLiteral("\r\n<h2>List of pending requests</h2>\r\n<br />\r\n\r\n");
            EndContext();
#line 10 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListRequests.cshtml"
 if (Model.Any())
{
    foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(178, 99, true);
            WriteLiteral("        <div class=\"card mb-3\">\r\n            <div class=\"card-header\">\r\n                Car name : ");
            EndContext();
            BeginContext(278, 17, false);
#line 16 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListRequests.cshtml"
                      Write(item.car.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(295, 36, true);
            WriteLiteral(" <br />\r\n                Produced : ");
            EndContext();
            BeginContext(332, 17, false);
#line 17 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListRequests.cshtml"
                      Write(item.car.ProdDate);

#line default
#line hidden
            EndContext();
            BeginContext(349, 37, true);
            WriteLiteral(" <br />\r\n                Requester : ");
            EndContext();
            BeginContext(387, 22, false);
#line 18 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListRequests.cshtml"
                       Write(item.siteUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(409, 110, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\"> Telephone: ");
            EndContext();
            BeginContext(520, 14, false);
#line 21 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListRequests.cshtml"
                                              Write(item.Telephone);

#line default
#line hidden
            EndContext();
            BeginContext(534, 26, true);
            WriteLiteral("</h5>\r\n                <p>");
            EndContext();
            BeginContext(561, 20, false);
#line 22 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListRequests.cshtml"
              Write(item.car.Description);

#line default
#line hidden
            EndContext();
            BeginContext(581, 92, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                Meet date: ");
            EndContext();
            BeginContext(674, 13, false);
#line 25 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListRequests.cshtml"
                      Write(item.MeetDate);

#line default
#line hidden
            EndContext();
            BeginContext(687, 33, true);
            WriteLiteral(" <br />\r\n                Price : ");
            EndContext();
            BeginContext(721, 14, false);
#line 26 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListRequests.cshtml"
                   Write(item.car.Price);

#line default
#line hidden
            EndContext();
            BeginContext(735, 41, true);
            WriteLiteral(" MKD <br />\r\n                Your price: ");
            EndContext();
            BeginContext(777, 17, false);
#line 27 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListRequests.cshtml"
                       Write(item.RequestPrice);

#line default
#line hidden
            EndContext();
            BeginContext(794, 53, true);
            WriteLiteral(" MKD <br />\r\n                <br />\r\n                ");
            EndContext();
            BeginContext(847, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70145febbbaa9f604d6d9e7252a82392851abacd8444", async() => {
                BeginContext(955, 101, true);
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-danger\">Decline</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListRequests.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["itemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-itemId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["itemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(1063, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 34 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListRequests.cshtml"
    }
}
else
{

#line default
#line hidden
            BeginContext(1120, 210, true);
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            No requests found.\r\n        </div>\r\n        <div class=\"card-body\">\r\n            Your requests list is empty.\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 46 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListRequests.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CarCart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
