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
    public partial class CadastroModelo : Form
    {
        CN_CarroClienteM carro = new CN_CarroClienteM();
        public string desc;
        public CadastroModelo()
        {
            InitializeComponent();
        }

        private void btnCadastroModelo_Click(object sender, EventArgs e)
        {
            if (txtCadastroModelo.Text != null)
            {
                desc = txtCadastroModelo.Text;
                carro.InsertModelo(txtCadastroModelo.Text);
            }
            txtCadastroModelo.Text = "";
            Close();
        }
    }
}
