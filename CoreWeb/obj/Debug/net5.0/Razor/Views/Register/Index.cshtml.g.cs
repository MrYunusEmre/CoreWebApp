#pragma checksum "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb8b8a4e79e506346976a036939d80fb4f112f00"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb8b8a4e79e506346976a036939d80fb4f112f00", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ccaa0bb7c2237ad0e2193309f82bddc35d0c1ac", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreWeb.ViewModels.Register.RegisterViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<section class=\"main-content-w3layouts-agileits\">\r\n    <div class=\"container\">\r\n        <h3 class=\"tittle\">Yazar Kayıt Sayfası</h3>\r\n        <div class=\"inner-sec\">\r\n            <div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 14 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml"
                 using (Html.BeginForm("Index", "Register", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-row\">\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom01\">Adınız-Soyadınız</label>\r\n                            ");
#nullable restore
#line 19 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.WriterName, new {Name = "WriterName"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 20 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </div>\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom02\">Mail Adresi</label>\r\n                            ");
#nullable restore
#line 25 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.WriterMail,  new {Name = "WriterMail"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 26 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword1 mb-2"">Şifre</label>
                            ");
#nullable restore
#line 33 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.WriterPassword, new {Name = "WriterPassword"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 34 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </div>\r\n                        <div class=\"form-group col-md-6\">\r\n                            <label for=\"exampleInputPassword2 mb-2\">Şifre Tekrar</label>\r\n                            ");
#nullable restore
#line 39 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.WriterPassword ,new {Name = "ConfirmPassword"} ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 40 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                        </div>

                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword1 mb-2"">Şehir </label>

                            ");
#nullable restore
#line 49 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml"
                       Write(Html.DropDownList("WriterCity",Model.Cities , new {Name = "WriterCity"} ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 50 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"                        </div>



                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword1 mb-2"">Görsel Dosya Yolu</label>
                            ");
#nullable restore
#line 70 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.WriterImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 71 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <button type=\"submit\" class=\"btn btn-primary submit mb-4\" id=\"submitBtn\">Kayıt Ol</button>\r\n                    <p>\r\n                        <a id=\"btn1\">Tüm şartları okudum, kabul ediyorum.</a>\r\n                    </p>\r\n");
#nullable restore
#line 80 "D:\Coding\C#\CoreWebApp\CoreWeb\Views\Register\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <br />\r\n\r\n</section>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb8b8a4e79e506346976a036939d80fb4f112f009932", async() => {
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
            WriteLiteral("\r\n<script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreWeb.ViewModels.Register.RegisterViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591