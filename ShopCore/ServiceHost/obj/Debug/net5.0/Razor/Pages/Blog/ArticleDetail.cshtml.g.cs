#pragma checksum "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed1bb73be113a7fc69f0e3ae076fea50244fbe58"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed1bb73be113a7fc69f0e3ae076fea50244fbe58", @"/Pages/Blog/ArticleDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Blog_ArticleDetail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
  
    ViewData["title"] = Model.Article.Title;
    Layout = "BlogLayout";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"breadcrumbs_area\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <div class=\"breadcrumb_content\">\r\n                    <ul>\r\n                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed1bb73be113a7fc69f0e3ae076fea50244fbe584790", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed1bb73be113a7fc69f0e3ae076fea50244fbe585974", async() => {
#nullable restore
#line 20 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
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
#line 20 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
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

<div class=""blog_bg_area"">
    <div class=""container"">
        <div class=""blog_page_section"">
            <div class=""row"">
                <div class=""col-lg-9 col-md-12"">
                    <!--blog grid area start-->
                    <div class=""blog_wrapper blog_details"">
                        <article class=""single_blog"">
                            <figure>
                                <div class=""post_header"">
                                    <h3 class=""post_title"">");
#nullable restore
#line 38 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                                      Write(Model.Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <div class=\"blog_meta\">\r\n                                        <span class=\"author\">ارسال توسط : <a href=\"#\">");
#nullable restore
#line 40 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                                                                 Write(Model.Article.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> / </span>\r\n                                        <span class=\"meta_date\">در : <a href=\"#\">");
#nullable restore
#line 41 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                                                            Write(Model.Article.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> /</span>\r\n                                        <span class=\"post_category\">دسته بندی : ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed1bb73be113a7fc69f0e3ae076fea50244fbe589655", async() => {
#nullable restore
#line 42 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                                                                                           WriteLiteral(Model.Article.CategoryId);

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
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"blog_thumb\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ed1bb73be113a7fc69f0e3ae076fea50244fbe5812347", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1831, "~/Img/ArticleImages/", 1831, 20, true);
#nullable restore
#line 46 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
AddHtmlAttributeValue("", 1851, Model.Article.Id, 1851, 17, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1868, "/", 1868, 1, true);
#nullable restore
#line 46 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
AddHtmlAttributeValue("", 1869, Model.Article.Picture, 1869, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 46 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
AddHtmlAttributeValue("", 1898, Model.Article.PictureAlt, 1898, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 46 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
AddHtmlAttributeValue("", 1932, Model.Article.PictureTitle, 1932, 27, false);

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
                                            <p>");
#nullable restore
#line 52 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                          Write(Model.Article.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </blockquote>\r\n                                        <p>");
#nullable restore
#line 54 "D:\ShopCore\ShopCore\ServiceHost\Pages\Blog\ArticleDetail.cshtml"
                                      Write(Model.Article.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

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
                                        </div");
            WriteLiteral(@">
                                    </div>
                                </figcaption>
                            </figure>
                        </article>
                        <div class=""related_posts"">
                            <h3>مطالب مرتبط</h3>
                            <div class=""row"">
                                <div class=""col-lg-4 col-md-6"">
                                    <article class=""single_related"">
                                        <figure>
                                            <div class=""related_thumb"">
                                                <img src=""assets/img/blog/blog7.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4083, "\"", 4089, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </div>
                                            <figcaption class=""related_content"">
                                                <h4><a href=""#"">مطلب دارای گالری</a></h4>
                                                <div class=""blog_meta"">
                                                    <span class=""author"">توسط: <a href=""#"">مدیر</a> / </span>
                                                    <span class=""meta_date""> 11 آذر 1398	</span>
                                                </div>
                                            </figcaption>
                                        </figure>
                                    </article>
                                </div>
                                <div class=""col-lg-4 col-md-6"">
                                    <article class=""single_related"">
                                        <figure>
                                            <div class=""related_thumb"">
  ");
            WriteLiteral("                                              <img src=\"assets/img/blog/blog8.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 5196, "\"", 5202, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </div>
                                            <figcaption class=""related_content"">
                                                <h4><a href=""#"">مطلب بلاگ صوتی</a></h4>
                                                <div class=""blog_meta"">
                                                    <span class=""author"">توسط: <a href=""#"">مدیر</a> / </span>
                                                    <span class=""meta_date""> 11 آذر 1398	</span>
                                                </div>
                                            </figcaption>
                                        </figure>
                                    </article>
                                </div>
                                <div class=""col-lg-4 col-md-6"">
                                    <article class=""single_related"">
                                        <figure>
                                            <div class=""related_thumb"">
    ");
            WriteLiteral("                                            <img src=\"assets/img/blog/blog9.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 6307, "\"", 6313, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </div>
                                            <figcaption class=""related_content"">
                                                <h4><a href=""#"">لورم ایپسوم متن ساختگی</a></h4>
                                                <div class=""blog_meta"">
                                                    <span class=""author"">توسط: <a href=""#"">مدیر</a> / </span>
                                                    <span class=""meta_date""> 11 آذر 1398	</span>
                                                </div>
                                            </figcaption>
                                        </figure>
                                    </article>
                                </div>
                            </div>
                        </div>
                        <div class=""comments_box"">
                            <h3>3 دیدگاه </h3>
                            <div class=""comment_list"">
                              ");
            WriteLiteral("  <div class=\"comment_thumb\">\r\n                                    <img src=\"assets/img/blog/comment3.png.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 7448, "\"", 7454, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""comment_content"">
                                    <div class=""comment_meta"">
                                        <h5><a href=""#"">مدیر</a></h5>
                                        <span>16 آذر 1398 ساعت 1:38 صبح</span>
                                    </div>
                                    <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان</p>
                                    <div class=""comment_reply"">
                                        <a href=""#"">پاسخ</a>
                                    </div>
                                </div>

                            </div>
                            <div class=""comment_list list_two"">
                                <div class=""comment_thumb"">
                                    <img src=""assets/img/blog/comment3.png.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8399, "\"", 8405, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""comment_content"">
                                    <div class=""comment_meta"">
                                        <h5><a href=""#"">دمو</a></h5>
                                        <span>16 آذر 1398 ساعت 1:38 صبح</span>
                                    </div>
                                    <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از</p>
                                    <div class=""comment_reply"">
                                        <a href=""#"">پاسخ</a>
                                    </div>
                                </div>
                            </div>
                            <div class=""comment_list"">
                                <div class=""comment_thumb"">
                                    <img src=""assets/img/blog/comment3.png.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9331, "\"", 9337, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""comment_content"">
                                    <div class=""comment_meta"">
                                        <h5><a href=""#"">مدیر</a></h5>
                                        <span>16 آذر 1398 ساعت 1:38 صبح</span>
                                    </div>
                                    <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان</p>
                                    <div class=""comment_reply"">
                                        <a href=""#"">پاسخ</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""comments_form"">
                            <h3>یک پاسخ ارسال کنید </h3>
                            <p>ایمیل شما منتشر نخواهد شد. فیلد های الزامی با * مشخص شده اند</p>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed1bb73be113a7fc69f0e3ae076fea50244fbe5824944", async() => {
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-12"">
                                        <label for=""review_comment"">دیدگاه </label>
                                        <textarea name=""comment"" id=""review_comment""></textarea>
                                    </div>
                                    <div class=""col-lg-4 col-md-4"">
                                        <label for=""author"">نام</label>
                                        <input id=""author"" type=""text"">

                                    </div>
                                    <div class=""col-lg-4 col-md-4"">
                                        <label for=""email"">ایمیل </label>
                                        <input id=""email"" type=""text"" dir=""ltr"">
                                    </div>
                                    <div class=""col-lg-4 col-md-4"">
                                        <label for=""website"">وب‌سایت </label>
       ");
                WriteLiteral(@"                                 <input id=""website"" type=""text"">
                                    </div>
                                </div>
                                <button class=""button"" type=""submit"">ارسال دیدگاه</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>

                    </div>
                    <!--blog grid area start-->
                </div>


                <div class=""col-lg-3 col-md-12"">
                    <div class=""blog_sidebar_widget"">
                        <div class=""widget_list widget_search"">
                            <div class=""widget_title"">
                                <h3>جستجو</h3>
                            </div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed1bb73be113a7fc69f0e3ae076fea50244fbe5828111", async() => {
                WriteLiteral("\r\n                                <input placeholder=\"جستجو ...\" type=\"text\">\r\n                                <button type=\"submit\">جستجو</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""widget_list comments"">
                            <div class=""widget_title"">
                                <h3>دیدگاه‌های جدید</h3>
                            </div>
                            <div class=""post_wrapper"">
                                <div class=""post_thumb"">
                                    <a href=""blog-details.html""><img src=""assets/img/blog/comment2.png.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12807, "\"", 12813, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                </div>
                                <div class=""post_info"">
                                    <span> <a href=""#"">دمو</a> می‌گوید:</span>
                                    <a href=""blog-details.html"">لورم ایپسوم متن ساختگی</a>
                                </div>
                            </div>
                            <div class=""post_wrapper"">
                                <div class=""post_thumb"">
                                    <a href=""blog-details.html""><img src=""assets/img/blog/comment2.png.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13387, "\"", 13393, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                </div>
                                <div class=""post_info"">
                                    <span><a href=""#"">مدیر</a> می‌گوید:</span>
                                    <a href=""blog-details.html"">لورم ایپسوم متن ساختگی</a>
                                </div>
                            </div>
                            <div class=""post_wrapper"">
                                <div class=""post_thumb"">
                                    <a href=""blog-details.html""><img src=""assets/img/blog/comment2.png.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13967, "\"", 13973, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                </div>
                                <div class=""post_info"">
                                    <span><a href=""#"">دمو</a> می‌گوید:</span>
                                    <a href=""blog-details.html"">لورم ایپسوم متن ساختگی</a>
                                </div>
                            </div>
                            <div class=""post_wrapper"">
                                <div class=""post_thumb"">
                                    <a href=""blog-details.html""><img src=""assets/img/blog/comment2.png.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14546, "\"", 14552, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                </div>
                                <div class=""post_info"">
                                    <span><a href=""#"">مدیر</a> می‌گوید:</span>
                                    <a href=""blog-details.html"">لورم ایپسوم متن ساختگی</a>
                                </div>
                            </div>
                        </div>
                        <div class=""widget_list widget_post"">
                            <div class=""widget_title"">
                                <h3>مطالب اخیر</h3>
                            </div>
                            <div class=""post_wrapper"">
                                <div class=""post_thumb"">
                                    <a href=""blog-details.html""><img src=""assets/img/blog/blog6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15359, "\"", 15365, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                </div>
                                <div class=""post_info"">
                                    <h4><a href=""blog-details.html"">مطلب بلاگ تصویری</a></h4>
                                    <span>16 آذر 1398 </span>
                                </div>
                            </div>
                            <div class=""post_wrapper"">
                                <div class=""post_thumb"">
                                    <a href=""blog-details.html""><img src=""assets/img/blog/blog7.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15918, "\"", 15924, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                </div>
                                <div class=""post_info"">
                                    <h4><a href=""blog-details.html"">مطلب دارای گالری</a></h4>
                                    <span>16 آذر 1398 </span>
                                </div>
                            </div>
                            <div class=""post_wrapper"">
                                <div class=""post_thumb"">
                                    <a href=""blog-details.html""><img src=""assets/img/blog/blog8.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 16477, "\"", 16483, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                </div>
                                <div class=""post_info"">
                                    <h4><a href=""blog-details.html"">مطلب بلاگ صوتی</a></h4>
                                    <span>16 آذر 1398 </span>
                                </div>
                            </div>
                            <div class=""post_wrapper"">
                                <div class=""post_thumb"">
                                    <a href=""blog-details.html""><img src=""assets/img/blog/blog9.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 17034, "\"", 17040, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                </div>
                                <div class=""post_info"">
                                    <h4><a href=""blog-details.html"">مطلب بلاگ ویدیویی</a></h4>
                                    <span>16 آذر 1398 </span>
                                </div>
                            </div>
                        </div>
                        <div class=""widget_list widget_categories"">
                            <div class=""widget_title"">
                                <h3>دسته ها</h3>
                            </div>
                            <ul>
                                <li><a href=""#"">صوت</a></li>
                                <li><a href=""#"">شرکت</a></li>
                                <li><a href=""#"">گالری</a></li>
                                <li><a href=""#"">تصویر</a></li>
                                <li><a href=""#"">سایر</a></li>
                                <li><a href=""#"">مسافرت</a></li>
                           ");
            WriteLiteral(@" </ul>
                        </div>

                        <div class=""widget_list widget_tag"">
                            <div class=""widget_title"">
                                <h3>برچسب های محصولات</h3>
                            </div>
                            <div class=""tag_widget"">
                                <ul>
                                    <li><a href=""#"">آسیایی</a></li>
                                    <li><a href=""#"">قهوه ای</a></li>
                                    <li><a href=""#"">یورو</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.Blog.ArticleDetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.Blog.ArticleDetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.Blog.ArticleDetailModel>)PageContext?.ViewData;
        public ServiceHost.Pages.Blog.ArticleDetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
