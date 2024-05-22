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
            SqlParameter[] parametros = new SqlParameter[8];
            object imgByte = veiculo.ImagemEmByte;
            if (imgByte == null)
                imgByte = DBNull.Value;
            parametros[0] = new SqlParameter("id", veiculo.Id);
            parametros[1] = new SqlParameter("modelo", veiculo.Modelo);
            parametros[2] = new SqlParameter("ano", veiculo.Ano);
            parametros[3] = new SqlParameter("marca", veiculo.Marca);
            parametros[4] = new SqlParameter("placa", veiculo.Placa);
            parametros[5] = new SqlParameter("foto", imgByte);// != null ? (object)veiculo.ImagemEmByte : DBNull.Value);
            parametros[6] = new SqlParameter("preco", veiculo.Preco);
            parametros[7] = new SqlParameter("tipo", veiculo.Tipo);

            return parametros;
        }

        protected override VeiculoViewModel MontaModel(DataRow registro)
        {
            VeiculoViewModel v = new VeiculoViewModel();

            if (registro["id"] != DBNull.Value)
                v.Id = Convert.ToInt32(registro["id"]);

            if (registro["modelo"] != DBNull.Value)
                v.Modelo = registro["modelo"].ToString();

            if (registro["ano"] != DBNull.Value)
                v.Ano = Convert.ToInt32(registro["ano"]);

            if (registro["placa"] != DBNull.Value)
                v.Placa = registro["placa"].ToString();

            if (registro["preco"] != DBNull.Value)
                v.Preco = Convert.ToDouble(registro["preco"]);

            if (registro["marca"] != DBNull.Value)
                v.Marca = registro["marca"].ToString();

            if (registro["foto"] != DBNull.Value)
                v.ImagemEmByte = registro["foto"] as byte[];

            if (registro["tipo"] != DBNull.Value)
                v.Tipo = registro["tipo"].ToString();

            return v;
        }

        protected override void SetTabela()
        {
            Tabela = "veiculo";
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
