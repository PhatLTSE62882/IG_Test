#pragma checksum "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\Shared\_ReadMePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47dd3fd7a3738b5c00263fb0b3546e9c8c77381b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ReadMePartial), @"mvc.1.0.view", @"/Views/Shared/_ReadMePartial.cshtml")]
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
#line 1 "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\_ViewImports.cshtml"
using IG_Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\_ViewImports.cshtml"
using IG_Test.Helpers.Shared.Constant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\_ViewImports.cshtml"
using IG_Test.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\_ViewImports.cshtml"
using IG_Test_Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47dd3fd7a3738b5c00263fb0b3546e9c8c77381b", @"/Views/Shared/_ReadMePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fae05152bd12df52c52fd6a588053595c7ebcf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ReadMePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id=""readmeModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title float-left""> Hướng dẫn sử dụng hệ thống</h4>
            </div>
            <div class=""modal-body"">
                <div class=""container"">
                    <div class=""row"">
                        <div style=""width:100%"">
                            <div class=""card card-signin my-5"">
                                <div class=""card-body"">
                                    <div class=""text-center"">
                                        <p>Passcode đăng nhập cho dịch vụ vệ sinh là : vesinh");
            WriteLiteral("@#</p>\r\n                                        <p>Passcode đăng nhập cho dịch vụ bảo vệ là : baove");
            WriteLiteral(@"@#</p>
                                        <p>sau khi đăng nhập , click vào tùy chọn > xem đánh giá để xem tất cả đánh giá hiện tại.</p>
                                        <p>Link repo của bài test : https://github.com/PhatLTSE62882/IG_Test</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
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
