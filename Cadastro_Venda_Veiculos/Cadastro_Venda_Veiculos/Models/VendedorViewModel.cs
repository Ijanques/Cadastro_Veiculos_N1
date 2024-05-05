using System;

namespace Cadastro_Venda_Veiculos.Models
{
    public class VendedorViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int? Vendas { get; set; }
        //Campo de vendas será o que aceitará nulo. No exemplo do Rosalém estamos usando Mensalidade. (Tópico 15)
    }
}
