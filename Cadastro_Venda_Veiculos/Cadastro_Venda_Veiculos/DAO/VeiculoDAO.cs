using Cadastro_Venda_Veiculos.Models;
using Cadastro_Venda_Veiculos.DAO;
using System.Collections.Generic;
using System.Data;
using System;
using System.Data.SqlClient;
using System.Reflection;

namespace Cadastro_Venda_Veiculos.DAO
{

    public class VeiculoDAO : PadraoDAO<VeiculoViewModel>
    {
        protected override SqlParameter[] CriaParametros(VeiculoViewModel veiculo)
        {
            object imgByte = veiculo.ImagemEmByte;
            if (imgByte == null)
                imgByte = DBNull.Value;
            SqlParameter[] parametros = new SqlParameter[7];
            parametros[0] = new SqlParameter("id", veiculo.Id);
            parametros[1] = new SqlParameter("modelo", veiculo.Modelo);
            parametros[2] = new SqlParameter("ano", veiculo.Ano);
            parametros[3] = new SqlParameter("marca", veiculo.Marca);
            parametros[4] = new SqlParameter("placa", veiculo.Placa);
            parametros[5] = new SqlParameter("foto", imgByte);
            parametros[6] = new SqlParameter("preco", veiculo.Preco);

            return parametros;
        }
        protected override VeiculoViewModel MontaModel(DataRow registro)
        {
            VeiculoViewModel v = new VeiculoViewModel
            {
                Id = registro["id"] != DBNull.Value ? Convert.ToInt32(registro["id"]) : 0,
                Modelo = registro["modelo"] != DBNull.Value ? registro["modelo"].ToString() : string.Empty,
                Ano = registro["ano"] != DBNull.Value ? Convert.ToInt32(registro["ano"]) : 0,
                Placa = registro["placa"] != DBNull.Value ? registro["placa"].ToString() : string.Empty,
                Preco = registro["preco"] != DBNull.Value ? Convert.ToDouble(registro["preco"]) : 0.0,
                Marca = registro["marca"] != DBNull.Value ? registro["marca"].ToString() : string.Empty
            };
            if (registro["foto"] != DBNull.Value)
                v.ImagemEmByte = registro["foto"] as byte[];

            return v;
        }

        protected override void SetTabela()
        {
            Tabela = "veiculos";
            NomeSpListagem = "spListagemVeiculo";
        }

        public override void Inserir(VeiculoViewModel veiculo)
        {
            HelperDAO.ExecutaProc("spIncluiVeiculo", CriaParametros(veiculo));
        }

        public override VeiculoViewModel Consulta(int id)
        {
            SqlParameter[] vetor = { new SqlParameter("id", id) };
            DataTable tabela = HelperDAO.ExecutaProcSelect("spConsultaVeiculo", vetor);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaModel(tabela.Rows[0]);
        }

        public override List<VeiculoViewModel> Listagem()
        {
            List<VeiculoViewModel> lista = new List<VeiculoViewModel>();
            DataTable tabela = HelperDAO.ExecutaProcSelect("spListagemVeiculo", null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaModel(registro));
            return lista;
        }

        public override int ProximoId()
        {
            SqlParameter[] vetor = { new SqlParameter("tabela", "veiculo") };
            DataTable tabela = HelperDAO.ExecutaProcSelect("spProximoId", vetor);
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]);
        }
    }
}





