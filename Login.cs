using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Data.Sql;

namespace Estacionamento
{
    public partial class Login : Form
    {
        private Conexao conn = new Conexao();
        SqlDataReader ler;
        DataTable tab = new DataTable();
        SqlCommand com = new SqlCommand();

        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            com.Connection = conn.AbrirConexao();
            com.CommandText = "Select * from tbFuncionario where loginUsuario = @login and senhaUsuario = @senha";
            com.Parameters.AddWithValue("@login", txtLogin.Text);
            com.Parameters.AddWithValue("@senha", txtSenha.Text);
            com.CommandType = CommandType.Text;
            ler = com.ExecuteReader();
            bool bTemlinha = ler.Read();
            com.Parameters.Clear();
            try
            {
                if (bTemlinha)
                {
                    
                    Visible = false;
                    Form1 tela = new Form1();
                    tela.ShowDialog();
                    conn.FecharConexao();
                    Close();
                }
                else
                {
                    MessageBox.Show("Login incorreto");
                    ler.Close();
                    conn.FecharConexao();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            txtLogin.Text = "";
            txtSenha.Text = "";


            
                
        }
     
    }
}
