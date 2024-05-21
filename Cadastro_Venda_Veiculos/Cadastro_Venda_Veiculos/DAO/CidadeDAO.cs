using Cadastro_Venda_Veiculos.DAO;
using Cadastro_Venda_Veiculos.Models;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Cadastro_Venda_Veiculos.DAO
{

    public class CidadeDAO : PadraoDAO<CidadeViewModel>
    {
        protected override SqlParameter[] CriaParametros(CidadeViewModel model)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("id", model.Id);
            parametros[1] = new SqlParameter("nome", model.Nome);
            return parametros;
        }

        protected override CidadeViewModel MontaModel(DataRow registro)
        {
            var c = new CidadeViewModel();
            c.Id = Convert.ToInt32(registro["id"]);
            c.Nome = registro["nome"].ToString();
            return c;
        }

        protected override void SetTabela()
        {
            Tabela = "cidades";
        }
    }
}
/*
 create  procedure spConsultaCidade
(@id int)
as
begin
select * from cidades where id = @id
end



create procedure spListagemCidades
as
begin
select * from cidades order by nome
end
*/


