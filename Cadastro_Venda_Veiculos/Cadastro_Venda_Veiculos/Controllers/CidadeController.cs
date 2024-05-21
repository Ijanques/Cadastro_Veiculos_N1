using Cadastro_Venda_Veiculos.DAO;
using Cadastro_Venda_Veiculos.Models;
using static Cadastro_Venda_Veiculos.Controllers.PadraoController<Cadastro_Venda_Veiculos.Models.CidadeViewModel>;

namespace Cadastro_Venda_Veiculos.Controllers
{
    public class CidadeController : PadraoController<CidadeViewModel>
    {
        public CidadeController()
        {
            DAO = new CidadeDAO();
            GeraProximoId = true;
        }

        protected override void ValidaDados(CidadeViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            if (string.IsNullOrEmpty(model.Nome))
                ModelState.AddModelError("Nome", "Preencha o nome.");
        }
    }
}
