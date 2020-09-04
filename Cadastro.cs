using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Cadastro : Form
    {
        public string desc;
        CN_Cargo objCargo = new CN_Cargo();
        //Form1 form = new Form1();
        public Cadastro()
        {
            InitializeComponent();
        
        }

        private void btnCadastroCargo_Click(object sender, EventArgs e)
        {
            if (cadastroCargo.Text != null)
            {
                desc = cadastroCargo.Text;
                objCargo.InsertCargo(cadastroCargo.Text);
            }
            cadastroCargo.Text = "";
            //form.Refresh();
            Close();
        }

       
        

       

        

        
        
        

    }
}
