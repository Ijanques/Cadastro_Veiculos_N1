using Cadastro_Venda_Veiculos.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

namespace Cadastro_Venda_Veiculos.DAO
{
    public class MotoDAO
    {

        public void Inserir(MotoViewModel moto)
        {
            HelperDAO.ExecutaProc("spIncluiMoto", CriaParametros(moto));
        }
        public void Alterar(MotoViewModel moto)
        {
            HelperDAO.ExecutaProc("spAlteraMoto", CriaParametros(moto));
        }
        private SqlParameter[] CriaParametros(MotoViewModel moto)
        {
            SqlParameter[] parametros = new SqlParameter[7];
            parametros[0] = new SqlParameter("id", moto.Id);
            parametros[1] = new SqlParameter("Marca", moto.Marca);
            parametros[2] = new SqlParameter("Modelo", moto.Modelo);
            parametros[3] = new SqlParameter("Placa", moto.Placa);
            parametros[4] = new SqlParameter("Kilometragem", moto.Kilometragem);
            parametros[5] = new SqlParameter("Valor", moto.Valor);
            parametros[6] = new SqlParameter("Cilindrada", moto.Cilindrada);

            if (moto.Placa == null)
                parametros[3] = new SqlParameter("Placa", DBNull.Value);

            return parametros;
        }
        public void Excluir(int id)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("id", id)
            };
            HelperDAO.ExecutaProc("spExcluiMoto", p);
        }
        private MotoViewModel MontaMoto(DataRow registro)
        {
            MotoViewModel a = new MotoViewModel();
            a.Id = Convert.ToInt32(registro["id"]);
            a.Marca = registro["Marca"].ToString();
            a.Modelo = registro["Modelo"].ToString();
            a.Placa = null;
            a.Kilometragem = Convert.ToInt32(registro["Kilometragem"]);
            a.Valor = Convert.ToDouble(registro["Valor"]);
            a.Cilindrada = Convert.ToInt32(registro["Cilindrada"]);

            if (registro["Placa"] != DBNull.Value)
                a.Placa = Convert.ToString(registro["Placa"]);

            return a;
        }
        public MotoViewModel Consulta(int id)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("id", id)
            };
            DataTable tabela = HelperDAO.ExecutaProcSelect("spConsultaMoto", p);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaMoto(tabela.Rows[0]);
        }
        public List<MotoViewModel> Listagem()
        {
            List<MotoViewModel> lista = new List<MotoViewModel>();

            DataTable tabela = HelperDAO.ExecutaProcSelect("spListagemMoto", null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaMoto(registro));
            return lista;
        }
        public int ProximoId()
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("tabela", "motos")
            };
            DataTable tabela = HelperDAO.ExecutaProcSelect("spProximoId", p);
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]);
        }
    }
}
