#pragma checksum "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\Admin\AdminIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7a24395db80b00ceb6c5db0f35214801896e5f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminIndex), @"mvc.1.0.view", @"/Views/Admin/AdminIndex.cshtml")]
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
#line 1 "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\Admin\AdminIndex.cshtml"
using init.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7a24395db80b00ceb6c5db0f35214801896e5f5", @"/Views/Admin/AdminIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0fe8630092d5c9dc41adaa638528dc7c1ff05c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dbCounter>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\Admin\AdminIndex.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<main>
    <div class=""container-fluid px-4"">
        <h1 class=""mt-4"">Dashboard</h1>
        <ol class=""breadcrumb mb-4"">
            <li class=""breadcrumb-item active"">Dashboard</li>
        </ol>
        <div class=""row"">
            <div class=""col-xl-4 col-md-8"">
                <div class=""card bg-primary text-white mb-4"">
                    <div class=""card-body"">Kullanıcı Sayısı</div>
                    <div class=""card-footer d-flex align-items-center justify-content-center"">
                        ");
#nullable restore
#line 20 "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\Admin\AdminIndex.cshtml"
                   Write(Model.usersCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""col-xl-4 col-md-8"">
                <div class=""card bg-warning text-white mb-4"">
                    <div class=""card-body"">Toplanan Bağış</div>
                    <div class=""card-footer d-flex align-items-center justify-content-center"">
                        $");
#nullable restore
#line 28 "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\Admin\AdminIndex.cshtml"
                    Write(Model.aidCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            
            <div class=""col-xl-4 col-md-8"">
                <div class=""card bg-danger text-white mb-4"">
                    <div class=""card-body"">Sahiplenilmeyi Bekleyen Dostlarımız</div>
                    <div class=""card-footer d-flex align-items-center justify-content-center"">
                        ");
#nullable restore
#line 37 "C:\Users\rammf\Documents\GitHub\WebProje\init\Views\Admin\AdminIndex.cshtml"
                   Write(Model.friendsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dbCounter> Html { get; private set; }
    }
}
#pragma warning restore 1591
