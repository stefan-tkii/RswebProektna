#pragma checksum "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5718986144895ede918afd8915acb9cd5fac7f99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserManagement_ListCart), @"mvc.1.0.view", @"/Views/UserManagement/ListCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserManagement/ListCart.cshtml", typeof(AspNetCore.Views_UserManagement_ListCart))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5718986144895ede918afd8915acb9cd5fac7f99", @"/Views/UserManagement/ListCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab68be648d29f7f002119bd8378afc08e3f7da1b", @"/Views/_ViewImports.cshtml")]
    public class Views_UserManagement_ListCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarCart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:5px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCartEntry", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCartItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListCart.cshtml"
  
    ViewBag.Title = "My cart";

#line default
#line hidden
            BeginContext(72, 57, true);
            WriteLiteral("\r\n<br />\r\n<h2>Current items in your cart</h2>\r\n<br />\r\n\r\n");
            EndContext();
#line 12 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListCart.cshtml"
 if (Model.Any())
{
    foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(191, 99, true);
            WriteLiteral("        <div class=\"card mb-3\">\r\n            <div class=\"card-header\">\r\n                Car name : ");
            EndContext();
            BeginContext(291, 17, false);
#line 18 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListCart.cshtml"
                      Write(item.car.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(308, 36, true);
            WriteLiteral(" <br />\r\n                Produced : ");
            EndContext();
            BeginContext(345, 17, false);
#line 19 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListCart.cshtml"
                      Write(item.car.ProdDate);

#line default
#line hidden
            EndContext();
            BeginContext(362, 33, true);
            WriteLiteral(" <br />\r\n                Owner : ");
            EndContext();
            BeginContext(396, 23, false);
#line 20 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListCart.cshtml"
                   Write(item.car.Owner.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(419, 114, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">Your telephone: ");
            EndContext();
            BeginContext(534, 14, false);
#line 23 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListCart.cshtml"
                                                  Write(item.Telephone);

#line default
#line hidden
            EndContext();
            BeginContext(548, 26, true);
            WriteLiteral("</h5>\r\n                <p>");
            EndContext();
            BeginContext(575, 20, false);
#line 24 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListCart.cshtml"
              Write(item.car.Description);

#line default
#line hidden
            EndContext();
            BeginContext(595, 92, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                Meet date: ");
            EndContext();
            BeginContext(688, 13, false);
#line 27 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListCart.cshtml"
                      Write(item.MeetDate);

#line default
#line hidden
            EndContext();
            BeginContext(701, 33, true);
            WriteLiteral(" <br />\r\n                Price : ");
            EndContext();
            BeginContext(735, 14, false);
#line 28 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListCart.cshtml"
                   Write(item.car.Price);

#line default
#line hidden
            EndContext();
            BeginContext(749, 41, true);
            WriteLiteral(" MKD <br />\r\n                Your price: ");
            EndContext();
            BeginContext(791, 17, false);
#line 29 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListCart.cshtml"
                       Write(item.RequestPrice);

#line default
#line hidden
            EndContext();
            BeginContext(808, 25, true);
            WriteLiteral(" <br />\r\n                ");
            EndContext();
            BeginContext(833, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5718986144895ede918afd8915acb9cd5fac7f999613", async() => {
                BeginContext(1009, 4, true);
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListCart.cshtml"
                                                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-itemId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 30 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListCart.cshtml"
                                                                                                                                                                WriteLiteral(item.car.FullName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1017, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1035, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5718986144895ede918afd8915acb9cd5fac7f9913236", async() => {
                BeginContext(1143, 100, true);
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n                ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListCart.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["itemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-itemId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["itemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(1250, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 36 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListCart.cshtml"
    }
}
else
{

#line default
#line hidden
            BeginContext(1307, 197, true);
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            No items found.\r\n        </div>\r\n        <div class=\"card-body\">\r\n            You cart is empty.\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 48 "C:\Users\stefa\source\repos\RSWEBProekt_v1\Views\UserManagement\ListCart.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarCart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
