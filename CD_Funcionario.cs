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
    class CD_Funcionario
    {
        private Conexao conexao = new Conexao();
        SqlDataReader ler;
        DataTable tab = new DataTable();
        SqlCommand com = new SqlCommand();



        public DataTable Mostrar()
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "select codFuncionario, nomeFuncionario, cpfFuncionario, rgFuncionario, sexoFuncionario, telefoneFuncionario, loginUsuario, senhaUsuario, descricaoCargo from tbFuncionario inner join tbCargo on tbCargo.codCargo = tbFuncionario.codCargo";
            ler = com.ExecuteReader();
            tab.Load(ler);
            return tab;
        }


        public void Insert(String nome, String cpf, String rg, String genero, string telefone, string login, string senha, String cargo)
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "execute CadastroFuncionario '" + nome + "', '" + cpf + "', '" + rg + "', '" + genero + "', '" + telefone + "', '" + login + "' , '" + senha +"', '" + cargo + "'";
            //com.CommandType = CommandType.StoredProcedure;
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }

        public void Editar(String nome, String cpf, String rg, String genero, string telefone, string login, string senha, string cargo, int id)
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "execute AlterarFuncionario '" + nome + "', '" + cpf + "', '" + rg + "', '" + genero + "', '" + telefone + "', '" + login + "', '" + senha + "', '" + cargo + "', '" + id + "'";
            //com.CommandType = CommandType.StoredProcedure;
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }

        public void Excluir(int id)
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "delete from tbFuncionario where codFuncionario = '" + id + "'";
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }

        public void NomeFuncionario(int id)
        {
            com.Connection = conexao.AbrirConexao();
            com.CommandText = "select nomeFuncionario from tbFuncionario where codFuncionario = '" + id + "'";
            com.ExecuteNonQuery();
            com.Parameters.Clear();
        }
    }
}
