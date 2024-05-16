using Cadastro_Venda_Veiculos.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

namespace Cadastro_Venda_Veiculos.DAO
{
    public class CarroDAO
    {
        public void Inserir(CarroViewModel carro)
        {
            HelperDAO.ExecutaProc("spIncluiCarro", CriaParametros(carro));
        }
        public void Alterar(CarroViewModel carro)
        {
            HelperDAO.ExecutaProc("spAlteraCarro", CriaParametros(carro));
        }
        private SqlParameter[] CriaParametros(CarroViewModel carro)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("id", carro.Id);
            parametros[1] = new SqlParameter("Marca", carro.Marca);
            parametros[2] = new SqlParameter("Modelo", carro.Modelo);
            parametros[3] = new SqlParameter("Placa", carro.Placa);
            parametros[4] = new SqlParameter("Kilometragem", carro.Kilometragem);
            parametros[5] = new SqlParameter("Valor", carro.Valor);
            parametros[6] = new SqlParameter("Tipo", carro.Tipo);

            if (carro.Placa == null)
                parametros[3] = new SqlParameter("Placa", DBNull.Value);

            return parametros;
        }
        public void Excluir(int id)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("id", id)
            };
            HelperDAO.ExecutaProc("spExcluiCarro", p);
        }
        private CarroViewModel MontaCarro(DataRow registro)
        {
            CarroViewModel a = new CarroViewModel();
            a.Id = Convert.ToInt32(registro["id"]);
            a.Marca = registro["Marca"].ToString();
            a.Modelo = registro["Modelo"].ToString();
            a.Placa = null;
            a.Kilometragem = Convert.ToInt32(registro["Kilometragem"]);
            a.Valor = Convert.ToDouble(registro["Valor"]);
            a.Tipo = registro["Tipo"].ToString();

            if (registro["Placa"] != DBNull.Value)
                a.Placa = Convert.ToString(registro["Placa"]);

            return a;
        }
        public CarroViewModel Consulta(int id)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("id", id)
            };
            DataTable tabela = HelperDAO.ExecutaProcSelect("spConsultaCarro", p);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaCarro(tabela.Rows[0]);
        }
        public List<CarroViewModel> Listagem()
        {
            List<CarroViewModel> lista = new List<CarroViewModel>();

            DataTable tabela = HelperDAO.ExecutaProcSelect("spListagemCarros", null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaCarro(registro));
            return lista;
        }
        public int ProximoId()
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("tabela", "carros")
            };
            DataTable tabela = HelperDAO.ExecutaProcSelect("spProximoId", p);
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]);
        }
    }
}
