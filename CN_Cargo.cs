using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Estacionamento
{
    class CN_Cargo
    {
        CD_Cargo objCargo = new CD_Cargo();

        public void InsertCargo(string cargo)
        {
            objCargo.Insert(cargo);
        }


        public List<string> ListarCargo()
        {
            return objCargo.Listar();
        }
    }
}
