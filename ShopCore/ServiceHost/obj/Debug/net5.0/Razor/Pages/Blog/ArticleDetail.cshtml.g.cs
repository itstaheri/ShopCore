#pragma checksum "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34cef452a16f8632e09036d907b4395d84a7e655"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Blog.Pages_Blog_ArticleDetail), @"mvc.1.0.razor-page", @"/Pages/Blog/ArticleDetail.cshtml")]
namespace ServiceHost.Pages.Blog
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:long}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34cef452a16f8632e09036d907b4395d84a7e655", @"/Pages/Blog/ArticleDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Blog_ArticleDetail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Blog/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ArticleDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
  
    var UserInfo = _auth.CurrentAccountInfo();

    Layout = "BlogLayout";


#line default
#line hidden
#nullable disable
            DefineSection("Title", async() => {
                WriteLiteral(" <title>");
#nullable restore
#line 13 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                   Write(ViewData["Title"] = $"{@Model.Article.Title}");

#line default
#line hidden
#nullable disable
                WriteLiteral(" | بلاگ </title>");
            }
            );
            WriteLiteral("\r\n<div class=\"breadcrumbs_area\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <div class=\"breadcrumb_content\">\r\n                    <ul>\r\n                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34cef452a16f8632e09036d907b4395d84a7e6556589", async() => {
                WriteLiteral("بلاگ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34cef452a16f8632e09036d907b4395d84a7e6557773", async() => {
#nullable restore
#line 22 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                                              Write(Model.Article.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("./Blog/");
#nullable restore
#line 22 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                    WriteLiteral(Model.Article.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<style>
    #image {
        text-align: center;
    }
</style>

<div class=""blog_bg_area"">
    <div class=""container"">
        <div class=""blog_page_section"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-12"">
                    <!--blog grid area start-->
                    <div class=""blog_wrapper blog_details"">
                        <article class=""single_blog"">
                            <figure>
                                <div class=""post_header"">
                                    <h3 class=""post_title"">");
#nullable restore
#line 45 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                                      Write(Model.Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <div class=\"blog_meta\">\r\n                                        <span class=\"author\">ارسال توسط : <a>");
#nullable restore
#line 47 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                                                        Write(Model.Article.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> / </span>\r\n                                        <span class=\"meta_date\">در : <a>");
#nullable restore
#line 48 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                                                   Write(Model.Article.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> /</span>\r\n                                        <span class=\"post_category\">دسته بندی : ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34cef452a16f8632e09036d907b4395d84a7e65511484", async() => {
#nullable restore
#line 49 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                                                                                                                                   Write(Model.Article.CategoryName);

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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CategoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                                                                                                 WriteLiteral(Model.Article.CategoryId);

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
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"blog_thumb\" id=\"image\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34cef452a16f8632e09036d907b4395d84a7e65514234", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2049, "~/Img/ArticleImages/", 2049, 20, true);
#nullable restore
#line 53 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
AddHtmlAttributeValue("", 2069, Model.Article.Id, 2069, 17, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2086, "/", 2086, 1, true);
#nullable restore
#line 53 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
AddHtmlAttributeValue("", 2087, Model.Article.Picture, 2087, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 53 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
AddHtmlAttributeValue("", 2116, Model.Article.PictureAlt, 2116, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 53 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
AddHtmlAttributeValue("", 2150, Model.Article.PictureTitle, 2150, 27, false);

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
            WriteLiteral(@"
                                </div>
                                <figcaption class=""blog_content"">
                                    <div class=""post_content"">

                                        <blockquote>
                                            ");
#nullable restore
#line 59 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                       Write(Html.Raw(Model.Article.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </blockquote>\r\n                                        ");
#nullable restore
#line 61 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                   Write(Html.Raw(Model.Article.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                    </div>
                                    <div class=""entry_content"">


                                        <div class=""social_sharing"">
                                            <p>اشتراک گذاری این مطلب:</p>
                                            <ul>
                                                <li><a href=""#"" title=""facebook""><i class=""fa fa-facebook""></i></a></li>
                                                <li><a href=""#"" title=""twitter""><i class=""fa fa-twitter""></i></a></li>
                                                <li><a href=""#"" title=""pinterest""><i class=""fa fa-pinterest""></i></a></li>
                                                <li><a href=""#"" title=""google+""><i class=""fa fa-google-plus""></i></a></li>
                                                <li><a href=""#"" title=""linkedin""><i class=""fa fa-linkedin""></i></a></li>
                                            </ul>
                                        </div>
 ");
            WriteLiteral(@"                                   </div>
                                </figcaption>
                            </figure>
                        </article>
                        <div class=""related_posts"">
                            <h3>مطالب مرتبط</h3>
");
#nullable restore
#line 83 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                             foreach (var item in Model.RealtedArticles)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                 foreach (var article in item.articles)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-6"">
                                            <article class=""single_related"">
                                                <figure>
                                                    <div class=""related_thumb"">
                                                        <img");
            BeginWriteAttribute("src", " src=\"", 4536, "\"", 4589, 4);
            WriteAttributeValue("", 4542, "/Img/ArticleImages/", 4542, 19, true);
#nullable restore
#line 92 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
WriteAttributeValue("", 4561, article.Id, 4561, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4572, "/", 4572, 1, true);
#nullable restore
#line 92 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
WriteAttributeValue("", 4573, article.Picture, 4573, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4590, "\"", 4615, 1);
#nullable restore
#line 92 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
WriteAttributeValue("", 4596, article.PictureAlt, 4596, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4616, "\"", 4645, 1);
#nullable restore
#line 92 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
WriteAttributeValue("", 4624, article.PictureTitle, 4624, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"408\" width=\"297\">\r\n                                                    </div>\r\n                                                    <figcaption class=\"related_content\">\r\n                                                        <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34cef452a16f8632e09036d907b4395d84a7e65521769", async() => {
#nullable restore
#line 95 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                                                                                                Write(article.Title);

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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                                                                            WriteLiteral(article.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n                                                        <div class=\"blog_meta\">\r\n                                                            <span class=\"author\">توسط :<a>");
#nullable restore
#line 97 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                                                                     Write(article.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n                                                            <span class=\"meta_date\">");
#nullable restore
#line 98 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                                                               Write(article.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                        </div>
                                                    </figcaption>
                                                </figure>
                                            </article>
                                        </div>

                                    </div>
");
#nullable restore
#line 106 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                 

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\"comments_box\">\r\n                            <h3>");
#nullable restore
#line 112 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                           Write(Model.comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" دیدگاه </h3>\r\n");
#nullable restore
#line 113 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                             foreach (var item in Model.comments)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"comment_list\">\r\n                                    <div class=\"comment_thumb\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34cef452a16f8632e09036d907b4395d84a7e65526658", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6116, "~/Img/ProfileImages/", 6116, 20, true);
#nullable restore
#line 117 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
AddHtmlAttributeValue("", 6136, item.Username, 6136, 14, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6150, "/", 6150, 1, true);
#nullable restore
#line 117 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
AddHtmlAttributeValue("", 6151, item.Picture, 6151, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"comment_content\">\r\n                                        <div class=\"comment_meta\">\r\n                                            <h5><a>");
#nullable restore
#line 121 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                              Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                            <span>");
#nullable restore
#line 122 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                             Write(item.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                        <p>");
#nullable restore
#line 124 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                      Write(item.text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                    </div>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 129 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 132 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                         if (_auth.IsAuthenticated() == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"comments_form\">\r\n                                <h3>یک دیدگاه ارسال کنید </h3>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34cef452a16f8632e09036d907b4395d84a7e65530584", async() => {
                WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""col-12"">
                                            <label for=""review_comment"">موضوع </label>
                                            <input name=""title"" id=""review_comment"" />
                                        </div>

                                        <div class=""col-12"">
                                            <label for=""review_comment"">دیدگاه </label>
                                            <textarea name=""Text"" id=""review_comment""></textarea>
                                        </div>
                                        <input type=""hidden"" name=""Username""");
                BeginWriteAttribute("value", " value=\"", 7774, "\"", 7800, 1);
#nullable restore
#line 147 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
WriteAttributeValue("", 7782, UserInfo.Username, 7782, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <input type=\"hidden\" name=\"ArticleId\"");
                BeginWriteAttribute("value", " value=\"", 7883, "\"", 7908, 1);
#nullable restore
#line 148 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
WriteAttributeValue("", 7891, Model.Article.Id, 7891, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <input type=\"hidden\" name=\"ArticleName\"");
                BeginWriteAttribute("value", " value=\"", 7993, "\"", 8021, 1);
#nullable restore
#line 149 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
WriteAttributeValue("", 8001, Model.Article.Title, 8001, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                                    </div>\r\n                                    <button class=\"button\" type=\"submit\">ارسال دیدگاه</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 155 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert-warning\">برای ثبت دیدگاه باید اول وارد حساب خود شوید</div>\r\n");
#nullable restore
#line 160 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <!--blog grid area start-->\r\n                </div>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Frameworks.IAuthHelper _auth { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.Blog.ArticleDetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.Blog.ArticleDetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.Blog.ArticleDetailModel>)PageContext?.ViewData;
        public ServiceHost.Pages.Blog.ArticleDetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
