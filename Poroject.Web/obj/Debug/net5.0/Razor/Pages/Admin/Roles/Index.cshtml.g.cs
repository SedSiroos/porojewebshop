#pragma checksum "C:\Users\Siroos\Desktop\new Asp.net\Poroject\Poroject.Web\Pages\Admin\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01474a443b649355cd38c2ad9aaf82576384a25b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Roles_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Roles/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01474a443b649355cd38c2ad9aaf82576384a25b", @"/Pages/Admin/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Roles_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Siroos\Desktop\new Asp.net\Poroject\Poroject.Web\Pages\Admin\Roles\Index.cshtml"
  
    ViewData["Title"] = "لیست نقش کاربران";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <h1 class=""page-header"">لیست نقش کاربران</h1>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    لیست نقش کاربران
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <div class=""table-responsive"">
                        <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">

                            <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                                <a href=""/Admin/Roles/CreateRoles"" class=""btn btn-success btn-sm""> افزودن کاربر جدید</a>
                                <thead>
                                    <tr>
        ");
            WriteLiteral("                                <th>نام نقش های کاربری</th>\r\n\r\n                                        <th></th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Siroos\Desktop\new Asp.net\Poroject\Poroject.Web\Pages\Admin\Roles\Index.cshtml"
                                     foreach (var item in Model.RoleList)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 37 "C:\Users\Siroos\Desktop\new Asp.net\Poroject\Poroject.Web\Pages\Admin\Roles\Index.cshtml"
                                           Write(item.RoleTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 1700, "\"", 1743, 2);
            WriteAttributeValue("", 1707, "/Admin/Roles/EditeRoles/", 1707, 24, true);
#nullable restore
#line 39 "C:\Users\Siroos\Desktop\new Asp.net\Poroject\Poroject.Web\Pages\Admin\Roles\Index.cshtml"
WriteAttributeValue("", 1731, item.RoleId, 1731, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">ویرایش</a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 1838, "\"", 1881, 2);
            WriteAttributeValue("", 1845, "/Admin/Roles/DeleteRole/", 1845, 24, true);
#nullable restore
#line 40 "C:\Users\Siroos\Desktop\new Asp.net\Poroject\Poroject.Web\Pages\Admin\Roles\Index.cshtml"
WriteAttributeValue("", 1869, item.RoleId, 1869, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">حذف</a>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Siroos\Desktop\new Asp.net\Poroject\Poroject.Web\Pages\Admin\Roles\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <!-- /.table-responsive -->

            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-12 -->
</div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proje.Web.Pages.Admin.Roles.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Proje.Web.Pages.Admin.Roles.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Proje.Web.Pages.Admin.Roles.IndexModel>)PageContext?.ViewData;
        public Proje.Web.Pages.Admin.Roles.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
