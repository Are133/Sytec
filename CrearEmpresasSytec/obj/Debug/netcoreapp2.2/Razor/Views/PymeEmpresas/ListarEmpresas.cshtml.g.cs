#pragma checksum "D:\MicrosoftNewLearn\CrearEmpresasSytec\CrearEmpresasSytec\Views\PymeEmpresas\ListarEmpresas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a00d62a690d8cf6958fc6de6111f7533e20b4316"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PymeEmpresas_ListarEmpresas), @"mvc.1.0.view", @"/Views/PymeEmpresas/ListarEmpresas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PymeEmpresas/ListarEmpresas.cshtml", typeof(AspNetCore.Views_PymeEmpresas_ListarEmpresas))]
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
#line 1 "D:\MicrosoftNewLearn\CrearEmpresasSytec\CrearEmpresasSytec\Views\_ViewImports.cshtml"
using CrearEmpresasSytec;

#line default
#line hidden
#line 2 "D:\MicrosoftNewLearn\CrearEmpresasSytec\CrearEmpresasSytec\Views\_ViewImports.cshtml"
using CrearEmpresasSytec.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a00d62a690d8cf6958fc6de6111f7533e20b4316", @"/Views/PymeEmpresas/ListarEmpresas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d998cd9488893bbbaedd9f4c45b422f3b4009c36", @"/Views/_ViewImports.cshtml")]
    public class Views_PymeEmpresas_ListarEmpresas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrearEmpresasSytec.Models.Empresa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/cardStyles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/crad-images/nophoto.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\MicrosoftNewLearn\CrearEmpresasSytec\CrearEmpresasSytec\Views\PymeEmpresas\ListarEmpresas.cshtml"
  
    ViewData["Title"] = "ListarEmpresas";
    Layout = null;

#line default
#line hidden
            BeginContext(125, 39, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(164, 503, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a00d62a690d8cf6958fc6de6111f7533e20b43165348", async() => {
                BeginContext(170, 217, true);
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width-device-width,initial-scale=1.0\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie-edge\" />\r\n    <title>Empresas Registradas</title>\r\n    ");
                EndContext();
                BeginContext(387, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a00d62a690d8cf6958fc6de6111f7533e20b43165966", async() => {
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
                EndContext();
                BeginContext(440, 220, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css\" integrity=\"sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l\" crossorigin=\"anonymous\">\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(667, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(671, 1537, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a00d62a690d8cf6958fc6de6111f7533e20b43168331", async() => {
                BeginContext(677, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 23 "D:\MicrosoftNewLearn\CrearEmpresasSytec\CrearEmpresasSytec\Views\PymeEmpresas\ListarEmpresas.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
                BeginContext(722, 147, true);
                WriteLiteral("        <section>\r\n            <!--Tarjeta 1-->\r\n            <div class=\"cuerpo-tarjeta\">\r\n                <div class=\"foto\">\r\n                    ");
                EndContext();
                BeginContext(869, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a00d62a690d8cf6958fc6de6111f7533e20b43169172", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(936, 109, true);
                WriteLiteral("\r\n\r\n                </div>\r\n              \r\n\r\n                <div class=\"descripcion\">\r\n                    ");
                EndContext();
                BeginContext(1046, 49, false);
#line 35 "D:\MicrosoftNewLearn\CrearEmpresasSytec\CrearEmpresasSytec\Views\PymeEmpresas\ListarEmpresas.cshtml"
               Write(Html.DisplayNameFor(model => model.NombreEmpresa));

#line default
#line hidden
                EndContext();
                BeginContext(1095, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1118, 48, false);
#line 36 "D:\MicrosoftNewLearn\CrearEmpresasSytec\CrearEmpresasSytec\Views\PymeEmpresas\ListarEmpresas.cshtml"
               Write(Html.DisplayFor(modelItem => item.NombreEmpresa));

#line default
#line hidden
                EndContext();
                BeginContext(1166, 91, true);
                WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"descripcion\">\r\n                    ");
                EndContext();
                BeginContext(1258, 50, false);
#line 40 "D:\MicrosoftNewLearn\CrearEmpresasSytec\CrearEmpresasSytec\Views\PymeEmpresas\ListarEmpresas.cshtml"
               Write(Html.DisplayNameFor(model => model.NombreComercil));

#line default
#line hidden
                EndContext();
                BeginContext(1308, 23, true);
                WriteLiteral(":\r\n                    ");
                EndContext();
                BeginContext(1332, 49, false);
#line 41 "D:\MicrosoftNewLearn\CrearEmpresasSytec\CrearEmpresasSytec\Views\PymeEmpresas\ListarEmpresas.cshtml"
               Write(Html.DisplayFor(modelItem => item.NombreComercil));

#line default
#line hidden
                EndContext();
                BeginContext(1381, 91, true);
                WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"descripcion\">\r\n                    ");
                EndContext();
                BeginContext(1473, 43, false);
#line 45 "D:\MicrosoftNewLearn\CrearEmpresasSytec\CrearEmpresasSytec\Views\PymeEmpresas\ListarEmpresas.cshtml"
               Write(Html.DisplayNameFor(model => model.Colonia));

#line default
#line hidden
                EndContext();
                BeginContext(1516, 23, true);
                WriteLiteral(":\r\n                    ");
                EndContext();
                BeginContext(1540, 42, false);
#line 46 "D:\MicrosoftNewLearn\CrearEmpresasSytec\CrearEmpresasSytec\Views\PymeEmpresas\ListarEmpresas.cshtml"
               Write(Html.DisplayFor(modelItem => item.Colonia));

#line default
#line hidden
                EndContext();
                BeginContext(1582, 91, true);
                WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"descripcion\">\r\n                    ");
                EndContext();
                BeginContext(1674, 45, false);
#line 50 "D:\MicrosoftNewLearn\CrearEmpresasSytec\CrearEmpresasSytec\Views\PymeEmpresas\ListarEmpresas.cshtml"
               Write(Html.DisplayNameFor(model => model.Municipio));

#line default
#line hidden
                EndContext();
                BeginContext(1719, 23, true);
                WriteLiteral(":\r\n                    ");
                EndContext();
                BeginContext(1743, 44, false);
#line 51 "D:\MicrosoftNewLearn\CrearEmpresasSytec\CrearEmpresasSytec\Views\PymeEmpresas\ListarEmpresas.cshtml"
               Write(Html.DisplayFor(modelItem => item.Municipio));

#line default
#line hidden
                EndContext();
                BeginContext(1787, 389, true);
                WriteLiteral(@"
                </div>


                <div class=""align-button"">
                    <a class=""btn btn-outline-primary btn-sm"">Detalles</a>
                    <a class=""btn btn-outline-warning btn-sm"">Editar</a>
                    <a class=""btn btn-outline-danger btn-sm"">Borrar</a>
                </div>
                <br />
            </div>


        </section>
");
                EndContext();
#line 65 "D:\MicrosoftNewLearn\CrearEmpresasSytec\CrearEmpresasSytec\Views\PymeEmpresas\ListarEmpresas.cshtml"
    }

#line default
#line hidden
                BeginContext(2183, 18, true);
                WriteLiteral("\r\n\r\n\r\n    \r\n\r\n\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2208, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CrearEmpresasSytec.Models.Empresa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
