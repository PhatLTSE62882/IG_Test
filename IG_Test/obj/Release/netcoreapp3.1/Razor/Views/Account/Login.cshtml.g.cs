#pragma checksum "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99f472a6502629975ecd9ec615f193c2d0f32f9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f472a6502629975ecd9ec615f193c2d0f32f9e", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fae05152bd12df52c52fd6a588053595c7ebcf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<IG_Service>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;width:50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/login/arrow-button.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-signin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-9 col-md-7 col-lg-5 mx-auto"">
            <div class=""card card-signin my-5"" style=""background-color:darkred"">
                <div class=""card-body"">
                    <div class=""text-center"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99f472a6502629975ecd9ec615f193c2d0f32f9e6195", async() => {
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
            WriteLiteral("\r\n                    </div>\r\n                    <h5 class=\"card-title text-center\" style=\"color:whitesmoke\">Đăng nhập</h5>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99f472a6502629975ecd9ec615f193c2d0f32f9e7464", async() => {
                WriteLiteral(@"
                        <div class=""form-label-group"">
                            <label for=""inputPassword"" style=""color:whitesmoke"">Passcode</label>
                            <div class=""row"">
                                <div class=""col-md-11"">
                                    <input type=""password"" id=""inputPassword"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 983, "\"", 997, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                </div>
                                <div class=""col-md-1"">
                                    <i class=""fa fa-eye-slash"" aria-hidden=""true""></i>
                                </div>
                            </div>
                        </div>
                        <p style=""color:red"" id=""passcode-error""></p>
                        <br>
                        <br>

                        <label style=""color:whitesmoke""><strong>Chọn loại dịch vụ</strong></label>
                        <div class=""row"">
");
#nullable restore
#line 34 "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\Account\Login.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"col-md-5 text-center pointer border-service\"");
                BeginWriteAttribute("onclick", "\r\n                                     onclick=\"", 1755, "\"", 1837, 3);
                WriteAttributeValue("", 1803, "chooseService(\'", 1803, 15, true);
#nullable restore
#line 37 "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\Account\Login.cshtml"
WriteAttributeValue("", 1818, item.serviceCode, 1818, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1835, "\')", 1835, 2, true);
                EndWriteAttribute();
                WriteLiteral("\r\n                                     data-id=\"");
#nullable restore
#line 38 "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\Account\Login.cshtml"
                                         Write(item.serviceCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99f472a6502629975ecd9ec615f193c2d0f32f9e10137", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1953, "~/", 1953, 2, true);
#nullable restore
#line 39 "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\Account\Login.cshtml"
AddHtmlAttributeValue("", 1955, item.serviceImage, 1955, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <h6 class=\"text-center\" style=\"color:red\"> ");
#nullable restore
#line 40 "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\Account\Login.cshtml"
                                                                          Write(item.serviceName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                </div>\r\n");
#nullable restore
#line 42 "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\Account\Login.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                        <p style=""color:red"" id=""service-error""></p>

                        <hr class=""my-4"">
                        <button class=""btn btn-lg btn-danger btn-block text-uppercase"" onclick=""loginService()"" type=""button"">Bắt đầu đánh giá</button>

                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
    </div>
</div>

<script>
    var serviceCode = """";
    function chooseService(item) {
        var element = $('[data-id=' + item + ']');
        serviceCode = item;
        console.log(serviceCode)
        if (element.css('background-color') != 'rgba(0, 0, 0, 0)') {
            element.css('background-color', 'transparent');
        } else {
            element.css('background-color', 'white');
        }
    }

    function loginService() {
        var passcode = $('#inputPassword').val();

        if (passcode == null || passcode == undefined || passcode.length == 0) {
            setErrorById('passcode-error', 'Vui lòng nhập passcode');
            return;
        } else {
            setErrorById('passcode-error', '');
        }
        if (serviceCode.length == 0) {
            setErrorById('service-error', 'Vui lòng chọn dịch vụ');
            return;
        }else {
            setErrorById('service-error', '')");
            WriteLiteral(";\r\n        }\r\n\r\n            $.ajax({\r\n            type: \"POST\",\r\n            url: \"");
#nullable restore
#line 87 "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\Account\Login.cshtml"
             Write(Url.Action("Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: { serviceCode: serviceCode, passCode: passcode},
            dataType: ""text"",
            success: function (msg) {
                window.location.href = ""/rating/rate"";
            },
            error: function (req, status, error) {
                setErrorById('passcode-error', 'Vui lòng kiểm tra lại passcode');
            }
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<IG_Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
