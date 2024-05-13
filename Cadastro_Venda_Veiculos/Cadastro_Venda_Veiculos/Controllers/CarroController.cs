using Cadastro_Venda_Veiculos.DAO;
using Cadastro_Venda_Veiculos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace Cadastro_Venda_Veiculos.Controllers
{
    public class CarroController : Controller
    {
        public IActionResult Index()
        {
            CarroDAO dao = new CarroDAO();
            List<CarroViewModel> lista = dao.Listagem();
            return View(lista);
        }

        public IActionResult Create()
        {
            ViewBag.Operacao = "I";
            try
            {
                CarroViewModel carro = new CarroViewModel();

                CarroDAO dao = new CarroDAO();
                carro.Id = dao.ProximoId();
                return View("Form", carro);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult Salvar(CarroViewModel carro, string Operacao)
        {
            try
            {
                ValidaDados(carro, Operacao);
                if (ModelState.IsValid == false)
                {
                    ViewBag.Operacao = Operacao;
                    return View("Form", carro);
                }
                else
                {
                    CarroDAO dao = new CarroDAO();
                    if (Operacao == "I")

                        if (dao.Consulta(carro.Id) == null)
                            dao.Inserir(carro);
                        else
                            dao.Alterar(carro);
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

                CarroDAO dao = new CarroDAO();
                CarroViewModel carro = dao.Consulta(id);
                if (carro == null)
                    return RedirectToAction("index");
                else
                    return View("Form", carro);
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
                CarroDAO dao = new CarroDAO();
                dao.Excluir(id);
                return RedirectToAction("index");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        //Verificar a aplicação dos dados.
        private void ValidaDados(CarroViewModel carro, string operacao)
        {
            ModelState.Clear(); // limpa os erros criados automaticamente pelo Asp.net (que podem estar com msg em inglês)
            CarroDAO dao = new CarroDAO();
            if (operacao == "I" && dao.Consulta(carro.Id) != null)
                ModelState.AddModelError("Id", "Código já está em uso.");
            if (operacao == "A" && dao.Consulta(carro.Id) == null)
                ModelState.AddModelError("Id", "Carro não existe.");
            if (carro.Id <= 0)
                ModelState.AddModelError("Id", "Id inválido!");

            if (string.IsNullOrEmpty(carro.Marca))
                ModelState.AddModelError("Marca", "Preencha a marca do veiculo.");
            if (string.IsNullOrEmpty(carro.Modelo))
                ModelState.AddModelError("Modelo", "Campo obrigatório.");
            if (carro.Kilometragem < 0)
                ModelState.AddModelError("Kilometragem", "A kilometragem não pode ser menor que zero.");
            if (carro.Valor <= 0)
                ModelState.AddModelError("Valor", "O valor não pode ser menor ou igual a zero.");

        }


    }
}
