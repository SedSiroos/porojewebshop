#pragma checksum "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a77f11d490db631c33713e4d0c3d5748f4585787"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
#line 1 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
using Poroject.DataLayer.Entities.Course;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77f11d490db631c33713e4d0c3d5748f4585787", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<Poroject.Core.RegisterViewModel.ShowCourseListItemViewModel>, int>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "price", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("changeGroup()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "updatedate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BoxCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formFilter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Course"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
  
    ViewData["Title"] = "آرشیو دوره ها";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <nav aria-label=""breadcrumb"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""#"">پروژه من</a></li>
            <li class=""breadcrumb-item active""><a href=""#"">دوره ها</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page""> برنامه نویسی وب </li>
        </ul>
    </nav>
</div>

<div class=""container"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a77f11d490db631c33713e4d0c3d5748f45857876518", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" id=\"pageid\" name=\"pageId\"");
                BeginWriteAttribute("value", " value=\"", 686, "\"", 720, 1);
#nullable restore
#line 19 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 694, ViewBag.pageId.ToString(), 694, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <section class=\"term-categories\">\r\n            <div class=\"top-bar\">\r\n                <header><h1> دوره های <span> برنامه نویسی وب </span> </h1> <span> ");
#nullable restore
#line 22 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                                                                             Write(Model.Item1.Count().ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@" دوره </span></header>                
                <div class=""row"">
                    <div class=""col-md-4 col-sm-12 col-xs-12 pull-right"">
                        <div class=""input"">
                            <input type=""text"" name=""filter"" placeholder=""موضوع مورد نظر ..."">
                            <button><i class=""zmdi zmdi-search""></i></button>
                            <a href=""/Course"" class=""btn btn-sm btn-danger"">رفرش</a>
                        </div>                        
                    </div>

                    <div class=""col-md-4 col-sm-6 col-xs-12 pull-right"">
                        <div class=""switch-field available"">
                            <input id=""available-filter-1"" name=""getType"" value=""all""");
                BeginWriteAttribute("checked", " checked=\"", 1680, "\"", 1690, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""radio"" onchange=""changeGroup()"">
                            <label for=""available-filter-1""> همه </label>
                            <input id=""available-filter-2"" name=""getType"" value=""buy"" type=""radio"" onchange=""changeGroup()"">
                            <label for=""available-filter-2""> خریدنی </label>
                            <input id=""available-filter-3"" name=""getType"" value=""free"" type=""radio"" onchange=""changeGroup()"">
                            <label for=""available-filter-3""> رایگان </label>
                        </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 col-xs-12 pull-left"">
                        <div class=""select-ddl"">
                            <select name=""getOrderByType"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a77f11d490db631c33713e4d0c3d5748f45857879476", async() => {
                    WriteLiteral(" قیمت ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a77f11d490db631c33713e4d0c3d5748f458578710818", async() => {
                    WriteLiteral(" تاریخ انتشار ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a77f11d490db631c33713e4d0c3d5748f458578712169", async() => {
                    WriteLiteral(" تاریخ بروزرسانی ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <aside class=""col-lg-3 col-md-4 col-sm-12 col-xs-12"">
                    <section class=""aside-section filter-by-price"">
                        <header>
                            <h3> فیلتر بر اساس قیمت </h3>
                        </header>
                        <div class=""price-range"">
                            <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 3311, "\"", 3319, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"min-value\" name=\"startPrice\">\r\n                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3404, "\"", 3412, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""max-value"" name=""endPrice"">
                            <div class=""price-bar"">
                                <div id=""priceFilter""></div>
                            </div>
                            <div class=""min-price"">از <span id=""min-text"">10000</span> تومان</div>
                            <div class=""max-price"">تا <span id=""max-text"">900000</span> تومان</div>
                            <div class=""clearfix""></div>
                        </div>
                    </section>
");
#nullable restore
#line 70 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                      
                        List<CourseGroup> groups = ViewBag.Groups as List<CourseGroup>;
                        List<int> selected = ViewBag.SelectedGroups as List<int>;
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <section class=\"aside-section filter-by-category\">\r\n                        <header><h3> دسته بندی موضوعات </h3></header>\r\n                        <div class=\"inner\">\r\n                            <ul>\r\n");
#nullable restore
#line 78 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                                 foreach (var grop in groups.Where(g => g.ParentId == null))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li>\r\n                                        <input type=\"checkbox\" onchange=\"changeGroup()\" name=\"selectedGroups\"");
                BeginWriteAttribute("value", " value=\"", 4642, "\"", 4663, 1);
#nullable restore
#line 81 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 4650, grop.GroupId, 4650, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 81 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                                                                                                                                Write((selected.Any(g => g == grop.GroupId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" id=\"cat-1\">\r\n                                        <label for=\"cat-1\"> ");
#nullable restore
#line 82 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                                                       Write(grop.GroupTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n\r\n");
#nullable restore
#line 84 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                                         if (groups.Any(g => g.ParentId == grop.GroupId))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <ul>\r\n");
#nullable restore
#line 87 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                                                 foreach (var subGroup in groups.Where(g => g.ParentId == grop.GroupId))
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <li>\r\n                                                        <input type=\"checkbox\" onchange=\"changeGroup()\" name=\"selectedGroups\"");
                BeginWriteAttribute("value", " value=\"", 5366, "\"", 5391, 1);
#nullable restore
#line 90 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 5374, subGroup.GroupId, 5374, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 90 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                                                                                                                                                    Write((selected.Any(g => g == subGroup.GroupId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" id=\"cat-1\">\r\n                                                        <label for=\"cat-1\"> ");
#nullable restore
#line 91 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                                                                       Write(subGroup.GroupTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n                                                    </li>\r\n");
#nullable restore
#line 93 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </ul>\r\n");
#nullable restore
#line 95 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </li>\r\n");
#nullable restore
#line 97 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </ul>
                        </div>
                    </section>
                </aside>
                <div class=""col-lg-9 col-md-8 col-sm-12 col-xs-12"">
                    <section class=""terms-items"">
                        <div class=""row"">
                            <!-- col -->
");
#nullable restore
#line 106 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                             foreach (var item in Model.Item1)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a77f11d490db631c33713e4d0c3d5748f458578720767", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 108 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 109 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <!-- /col -->\r\n                        </div>\r\n");
#nullable restore
#line 112 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                         if (Model.Item2 > 1)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <nav aria-label=\"Page navigation\">\r\n                                <ul class=\"pagination justify-content-center\">                                   \r\n");
#nullable restore
#line 116 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                                     for (int i = 1; i <= Model.Item2; i++)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li class=\"page-item\">\r\n                                            <a class=\"page-link\"");
                BeginWriteAttribute("onclick", " onclick=\"", 6963, "\"", 6987, 3);
                WriteAttributeValue("", 6973, "changePage(", 6973, 11, true);
#nullable restore
#line 119 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 6984, i, 6984, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6986, ")", 6986, 1, true);
                EndWriteAttribute();
                WriteLiteral(" href=\"#\">");
#nullable restore
#line 119 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                                                                                              Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                        </li>\r\n");
#nullable restore
#line 121 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                                    }                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </ul>\r\n                            </nav>\r\n");
#nullable restore
#line 124 "C:\Users\Siroos\Desktop\proje\Poroject.Web\Views\Course\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </section>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""/noUiSlider/nouislider.min.js""></script>
    <script src=""/js/script.js""></script>
    <script type=""text/javascript"">

        function changePage(pageid) {
            $(""#pageid"").val(pageid);
            $(""#formFilter"").submit();
        }

        $(function () {
            var slider = document.getElementById('priceFilter');
            noUiSlider.create(slider, {
                start: [900000, 20000],
                step: 5000,
                connect: true,
                direction: 'rtl',
                range: {
                    'min': 20000,
                    'max': 900000
                }
            });
            var marginMin = document.getElementById('min-text'),
                marginMax = document.getElementById('max-text');

            slider.noUiSlider.on('update', function (values, handle) {
                var xvalue = Math.round(values[handle]);
                if (handle) {
                    marginMax.innerHTML = xvalue;
   ");
                WriteLiteral(@"             } else {
                    marginMin.innerHTML = xvalue;
                }
                //console.log(values[handle]);
            });
            slider.noUiSlider.on('change', function (values, handle) {
                var xvalue = Math.round(values[handle]);
                if (handle) {
                    // setGetParameter('max_price', xvalue);
                    $('#max-value').val(xvalue);
                } else {
                    // setGetParameter('min_price', xvalue);
                    $('#min-value').val(xvalue);
                }
            });
            slider.noUiSlider.on('slide', function (values, handle) {

                console.log(values[0]);
                console.log(values[1]);

                var xvalue = Math.round(values[handle]);
                //updateSliderRange( Math.round(values[0]), Math.round(values[1]) );
            });
            function updateSliderRange(min, max) {
                slider.noUiSlider.updateOptions({");
                WriteLiteral(@"
                    range: {
                        'min': min,
                        'max': max
                    }
                });
            }
        });
        function changeGroup() {
            $(""#formFilter"").submit();
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<Poroject.Core.RegisterViewModel.ShowCourseListItemViewModel>, int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
