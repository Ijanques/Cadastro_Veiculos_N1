using Cadastro_Venda_Veiculos.Controllers;
using Cadastro_Venda_Veiculos.DAO;
using Cadastro_Venda_Veiculos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Reflection;

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

            if (string.IsNullOrEmpty(veiculo.Tipo) || (veiculo.Tipo != "Carro" && veiculo.Tipo != "Moto"))
                ModelState.AddModelError("Tipo", "Informe o tipo válido (Carro ou Moto).");

            if (veiculo.Imagem == null && operacao == "I")
                ModelState.AddModelError("Imagem", "Escolha uma imagem.");

            if (veiculo.Imagem != null && veiculo.Imagem.Length / 1024 / 1024 >= 2)
                ModelState.AddModelError("Imagem", "Imagem limitada a 2 mb.");

            if (ModelState.IsValid)
            {
                //na alteração, se não foi informada a imagem, iremos manter a que já estava salva.
                if (operacao == "A" && veiculo.Imagem == null)
                {
                    VeiculoViewModel cid = DAO.Consulta(veiculo.Id);
                    veiculo.ImagemEmByte = cid.ImagemEmByte;
                }
                else
                {
                    veiculo.ImagemEmByte = ConvertImageToByte(veiculo.Imagem);
                }
            }

        }

        public byte[] ConvertImageToByte(IFormFile file)
        {
            if (file != null)
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    return ms.ToArray();
                }
            else
                return null;
        }
    }
}
