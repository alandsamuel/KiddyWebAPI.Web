#pragma checksum "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5b273f8efe2a4d27748525b8c0c6c34b1a682de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
using Kiddy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5b273f8efe2a4d27748525b8c0c6c34b1a682de", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fd7fb945bf496c6c86c5036d0f34d221a01e9af", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserResponse[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int no = 0;

    string error = ViewBag.error ?? string.Empty;
    string statusCode = ViewBag.StatusCode ?? string.Empty;
    string message = ViewBag.Message ?? string.Empty;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-3\">\r\n            <ul>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 417, "\"", 441, 1);
#nullable restore
#line 19 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
WriteAttributeValue("", 424, MVC.User.Index(), 424, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Shape List</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 486, "\"", 511, 1);
#nullable restore
#line 20 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
WriteAttributeValue("", 493, MVC.Admin.Index(), 493, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">User List</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 555, "\"", 586, 1);
#nullable restore
#line 21 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
WriteAttributeValue("", 562, MVC.Admin.CreateAdmin(), 562, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Create User / Admin</a></li>
            </ul>
        </div>
        <div class=""col"">
            <table>
                <th>
                <td>NO</td>
                <td>Action</td>
                <td>User ID</td>
                <td>Email</td>
                <td>Created By</td>
                <td>Created On</td>
                </th>
");
#nullable restore
#line 34 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
                 if (Model != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 39 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
                           Write(no);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1183, "\"", 1217, 1);
#nullable restore
#line 40 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1190, MVC.Admin.Details(item.ID), 1190, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> || <a href=\"#\">Delete</a></td>\r\n                            <td>");
#nullable restore
#line 41 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
                           Write(item.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
                           Write(item.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 44 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
                           Write(item.CreatedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 46 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
                    Write(no++);

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
                               ;
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
                     

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>No Data To Be Displayed</td>\r\n                    </tr>\r\n");
#nullable restore
#line 55 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<script>\r\n        if (\'");
#nullable restore
#line 63 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
        Write(error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' != \'\')\r\n        {\r\n            confirm_dialog(\'");
#nullable restore
#line 65 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
                       Write(error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'Error\', \'\', null);\r\n        }\r\n        if(\'");
#nullable restore
#line 67 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
       Write(statusCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' != ");
#nullable restore
#line 67 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
                       Write(string.Empty);

#line default
#line hidden
#nullable disable
            WriteLiteral("){\r\n            alert(");
#nullable restore
#line 68 "Z:\Project\C#\Kiddy.Web\Views\Admin\Index.cshtml"
             Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n        }\r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserResponse[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
