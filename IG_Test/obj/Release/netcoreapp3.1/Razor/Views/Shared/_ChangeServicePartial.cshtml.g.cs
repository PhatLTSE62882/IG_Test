#pragma checksum "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\Shared\_ChangeServicePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ccbd2824649d78dbf64f8a409d100b7e7ee5c8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ChangeServicePartial), @"mvc.1.0.view", @"/Views/Shared/_ChangeServicePartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ccbd2824649d78dbf64f8a409d100b7e7ee5c8e", @"/Views/Shared/_ChangeServicePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fae05152bd12df52c52fd6a588053595c7ebcf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ChangeServicePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;width:50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/login/arrow-button.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-signin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"  <!-- Modal -->
<div id=""changeServiceModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title float-left"">Vui lòng nhập passcode</h4>
            </div>
            <div class=""modal-body"">
                <div class=""container"">
                    <div class=""row"">
                        <div style=""width:100%"">
                            <div class=""card card-signin my-5"">
                                <div class=""card-body"">
                                    <div class=""text-center"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5ccbd2824649d78dbf64f8a409d100b7e7ee5c8e5799", async() => {
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
            WriteLiteral("\r\n                                    </div>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ccbd2824649d78dbf64f8a409d100b7e7ee5c8e6994", async() => {
                WriteLiteral(@"
                                        <div class=""form-label-group"">
                                            <label for=""inputPassword"" style=""color:silver"">Passcode</label>
                                            <div class=""row"">
                                                <div class=""col-md-11"">
                                                    <input type=""password"" style=""border-bottom:1px solid black"" id=""inputPassword"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1380, "\"", 1394, 0);
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

                                        <label style=""color:silver""><strong>Chọn loại dịch vụ</strong></label>
                                        <div class=""row"" id=""loadService"">

                                        </div>
                                        <p style=""color:red"" id=""service-error""></p>

                                        <hr class=""my-4"">
                                        <button class=""btn");
                WriteLiteral(" btn-lg btn-danger btn-block text-uppercase\" onclick=\"loginService()\" type=\"button\">Đổi dịch vụ</button>\r\n\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            </div>
        </div>

    </div>
</div>

<script>
    var serviceCode = """";
    $(document).ready(() => {
        loadService();
    })
    function templateService(jsonItem) {
        var html = """";
        for (var i = 0; i < jsonItem.length; i++) {
            var template = `<div class=""col-md-5 text-center pointer border-service"" style=""border: 1px solid deeppink;""
                                                         onclick=""chooseServiceModal('SERVICE_CODE')""
                                                         data-id=""SERVICE_CODE"">
                                                        <img src=""/IMAGE_SOURCE"" class=""img-center"" alt=""Alternate Text"" />
                                                        <h6 class=""text-center"" style=""color:red""> SERVICE_NAME </h6>
                                ");
            WriteLiteral(@"                    </div>`;
            var item = jsonItem[i];
            template = template.replace(""SERVICE_CODE"", item.serviceCode).replace('SERVICE_CODE', item.serviceCode).replace('IMAGE_SOURCE', item.serviceImage).replace('SERVICE_NAME', item.serviceName);
            html += template;
        }
        document.getElementById('loadService').innerHTML = html;
    }

    function loadService() {
           $.ajax({
            type: ""GET"",
            url: """);
#nullable restore
#line 80 "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\Shared\_ChangeServicePartial.cshtml"
             Write(Url.Action("Service","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            success: function (msg) {
                templateService(msg);
            },
               error: function (req, status, error) {
                   console.log(error);
            }
        });
    }

    function chooseServiceModal(item) {
        var element = $('[data-id=' + item + ']');
        serviceCode = item;
        if (element.css('background-color') != 'rgba(0, 0, 0, 0)') {
            element.css('background-color', 'transparent');
        } else {
            element.css('background-color', 'silver');
        }
    }

    function setErrorById(id, errorMsg) {
        document.getElementById(id).innerText = errorMsg;
    }

    function loginService() {
        var passcode = $('#inputPassword').val();
        console.log(passcode);
        console.log(serviceCode)

        if (passcode == null || passcode == undefined || passcode.length == 0) {
            setErrorById('passcode-error', 'Vui lòng nhập passcode');
            return;
        } el");
            WriteLiteral(@"se {
            setErrorById('passcode-error', '');
        }
        if (serviceCode.length == 0) {
            setErrorById('service-error', 'Vui lòng chọn dịch vụ');
            return;
        }else {
            setErrorById('service-error', '');
        }

            $.ajax({
            type: ""POST"",
            url: """);
#nullable restore
#line 124 "C:\Users\ADMIN\source\repos\IG_Test\IG_Test\Views\Shared\_ChangeServicePartial.cshtml"
             Write(Url.Action("Login","Account"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
