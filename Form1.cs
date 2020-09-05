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
    public partial class Form1 : Form
    {
        CN_Cliente objc = new CN_Cliente();
        CN_Funcionario objFunc = new CN_Funcionario();
        CN_Cargo objCargo = new CN_Cargo();
        CN_CarroClienteM umCarro = new CN_CarroClienteM();
        CN_EntraSaiCarro funcionamento = new CN_EntraSaiCarro();

        

        private String idCliente = null;
        private String idFuncionario = null;
        private String idCarro = null;
        Boolean editarFunc = false;
        Boolean editarCliente = false;

        Boolean removeCarro = false;
        //cargo
        Cadastro cadastro = new Cadastro();
        CadastroModelo modelo = new CadastroModelo();
        CadastroCarroM carroM = new CadastroCarroM();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarCarros();
            MostrarCliente();
            MostrarFuncionario();
            MostrarCargo();
            painelPrincipal.Controls.Clear();
            painelPrincipal.Controls.Add(painelVagas);
            this.MaximizeBox = false;
            viewCarrosEstacionados.DataSource = null;
            viewCarrosEstacionados.Controls.Clear();
            viewCarrosEstacionados.DataSource = funcionamento.MostrarEntrada();
            tbEstacionados.DataSource = null;
            tbEstacionados.Controls.Clear();
            tbEstacionados.DataSource = funcionamento.MostrarEntrada();

        }

        private void MostrarCargo()
        {
            CN_Cargo onj = new CN_Cargo();
            cbxCargoFuncionario.DataSource = null;
            cbxCargoFuncionario.Items.Clear();
            cbxCargoFuncionario.DataSource = onj.ListarCargo();
            cbxCargoFuncionario.Update();
        }

        private void MostrarFuncionario()
        {
            CN_Funcionario func = new CN_Funcionario();
            viewFuncionarios.DataSource = func.MostrarFunc();
        }
        private void MostrarCliente()
        {
            CN_Cliente x = new CN_Cliente();
            viewClienteM.DataSource = x.MostrarC();
        }
        private void MostrarCarros()
        {
            CN_CarroClienteM car = new CN_CarroClienteM();
            viewCarrosClienteM.DataSource = car.MostrarCarros();
        }




        private void btnInicio_Click(object sender, EventArgs e)
        {
            painelPrincipal.Controls.Clear();
            painelPrincipal.Controls.Add(painelVagas);
            tbEstacionados.DataSource = null;
            tbEstacionados.Controls.Clear();
            tbEstacionados.DataSource = funcionamento.MostrarEntrada();

        }
        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            painelPrincipal.Controls.Clear();
            painelPrincipal.Controls.Add(painelFuncionario);
        }
        private void btnClienteM_Click(object sender, EventArgs e)
        {
            painelPrincipal.Controls.Clear();
            painelPrincipal.Controls.Add(painelClientesMensais);
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Dispose();
            Login login = new Login();
            login.ShowDialog();  
        }       
        private void addCargo_Click(object sender, EventArgs e)
        {
            cadastro.ShowDialog();
            if (cadastro.desc != null)
            {
                MostrarCargo();
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            painelPrincipal.Controls.Clear();
            painelPrincipal.Controls.Add(painelEntrada);
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            painelPrincipal.Controls.Clear();
            painelPrincipal.Controls.Add(painelSaida);
        }

        private void btnCadastroCarroClienteM_Click(object sender, EventArgs e)
        {
            carroM.ShowDialog();
            if (carroM.placa != null && carroM.modelo != null && carroM.cor != null)
            {
                listCarroClienteM.Items.Add(carroM.placa);
            }
        }

        private void btnModeloCarroEntrada_Click(object sender, EventArgs e)
        {
           
        }

        
        

        private void btnCadastroClienteM_Click(object sender, EventArgs e)
        {
            if(editarCliente)
            {
                objc.EditarCliente(txtNomeClienteM.Text, txtCpfClienteM.Text, txtRgClienteM.Text, txtTelefoneClienteM.Text, idCliente);
                MostrarCliente();
                MessageBox.Show("Cliente Alterado");
                editarCliente = false;
            }
            else
            {
            try
            {
                objc.InsertCliente(txtNomeClienteM.Text, txtCpfClienteM.Text, txtRgClienteM.Text, txtTelefoneClienteM.Text);

                if (listCarroClienteM.Items != null)
                {
                    for(int i = 0; i < listCarroClienteM.Items.Count; i++){
                       umCarro.CompletaCarro(listCarroClienteM.Items[i].ToString());
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Vish");
            }

            MostrarCliente();
            MessageBox.Show("Cliente Cadastrado");
            }

            txtNomeClienteM.Text = "";
            txtRgClienteM.Text = "";
            txtCpfClienteM.Text = "";
            txtTelefoneClienteM.Text = "";
            listCarroClienteM.Items.Clear();
        }

        private void painelClientesMensais_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listCarrosClienteM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoverClienteM_Click(object sender, EventArgs e)
        {
            if (removeCarro)
            {
                if ((viewCarrosClienteM.SelectedRows.Count > 0))
                {
                    idCarro = viewCarrosClienteM.CurrentRow.Cells["codCarrosClienteMensal"].Value.ToString();
                    objc.ExcluirCarro(idCarro);
                    MostrarCarros();
                    MessageBox.Show("Carro removido com sucesso");
                    
                }
            }
            else
            {
                if ((viewClienteM.SelectedRows.Count > 0))
                {
                    idCliente = viewClienteM.CurrentRow.Cells["codClienteMensal"].Value.ToString();
                    objc.ExcluirCliente(idCliente);
                    MessageBox.Show("Cliente removido com sucesso");
                    MostrarCliente();
                }
            }
            
        }


        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            if ((viewFuncionarios.SelectedRows.Count > 0))
            {
                idFuncionario = viewFuncionarios.CurrentRow.Cells["codFuncionario"].Value.ToString();
                objFunc.ExcluirFuncionario(idFuncionario);
                MessageBox.Show("Funcionario removido com sucesso");
                MostrarFuncionario();
            }
        }

        private void btnCadastroFunc_Click(object sender, EventArgs e)
        {
            if(editarFunc)
            {
                objFunc.EditarFunc(nomeFuncionario.Text, cpfFuncionario.Text, rgFuncionario.Text, cbxSexoFuncionario.Text, txtTelefoneFuncionario.Text, txtLoginFuncionario.Text, txtSenhaFuncionario.Text, cbxCargoFuncionario.SelectedItem.ToString(), idFuncionario);
                MessageBox.Show("Funcionário Alterado");
               
               MostrarFuncionario();
               editarFunc = false;
            }
            else
            {
                objFunc.InsertFuncionario(nomeFuncionario.Text, cpfFuncionario.Text, rgFuncionario.Text, cbxSexoFuncionario.SelectedItem.ToString(), txtTelefoneFuncionario.Text, txtLoginFuncionario.Text, txtSenhaFuncionario.Text, cbxCargoFuncionario.SelectedItem.ToString());       
                MostrarFuncionario();
                MessageBox.Show("Funcionario Cadastrado");
            }

            nomeFuncionario.Text = "";
            cpfFuncionario.Text = "";
            rgFuncionario.Text = "";
            txtTelefoneFuncionario.Text = "";
            txtLoginFuncionario.Text = "";
            txtSenhaFuncionario.Text = "";
        }

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            if(viewFuncionarios.SelectedRows.Count > 0){
                editarFunc = true;
                
                nomeFuncionario.Text = viewFuncionarios.CurrentRow.Cells["nomeFuncionario"].Value.ToString();
                cpfFuncionario.Text = viewFuncionarios.CurrentRow.Cells["cpfFuncionario"].Value.ToString();
                rgFuncionario.Text = viewFuncionarios.CurrentRow.Cells["rgFuncionario"].Value.ToString();
                cbxSexoFuncionario.Text = viewFuncionarios.CurrentRow.Cells["sexoFuncionario"].Value.ToString();
                idFuncionario = viewFuncionarios.CurrentRow.Cells["codFuncionario"].Value.ToString();
                cbxCargoFuncionario.Text = viewFuncionarios.CurrentRow.Cells["descricaoCargo"].Value.ToString();
                txtLoginFuncionario.Text = viewFuncionarios.CurrentRow.Cells["loginUsuario"].Value.ToString();
                txtSenhaFuncionario.Text = viewFuncionarios.CurrentRow.Cells["senhaUsuario"].Value.ToString();
                txtTelefoneFuncionario.Text = viewFuncionarios.CurrentRow.Cells["telefoneFuncionario"].Value.ToString();
            }
        }

        private void btnMostraCliente_Click(object sender, EventArgs e)
        {
            removeCarro = false;
     
            btnEditarClienteM.Visible = true;
            viewCarrosClienteM.Visible = false;
            viewClienteM.Visible = true;
        }

        private void btnMostraCarro_Click(object sender, EventArgs e)
        {
            MostrarCarros();
            removeCarro = true;
            
            btnEditarClienteM.Visible = false;
            viewClienteM.Visible = false;
            viewCarrosClienteM.Visible = true;
        }

        private void btnEditarClienteM_Click(object sender, EventArgs e)
        {
            //visible false no listbox
            editarCliente = true;
            if (viewClienteM.SelectedRows.Count > 0)
            {
                txtNomeClienteM.Text = viewClienteM.CurrentRow.Cells["nomeClienteMensal"].Value.ToString();
                txtCpfClienteM.Text = viewClienteM.CurrentRow.Cells["cpfClienteMensal"].Value.ToString();
                txtRgClienteM.Text = viewClienteM.CurrentRow.Cells["rgClienteMensal"].Value.ToString();
                txtTelefoneClienteM.Text = viewClienteM.CurrentRow.Cells["telefoneClienteMensal"].Value.ToString();
                idCliente = viewClienteM.CurrentRow.Cells["codClienteMensal"].Value.ToString();
            }
        }

        private void btnExcluirCarroC_Click(object sender, EventArgs e)
        {
            umCarro.RemoveCarroLista(listCarroClienteM.SelectedItem.ToString());
            listCarroClienteM.Items.RemoveAt(listCarroClienteM.SelectedIndex);

        }

        private void btnEntradaCarro_Click(object sender, EventArgs e)
        {
            viewCarrosEstacionados.DataSource = null;
            viewCarrosEstacionados.Controls.Clear();
            //viewCarrosEstacionados.Update();
            viewCarrosEstacionados.DataSource = funcionamento.MostrarEntrada();
            funcionamento.Entrada(txtPlacaEntrada.Text, dataEntrada.Text);
            txtPlacaEntrada.Text = "";
            dataEntrada.Text = "";
        }

        private void btnConcluirSaida_Click(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;
            funcionamento.Saida(txtPlacaSaida.Text, agora.ToString());
            
            painelRecibo.Visible = true;
            viewRecibo.DataSource = funcionamento.MostrarSaida(txtPlacaSaida.Text);
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;
            dataEntrada.Text = agora.ToString();
        }

        private void btnOkRecibo_Click(object sender, EventArgs e)
        {
            painelRecibo.Visible = false;
            viewRecibo.Controls.Clear();
            funcionamento.Limpar(txtPlacaSaida.Text);
            txtPlacaSaida.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tbEstacionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewCarrosClienteM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


       

        

      

       


        

        

        

      
        
        

       

       


        
        

        


        }      
        
    }

