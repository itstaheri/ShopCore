#pragma checksum "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7d81c57373e7c4d57589141828dc92a0fe6393e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.ArticleSidebar.Pages_Shared_Components_ArticleSidebar_default), @"mvc.1.0.view", @"/Pages/Shared/Components/ArticleSidebar/default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.ArticleSidebar
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
#line 1 "D:\ShopCore\ShopCore\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7d81c57373e7c4d57589141828dc92a0fe6393e", @"/Pages/Shared/Components/ArticleSidebar/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_ArticleSidebar_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Query.BlogQuery.ArticleSidebarViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("comment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "articleDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"col-lg-3 col-md-12\">\r\n    <div class=\"blog_sidebar_widget\">\r\n\r\n        <div class=\"widget_list comments\">\r\n            <div class=\"widget_title\">\r\n                <h3>دیدگاه‌های جدید</h3>\r\n            </div>\r\n");
#nullable restore
#line 11 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
             foreach (var item in Model.comments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"post_wrapper\">\r\n                    <div class=\"post_thumb\">\r\n                        <a href=\"blog-details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c7d81c57373e7c4d57589141828dc92a0fe6393e4870", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 492, "~/Img/ProfileImages/", 492, 20, true);
#nullable restore
#line 15 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
AddHtmlAttributeValue("", 512, item.Username, 512, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                    </div>\r\n                    <div class=\"post_info\">\r\n                        <span> <a>");
#nullable restore
#line 18 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
                             Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> می‌گوید:</span>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7d81c57373e7c4d57589141828dc92a0fe6393e6867", async() => {
#nullable restore
#line 19 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
                                                                              Write(item.text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
                                                      WriteLiteral(item.ArticleId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 22 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"widget_list widget_post\">\r\n            <div class=\"widget_title\">\r\n                <h3>مطالب اخیر</h3>\r\n            </div>\r\n");
#nullable restore
#line 29 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
             foreach (var item in Model.articles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"post_wrapper\">\r\n                    <div class=\"post_thumb\">\r\n                        <a href=\"blog-details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c7d81c57373e7c4d57589141828dc92a0fe6393e10132", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1237, "~/Img/ArticleImages/", 1237, 20, true);
#nullable restore
#line 33 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
AddHtmlAttributeValue("", 1257, item.Id, 1257, 8, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1265, "/", 1265, 1, true);
#nullable restore
#line 33 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
AddHtmlAttributeValue("", 1266, item.Picture, 1266, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 33 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
AddHtmlAttributeValue("", 1286, item.PictureAlt, 1286, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 33 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
AddHtmlAttributeValue("", 1311, item.PictureTitle, 1311, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                    </div>\r\n                    <div class=\"post_info\">\r\n                        <h4><a href=\"blog-details.html\">");
#nullable restore
#line 36 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                        <span>");
#nullable restore
#line 37 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
                         Write(item.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 40 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"widget_list widget_categories\">\r\n            <div class=\"widget_title\">\r\n                <h3>دسته ها</h3>\r\n            </div>\r\n            <ul>\r\n");
#nullable restore
#line 48 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
                 foreach (var item in Model.categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7d81c57373e7c4d57589141828dc92a0fe6393e14357", async() => {
#nullable restore
#line 50 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
                                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CategoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CategoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CategoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CategoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 51 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\ArticleSidebar\default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Query.BlogQuery.ArticleSidebarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591