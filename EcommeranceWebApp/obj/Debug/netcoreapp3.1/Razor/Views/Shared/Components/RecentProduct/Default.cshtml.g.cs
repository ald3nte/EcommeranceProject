#pragma checksum "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Shared\Components\RecentProduct\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5423ecc9db59662f1cc596465eedee5a4d2295d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RecentProduct_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RecentProduct/Default.cshtml")]
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
#line 1 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\_ViewImports.cshtml"
using EcommeranceWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\_ViewImports.cshtml"
using EcommeranceWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\_ViewImports.cshtml"
using EcommeranceWebApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5423ecc9db59662f1cc596465eedee5a4d2295d4", @"/Views/Shared/Components/RecentProduct/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd33df34a3efbbe0533bd069379292ca5370f3d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RecentProduct_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductDetailsDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <!-- Related Product Section Begin -->
    <section class=""related-product spad"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 text-center"">
                    <div class=""section-title"">
                        <h2>Related Products</h2>
                    </div>
                </div>
            </div>
            <div class=""row"">

");
#nullable restore
#line 14 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Shared\Components\RecentProduct\Default.cshtml"
                 foreach (var product in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-sm-6\">\r\n                    <div class=\"single-product-item\">\r\n                        <figure>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5423ecc9db59662f1cc596465eedee5a4d2295d45014", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 776, "\"", 831, 1);
#nullable restore
#line 19 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Shared\Components\RecentProduct\Default.cshtml"
WriteAttributeValue("", 782, product.ProductFotosDTO.FirstOrDefault().FotoUrl, 782, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 832, "\"", 838, 0);
                EndWriteAttribute();
                WriteLiteral(">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productGUID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Shared\Components\RecentProduct\Default.cshtml"
                                                                                            WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productGUID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productGUID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productGUID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Shared\Components\RecentProduct\Default.cshtml"
                             if (product.CreatedAt > @DateTime.Now.AddDays(-7))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"p-status\">new</div>\r\n");
#nullable restore
#line 23 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Shared\Components\RecentProduct\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </figure>\r\n                        <div class=\"product-text\">\r\n                            <h6>");
#nullable restore
#line 26 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Shared\Components\RecentProduct\Default.cshtml"
                           Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <p>");
#nullable restore
#line 27 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Shared\Components\RecentProduct\Default.cshtml"
                          Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 31 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Shared\Components\RecentProduct\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n    <!-- Related Product Section End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductDetailsDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
