using Cadastro_Venda_Veiculos.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using Cadastro_Venda_Veiculos.DAO;

namespace Cadastro_Venda_Veiculos.DAO
{
    public class PessoaDAO : PadraoDAO<PessoaViewModel>
    {

        protected override SqlParameter[] CriaParametros(PessoaViewModel pessoa)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("Id", pessoa.Id);
            parametros[1] = new SqlParameter("Nome", pessoa.Nome);
            parametros[2] = new SqlParameter("Telefone", pessoa.Telefone);
            parametros[3] = new SqlParameter("Tipo", pessoa.Tipo);

            return parametros;
        }

        public void Excluir(int Id)
        {
            var p = new SqlParameter[]
            {
            new SqlParameter("Id", Id)
            };
            HelperDAO.ExecutaProc("SpExcluiPessoa", p);
        }

        protected override void SetTabela()
        {
            Tabela = "pessoa";
            NomeSpListagem = "spListagemPessoa";
        }

        protected override PessoaViewModel MontaModel(DataRow registro)
        {
            PessoaViewModel pessoa = new PessoaViewModel();
            pessoa.Id = Convert.ToInt32(registro["Id"]);
            pessoa.Nome = registro["Nome"].ToString();
            pessoa.Telefone = registro["Telefone"].ToString();
            pessoa.Tipo = registro["Tipo"].ToString();

            return pessoa;
        }

        public override PessoaViewModel Consulta(int Id)
        {
            var p = new SqlParameter[]
            {
            new SqlParameter("Id", Id)
            };
            DataTable tabela = HelperDAO.ExecutaProcSelect("SPConsultaPessoa", p);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaModel(tabela.Rows[0]);
        }

        public override List<PessoaViewModel> Listagem()
        {
            List<PessoaViewModel> lista = new List<PessoaViewModel>();
            DataTable tabela = HelperDAO.ExecutaProcSelect("SpListagemPessoa", null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaModel(registro));
            return lista;
        }
        public override int ProximoId()
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("tabela", "pessoa")
            };
            DataTable tabela = HelperDAO.ExecutaProcSelect("spProximoId", p);
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]);
        }
    }
}
