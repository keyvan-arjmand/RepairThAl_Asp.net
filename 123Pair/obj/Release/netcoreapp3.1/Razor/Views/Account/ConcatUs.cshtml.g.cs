#pragma checksum "E:\New folder (5)\123Pair\Views\Account\ConcatUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d73477dc5535b829c7607766b43fa524353e6a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ConcatUs), @"mvc.1.0.view", @"/Views/Account/ConcatUs.cshtml")]
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
#line 1 "E:\New folder (5)\123Pair\Views\_ViewImports.cshtml"
using _123Pair;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\New folder (5)\123Pair\Views\_ViewImports.cshtml"
using _123Pair.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d73477dc5535b829c7607766b43fa524353e6a8", @"/Views/Account/ConcatUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f37183929ab64bcf80fc4912765f7c128c10cdf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_ConcatUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("sentMessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" <!-- Contact Start -->
<div class=""px-4 py-5 px-md-5 text-center text-lg-start"" style=""background-color: hsl(0, 0%, 96%)"">
    <div class=""container-fluid py-5"">
        <div class=""row align-items-end mb-4"">
            <div class=""col-lg-6"">
                <h6 class=""text-secondary font-weight-semi-bold text-uppercase mb-3"">تماس با ما</h6>
                <h1 class=""section-title mb-3"">فرم ارسال درخواست</h1>
            </div>
            <div class=""col-lg-6"">
                <h4 class=""font-weight-normal text-muted mb-3"" style=""text-align: right;"">ارتباط مستقیم با ما</h4>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-7 mb-5 mb-lg-0"">
                <div class=""contact-form"" style=""text-align: right;"" dir=""rtl"">
                    <div id=""success""></div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d73477dc5535b829c7607766b43fa524353e6a85135", async() => {
                WriteLiteral(@"
                        <div class=""form-row"">
                            <div class=""col-sm-6 control-group"">
                                <input type=""text"" class=""form-control p-4"" id=""name""
                                       placeholder=""نام و نام خانوادگی"" required=""required""
                                       data-validation-required-message=""مشخصات خود را وارد کنید"" />
                                <p class=""help-block text-danger""></p>
                            </div>
                            <div class=""col-sm-6 control-group"">
                                <input type=""text"" class=""form-control p-4"" id=""email"" placeholder=""شماره تماس""
                                       required=""required""
                                       data-validation-required-message=""شماره همراه الزامی میباشد"" />
                                <p class=""help-block text-danger""></p>
                            </div>
                        </div>
                        <div class=");
                WriteLiteral(@"""control-group"">
                            <input type=""text"" class=""form-control p-4"" id=""subject"" placeholder=""موضوع پیام""
                                   required=""required"" data-validation-required-message=""موضوع پیام را وارد کنید"" />
                            <p class=""help-block text-danger""></p>
                        </div>
                        <div class=""control-group"">
                            <textarea class=""form-control p-4"" rows=""6"" id=""message"" placeholder=""متن پیام""
                                      required=""required""
                                      data-validation-required-message=""پیام خود را وارد کنید""></textarea>
                            <p class=""help-block text-danger""></p>
                        </div>
                        <div>
                            <button class=""btn btn-primary btn-block py-3 px-5"" type=""submit""
                                    id=""sendMessageButton"">
                                ارسال پیام
                 ");
                WriteLiteral("           </button>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-5\" style=\"min-height: 400px;text-align: right;background: #e0e0e0;\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 3216, "\"", 3222, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3223, "\"", 3229, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <p>
                    آدرس : کرج ، چهارراه مصباح ، بلوار فردوس مرکز تعمیرات لوازم خانگی 123تعمیر
                    <br />
                    تلفن : 84340-021
                    <br />
                    info@alorepair.com : ایمیل
                    <br />
                    ما را در شبکه های اجتماعی دنبال کنید
                    <br />
                    <a class=""text-primary p-2""");
            BeginWriteAttribute("href", " href=\"", 3653, "\"", 3660, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <i class=""fab fa-linkedin-in""></i>
                    </a>
                    <a class=""text-primary p-2"" href=""https://www.instagram.com/technical_tehran.alborz/"">
                        <i class=""fab fa-instagram""></i>
                    </a>
                </p>
            </div>
        </div>
    </div>
</div>
<!-- Contact End --><div class=""loadpanel"">
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
