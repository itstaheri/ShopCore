#pragma checksum "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ddf37de79233b5c5de538db57eb92cc3333dfb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_Category), @"mvc.1.0.razor-page", @"/Pages/Category.cshtml")]
namespace ServiceHost.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ddf37de79233b5c5de538db57eb92cc3333dfb7", @"/Pages/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Category : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"


                <!--shop banner area start-->
        
                <!--shop banner area end-->
                <!--shop toolbar start-->
             
                <!--shop wrapper start-->
                <div class=""row no-gutters shop_wrapper"">

");
#nullable restore
#line 16 "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml"
                     foreach (var item in Model.categories)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml"
                         foreach (var product in item.products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-lg-3 col-md-4 col-12 "">
                                <article class=""single_product"">
                                    <figure>
                                        <div class=""product_thumb"">
                                            <a class=""primary_img"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7ddf37de79233b5c5de538db57eb92cc3333dfb74394", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 827, "~/Img/ProductImages/", 827, 20, true);
#nullable restore
#line 24 "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml"
AddHtmlAttributeValue("", 847, product.ProductName, 847, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 867, "/", 867, 1, true);
#nullable restore
#line 24 "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml"
AddHtmlAttributeValue("", 868, product.Picture, 868, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml"
AddHtmlAttributeValue("", 893, product.PictureAlt, 893, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml"
AddHtmlAttributeValue("", 921, product.PictureTitle, 921, 21, false);

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
            WriteLiteral("</a>\r\n");
#nullable restore
#line 26 "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml"
                                             if (product.DiscountRate > 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"label_product\">\r\n                                                    <span class=\"label_sale\">");
#nullable restore
#line 29 "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml"
                                                                        Write(product.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\r\n                                                </div>\r\n");
#nullable restore
#line 31 "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""action_links"">
                                                <ul>
                                                    <li class=""wishlist""><a href=""wishlist.html"" title=""افزودن به علاقه‌مندی‌ها""><i class=""ion-android-favorite-outline""></i></a></li>
                                                    <li class=""compare""><a href=""#"" title=""افزودن به مقایسه""><i class=""ion-ios-settings-strong""></i></a></li>
                                                    <li class=""quick_button""><a href=""#"" data-toggle=""modal"" data-target=""#modal_box"" title=""مشاهده سریع""><i class=""ion-ios-search-strong""></i></a></li>
                                                </ul>
                                            </div>
                                        </div>

                                        <div class=""product_content grid_content"">
                                            <div class=""product_content_inner"">
                               ");
            WriteLiteral("                 <h4 class=\"product_name\"><a href=\"product-details.html\">");
#nullable restore
#line 43 "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml"
                                                                                                   Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                               \r\n                                                <div class=\"price_box\">\r\n                                                    <span class=\"old_price\">");
#nullable restore
#line 46 "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml"
                                                                       Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                                                    <span class=\"current_price\">");
#nullable restore
#line 47 "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml"
                                                                           Write(product.PriceAfterDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                                                </div>\r\n                                                <div class=\"text\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ddf37de79233b5c5de538db57eb92cc3333dfb710540", async() => {
#nullable restore
#line 50 "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml"
                                                                                                      Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CategoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml"
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
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""add_to_cart"">
                                                <a href=""cart.html"" title=""افزودن به سبد"">افزودن به سبد</a>
                                            </div>
                                        </div>
                                        <div class=""product_content list_content"">
                                            <h4 class=""product_name""><a href=""product-details.html"">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از</a></h4>
                                            <div class=""product_rating"">
                                                <ul>
                                                    <li><a href=""#""><i class=""ion-android-star-outline""></i></a></li>
                                                    <li><a href=""#""><i class=""ion-android-star-outline""></i></a></li>
                         ");
            WriteLiteral(@"                           <li><a href=""#""><i class=""ion-android-star-outline""></i></a></li>
                                                    <li><a href=""#""><i class=""ion-android-star-outline""></i></a></li>
                                                    <li><a href=""#""><i class=""ion-android-star-outline""></i></a></li>
                                                </ul>
                                            </div>
                                            <div class=""price_box"">
                                                <span class=""old_price"">80,000 تومان</span>
                                                <span class=""current_price"">70,000 تومان</span>
                                            </div>
                                            <div class=""product_desc"">
                                                <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که ");
            WriteLiteral(@"لازم است و برای شرایط فعلی</p>
                                            </div>
                                            <div class=""add_to_cart"">
                                                <a href=""cart.html"" title=""افزودن به سبد"">افزودن به سبد</a>
                                            </div>
                                            <div class=""action_links"">
                                                <ul>
                                                    <li class=""wishlist""><a href=""wishlist.html"" title=""افزودن به علاقه‌مندی‌ها""><i class=""ion-android-favorite-outline""></i> افزودن به علاقه‌مندی‌ها</a></li>
                                                    <li class=""compare""><a href=""#"" title=""افزودن به مقایسه""><i class=""ion-ios-settings-strong""></i> مقایسه</a></li>
                                                    <li class=""quick_button""><a href=""#"" data-toggle=""modal"" data-target=""#modal_box"" title=""مشاهده سریع""><i class=""ion-ios-search-strong""></i> نمایش سریع</a></");
            WriteLiteral(@"li>
                                                </ul>
                                            </div>
                                        </div>
                                    </figure>
                                </article>
                            </div>
");
#nullable restore
#line 89 "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\ShopCore\ShopCore\ServiceHost\Pages\Category.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>

                <div class=""shop_toolbar t_bottom"">
                    <div class=""pagination"">
                        <ul>
                            <li class=""current"">1</li>
                            <li><a href=""#"">2</a></li>
                            <li><a href=""#"">3</a></li>
                            <li class=""next""><a href=""#"">بعدی</a></li>
                            <li><a href=""#""><i class=""fa fa-angle-double-left""></i></a></li>
                        </ul>
                    </div>
                </div>
                <!--shop toolbar end-->
                <!--shop wrapper end-->
            </div>
        </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.CategoryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.CategoryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.CategoryModel>)PageContext?.ViewData;
        public ServiceHost.Pages.CategoryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
