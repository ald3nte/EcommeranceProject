#pragma checksum "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Product\ProductPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3764ad81d78ff8f67673c73e3ca85acfcc15b477"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductPage), @"mvc.1.0.view", @"/Views/Product/ProductPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3764ad81d78ff8f67673c73e3ca85acfcc15b477", @"/Views/Product/ProductPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd33df34a3efbbe0533bd069379292ca5370f3d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDescriptionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/add.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!-- Page Add Section Begin -->
<section class=""page-add"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""page-breadcrumb"">
                    <h2>Shirts<span>.</span></h2>
                    <a href=""#"">Home</a>
                    <a class=""active"" href=""#""></a>
                </div>
            </div>
            <div class=""col-lg-8"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3764ad81d78ff8f67673c73e3ca85acfcc15b4774573", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
    </div>
</section>
<!-- Page Add Section End -->
<!-- Product Page Section Beign -->
<section class=""product-page"">
    <div class=""container"">
        <div class=""product-control"">
            <a href=""#"">Previous</a>
            <a href=""#"">Next</a>
        </div>
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""product-slider owl-carousel"">
");
#nullable restore
#line 30 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Product\ProductPage.cshtml"
                     if (Model.Product.ProductFotosDTO != null)
                    {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Product\ProductPage.cshtml"
                     foreach (var ProductFoto in Model.Product.ProductFotosDTO)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"product-img\">\r\n\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1195, "\"", 1221, 1);
#nullable restore
#line 36 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Product\ProductPage.cshtml"
WriteAttributeValue("", 1201, ProductFoto.FotoUrl, 1201, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1222, "\"", 1252, 1);
#nullable restore
#line 36 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Product\ProductPage.cshtml"
WriteAttributeValue("", 1228, ProductFoto.Description, 1228, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 38 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Product\ProductPage.cshtml"
             if (@Model.Product.CreatedAt > @DateTime.Now.AddDays(-7))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"p-status\">\r\n             <figure>\r\n                New\r\n             </figure>\r\n            </div>\r\n");
#nullable restore
#line 45 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Product\ProductPage.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 47 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Product\ProductPage.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Product\ProductPage.cshtml"
                     
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"product-content\">\r\n                    <h2>");
#nullable restore
#line 53 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Product\ProductPage.cshtml"
                   Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <div class=\"pc-meta\">\r\n                        <h5>");
#nullable restore
#line 55 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Product\ProductPage.cshtml"
                       Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" zł</h5>
                        <div class=""rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                        </div>
                    </div>
                    <p>
                        ");
#nullable restore
#line 65 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Product\ProductPage.cshtml"
                   Write(Html.Raw(@Model.Product.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <ul class=\"tags\">\r\n                        <li><span>Collection :</span> ");
#nullable restore
#line 68 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Product\ProductPage.cshtml"
                                                 Write(Model.Product.Collection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>Mark :</span> ");
#nullable restore
#line 69 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Product\ProductPage.cshtml"
                                           Write(Model.Product.Mark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                    <div class=\"product-quantity\">\r\n                        <div class=\"pro-qty\">\r\n                            <input type=\"text\" value=\"1\"");
            BeginWriteAttribute("max", " max=\"", 2705, "\"", 2734, 1);
#nullable restore
#line 73 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Product\ProductPage.cshtml"
WriteAttributeValue("", 2711, Model.Product.Quantity, 2711, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                    <a href=""#"" class=""primary-btn pc-btn"">Add to cart</a>
                    <ul class=""p-info"">
                        <li>Product Information</li>
                        <li>Reviews</li>
                        <li>Product Care</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Product Page Section End -->
");
#nullable restore
#line 88 "C:\Users\sjsha\Documents\Project\EcommeranceProject\EcommeranceWebApp\Views\Product\ProductPage.cshtml"
Write(await Component.InvokeAsync("RecentProduct"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDescriptionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
