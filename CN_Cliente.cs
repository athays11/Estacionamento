using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Estacionamento
{
    public class CN_Cliente
    {
        private CD_Cliente objCliente = new CD_Cliente();

        public DataTable MostrarC()
        {
            DataTable taba = new DataTable();
            taba = objCliente.Mostrar();
            return taba;
        }

        public void InsertCliente( String nome, String cpf, String rg, string telefone)
        {
            objCliente.InsertCliente(nome, cpf, rg, telefone);
        }


        public void EditarCliente(String nome, String cpf, String rg, String telefone, String id)
        {
            objCliente.Editar(nome, cpf, rg, telefone, Convert.ToInt32(id));
        }

        public void ExcluirCliente(string id)
        {
            objCliente.Excluir(Convert.ToInt32(id));
        }

        public void ExcluirCarro(string id)
        {
            objCliente.ExcluirCarro(Convert.ToInt32(id));
        }
    }
}
