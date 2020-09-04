using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Estacionamento
{
    class CN_Funcionario
    {
        
            private CD_Funcionario objFuncionario = new CD_Funcionario();

            public DataTable MostrarFunc()
            {
                DataTable tabFunc = new DataTable();
                tabFunc = objFuncionario.Mostrar();
                return tabFunc;
            }
          
            public void InsertFuncionario(String nome, String cpf, String rg, string genero, string telefone, string login, string senha, string cargo)
            {
                objFuncionario.Insert(nome, cpf, rg, genero, telefone, login, senha, cargo);
            }

            public void EditarFunc(String nome, String cpf, String rg, String genero, String telefone, string login, string senha, string cargo, String id)
            {
                objFuncionario.Editar(nome, cpf, rg, genero, telefone, login, senha, cargo, Convert.ToInt32(id));
            }

            public void ExcluirFuncionario(string id)
            {
                objFuncionario.Excluir(Convert.ToInt32(id));
            }
    }
}
