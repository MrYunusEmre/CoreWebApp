#pragma checksum "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55bc4fa9f6466f619476ea4082bab3407478d862"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
#line 1 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\_ViewImports.cshtml"
using CoreWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\_ViewImports.cshtml"
using CoreWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55bc4fa9f6466f619476ea4082bab3407478d862", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ccaa0bb7c2237ad0e2193309f82bddc35d0c1ac", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55bc4fa9f6466f619476ea4082bab3407478d8624673", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<section class=\"main-content-w3layouts-agileits\">\r\n    <div class=\"container\">\r\n        <h3 class=\"tittle\">Yazar Kayıt Sayfası</h3>\r\n        <div class=\"inner-sec\">\r\n            <div class=\"login p-5 bg-light mx-auto mw-100\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55bc4fa9f6466f619476ea4082bab3407478d8625983", async() => {
                WriteLiteral(@"
                    <div class=""form-row"">
                        <div class=""col-md-6 mb-3"">
                            <label for=""validationCustom01"">Adınız-Soyadınız</label>

                            <input type=""text"" class=""form-control"" id=""validationDefault01"" name=""WriterName""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 797, "\"", 811, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 812, "\"", 823, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""col-md-6 mb-3"">
                            <label for=""validationCustom02"">Mail Adresi</label>
                            <input type=""email"" class=""form-control"" id=""validationDefault02"" name=""WriterMail""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1104, "\"", 1118, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 1119, "\"", 1130, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword1 mb-2"">Şifre</label>
                            <input type=""password"" class=""form-control"" id=""password1"" name=""WriterPassword""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1488, "\"", 1502, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 1503, "\"", 1514, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword2 mb-2"">Şifre Tekrar</label>
                            <input type=""password"" class=""form-control"" id=""password2"" name=""ConfirmPassword""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1808, "\"", 1822, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 1823, "\"", 1834, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>

                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword1 mb-2"">Görsel Dosya Yolu</label>
                            <input type=""text"" class=""form-control""");
                BeginWriteAttribute("id", " id=\"", 2165, "\"", 2170, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"WriterImage\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2190, "\"", 2204, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 2205, "\"", 2216, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>

                    </div>
                    <button type=""submit"" class=""btn btn-primary submit mb-4"" id=""submitBtn"" disabled>Kayıt Ol</button>
                    <p>
                        <a id=""btn1"">Tüm şartları okudum, kabul ediyorum.</a>
                    </p>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
    <br />
    <script>
        $('#btn1').click(function(){
           swal(""Sitemizde verdiğiniz mail adresi üzerinden bilgi ve haber e-postaları spam ölçüsüne varmadan gönderilmeye devam edilecektir. Eğer e-posta bülteninden çıkmak isterseniz mail ileti dizisini durdurabilirsiniz, şifre ve mail adresleriniz şifrelenmiş formatta herhangi bir kullanıcının göremeyeceği şekilde veritabanımızda saklanmaktadır."");
        });

           $(document).ready(function(){
        var $submitBtn = $(""#form button[type='submit']"");
        var $passwordBox = $(""#password1"");
        var $confirmBox = $(""#password2"");
        var $errorMsg =  $('<span id=""error_msg"">Şifreler aynı değil.</span>');

        // This is incase the user hits refresh - some browsers will maintain the disabled state of the button.
        $submitBtn.removeAttr(""disabled"");

        function checkMatchingPasswords(){
            if($confirmBox.val() != """" && $passwordBox.val !=");
            WriteLiteral(@" """"){
                if( $confirmBox.val() != $passwordBox.val() ){
                    $submitBtn.attr(""disabled"", ""disabled"");
                    $errorMsg.insertAfter($confirmBox);
                }
            }
        }

        function resetPasswordError(){
            $submitBtn.removeAttr(""disabled"");
            var $errorCont = $(""#error_msg"");
            if($errorCont.length > 0){
                $errorCont.remove();
            }  
        }


        $(""#password2, #password1"")
             .on(""keydown"", function(e){
                /* only check when the tab or enter keys are pressed
                 * to prevent the method from being called needlessly  */
                if(e.keyCode == 13 || e.keyCode == 9) {
                    checkMatchingPasswords();
                }
             })
             .on(""blur"", function(){                    
                // also check when the element looses focus (clicks somewhere else)
                checkMatchingPasswo");
            WriteLiteral(@"rds();
            })
            .on(""focus"", function(){
                // reset the error message when they go to make a change
                resetPasswordError();
            })
        $('#submitBtn').click(function(){
            checkMatchingPasswords();
        });

    });

    </script>
</section>
");
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
