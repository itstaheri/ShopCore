#pragma checksum "D:\Projects\ShopCore\ShopCore\ShopCore\ServiceHost\Pages\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b95c06ee533275706b7d940734d9818cefa5703"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_Result), @"mvc.1.0.razor-page", @"/Pages/Result.cshtml")]
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
#line 1 "D:\Projects\ShopCore\ShopCore\ShopCore\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b95c06ee533275706b7d940734d9818cefa5703", @"/Pages/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Result : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Title", async() => {
                WriteLiteral(" <title>");
#nullable restore
#line 6 "D:\Projects\ShopCore\ShopCore\ShopCore\ServiceHost\Pages\Result.cshtml"
                   Write(ViewData["Title"] ="نتیجه ");

#line default
#line hidden
#nullable disable
                WriteLiteral(" | موبایل شاپ </title>");
            }
            );
            WriteLiteral("\r\n<div class=\"checkout_page_bg\">\r\n    <div class=\"container\">\r\n        <div class=\"col-lg-12\">\r\n\r\n");
#nullable restore
#line 12 "D:\Projects\ShopCore\ShopCore\ShopCore\ServiceHost\Pages\Result.cshtml"
             if (!string.IsNullOrWhiteSpace(Model.message))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-success\">\r\n                    <p>");
#nullable restore
#line 15 "D:\Projects\ShopCore\ShopCore\ShopCore\ServiceHost\Pages\Result.cshtml"
                  Write(Model.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                </div>\r\n");
#nullable restore
#line 18 "D:\Projects\ShopCore\ShopCore\ShopCore\ServiceHost\Pages\Result.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.ResultModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ResultModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ResultModel>)PageContext?.ViewData;
        public ServiceHost.Pages.ResultModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
