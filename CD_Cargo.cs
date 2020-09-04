using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace Estacionamento
{
    class CD_Cargo
    {
        private Conexao conexao = new Conexao();
        DataTable tab = new DataTable();
        SqlCommand com = new SqlCommand();
        DataTable dadosTabela = new DataTable();
        
        

        public void Insert(string cargo)
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "insert into tbCargo(descricaoCargo) values('"+ cargo +"')";
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }

        public List<string> Listar()
        {
            List<string> listaCargo = new List<string>();
            com.Connection = conexao.AbrirConexao();
            SqlDataAdapter adapta = new SqlDataAdapter("select descricaoCargo from tbCargo", com.Connection);
            adapta.Fill(dadosTabela);
            listaCargo = dadosTabela.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("descricaoCargo")).ToList();
            return listaCargo;   
        }
    }
}
