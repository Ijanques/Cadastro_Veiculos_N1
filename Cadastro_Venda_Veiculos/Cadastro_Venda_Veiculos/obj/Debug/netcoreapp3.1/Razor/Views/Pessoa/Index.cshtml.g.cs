#pragma checksum "C:\Users\evand\Desktop\Cad\Cadastro_Veiculos_N1-main (2)\Cadastro_Veiculos_N1-main\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Pessoa\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "669ee7d068db510ce1441ca18f085fe65998680582bb2ca9fa0ef786237f90e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa_Index), @"mvc.1.0.view", @"/Views/Pessoa/Index.cshtml")]
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
#line 1 "C:\Users\evand\Desktop\Cad\Cadastro_Veiculos_N1-main (2)\Cadastro_Veiculos_N1-main\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\_ViewImports.cshtml"
using Cadastro_Venda_Veiculos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\evand\Desktop\Cad\Cadastro_Veiculos_N1-main (2)\Cadastro_Veiculos_N1-main\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\_ViewImports.cshtml"
using Cadastro_Venda_Veiculos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"669ee7d068db510ce1441ca18f085fe65998680582bb2ca9fa0ef786237f90e6", @"/Views/Pessoa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b8b0986c6594a28974480ec6870560b69d6aaa9b4889dab98c2cb7bf61d140aa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pessoa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cadastro_Venda_Veiculos.Models.PessoaViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\evand\Desktop\Cad\Cadastro_Veiculos_N1-main (2)\Cadastro_Veiculos_N1-main\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Pessoa\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>Listagem de Pessoas</h2>

<a href=""/pessoa/Create"" class=""btn btn-info"">Novo Registro</a>
<br />

<table class=""table table-responsive table-hover"">
    <thead>
        <tr>
            <th>Ações</th>
            <th>ID</th>
            <th>Nome</th>
            <th>Telefone</th>
            <th>Tipo</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\evand\Desktop\Cad\Cadastro_Veiculos_N1-main (2)\Cadastro_Veiculos_N1-main\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Pessoa\Index.cshtml"
         foreach (var pessoa in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 572, "\"", 605, 2);
            WriteAttributeValue("", 579, "/pessoa/Edit?id=", 579, 16, true);
#nullable restore
#line 26 "C:\Users\evand\Desktop\Cad\Cadastro_Veiculos_N1-main (2)\Cadastro_Veiculos_N1-main\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 595, pessoa.Id, 595, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Editar</a>\n                    &nbsp;&nbsp;&nbsp;\n                    <a");
            BeginWriteAttribute("href", " href=\"", 700, "\"", 738, 3);
            WriteAttributeValue("", 707, "javascript:confirma(", 707, 20, true);
#nullable restore
#line 28 "C:\Users\evand\Desktop\Cad\Cadastro_Veiculos_N1-main (2)\Cadastro_Veiculos_N1-main\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 727, pessoa.Id, 727, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 737, ")", 737, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Apagar</a>\n                </td>\n                <td>");
#nullable restore
#line 30 "C:\Users\evand\Desktop\Cad\Cadastro_Veiculos_N1-main (2)\Cadastro_Veiculos_N1-main\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Pessoa\Index.cshtml"
               Write(pessoa.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 31 "C:\Users\evand\Desktop\Cad\Cadastro_Veiculos_N1-main (2)\Cadastro_Veiculos_N1-main\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Pessoa\Index.cshtml"
               Write(pessoa.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 32 "C:\Users\evand\Desktop\Cad\Cadastro_Veiculos_N1-main (2)\Cadastro_Veiculos_N1-main\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Pessoa\Index.cshtml"
               Write(pessoa.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 33 "C:\Users\evand\Desktop\Cad\Cadastro_Veiculos_N1-main (2)\Cadastro_Veiculos_N1-main\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Pessoa\Index.cshtml"
               Write(pessoa.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 35 "C:\Users\evand\Desktop\Cad\Cadastro_Veiculos_N1-main (2)\Cadastro_Veiculos_N1-main\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Pessoa\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n<script>\n    function confirma(id) {\n        if (confirm(\'Deseja mesmo apagar?\')) {\n            location.href = \'/pessoa/Delete?id=\' + id;\n        }\n    }\n</script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cadastro_Venda_Veiculos.Models.PessoaViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
