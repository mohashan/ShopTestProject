#pragma checksum "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\Shared\_Notification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34a2df29f50a0804548c676cc8ffe76f34cce1d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Notification), @"mvc.1.0.view", @"/Views/Shared/_Notification.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Notification.cshtml", typeof(AspNetCore.Views_Shared__Notification))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34a2df29f50a0804548c676cc8ffe76f34cce1d3", @"/Views/Shared/_Notification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"672decb5e98330d47408f442ab2ef988c17b56a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Notification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\Shared\_Notification.cshtml"
  
	var succesKey = $"Notification.{OfoghKuroshShopProject.Models.ViewModels.AlertStyles.Success}";
	var dangerKey = $"Notification.{OfoghKuroshShopProject.Models.ViewModels.AlertStyles.Danger}";
	var warningKey = $"Notification.{OfoghKuroshShopProject.Models.ViewModels.AlertStyles.Warning}";
	var informationKey = $"Notification.{OfoghKuroshShopProject.Models.ViewModels.AlertStyles.Information}";

	var successMessage = TempData[succesKey]?.ToString() ?? ViewData[succesKey]?.ToString();
	var dangerMessage = TempData[dangerKey]?.ToString() ?? ViewData[dangerKey]?.ToString();
	var warningMessage = TempData[warningKey]?.ToString() ?? ViewData[warningKey]?.ToString();
	var informationMessage = TempData[informationKey]?.ToString() ?? ViewData[informationKey]?.ToString();

#line default
#line hidden
            BeginContext(789, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\Shared\_Notification.cshtml"
 if (!string.IsNullOrEmpty(successMessage))
{

#line default
#line hidden
            BeginContext(839, 171, true);
            WriteLiteral("\t<div class=\"alert alert-success alert-dismissable\" id=\"success-alert\">\r\n\t\t<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>\r\n\t\t");
            EndContext();
            BeginContext(1011, 14, false);
#line 17 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\Shared\_Notification.cshtml"
   Write(successMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1025, 11, true);
            WriteLiteral("\r\n\t</div>\r\n");
            EndContext();
#line 19 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\Shared\_Notification.cshtml"
}

#line default
#line hidden
            BeginContext(1039, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\Shared\_Notification.cshtml"
 if (!string.IsNullOrEmpty(dangerMessage))
{

#line default
#line hidden
            BeginContext(1088, 170, true);
            WriteLiteral("\t<div class=\"alert alert-danger alert-dismissable\" id=\"success-alert\">\r\n\t\t<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>\r\n\t\t");
            EndContext();
            BeginContext(1259, 13, false);
#line 25 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\Shared\_Notification.cshtml"
   Write(dangerMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1272, 11, true);
            WriteLiteral("\r\n\t</div>\r\n");
            EndContext();
#line 27 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\Shared\_Notification.cshtml"
}

#line default
#line hidden
#line 28 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\Shared\_Notification.cshtml"
 if (!string.IsNullOrEmpty(warningMessage))
{

#line default
#line hidden
            BeginContext(1334, 171, true);
            WriteLiteral("\t<div class=\"alert alert-warning alert-dismissable\" id=\"success-alert\">\r\n\t\t<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>\r\n\t\t");
            EndContext();
            BeginContext(1506, 14, false);
#line 32 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\Shared\_Notification.cshtml"
   Write(warningMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1520, 11, true);
            WriteLiteral("\r\n\t</div>\r\n");
            EndContext();
#line 34 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\Shared\_Notification.cshtml"
}

#line default
#line hidden
#line 35 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\Shared\_Notification.cshtml"
 if (!string.IsNullOrEmpty(informationMessage))
{

#line default
#line hidden
            BeginContext(1586, 168, true);
            WriteLiteral("\t<div class=\"alert alert-info alert-dismissable\" id=\"success-alert\">\r\n\t\t<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>\r\n\t\t");
            EndContext();
            BeginContext(1755, 18, false);
#line 39 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\Shared\_Notification.cshtml"
   Write(informationMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1773, 11, true);
            WriteLiteral("\r\n\t</div>\r\n");
            EndContext();
#line 41 "D:\Programming\Asp.net Core\OKShop\OfoghKuroshShopProject\OfoghKuroshShopProject\Views\Shared\_Notification.cshtml"
}

#line default
#line hidden
            BeginContext(1787, 268, true);
            WriteLiteral(@"<script>
	$(document).ready(function () {
		$(""#success-alert"").hide();
		$(""#success-alert"").show(function showAlert() {
			$(""#success-alert"").fadeTo(2000, 500).slideUp(500, function () {
				$(""#success-alert"").slideUp(500);
			});
		});
	});


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
