#pragma checksum "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6369569aee6343a80f16162967cbb4af6a6949a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Details), @"mvc.1.0.view", @"/Views/Admin/Details.cshtml")]
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
#line 1 "Z:\Project\C#\Kiddy.Web\Views\_ViewImports.cshtml"
using Kiddy.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Z:\Project\C#\Kiddy.Web\Views\_ViewImports.cshtml"
using Kiddy.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
using Kiddy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6369569aee6343a80f16162967cbb4af6a6949a", @"/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fd7fb945bf496c6c86c5036d0f34d221a01e9af", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserResponse>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
  
    ViewData["Title"] = "Index";
    int no = 0;

    string error = ViewBag.error ?? string.Empty;
    string statusCode = ViewBag.StatusCode ?? string.Empty;
    string message = ViewBag.Message ?? string.Empty;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6369569aee6343a80f16162967cbb4af6a6949a3716", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6369569aee6343a80f16162967cbb4af6a6949a4777", async() => {
                WriteLiteral("\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-3\">\r\n                <ul>\r\n                    <li><a");
                BeginWriteAttribute("href", " href=\"", 558, "\"", 582, 1);
#nullable restore
#line 26 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
WriteAttributeValue("", 565, MVC.User.Index(), 565, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Shape List</a></li>\r\n                    <li><a");
                BeginWriteAttribute("href", " href=\"", 631, "\"", 656, 1);
#nullable restore
#line 27 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
WriteAttributeValue("", 638, MVC.Admin.Index(), 638, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">User List</a></li>\r\n                    <li><a");
                BeginWriteAttribute("href", " href=\"", 704, "\"", 735, 1);
#nullable restore
#line 28 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
WriteAttributeValue("", 711, MVC.Admin.CreateAdmin(), 711, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Create User / Admin</a></li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"col\">\r\n");
#nullable restore
#line 32 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
                 using (Html.BeginForm(new { ReturnUrl = ViewBag.ReturnUrl }))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
               Write(Html.TextBoxFor(m => m.UserID, new { @placeholder = "Username" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
                                                                                      ;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
               Write(Html.TextBoxFor(m => m.Email, new { @placeholder = "Email" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"login-btn\">\r\n\r\n                        <input type=\"submit\" name=\"red-submit\" value=\"Submit\" />\r\n\r\n                    </div>\r\n");
#nullable restore
#line 44 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
               Write(Html.ValidationSummary(false, string.Empty, new { style = "color:red" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
                                                                                             ;
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <script>\r\n        if (\'");
#nullable restore
#line 52 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
        Write(error);

#line default
#line hidden
#nullable disable
                WriteLiteral("\' != \'\')\r\n        {\r\n            confirm_dialog(\'");
#nullable restore
#line 54 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
                       Write(error);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \'Error\', \'\', null);\r\n        }\r\n        if(\'");
#nullable restore
#line 56 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
       Write(statusCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("\' != ");
#nullable restore
#line 56 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
                       Write(string.Empty);

#line default
#line hidden
#nullable disable
                WriteLiteral("){\r\n            alert(");
#nullable restore
#line 57 "Z:\Project\C#\Kiddy.Web\Views\Admin\Details.cshtml"
             Write(message);

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n        }\r\n\r\n\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
