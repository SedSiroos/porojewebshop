#pragma checksum "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Shared\_ActiveEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b533ca16e3d7ca7611cd30a73fb26f091a0047e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ActiveEmail), @"mvc.1.0.view", @"/Views/Shared/_ActiveEmail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b533ca16e3d7ca7611cd30a73fb26f091a0047e2", @"/Views/Shared/_ActiveEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ActiveEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Poroject.DataLayer.Entities.User.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Shared\_ActiveEmail.cshtml"
  
    ViewData["Title"] = "ایمیل فعال سازی";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h2>");
#nullable restore
#line 7 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Shared\_ActiveEmail.cshtml"
   Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" عزیز</h2>\r\n    <p>\r\n        جهت ادامه کار به حساب کاربری خود را فعال کنید\r\n    </p>\r\n    <p><a");
            BeginWriteAttribute("href", " href=\"", 224, "\"", 294, 2);
            WriteAttributeValue("", 231, "https://localhost:44331/Account/ActiveAccount/", 231, 46, true);
#nullable restore
#line 11 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Shared\_ActiveEmail.cshtml"
WriteAttributeValue("", 277, Model.ActiveCode, 277, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">فعالسازی</a></p>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Poroject.DataLayer.Entities.User.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
