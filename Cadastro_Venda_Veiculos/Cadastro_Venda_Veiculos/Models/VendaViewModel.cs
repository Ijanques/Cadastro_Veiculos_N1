using Microsoft.AspNetCore.Http;
using System;

namespace Cadastro_Venda_Veiculos.Models
{
    public class VendaViewModel : PadraoViewModel
    {
        public int VeiculoId { get; set; }
        public int CompradorId { get; set; }
        public int VendedorId { get; set; }
        public DateTime DataVenda { get; set; }

    }
}
