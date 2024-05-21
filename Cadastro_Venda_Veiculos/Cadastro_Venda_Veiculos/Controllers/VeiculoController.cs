using Cadastro_Venda_Veiculos.Controllers;
using Cadastro_Venda_Veiculos.DAO;
using Cadastro_Venda_Veiculos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using static Cadastro_Venda_Veiculos.Controllers.PadraoController<Cadastro_Venda_Veiculos.Models.VeiculoViewModel>;

namespace Cadastro_Venda_Veiculos.Controllers
{
    public class VeiculoController : PadraoController<VeiculoViewModel>
    {
        public VeiculoController()
        {
            DAO = new VeiculoDAO();
            GeraProximoId = true;
        }

        protected override void ValidaDados(VeiculoViewModel veiculo, string operacao)
        {
            base.ValidaDados(veiculo, operacao);
            if (string.IsNullOrEmpty(veiculo.Modelo))
                ModelState.AddModelError("Modelo", "Preencha o modelo.");
            if (veiculo.Ano <= 0)
                ModelState.AddModelError("Ano", "Ano inválido.");
            if (string.IsNullOrEmpty(veiculo.Marca))
                ModelState.AddModelError("Marca", "Informe a marca.");
            if (veiculo.Preco == null || veiculo.Preco <= 0)
                ModelState.AddModelError("Preco", "Preço inválido.");
        }
    }
}
