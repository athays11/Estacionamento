using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Estacionamento
{
    class CN_EntraSaiCarro
    {
        CD_EntraSaiCarro funcionamento = new CD_EntraSaiCarro();

        public void Entrada(string placa, string dataHora)
        {
            funcionamento.Entrar(placa, dataHora);
        }

        public void Saida(string placa, string hora)
        {
            funcionamento.Sair(placa, hora);
        }

        public DataTable MostrarSaida(string placa)
        {
            DataTable taba = new DataTable();
            taba = funcionamento.MostrarSaida(placa);
            return taba;
        }

        public DataTable MostrarEntrada()
        {
            DataTable taba = new DataTable();
            taba = funcionamento.MostrarEntrada();
            return taba;
        }

        public void Limpar(string placa)
        {
            funcionamento.Limpa(placa);
        }
        
    }
}
