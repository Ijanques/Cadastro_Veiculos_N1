#pragma checksum "C:\Users\evand\Documents\GitHub\Cadastro_Veiculos_N1\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Cidade\Form.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9ddc54a856ada0e03d62cee90f6aa362292eede7a3527047b2d4b3bebb79e18d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cidade_Form), @"mvc.1.0.view", @"/Views/Cidade/Form.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\evand\Documents\GitHub\Cadastro_Veiculos_N1\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\_ViewImports.cshtml"
using Cadastro_Venda_Veiculos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\evand\Documents\GitHub\Cadastro_Veiculos_N1\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\_ViewImports.cshtml"
using Cadastro_Venda_Veiculos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9ddc54a856ada0e03d62cee90f6aa362292eede7a3527047b2d4b3bebb79e18d", @"/Views/Cidade/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b8b0986c6594a28974480ec6870560b69d6aaa9b4889dab98c2cb7bf61d140aa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cidade_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CidadeViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\evand\Documents\GitHub\Cadastro_Veiculos_N1\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Cidade\Form.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Cadastro de Cidade</h2>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ddc54a856ada0e03d62cee90f6aa362292eede7a3527047b2d4b3bebb79e18d5342", async() => {
                WriteLiteral("\n\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 179, "\"", 204, 1);
#nullable restore
#line 8 "C:\Users\evand\Documents\GitHub\Cadastro_Veiculos_N1\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Cidade\Form.cshtml"
WriteAttributeValue("", 187, ViewBag.Operacao, 187, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Operacao\" />\n\n    <label for=\"Id\" class=\"control-label\">Código da cidade</label>\n\n");
#nullable restore
#line 12 "C:\Users\evand\Documents\GitHub\Cadastro_Veiculos_N1\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Cidade\Form.cshtml"
     if (ViewBag.Operacao == "I")
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"number\" Name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 373, "\"", 390, 1);
#nullable restore
#line 14 "C:\Users\evand\Documents\GitHub\Cadastro_Veiculos_N1\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Cidade\Form.cshtml"
WriteAttributeValue("", 381, Model.Id, 381, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\n");
#nullable restore
#line 15 "C:\Users\evand\Documents\GitHub\Cadastro_Veiculos_N1\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Cidade\Form.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"number\" Name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 477, "\"", 494, 1);
#nullable restore
#line 18 "C:\Users\evand\Documents\GitHub\Cadastro_Veiculos_N1\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Cidade\Form.cshtml"
WriteAttributeValue("", 485, Model.Id, 485, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly class=\"form-control\" />\n");
#nullable restore
#line 19 "C:\Users\evand\Documents\GitHub\Cadastro_Veiculos_N1\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Cidade\Form.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ddc54a856ada0e03d62cee90f6aa362292eede7a3527047b2d4b3bebb79e18d7951", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 20 "C:\Users\evand\Documents\GitHub\Cadastro_Veiculos_N1\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Cidade\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n\n    <br />\n    <label for=\"Nome\" class=\"control-label\">Nome da cidade</label>\n    <input type=\"text\" class=\"form-control\" Name=\"Nome\"");
                BeginWriteAttribute("value", " value=\"", 732, "\"", 751, 1);
#nullable restore
#line 25 "C:\Users\evand\Documents\GitHub\Cadastro_Veiculos_N1\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Cidade\Form.cshtml"
WriteAttributeValue("", 740, Model.Nome, 740, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ddc54a856ada0e03d62cee90f6aa362292eede7a3527047b2d4b3bebb79e18d10239", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 26 "C:\Users\evand\Documents\GitHub\Cadastro_Veiculos_N1\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Cidade\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nome);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <br />\n\n    <input type=\"submit\" class=\"btn btn-info\" value=\"Salvar dados\" />\n    <br />\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CidadeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
