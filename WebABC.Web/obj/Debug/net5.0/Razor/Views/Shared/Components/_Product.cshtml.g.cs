#pragma checksum "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\Shared\Components\_Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f01a18a21868da2088890d309afdd0c2f0665fbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Product), @"mvc.1.0.view", @"/Views/Shared/Components/_Product.cshtml")]
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
#line 1 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\_ViewImports.cshtml"
using WebABC.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\_ViewImports.cshtml"
using WebABC.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\_ViewImports.cshtml"
using WebABC.Web.Dto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f01a18a21868da2088890d309afdd0c2f0665fbd", @"/Views/Shared/Components/_Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f29df2f048a6f955f9b24a7e2fb998cca5b26226", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:330px;width:270px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 23, "\"", 69, 3);
            WriteAttributeValue("", 31, "product-item", 31, 12, true);
            WriteAttributeValue(" ", 43, "all", 44, 4, true);
#nullable restore
#line 2 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\Shared\Components\_Product.cshtml"
WriteAttributeValue(" ", 47, Model.Unit.ToLower(), 48, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"pi-pic\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f01a18a21868da2088890d309afdd0c2f0665fbd5276", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 117, "~/publics/img/products/", 117, 23, true);
#nullable restore
#line 4 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\Shared\Components\_Product.cshtml"
AddHtmlAttributeValue("", 140, Model.Image, 140, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\Shared\Components\_Product.cshtml"
         if (Model.UnitPrice != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"sale\">Sale</div>\r\n");
#nullable restore
#line 8 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\Shared\Components\_Product.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"icon\">\r\n            <i class=\"icon_heart_alt\"></i>\r\n        </div>\r\n        <ul>\r\n            <li class=\"w-icon active\"><a class=\"item\" data-item=\"");
#nullable restore
#line 13 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\Shared\Components\_Product.cshtml"
                                                            Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"icon_cart_alt\"></i></a></li>\r\n            <li class=\"quick-view\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f01a18a21868da2088890d309afdd0c2f0665fbd7949", async() => {
                WriteLiteral("+ Quick View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\Shared\Components\_Product.cshtml"
                                                                                         WriteLiteral(Model.Id);

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
            WriteLiteral("</li>\r\n            <li class=\"w-icon\"><a href=\"#\"><i class=\"fa fa-random\"></i></a></li>\r\n        </ul>\r\n    </div>\r\n    <div class=\"pi-text\">\r\n        <div class=\"catagory-name\">");
#nullable restore
#line 19 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\Shared\Components\_Product.cshtml"
                              Write(Model.Unit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <a href=\"#\">\r\n            <h5>");
#nullable restore
#line 21 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\Shared\Components\_Product.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </a>\r\n        <div class=\"product-price\">\r\n");
#nullable restore
#line 24 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\Shared\Components\_Product.cshtml"
             if (Model.UnitPrice != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\Shared\Components\_Product.cshtml"
           Write(Model.PromotionPrice.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 27 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\Shared\Components\_Product.cshtml"
                 Write(Model.UnitPrice.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 28 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\Shared\Components\_Product.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\Shared\Components\_Product.cshtml"
           Write(Model.PromotionPrice.ToString("c"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\vs-workspace\dev\WebABC\WebABC.Web\Views\Shared\Components\_Product.cshtml"
                                                   
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
