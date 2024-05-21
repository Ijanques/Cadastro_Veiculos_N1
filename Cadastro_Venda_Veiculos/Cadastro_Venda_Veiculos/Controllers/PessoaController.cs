using Cadastro_Venda_Veiculos.DAO;
using Cadastro_Venda_Veiculos.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using static Cadastro_Venda_Veiculos.Controllers.PadraoController<Cadastro_Venda_Veiculos.Models.PessoaViewModel>;

namespace Cadastro_Venda_Veiculos.Controllers
{
    public class PessoaController : PadraoController<PessoaViewModel>
    {
        public PessoaController()
        {
            DAO = new PessoaDAO();
            GeraProximoId = true;
        }

        protected override void ValidaDados(PessoaViewModel pessoa, string operacao)
        {
            base.ValidaDados(pessoa, operacao);
            if (string.IsNullOrEmpty(pessoa.Nome))
                ModelState.AddModelError("Nome", "Preencha o nome.");
            if (string.IsNullOrEmpty(pessoa.Tipo))
                ModelState.AddModelError("Tipo", "Informe o Tipo.");
        }
    }
}
