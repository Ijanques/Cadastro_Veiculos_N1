using Cadastro_Venda_Veiculos.Models;
using Cadastro_Venda_Veiculos.DAO;
using System.Collections.Generic;
using System.Data;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Collections;

namespace Cadastro_Venda_Veiculos.DAO
{
    public class VendaDAO : PadraoDAO<VendaViewModel>
    {
        protected override SqlParameter[] CriaParametros(VendaViewModel venda)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("id", venda.Id);
            parametros[1] = new SqlParameter("veiculoId", venda.VeiculoId);
            parametros[2] = new SqlParameter("compradorId", venda.CompradorId);
            parametros[3] = new SqlParameter("vendedorId", venda.VendedorId);
            parametros[4] = new SqlParameter("dataVenda", venda.DataVenda);

            return parametros;
        }

        protected override VendaViewModel MontaModel(DataRow registro)
        {
            VendaViewModel venda = new VendaViewModel();
            venda.Id = Convert.ToInt32(registro["id"]);
            venda.VeiculoId = Convert.ToInt32(registro["veiculoId"]);
            venda.CompradorId = Convert.ToInt32(registro["compradorId"]);
            venda.VendedorId = Convert.ToInt32(registro["vendedorId"]);
            venda.DataVenda = Convert.ToDateTime(registro["dataVenda"]);

            return venda;
        }

        protected override void SetTabela()
        {
            Tabela = "vendas";
            NomeSpListagem = "spListagemVendas";
        }
        public override void Inserir(VendaViewModel venda)
        {
            HelperDAO.ExecutaProc("spInsereVenda", CriaParametros(venda));
        }

        public override VendaViewModel Consulta(int id)
        {
            SqlParameter[] vetor = { new SqlParameter("id", id) };
            DataTable tabela = HelperDAO.ExecutaProcSelect("spConsultaVenda", vetor);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaModel(tabela.Rows[0]);
        }

        public override List<VendaViewModel> Listagem()
        {
            List<VendaViewModel> lista = new List<VendaViewModel>();
            DataTable tabela = HelperDAO.ExecutaProcSelect("spListagemVenda", null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaModel(registro));
            return lista;
        }

        public override int ProximoId()
        {
            SqlParameter[] vetor = { new SqlParameter("tabela", "vendas") };
            DataTable tabela = HelperDAO.ExecutaProcSelect("spProximoId", vetor);
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]);
        }
        public static List<VendaViewModel> PesquisarDetalhada(string tipoVeiculo, string nomeVendedor, string nomeComprador)
        {
            List<VendaViewModel> vendas = new List<VendaViewModel>();
            if (string.IsNullOrEmpty(tipoVeiculo) || tipoVeiculo.ToLower() == "todos")
                tipoVeiculo = "%";
            if (string.IsNullOrEmpty(nomeVendedor))
                nomeVendedor = "%";
            if (string.IsNullOrEmpty(nomeComprador))
                nomeComprador = "%";
            SqlParameter[] parametros = new SqlParameter[3];
            parametros[0] = new SqlParameter("tipoVeiculo", tipoVeiculo);
            parametros[1] = new SqlParameter("nomeVendedor", nomeVendedor);
            parametros[2] = new SqlParameter("nomeComprador", nomeComprador);
            DataTable tabela = HelperDAO.ExecutaProcSelect("spPesquisaDetalhadaVendas", parametros);
            foreach (DataRow registro in tabela.Rows)
                vendas.Add(new VendaDAO().MontaModel(registro));
            return vendas;

        }
    }
}
