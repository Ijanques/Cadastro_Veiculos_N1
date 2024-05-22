using Cadastro_Venda_Veiculos.DAO;
using Cadastro_Venda_Veiculos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Cadastro_Venda_Veiculos.Controllers
{
    public class VendaController : PadraoController<VendaViewModel>
    {
        public VendaController()
        {
            DAO = new VendaDAO();
            GeraProximoId = true;
        }

        protected override void ValidaDados(VendaViewModel venda, string operacao)
        {
            base.ValidaDados(venda, operacao);

            if (venda.VeiculoId <= 0)
                ModelState.AddModelError("VeiculoId", "Selecione um veículo válido.");

            if (venda.CompradorId <= 0)
                ModelState.AddModelError("CompradorId", "Selecione um comprador válido.");

            if (venda.VendedorId <= 0)
                ModelState.AddModelError("VendedorId", "Selecione um vendedor válido.");

            if (venda.DataVenda == default(DateTime))
                ModelState.AddModelError("DataVenda", "Informe uma data de venda válida.");
        }

        public IActionResult SearchVeiculo(string searchTerm)
        {
            var veiculos = new VeiculoDAO().Listagem();
            return Json(veiculos);
        }

        public IActionResult SearchComprador(string searchTerm)
        {
            var compradores = new PessoaDAO().ListagemCompradores();
            return Json(compradores);
        }

        public IActionResult SearchVendedor(string searchTerm)
        {
            var vendedores = new PessoaDAO().ListagemVendores();
            return Json(vendedores);
        }
        public IActionResult PesquisaDetalhada(string tipoVeiculo, string nomeVendedor, string nomeComprador)
        {
            List<VendaViewModel> todasVendas = VendaDAO.PesquisarDetalhada(tipoVeiculo, nomeVendedor, nomeComprador);
            return View(todasVendas);
        }

    }
}
