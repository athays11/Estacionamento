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
    class CD_EntraSaiCarro
    {
        private Conexao conexao = new Conexao();
        SqlDataReader ler;
        DataTable tab = new DataTable();
        SqlCommand com = new SqlCommand();


        public void Entrar(string placa, string data)
        {
            com.Connection = conexao.AbrirConexao();
            com.Parameters.Add("@placa", placa);
            com.Parameters.Add("@data", data);
            com.CommandText = "execute dbo.EntradaCarro @placa, @data";
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }

        public void Sair(string placa, string hora)
        {
            com.Connection = conexao.AbrirConexao();
            com.Parameters.Add("@placa", placa);
            com.Parameters.Add("@hora", hora);
            com.CommandText = "execute dbo.SaidaCarro @placa, @hora";
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }


        public DataTable MostrarSaida(string placa)
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "Select * from tbSaidaCarro where placaSaidaCarro like '" + placa + "'";
            ler = com.ExecuteReader();
            tab.Load(ler);
            return tab;
        }

        public DataTable MostrarEntrada()
        {
            SqlDataReader lers;
            DataTable tabs = new DataTable();
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "Select * from tbEntradaCarro";
            lers = com.ExecuteReader();
            tabs.Load(lers);
            return tabs;
        }

        public void Limpa(string placa)
        {
            com.Connection = conexao.AbrirConexao();
            com.Parameters.Add("@placa", placa);
            com.CommandText = "execute dbo.LimpaCarro @placa";
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }
    }
}
