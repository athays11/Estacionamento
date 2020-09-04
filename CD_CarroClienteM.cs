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
    class CD_CarroClienteM
    {
        private Conexao conexao = new Conexao();
        DataTable tab = new DataTable();
        SqlCommand com = new SqlCommand();
        DataTable dadosTabela = new DataTable();
        SqlDataReader ler;
        DataTable tab2 = new DataTable();

        public void InsertModelo(string modelo)
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "insert into tbModelo(descricaoModelo) values('" + modelo + "')";
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }
        public void InsertCor(string cor)
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "insert into tbCor(cor) values('" + cor + "')";
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }


        public List<string> ListarModelo()
        {
            List<string> listaModelo = new List<string>();
            com.Connection = conexao.AbrirConexao();
            SqlDataAdapter adapta = new SqlDataAdapter("select descricaoModelo from tbModelo", com.Connection);
            adapta.Fill(dadosTabela);
            listaModelo = dadosTabela.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("descricaoModelo")).ToList();
            return listaModelo;
        }

        public List<string> ListarCor()
        {
            List<string> listaCor = new List<string>();
            com.Connection = conexao.AbrirConexao();
            SqlDataAdapter adapta = new SqlDataAdapter("select cor from tbCor", com.Connection);
            adapta.Fill(dadosTabela);
            listaCor = dadosTabela.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("cor")).ToList();
            return listaCor;
        }

        public void InsertCarro(string placa, string modelo, string cor)
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "execute CadastroCarroClienteMensal '" + placa + "','" + modelo + "','" + cor + "'";
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }

        public void CompletaCarro(string placa)
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "execute CadastroCompletoCarro '" + placa + "'";
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }

        public DataTable MostrarCarros()
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "select codCarrosClienteMensal, nomeClienteMensal, placaCarrosClienteMensal, cor, descricaoModelo from tbCarrosClienteMensal inner join tbClienteMensal on tbClienteMensal.codClienteMensal = tbCarrosClienteMensal.codClienteMensal inner join tbCor on tbCarrosClienteMensal.codCor = tbCor.codCor inner join tbModelo on tbCarrosClienteMensal.codModelo = tbModelo.codModelo";
            //com.CommandText = "select * from tbCarrosClienteMensal";
            ler = com.ExecuteReader();
            tab2.Load(ler);
            return tab2;
        }

        public void ExcluirCarroLista(string placa)
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "delete from tbCarrosClienteMensal where placaCarrosClienteMensal like '" + placa + "'";
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }




    }
}
