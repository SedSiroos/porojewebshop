#pragma checksum "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "054a86537cce93dd6d0ad3e113457b099933c1e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Roles_EditeRoles), @"mvc.1.0.razor-page", @"/Pages/Admin/Roles/EditeRoles.cshtml")]
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
#line 2 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
using Poroject.DataLayer.Entities.Permissons;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"054a86537cce93dd6d0ad3e113457b099933c1e7", @"/Pages/Admin/Roles/EditeRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Roles_EditeRoles : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
  
    ViewData["Title"] = "ویرایش کاربر";
    List<Permission> permissions = ViewData["permission"] as List<Permission>;
    List<int> selctedPermission = ViewData["Selectedpermission"] as List<int>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1 class=\"page-header\">ویرایش نقش</h1>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "054a86537cce93dd6d0ad3e113457b099933c1e76309", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "054a86537cce93dd6d0ad3e113457b099933c1e76579", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 18 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.editeRolesViewModel.RoleId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "054a86537cce93dd6d0ad3e113457b099933c1e78311", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 19 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.editeRolesViewModel);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <div class=""col-md-8"">
                <div class=""panel panel-info"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseOne"">ویرایش نقش</a>
                        </h4>
                    </div>
                    <div class=""container"" style=""margin:15px 0px"">

                        <div class=""form-group"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "054a86537cce93dd6d0ad3e113457b099933c1e710549", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 30 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.editeRolesViewModel.RoleTitle);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                        <p>\r\n                            <input type=\"submit\" value=\" ویرایش نقش\" class=\"btn btn-success\" />\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "054a86537cce93dd6d0ad3e113457b099933c1e712559", async() => {
                    WriteLiteral("انصراف");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </p>
                    </div>
                </div>
            </div>

            <div class=""col-md-4"">
                <div class=""panel panel-danger"">
                    <div class=""panel-heading"">
                        دسترسی های نقش
                    </div>
                    <div class=""panel-body"">
                        <div class=""form-group"">
                            <ul>
");
#nullable restore
#line 48 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                 foreach (var per in permissions.Where(p => p.ParentId == null))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li>\r\n                                        <input type=\"checkbox\" ");
#nullable restore
#line 51 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                                           Write((selctedPermission.Any(p => p == per.PermissionId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" name=\"SelectedPermission\" value=\"");
#nullable restore
#line 51 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                                                                                                                                                   Write(per.PermissionId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" />  ");
#nullable restore
#line 51 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                                                                                                                                                                          Write(per.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                         if (permissions.Any(p => p.PermissionId == per.PermissionId))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <ul>\r\n");
#nullable restore
#line 55 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                                 foreach (var Chaild1 in permissions.Where(p => p.ParentId == per.PermissionId))
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <li>\r\n                                                        <input type=\"checkbox\" ");
#nullable restore
#line 58 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                                                           Write((selctedPermission.Any(p => p == Chaild1.PermissionId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" name=\"SelectedPermission\" value=\"");
#nullable restore
#line 58 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                                                                                                                                                                       Write(Chaild1.PermissionId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" />  ");
#nullable restore
#line 58 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                                                                                                                                                                                                  Write(Chaild1.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                                         if (permissions.Any(p => p.PermissionId == Chaild1.PermissionId))
                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <ul>\r\n");
#nullable restore
#line 62 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                                                 foreach (var Chaild2 in permissions.Where(p => p.ParentId == Chaild1.PermissionId))
                                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                    <li>\r\n                                                                        <input type=\"checkbox\" ");
#nullable restore
#line 65 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                                                                           Write((selctedPermission.Any(p => p == Chaild2.PermissionId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" name=\"SelectedPermission\" value=\"");
#nullable restore
#line 65 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                                                                                                                                                                                       Write(Chaild2.PermissionId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" />  ");
#nullable restore
#line 65 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                                                                                                                                                                                                                  Write(Chaild2.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                    </li>\r\n");
#nullable restore
#line 67 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            </ul>\r\n");
#nullable restore
#line 69 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    </li>\r\n");
#nullable restore
#line 71 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </ul>\r\n");
#nullable restore
#line 73 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </li>\r\n");
#nullable restore
#line 75 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Pages\Admin\Roles\EditeRoles.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proje.Web.Pages.Admin.Roles.EditeRolesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Proje.Web.Pages.Admin.Roles.EditeRolesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Proje.Web.Pages.Admin.Roles.EditeRolesModel>)PageContext?.ViewData;
        public Proje.Web.Pages.Admin.Roles.EditeRolesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
