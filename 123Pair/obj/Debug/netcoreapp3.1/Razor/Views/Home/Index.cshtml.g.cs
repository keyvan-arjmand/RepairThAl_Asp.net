#pragma checksum "E:\New folder (5)\123Pair\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43d5d034d291c2cce60e589c32e71b1dac01faf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d5d034d291c2cce60e589c32e71b1dac01faf0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f37183929ab64bcf80fc4912765f7c128c10cdf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Repair1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/document_6023975164906049769.mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("video/mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "E:\New folder (5)\123Pair\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "صفحه ی اصلی";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    /* The Modal (background) */
    .modal {
        display: none;
        /* Hidden by default */
        position: fixed;
        /* Stay in place */
        z-index: 1000;
        /* Sit on top */
        /* Location of the box */
        left: 0;
        top: 0;
        width: 100%;
        /* Full width */
        height: 100%;
        /* Full height */
        overflow: auto;
        /* Enable scroll if needed */
        background-color: rgb(0, 0, 0);
        /* Fallback color */
        background-color: rgba(0, 0, 0, 0.4);
        /* Black w/ opacity */
    }

    /* Modal Content */
    .modal-content {
        background-color: #fefefe;
        margin: auto;
        padding: 10px;
        border: 1px solid #888;
        width: 70%;
    }

    /* The Close Button */
    .close {
        color: #aaaaaa;
        float: right;
        font-size: 28px;
        font-weight: bold;
    }

        .close:hover,
        .close:focus {
            color: #0");
            WriteLiteral(@"00;
            text-decoration: none;
            cursor: pointer;
        }
</style>

<!-- Carousel Start -->
<div class=""container-fluid p-0"">
    <div id=""header-carousel"" class=""carousel slide carousel-fade"" data-ride=""carousel"">
        <ol class=""carousel-indicators"" style=""z-index:3"">
            <li data-target=""#header-carousel"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#header-carousel"" data-slide-to=""1""></li>
            <li data-target=""#header-carousel"" data-slide-to=""2""></li>
        </ol>
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "43d5d034d291c2cce60e589c32e71b1dac01faf07414", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""carousel-caption d-flex align-items-center justify-content-center"">
                    <div class=""p-5"" style=""width: 100%; max-width: 900px;text-align:right"">
                        <h5 class=""text-primary text-uppercase mb-md-3"">ضمانت و پشتیبانی ۲۴ ساعته</h5>
                        <h1 class=""display-3 text-white mb-md-4"">
                            تعمیرات انواع لوازم خانگی بصورت حرفه و با کیفیت بالا
                        </h1>
                        <a");
            BeginWriteAttribute("href", " href=\"", 2312, "\"", 2353, 1);
#nullable restore
#line 70 "E:\New folder (5)\123Pair\Views\Home\Index.cshtml"
WriteAttributeValue("", 2319, Url.Action("OrderPage","Account"), 2319, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">درخواست اعزام کارشناس</a>
                    </div>
                </div>
            </div>
            <div class=""carousel-item"">
                <img class=""img-fluid"" src=""img\Service.jpg"" alt=""Image"" width=""100%"" height=""auto"">
                <div class=""carousel-caption d-flex align-items-center justify-content-center"">
                    <div class=""p-5"" style=""width: 100%; max-width: 900px;text-align:right"">
                        <h5 class=""text-primary text-uppercase mb-md-3"">ارائه  خدمات در کمترین زمان و بالا ترین کیفیت</h5>
                        <h1 class=""display-3 text-white mb-md-4"">استفاده از قطعات اورجینال در تمامی تعمیرات</h1>
                        <a");
            BeginWriteAttribute("href", " href=\"", 3076, "\"", 3117, 1);
#nullable restore
#line 80 "E:\New folder (5)\123Pair\Views\Home\Index.cshtml"
WriteAttributeValue("", 3083, Url.Action("OrderPage","Account"), 3083, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">درخواست اعزام کارشناس</a>
                    </div>
                </div>
            </div>
            <div class=""carousel-item"">
                <img class=""img-fluid"" src=""img\Repair5.jpg"" alt=""Image"" width=""100%"" height=""auto"">
                <div class=""carousel-caption d-flex align-items-center justify-content-center"">
                    <div class=""p-5"" style=""width: 100%; max-width: 900px;text-align:right"">
                        <h5 class=""text-primary text-uppercase mb-md-3"">دارای کارشناس های ماهر با تجربه بالا</h5>
                        <h1 class=""display-3 text-white mb-md-4"">ارائه تمامی خدمات در زمینه تعمیرات لوازم خانگی</h1>
                        <a");
            BeginWriteAttribute("href", " href=\"", 3835, "\"", 3876, 1);
#nullable restore
#line 90 "E:\New folder (5)\123Pair\Views\Home\Index.cshtml"
WriteAttributeValue("", 3842, Url.Action("OrderPage","Account"), 3842, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">درخواست اعزام کارشناس</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
    </div>
<!-- Carousel End -->
<!-- Contact Info Start -->
<div class=""container-fluid pb-5 contact-info"">
    <div class=""row"">
        <div class=""col-lg-4 p-0"">
            <div class=""contact-info-item d-flex align-items-center justify-content-center bg-primary text-white py-4 py-lg-0"">
                <i class=""fa fa-3x fa-map-marker-alt text-secondary mr-4""></i>
                <div");
            BeginWriteAttribute("class", " class=\"", 4438, "\"", 4446, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <h5 class=""mb-2"">آدرس</h5>
                    <p class=""m-0"">تهران بلوار خیابان پلاک 216</p>
                </div>
            </div>
        </div>
        <div class=""col-lg-4 p-0"">
            <div class=""contact-info-item d-flex align-items-center justify-content-center bg-secondary text-white py-4 py-lg-0"">
                <i class=""fa fa-3x fa-envelope-open text-primary mr-4""></i>
                <div");
            BeginWriteAttribute("class", " class=\"", 4890, "\"", 4898, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <h5 class=""mb-2"">نمایندگی</h5>
                    <p class=""m-0"">+021 345 6789</p>
                </div>
            </div>
        </div>
        <div class=""col-lg-4 p-0"">
            <div class=""contact-info-item d-flex align-items-center justify-content-center bg-primary text-white py-4 py-lg-0"">
                <i class=""fa fa-3x fa-phone-alt text-secondary mr-4""></i>
                <div");
            BeginWriteAttribute("class", " class=\"", 5328, "\"", 5336, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <h5 class=""mb-2"">تماس با ما</h5>
                    <p class=""m-0"">0912 883 7627</p>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Contact Info End -->
<!-- About Start -->
<div class=""container-fluid py-5 mb-5"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-5"">
                <div class=""d-flex flex-column align-items-center justify-content-center bg-about rounded h-100 py-5 px-3"">
                    <i class=""fa fa-5x fa-award text-primary mb-4""></i>
                    <h1 class=""display-2 text-white mb-2"" data-toggle=""counter-up"">25</h1>
                    <h2 class=""text-white m-0"">سال</h2>
                    <h2 class=""text-white m-0"">سابقه ی موفق</h2>
                </div>
            </div>
            <div class=""col-lg-7 pt-5 pb-lg-5"">
                <h6 class=""text-secondary font-weight-semi-bold text-uppercase mb-3"">درباره ما</h6>
                <h1 class=""mb-4 section-titl");
            WriteLiteral(@"e"">ما بهترین خدمات تعمیرات را اراعه میدهیم</h1>
                <h5 class=""text-muted font-weight-normal mb-3"">

                    پس از 25 سال تجربه درخشان ارائه خدمات در زمینه تعمیرات لوازم خانگی در مجموعه ایران سرویس در
                    مواجه با گسترش کسب و کارهای اینترنتی بر آن شدیم تا با نام تجاری جدیدی پا به عرصه رقابت گذاشته و
                    با ایجاد پلتفرم “123 تعمیر“ وظیفه خدمت رسانی به هم میهنان عزیزمان را گسترش داده و این خدمات را
                    در
                    دسترس عموم قرار دهیم تا باشگاهی بزرگ از مشتریان گذشته ، حال و آینده را تشکیل داده و با ارائه
                    خدمات به روز ، متحولانه و به صرفه نامی ماندگار در اذهان عموم بر جای بگذاریم.
                </h5>
                <p>
                    این مرکز جهت رفاه مشتریان خود کلیه خدمات تعمیرات را در صورت امکان در محل مشتری انجام خواهد داد ؛
                    ما برای تعمیرات لوازم خانگی در محل ، کلیه تجهیزات و ملزومات مورد نیاز را در دسترس داشته و با به
                    کارگیری قطعات اورجینال و دا");
            WriteLiteral("رای ضمانت تمام تلاش خود را خواهیم کرد تا تمام مراحل تعمیرات لوازم\r\n                    خانگی شما در همان محل و در حضور شما انجام گردد.\r\n                </p>\r\n                <div class=\"d-flex align-items-center pt-4\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 7627, "\"", 7666, 1);
#nullable restore
#line 163 "E:\New folder (5)\123Pair\Views\Home\Index.cshtml"
WriteAttributeValue("", 7634, Url.Action("AboutUs","Account"), 7634, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary mr-5"">بیشتر</a>
                    <button type=""button"" class=""btn-play"" id=""myBtnVideo"">
                        <span></span>
                    </button>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- About End -->
<!-- Video Modal Start -->
<div class=""modal fade"" id=""videoModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <button type=""button"" class=""close1"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <!-- 16:9 aspect ratio -->
                <div class=""embed-responsive embed-responsive-16by9"">
                    <iframe class=""embed-responsive-item""");
            BeginWriteAttribute("src", " src=\"", 8592, "\"", 8598, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""video"" allowscriptaccess=""always""
                            allow=""autoplay""></iframe>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Video Modal End -->
<!-- Services Start -->
<div class=""container-fluid bg-service py-5"">
    <div class=""container py-5"">
        <div class=""row align-items-center"">
            <div class=""col-lg-6"">
                <h6 class=""text-secondary font-weight-semi-bold text-uppercase mb-3"">خدمات مـا</h6>
                <h1 class=""mb-4 section-title text-white"">بهترین خدمات تعمیرات برای شما</h1>
                <p class=""text-white"">
                    ی123 تعمیر با پشتیبانی 24 ساعته و در دست داشتن تعداد زیادی تکنسین فعال در نقاط مختلف کشور این
                    امکان را فراهم آورده تا تمام خدمات و تعمیرات در سریعترین زمان ممکن پس از تماس مشتری انجام گردد.
                    تعمیرات انجام شده توسط متخصصین ما 90 روزضمانت میگردد و چنانچه مشتری از خدمات دریافتی ابراز
                    نارضایتی داشته باشد امکان بازگشت وج");
            WriteLiteral("ه دریافت شده به مشتری وجود دارد.\r\n                </p>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 9697, "\"", 9704, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary mt-3 py-2 px-4"">ثبت درخواست</a>
            </div>
            <div class=""col-lg-6 pt-5 pt-lg-0"">
                <div class=""owl-carousel service-carousel position-relative"">
                    <div style=""height:360px ;""
                         class=""d-flex flex-column align-items-center text-center bg-white rounded overflow-hidden pt-4"">
                        <div class=""icon-box bg-light text-secondary shadow mt-2 mb-4"">
                            <i class=""fa fa-2x"">
                                <img src=""https://cdn-icons-png.flaticon.com/512/2969/2969435.png"" height=""60px"" />
                            </i>
                        </div>
                        <h5 class=""font-weight-bold mb-4 px-4"">تعمیرات یخچال</h5>
                        <img src=""img/Repair3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10537, "\"", 10543, 0);
            EndWriteAttribute();
            WriteLiteral(@" height=""181px"">
                    </div>
                    <div style=""height:360px ;""
                         class=""d-flex flex-column align-items-center text-center bg-white rounded overflow-hidden pt-4"">
                        <div class=""icon-box bg-light text-secondary shadow mt-2 mb-4"">
                            <i class=""fa fa-2x"">
                                <img src=""https://cdn-icons-png.flaticon.com/512/6265/6265588.png "" height=""60px"" />
                            </i>
                        </div>
                        <h5 class=""font-weight-bold mb-4 px-4"">تعمیرات تلویزیون</h5>
                        <img src=""img/TvR.webp""");
            BeginWriteAttribute("alt", " alt=\"", 11218, "\"", 11224, 0);
            EndWriteAttribute();
            WriteLiteral(@" height=""181px"">
                    </div>
                    <div style=""height:360px ;""
                         class=""d-flex flex-column align-items-center text-center bg-white rounded overflow-hidden pt-4"">
                        <div class=""icon-box bg-light text-secondary shadow mt-2 mb-4"">
                            <i class=""fa fa-2x"">
                                <img src=""https://cdn-icons-png.flaticon.com/512/4360/4360201.png"" />
                            </i>
                        </div>
                        <h5 class=""font-weight-bold mb-4 px-4"">تاسیسات ساختمان</h5>
                        <img src=""img/Elc.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11882, "\"", 11888, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Services End -->
<div id=""myModalVideo"" class=""modal"">

    <!-- Modal content -->
    <div class=""modal-content"">
        <span class=""close"">&times;</span>
        <video style=""width: 100%;height: auto;"" controls>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "43d5d034d291c2cce60e589c32e71b1dac01faf021890", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            Your browser does not support the video tag.\r\n        </video>\r\n    </div>\r\n\r\n</div>\r\n<div class=\"loadpanel\">\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

<script>
    // Get the modal
    var modalVideo = document.getElementById(""myModalVideo"");

    // Get the button that opens the modal
    var btnVideo = document.getElementById(""myBtnVideo"");

    // Get the <span> element that closes the modal
    var spanVideo = document.getElementsByClassName(""close1"")[0];

    // When the user clicks the button, open the modal
    btnVideo.onclick = function () {
        modalVideo.style.display = ""block"";
    }

    // When the user clicks on <span> (x), close the modal
    spanVideo.onclick = function () {
        modalVideo.style.display = ""none"";
    }

    // When the user clicks anywhere outside of the modal, close it
    window.onclick = function (event) {
        if (event.target == modalVideo) {
            modalVideo.style.display = ""none"";
        }
    }
</script>
");
            }
            );
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