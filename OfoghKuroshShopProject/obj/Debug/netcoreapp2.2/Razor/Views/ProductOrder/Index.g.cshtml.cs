#pragma checksum "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\ProductOrder\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "346c128e043a3ed1950d4fa1f4cb292dbf050e22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductOrder_Index), @"mvc.1.0.view", @"/Views/ProductOrder/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductOrder/Index.cshtml", typeof(AspNetCore.Views_ProductOrder_Index))]
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
#line 1 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\_ViewImports.cshtml"
using OfoghKuroshShopProject;

#line default
#line hidden
#line 2 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\_ViewImports.cshtml"
using OfoghKuroshShopProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"346c128e043a3ed1950d4fa1f4cb292dbf050e22", @"/Views/ProductOrder/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"672decb5e98330d47408f442ab2ef988c17b56a5", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductOrder_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OfoghKuroshShopProject.Models.ViewModels.ProductOrderVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\ProductOrder\Index.cshtml"
  
	ViewData["Title"] = "لیست اقلام";

#line default
#line hidden
            BeginContext(113, 159, true);
            WriteLiteral("\r\n<table class=\"table table-striped\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<td class=\"col-lg-6\">عنوان</td>\r\n\t\t\t<td class=\"col-lg-6\">مقدار</td>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
            EndContext();
#line 14 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\ProductOrder\Index.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
            BeginContext(309, 34, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td class=\"col-lg-6\">");
            EndContext();
            BeginContext(344, 16, false);
#line 17 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\ProductOrder\Index.cshtml"
                                Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(360, 32, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td class=\"col-lg-6\">");
            EndContext();
            BeginContext(393, 11, false);
#line 18 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\ProductOrder\Index.cshtml"
                                Write(item.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(404, 17, true);
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 20 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\ProductOrder\Index.cshtml"
		}

#line default
#line hidden
            BeginContext(426, 25, true);
            WriteLiteral("\t</tbody>\r\n\r\n\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OfoghKuroshShopProject.Models.ViewModels.ProductOrderVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
