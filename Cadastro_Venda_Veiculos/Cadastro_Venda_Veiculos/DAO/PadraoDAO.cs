﻿using System.Collections.Generic;
using System.Data;
using System;
using System.Data.SqlClient;
using Cadastro_Venda_Veiculos.DAO;
using Cadastro_Venda_Veiculos.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_Venda_Veiculos.DAO
{

    public abstract class PadraoDAO<T> where T : PadraoViewModel
    {
        public PadraoDAO()
        {
            SetTabela();
        }

        protected string Tabela { get; set; }
        protected string NomeSpListagem { get; set; } = "spListagem";
        protected abstract SqlParameter[] CriaParametros(T model);
        protected abstract T MontaModel(DataRow registro);
        protected abstract void SetTabela();

        public virtual void Inserir(T model)
        {
            HelperDAO.ExecutaProc("spinsere" + Tabela, CriaParametros(model));
        }
        public virtual void Alterar(T model)
        {
            HelperDAO.ExecutaProc("spaltera" + Tabela, CriaParametros(model));
        }
        public virtual void Delete(int id)
        {
            var p = new SqlParameter[]
            {
                    new SqlParameter("id", id),
            };
            HelperDAO.ExecutaProc("SpExclui" + Tabela, p);
        }
        public virtual T Consulta(int id)
        {
            var p = new SqlParameter[]
            {
                 new SqlParameter("id", id),
                 new SqlParameter("tabela", Tabela)
            };
            var tabela = HelperDAO.ExecutaProcSelect("spConsulta", p);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaModel(tabela.Rows[0]);
        }
        public virtual int ProximoId()
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("tabela", Tabela)
            };
            var tabela = HelperDAO.ExecutaProcSelect("spProximoId", p);
            return Convert.ToInt32(tabela.Rows[0][0]);
        }
        public virtual List<T> Listagem()
        {
            var p = new SqlParameter[]
            {
             new SqlParameter("tabela", Tabela),
             new SqlParameter("Ordem", "1") // 1 é o primeiro campo da tabela
            };
            var tabela = HelperDAO.ExecutaProcSelect(NomeSpListagem, null);
            List<T> lista = new List<T>();
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaModel(registro));

            return lista;
        }
    }
}



