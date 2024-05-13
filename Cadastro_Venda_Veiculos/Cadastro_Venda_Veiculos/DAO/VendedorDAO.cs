using static Cadastro_Venda_Veiculos.Models.VendedorViewModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using Cadastro_Venda_Veiculos.Models;

namespace Cadastro_Venda_Veiculos.DAO
{
    public class VendedorDAO
    {
        public void Inserir(VendedorViewModel vendedor)
        {
            HelperDAO.ExecutaProc("spIncluiVendedor", CriaParametros(vendedor));
        }
        public void Alterar(VendedorViewModel vendedor)
        {
            HelperDAO.ExecutaProc("spAlteraVendedor", CriaParametros(vendedor));
        }
        private SqlParameter[] CriaParametros(VendedorViewModel vendedor)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("id", vendedor.Id);
            parametros[1] = new SqlParameter("nome", vendedor.Nome);
            parametros[2] = new SqlParameter("Telefone", vendedor.Telefone);
            parametros[3] = new SqlParameter("Vendas", vendedor.Vendas);

            if (vendedor.Vendas == null)
                parametros[3] = new SqlParameter("vendas", DBNull.Value);
            else
                parametros[3] = new SqlParameter("vendas", vendedor.Vendas);

            return parametros;
        }
        public void Excluir(int id)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("id", id)
            };
            HelperDAO.ExecutaProc("spExcluiVendedor", p);
        }
        private VendedorViewModel MontaVendedor(DataRow registro)
        {
            VendedorViewModel a = new VendedorViewModel();
            a.Id = Convert.ToInt32(registro["id"]);
            a.Nome = registro["nome"].ToString();
            a.Vendas = null;
            a.Telefone = (string)registro["Telefone"];

            if (registro["Vendas"] != DBNull.Value)
                a.Vendas = (int?)Convert.ToDouble(registro["Vendas"]);

            return a;
        }
        public VendedorViewModel Consulta(int id)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("id", id)
            };
            DataTable tabela = HelperDAO.ExecutaProcSelect("spConsultaVendedor", p);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaVendedor(tabela.Rows[0]);
        }
        public List<VendedorViewModel> Listagem()
        {
            List<VendedorViewModel> lista = new List<VendedorViewModel>();

            DataTable tabela = HelperDAO.ExecutaProcSelect("spListagemVendedores", null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaVendedor(registro));
            return lista;
        }
        public int ProximoId()
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("tabela", "vendedores")
            };
            DataTable tabela = HelperDAO.ExecutaProcSelect("spProximoId", p);
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]);
        }
    }
}
