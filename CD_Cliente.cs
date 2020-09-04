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
   public class CD_Cliente
    {
        private Conexao conexao = new Conexao();
        SqlDataReader ler;
        DataTable tab = new DataTable();
        SqlCommand com = new SqlCommand();
        
        

        public DataTable Mostrar()
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "Select * from tbClienteMensal";
            ler = com.ExecuteReader();
            tab.Load(ler);
            return tab;
        }

        public void InsertCliente(String nome, String cpf, String rg, string telefone)
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "insert into tbClienteMensal(nomeClienteMensal, cpfClienteMensal, rgClienteMensal, telefoneClienteMensal) values('" + nome + "','" + cpf + "','" + rg + "','" + telefone + "')";
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }

        public void Excluir(int id)
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "execute RemoveCliente'"+id+"'";
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }

        public void Editar(String nome, String cpf, String rg, String telefone, int id)
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "execute dbo.AlterarCliente '" + nome + "', '" + cpf + "', '" + rg + "', '" + telefone + "', '" + id + "'";
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }

        public void ExcluirCarro(int id)
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "delete from tbCarrosClienteMensal where codCarrosClienteMensal = '" + id + "'";
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }
    }
}
