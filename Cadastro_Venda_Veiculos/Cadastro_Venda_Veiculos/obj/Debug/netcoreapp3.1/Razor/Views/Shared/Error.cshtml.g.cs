#pragma checksum "C:\Users\evand\Desktop\Cad\Cadastro_Veiculos_N1-main (2)\Cadastro_Veiculos_N1-main\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Shared\Error.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "333ba4384dac22b358840875ff3fefa481c5da580e3756b4131a35ca9f4027a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"333ba4384dac22b358840875ff3fefa481c5da580e3756b4131a35ca9f4027a2", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b8b0986c6594a28974480ec6870560b69d6aaa9b4889dab98c2cb7bf61d140aa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\evand\Desktop\Cad\Cadastro_Veiculos_N1-main (2)\Cadastro_Veiculos_N1-main\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2 class=\"text-danger\">Um erro ocorreu durante o processamento da sua requisição. </h2>\n<p>\n    <strong>Detalhes do erro: </strong> <code> ");
#nullable restore
#line 8 "C:\Users\evand\Desktop\Cad\Cadastro_Veiculos_N1-main (2)\Cadastro_Veiculos_N1-main\Cadastro_Venda_Veiculos\Cadastro_Venda_Veiculos\Views\Shared\Error.cshtml"
                                          Write(Model.Erro);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </code>\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
