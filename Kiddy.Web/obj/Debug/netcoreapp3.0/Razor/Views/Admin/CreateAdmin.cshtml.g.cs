#pragma checksum "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abcc24148ecc432a1988f6375f50c3ba3363ac3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CreateAdmin), @"mvc.1.0.view", @"/Views/Admin/CreateAdmin.cshtml")]
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
#line 1 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
using Kiddy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abcc24148ecc432a1988f6375f50c3ba3363ac3d", @"/Views/Admin/CreateAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b4424beb443a29b6c453a3f2b58dca52f45d8c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CreateAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsersRegister>
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
        private global::R4Mvc.TagHelpers.AnchorTagHelper __R4Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
  
    ViewData["Title"] = "Index";
    int no = 0;

    string error = ViewBag.error ?? string.Empty;
    string statusCode = ViewBag.StatusCode ?? string.Empty;
    string message = ViewBag.Message ?? string.Empty;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abcc24148ecc432a1988f6375f50c3ba3363ac3d3839", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abcc24148ecc432a1988f6375f50c3ba3363ac3d4900", async() => {
                WriteLiteral("\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-3\">\r\n                <ul>\r\n                    <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abcc24148ecc432a1988f6375f50c3ba3363ac3d5313", async() => {
                    WriteLiteral("Shape List");
                }
                );
                __R4Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::R4Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__R4Mvc_TagHelpers_AnchorTagHelper);
#nullable restore
#line 26 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
__R4Mvc_TagHelpers_AnchorTagHelper.ObjectAction = MVC.User.Index();

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("mvc-action", __R4Mvc_TagHelpers_AnchorTagHelper.ObjectAction, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                    <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abcc24148ecc432a1988f6375f50c3ba3363ac3d6718", async() => {
                    WriteLiteral("User List");
                }
                );
                __R4Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::R4Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__R4Mvc_TagHelpers_AnchorTagHelper);
#nullable restore
#line 27 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
__R4Mvc_TagHelpers_AnchorTagHelper.ObjectAction = MVC.Admin.Index();

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("mvc-action", __R4Mvc_TagHelpers_AnchorTagHelper.ObjectAction, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                    <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abcc24148ecc432a1988f6375f50c3ba3363ac3d8123", async() => {
                    WriteLiteral("Create User / Admin");
                }
                );
                __R4Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::R4Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__R4Mvc_TagHelpers_AnchorTagHelper);
#nullable restore
#line 28 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
__R4Mvc_TagHelpers_AnchorTagHelper.ObjectAction = MVC.Admin.CreateAdmin();

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("mvc-action", __R4Mvc_TagHelpers_AnchorTagHelper.ObjectAction, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"col\">\r\n");
#nullable restore
#line 32 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
                 using (Html.BeginForm(new { ReturnUrl = ViewBag.ReturnUrl }))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
               Write(Html.TextBoxFor(m => m.UserID, new { @placeholder = "Username" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
                                                                                      ;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
               Write(Html.PasswordFor(m => m.password, new { @placeholder = "Password" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
                                                                                         ;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
               Write(Html.TextBoxFor(m => m.Email, new { @placeholder = "Email" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"login-btn\">\r\n\r\n                        <input type=\"submit\" name=\"red-submit\" class=\"btn btn-danger\" value=\"Submit\" />\r\n\r\n                    </div>\r\n");
#nullable restore
#line 45 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
               Write(Html.ValidationSummary(false, string.Empty, new { style = "color:red" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
                                                                                             ;
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <script>\r\n        if (\'");
#nullable restore
#line 54 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
        Write(error);

#line default
#line hidden
#nullable disable
                WriteLiteral("\' != \'\')\r\n        {\r\n            confirm_dialog(\'");
#nullable restore
#line 56 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
                       Write(error);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \'Error\', \'\', null);\r\n        }\r\n        if(\'");
#nullable restore
#line 58 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
       Write(statusCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("\' != ");
#nullable restore
#line 58 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
                       Write(string.Empty);

#line default
#line hidden
#nullable disable
                WriteLiteral("){\r\n            alert(");
#nullable restore
#line 59 "Z:\Project\C#\Kiddy.Web\Views\Admin\CreateAdmin.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsersRegister> Html { get; private set; }
    }
}
#pragma warning restore 1591
