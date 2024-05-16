using System;
using System.Reflection.PortableExecutable;

namespace Cadastro_Venda_Veiculos.Models
{
    public class VendedorViewModel : PessoaViewModel
    {
        public int? Vendas { get; set; }
    }

}
