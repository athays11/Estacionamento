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
    public partial class CadastroCarroM : Form
    {
        //CN_Modelo objModelo = new CN_Modelo();
        CN_CarroClienteM objCarroClienteM = new CN_CarroClienteM();
        public string placa;
        public string modelo;
        public string cor;

        public CadastroCarroM()
        {
            InitializeComponent();

        }
        private void CadastroCarroM_Load(object sender, EventArgs e)
        {
            MostrarCor();
            MostrarModelo();
        }
        private void MostrarCor()
        {
            CN_CarroClienteM objCarro = new CN_CarroClienteM();
            cbxCor.DataSource = null;
            cbxCor.Items.Clear();
            cbxCor.DataSource = objCarro.ListarCor();
            cbxCor.Update();
        }
        private void MostrarModelo()
        {
            CN_CarroClienteM objCarro = new CN_CarroClienteM();
            cbxModeloCarroM.DataSource = null;
            cbxModeloCarroM.Items.Clear();
            cbxModeloCarroM.DataSource = objCarro.ListarModelo();
            cbxModeloCarroM.Update();
        }





        private void btnAddModCarro_Click(object sender, EventArgs e)
        {
            painelCarroMod.Visible = true;
        }

        private void btnModCarro_Click(object sender, EventArgs e)
        {
            painelCarroMod.Visible = false;
            if (descMod.Text != null)
            {
                objCarroClienteM.InsertModelo(descMod.Text);
                MostrarModelo();
                descMod.Text = "";
            }
            

        }

        private void btnAddCarroCor_Click(object sender, EventArgs e)
        {
            painelCorCarroM.Visible = true;
        }

        private void btnAddCorCarroM_Click(object sender, EventArgs e)
        {
            painelCorCarroM.Visible = false;
            if (txtCorCarroM.Text != null)
            {
                objCarroClienteM.InsertCor(txtCorCarroM.Text);
                MostrarCor();
                txtCorCarroM.Text = "";
            }
        }

        private void btnAddCarroM_Click(object sender, EventArgs e)
        {
            if (placaCarroM.Text != null && cbxModeloCarroM.SelectedItem.ToString() != null && cbxCor.SelectedItem.ToString() != null)
            {
                placa = placaCarroM.Text;
                modelo = cbxModeloCarroM.Text;
                cor = cbxCor.Text;
                objCarroClienteM.InsertCarro(placa, cbxModeloCarroM.Text, cbxCor.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
            placaCarroM.Text = "";
            
            //objCarroClienteM.InsertCarro(placaCarroM.Text, cbxModeloCarroM.SelectedItem.ToString(), cbxCor.SelectedItem.ToString());
            
        }

        private void placaCarroM_TextChanged(object sender, EventArgs e)
        {

        }

        

        


         
        
    }
}
