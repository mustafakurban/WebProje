#pragma checksum "C:\Users\mustafa\Source\Repos\mustafakurban\WebProje\init\Views\hayvanlar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f99cf8b812f5b301e0218d633e536b438d5d498"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_hayvanlar_Index), @"mvc.1.0.view", @"/Views/hayvanlar/Index.cshtml")]
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
#line 1 "C:\Users\mustafa\Source\Repos\mustafakurban\WebProje\init\Views\_ViewImports.cshtml"
using init;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mustafa\Source\Repos\mustafakurban\WebProje\init\Views\hayvanlar\Index.cshtml"
using init.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f99cf8b812f5b301e0218d633e536b438d5d498", @"/Views/hayvanlar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0fe8630092d5c9dc41adaa638528dc7c1ff05c7", @"/Views/_ViewImports.cshtml")]
    public class Views_hayvanlar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<hayvanlar>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/hayvanlar_Index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "hayvanlar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "sahiplen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mustafa\Source\Repos\mustafakurban\WebProje\init\Views\hayvanlar\Index.cshtml"
  
    ViewBag.Title = "Dostlarımız";
    var directroy = "";
    var itemCount = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f99cf8b812f5b301e0218d633e536b438d5d4985803", async() => {
                WriteLiteral("\r\n    <title>Dostlarımız</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f99cf8b812f5b301e0218d633e536b438d5d4986099", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f99cf8b812f5b301e0218d633e536b438d5d4987981", async() => {
                WriteLiteral("\r\n\r\n\r\n    <div>\r\n");
#nullable restore
#line 20 "C:\Users\mustafa\Source\Repos\mustafakurban\WebProje\init\Views\hayvanlar\Index.cshtml"
     foreach (var item in from i in Model.Select((value, index) => new { value, index }) group i.value by i.index / 3 into g select g)
    {


#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container-fluid\">\r\n            <div class=\"row\">\r\n\r\n");
#nullable restore
#line 26 "C:\Users\mustafa\Source\Repos\mustafakurban\WebProje\init\Views\hayvanlar\Index.cshtml"
                 foreach (var category in item)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-xs-4 col-sm-4 col-md-4\">\r\n                        \r\n");
#nullable restore
#line 30 "C:\Users\mustafa\Source\Repos\mustafakurban\WebProje\init\Views\hayvanlar\Index.cshtml"
                             switch (category.katagori)
                            {
                                case "Köpek":
                                    directroy = "/css/animal_images/dog.jpg";
                                    break;
                                case "Kedi":
                                    directroy = "/css/animal_images/cat.jpg";
                                    break;
                                case "Kaplumbağa":
                                    directroy = "/css/animal_images/turtle.jpg";
                                    break;
                                default:
                                    break;
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"card row\" style=\"width: 18rem;\">\r\n                                <img width=\"300\" height=\"240\" class=\"card-img-top\"");
                BeginWriteAttribute("src", " src=", 1533, "", 1548, 1);
#nullable restore
#line 46 "C:\Users\mustafa\Source\Repos\mustafakurban\WebProje\init\Views\hayvanlar\Index.cshtml"
WriteAttributeValue("", 1538, directroy, 1538, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=", 1548, "", 1571, 1);
#nullable restore
#line 46 "C:\Users\mustafa\Source\Repos\mustafakurban\WebProje\init\Views\hayvanlar\Index.cshtml"
WriteAttributeValue("", 1553, category.katagori, 1553, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <div class=\"card-body\">\r\n                                    <h5 class=\"card-title\">");
#nullable restore
#line 48 "C:\Users\mustafa\Source\Repos\mustafakurban\WebProje\init\Views\hayvanlar\Index.cshtml"
                                                      Write(category.isim);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                    <p class=\"card-text fw-bold\"> ");
#nullable restore
#line 49 "C:\Users\mustafa\Source\Repos\mustafakurban\WebProje\init\Views\hayvanlar\Index.cshtml"
                                                             Write(category.katagori);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p class=\"card-text fw-bold\">Dostumuzun yaşı : ");
#nullable restore
#line 50 "C:\Users\mustafa\Source\Repos\mustafakurban\WebProje\init\Views\hayvanlar\Index.cshtml"
                                                                              Write(category.yas);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f99cf8b812f5b301e0218d633e536b438d5d49812088", async() => {
                    WriteLiteral("Sahiplen");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <br />\r\n                        \r\n                    </div>\r\n");
#nullable restore
#line 57 "C:\Users\mustafa\Source\Repos\mustafakurban\WebProje\init\Views\hayvanlar\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div> <!-- End row -->\r\n        </div><!-- End container -->\r\n");
#nullable restore
#line 61 "C:\Users\mustafa\Source\Repos\mustafakurban\WebProje\init\Views\hayvanlar\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n\r\n    \r\n\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<hayvanlar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
