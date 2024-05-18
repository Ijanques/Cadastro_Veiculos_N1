using Cadastro_Venda_Veiculos.DAO;
using Cadastro_Venda_Veiculos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace Cadastro_Venda_Veiculos.Controllers
{
    public class VendedorController : Controller
    {
        public IActionResult Index()
        {
            VendedorDAO dao = new VendedorDAO();
            List<VendedorViewModel> lista = dao.Listagem();
            return View(lista);
        }

        public IActionResult Create()
        {
            ViewBag.Operacao = "I";
            try
            {
                VendedorViewModel vendedor = new VendedorViewModel();

                VendedorDAO dao = new VendedorDAO();
                vendedor.Id = dao.ProximoId();
                return View("Form", vendedor);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult Salvar(VendedorViewModel vendedor, string Operacao)
        {
            try
            {
                ValidaDados(vendedor, Operacao);
                if (ModelState.IsValid == false)
                {
                    ViewBag.Operacao = Operacao;
                    return View("Form", vendedor);
                }
                else
                {
                    VendedorDAO dao = new VendedorDAO();
                    if (Operacao == "I")

                        if (dao.Consulta(vendedor.Id) == null)
                            dao.Inserir(vendedor);
                        else
                            dao.Alterar(vendedor);
                    return RedirectToAction("index");
                }
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }


        public IActionResult Edit(int id)
        {
            try
            {
                ViewBag.Operacao = "A";

                VendedorDAO dao = new VendedorDAO();
                VendedorViewModel vendedor = dao.Consulta(id);
                if (vendedor == null)
                    return RedirectToAction("index");
                else
                    return View("Form", vendedor);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                VendedorDAO dao = new VendedorDAO();
                dao.Excluir(id);
                return RedirectToAction("index");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        //Verificar a aplicação dos dados.
        private void ValidaDados(VendedorViewModel vendedor, string operacao)
        {
            ModelState.Clear(); // limpa os erros criados automaticamente pelo Asp.net (que podem estar com msg em inglês)
            VendedorDAO dao = new VendedorDAO();
            if (operacao == "I" && dao.Consulta(vendedor.Id) != null)
                ModelState.AddModelError("Id", "Código já está em uso.");
            if (operacao == "A" && dao.Consulta(vendedor.Id) == null)
                ModelState.AddModelError("Id", "Vendedor não existe.");
            if (vendedor.Id <= 0)
                ModelState.AddModelError("Id", "Id inválido!");

            if (string.IsNullOrEmpty(vendedor.Nome))
                ModelState.AddModelError("Nome", "Preencha o nome.");
            if (string.IsNullOrEmpty(vendedor.Telefone))
                ModelState.AddModelError("Telefone", "Campo obrigatório.");
        }


    }
}
