#pragma checksum "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\Admin\AdminFriends.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28c0187ff71be9bf548017a763cfbfb289cbe821"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminFriends), @"mvc.1.0.view", @"/Views/Admin/AdminFriends.cshtml")]
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
#line 1 "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\_ViewImports.cshtml"
using init;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\Admin\AdminFriends.cshtml"
using init.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28c0187ff71be9bf548017a763cfbfb289cbe821", @"/Views/Admin/AdminFriends.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0fe8630092d5c9dc41adaa638528dc7c1ff05c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminFriends : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<hayvanlar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\Admin\AdminFriends.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<main>

    <div class=""card mb-4"">
        <div class=""card-header"">
            <i class=""fas fa-table me-1""></i>
            Sahiplenilmeyi Bekleyen Dostlarımız
        </div>
        <div class=""card-body"">
            <table id=""datatablesSimple"">
                <thead>
                    <tr>
                        <th>KATEGORİ</th>
                        <th>YAŞ</th>
                        <th>İSİM</th>
                        <th>SİL</th>
                        <th>GÜNCELLE</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                    </tr>
                </tfoot>
                <tbody>
");
#nullable restore
#line 33 "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\Admin\AdminFriends.cshtml"
                     foreach (var x in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 36 "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\Admin\AdminFriends.cshtml"
                           Write(x.katagori);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\Admin\AdminFriends.cshtml"
                           Write(x.yas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\Admin\AdminFriends.cshtml"
                           Write(x.isim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1110, "\"", 1132, 2);
            WriteAttributeValue("", 1117, "hayvanSil/", 1117, 10, true);
#nullable restore
#line 39 "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\Admin\AdminFriends.cshtml"
WriteAttributeValue("", 1127, x.id, 1127, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">SİL</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1205, "\"", 1229, 2);
            WriteAttributeValue("", 1212, "hayvanGetir/", 1212, 12, true);
#nullable restore
#line 40 "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\Admin\AdminFriends.cshtml"
WriteAttributeValue("", 1224, x.id, 1224, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">GÜNCELLE</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\Admin\AdminFriends.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n\r\n            </table>\r\n            <td><a href=\"YeniHayvan\" class=\"btn btn-info\">Yeni Hayvan</a></td>\r\n        </div>\r\n\r\n\r\n\r\n\r\n\r\n</main>");
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