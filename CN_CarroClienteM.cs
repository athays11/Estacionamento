using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Estacionamento
{
    class CN_CarroClienteM
    {
        CD_CarroClienteM objCarro = new CD_CarroClienteM();
        private Conexao conexao = new Conexao();
        DataTable tab = new DataTable();
        SqlCommand com = new SqlCommand();

        public void InsertModelo(string modelo)
        {
            objCarro.InsertModelo(modelo);
        }
        public List<string> ListarModelo()
        {
            return objCarro.ListarModelo();
        }




        public void InsertCor(string cor)
        {
            objCarro.InsertCor(cor);
        }
        public List<string> ListarCor()
        {
            return objCarro.ListarCor();
        }


        public void InsertCarro(string placa, string modelo, string cor)
        {
            objCarro.InsertCarro(placa, modelo, cor);
        }

        public void CompletaCarro(string placa)
        {
            objCarro.CompletaCarro(placa);
        }



        public DataTable MostrarCarros()
        {
            DataTable taba = new DataTable();
            taba = objCarro.MostrarCarros();
            return taba;
        }

        public void RemoveCarroLista(string placa)
        {
            objCarro.ExcluirCarroLista(placa);
        }
        
    
    }
}
