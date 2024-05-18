using Cadastro_Venda_Veiculos.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

namespace Cadastro_Venda_Veiculos.DAO
{
    public class ClienteDAO
    {

        public void Inserir(ClienteViewModel cliente)
        {
            HelperDAO.ExecutaProc("spIncluiCliente", CriaParametros(cliente));
        }
        public void Alterar(ClienteViewModel cliente)
        {
            HelperDAO.ExecutaProc("spAlteraCliente", CriaParametros(cliente));
        }
        private SqlParameter[] CriaParametros(ClienteViewModel cliente)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("id", cliente.Id);
            parametros[1] = new SqlParameter("nome", cliente.Nome);
            parametros[2] = new SqlParameter("Telefone", cliente.Telefone);
            parametros[3] = new SqlParameter("VeiculosComprados", cliente.VeiculosComprados);

            return parametros;
        }
        public void Excluir(int id)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("id", id)
            };
            HelperDAO.ExecutaProc("spExcluiCliente", p); 
        }
        private ClienteViewModel MontaCliente(DataRow registro)
        {
            ClienteViewModel a = new ClienteViewModel();
            a.Id = Convert.ToInt32(registro["id"]);
            a.Nome = registro["nome"].ToString();
            a.Telefone = (string)registro["Telefone"];
            a.VeiculosComprados = (Int32)registro["VeiculosComprados"];

            return a;
        }
        public ClienteViewModel Consulta(int id)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("id", id)
            };
            DataTable tabela = HelperDAO.ExecutaProcSelect("spConsultaCliente", p); 
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaCliente(tabela.Rows[0]);
        }
        public List<ClienteViewModel> Listagem()
        {
            List<ClienteViewModel> lista = new List<ClienteViewModel>();

            DataTable tabela = HelperDAO.ExecutaProcSelect("spListagemCliente", null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaCliente(registro));
            return lista;
        }
        public int ProximoId()
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("tabela", "clientes")
            };
            DataTable tabela = HelperDAO.ExecutaProcSelect("spProximoId", p);
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]);
        }
    }
}

