using System.Data.SqlClient;

namespace Cadastro_Venda_Veiculos.DAO
{
    public class ConexaoBD
    {
        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source=localhost; Database=AULADB; integrated security=true";//User ID=sa; Password=123456";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
        }


    }
}
