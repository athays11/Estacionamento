using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Estacionamento
{
    public class Conexao
    {
        private SqlConnection conexao = new SqlConnection("Server=YELYAHTATA\\SQLEXPRESS; Database=bdEstacionamento1; Integrated Security=SSPI;");


        public SqlConnection AbrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
                conexao.Open();
            return conexao;
        }


        public SqlConnection FecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
                conexao.Close();
            return conexao;

        }

    }
}
