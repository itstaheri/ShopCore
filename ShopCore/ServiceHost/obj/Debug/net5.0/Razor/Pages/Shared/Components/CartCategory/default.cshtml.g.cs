#pragma checksum "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\CartCategory\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e9f72fb759c676ee65b339003b2a11f672ea300"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.CartCategory.Pages_Shared_Components_CartCategory_default), @"mvc.1.0.view", @"/Pages/Shared/Components/CartCategory/default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.CartCategory
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e9f72fb759c676ee65b339003b2a11f672ea300", @"/Pages/Shared/Components/CartCategory/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_CartCategory_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SM.Application.Contracts.ProductCategory.ProductCategoryViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <div class=\"categories_product_area mb-55\">\r\n        <div class=\"container\">\r\n            <div class=\"categories_product_inner\">\r\n");
#nullable restore
#line 7 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\CartCategory\default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"single_categories_product\">\r\n                        <div class=\"categories_product_content\">\r\n                            <h4><a href=\"shop.html\">");
#nullable restore
#line 11 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\CartCategory\default.cshtml"
                                               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                            <p>");
#nullable restore
#line 12 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\CartCategory\default.cshtml"
                          Write(item.ProductCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" محصول</p>\r\n                        </div>\r\n                        <div class=\"categories_product_thumb\">\r\n                            <a href=\"shop.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4e9f72fb759c676ee65b339003b2a11f672ea3004809", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 706, "~/Img/CategoryImages/", 706, 21, true);
#nullable restore
#line 15 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\CartCategory\default.cshtml"
AddHtmlAttributeValue("", 727, item.CategoryName, 727, 18, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 745, "/", 745, 1, true);
#nullable restore
#line 15 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\CartCategory\default.cshtml"
AddHtmlAttributeValue("", 746, item.Picture, 746, 13, false);

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
            WriteLiteral("</a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 18 "D:\ShopCore\ShopCore\ServiceHost\Pages\Shared\Components\CartCategory\default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SM.Application.Contracts.ProductCategory.ProductCategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591