#pragma checksum "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Shared\_ProductPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fa91b81c851aba4aa81b398f47cdbf341fa7bae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductPartial.cshtml")]
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
#line 1 "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\_ViewImports.cshtml"
using TaskNest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\_ViewImports.cshtml"
using TaskNest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\_ViewImports.cshtml"
using TaskNest.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fa91b81c851aba4aa81b398f47cdbf341fa7bae", @"/Views/Shared/_ProductPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c6bf3f5a72dc5107c9286c90c61434473c6e4ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("add-cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Shared\_ProductPartial.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-lg-1-5 col-md-4 col-12 col-sm-6"">
        <div class=""product-cart-wrap mb-30"">
            <div class=""product-img-action-wrap"">
                <div class=""product-img product-img-zoom"">
                    <a href=""shop-product-right.html"">
                        <img class=""default-img"" width=""190""");
            BeginWriteAttribute("src", " src=\"", 391, "\"", 476, 2);
            WriteAttributeValue("", 397, "assets/imgs/shop/", 397, 17, true);
#nullable restore
#line 9 "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Shared\_ProductPartial.cshtml"
WriteAttributeValue("", 414, item.ProductImages.FirstOrDefault(pi=>pi.IsFront==true).Image, 414, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 477, "\"", 483, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <img class=\"hover-img\" width=\"190\"");
            BeginWriteAttribute("src", " src=\"", 547, "\"", 631, 2);
            WriteAttributeValue("", 553, "assets/imgs/shop/", 553, 17, true);
#nullable restore
#line 10 "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Shared\_ProductPartial.cshtml"
WriteAttributeValue("", 570, item.ProductImages.FirstOrDefault(pi=>pi.IsBack==true).Image, 570, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 632, "\"", 638, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </a>
                </div>
                <div class=""product-action-1"">
                    <a aria-label=""Add To Wishlist"" class=""action-btn"" href=""shop-wishlist.html""><i class=""fi-rs-heart""></i></a>
                    <a aria-label=""Quick view"" class=""action-btn"" data-bs-toggle=""modal"" data-bs-target=""#quickViewModal""><i class=""fi-rs-eye""></i></a>
                </div>
                <div class=""product-badges product-badges-position product-badges-mrg"">
");
#nullable restore
#line 18 "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Shared\_ProductPartial.cshtml"
                     if (item.StockCount == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"hot\">Bitdi</span>\r\n");
#nullable restore
#line 21 "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Shared\_ProductPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"product-content-wrap\">\r\n                <div class=\"product-category\">\r\n                    <a href=\"shop-grid-right.html\">");
#nullable restore
#line 26 "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Shared\_ProductPartial.cshtml"
                                              Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n                <h2>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fa91b81c851aba4aa81b398f47cdbf341fa7bae8672", async() => {
#nullable restore
#line 28 "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Shared\_ProductPartial.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Shared\_ProductPartial.cshtml"
                                              WriteLiteral(item.Id);

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
            WriteLiteral("</h2>\r\n                <div class=\"product-rate-cover\">\r\n                    <div class=\"product-rate d-inline-block\">\r\n                        <div class=\"product-rating\"");
            BeginWriteAttribute("style", " style=\"", 1781, "\"", 1815, 3);
            WriteAttributeValue("", 1789, "width:", 1789, 6, true);
#nullable restore
#line 31 "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Shared\_ProductPartial.cshtml"
WriteAttributeValue(" ", 1795, item.Raiting*20, 1796, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1814, "%", 1814, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                    </div>\r\n                    <span class=\"font-small ml-5 text-muted\"> (");
#nullable restore
#line 33 "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Shared\_ProductPartial.cshtml"
                                                          Write(item.Raiting);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"product-card-bottom\">\r\n                    <div class=\"product-price\">\r\n                        <span>$");
#nullable restore
#line 40 "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Shared\_ProductPartial.cshtml"
                          Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                    </div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fa91b81c851aba4aa81b398f47cdbf341fa7bae12723", async() => {
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"add\"><i class=\"fi-rs-shopping-cart mr-5\"></i>Add </button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Shared\_ProductPartial.cshtml"
                                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 50 "C:\Users\tu7hnsxs1\Desktop\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Shared\_ProductPartial.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
