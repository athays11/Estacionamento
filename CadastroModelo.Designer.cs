namespace Estacionamento
{
    partial class CadastroModelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.painelCargo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastroModelo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCadastroModelo = new System.Windows.Forms.TextBox();
            this.painelCargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelCargo
            // 
            this.painelCargo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.painelCargo.Controls.Add(this.label2);
            this.painelCargo.Controls.Add(this.btnCadastroModelo);
            this.painelCargo.Controls.Add(this.label3);
            this.painelCargo.Controls.Add(this.txtCadastroModelo);
            this.painelCargo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painelCargo.ForeColor = System.Drawing.Color.White;
            this.painelCargo.Location = new System.Drawing.Point(12, 9);
            this.painelCargo.Name = "painelCargo";
            this.painelCargo.Size = new System.Drawing.Size(293, 212);
            this.painelCargo.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Novo Modelo";
            // 
            // btnCadastroModelo
            // 
            this.btnCadastroModelo.BackColor = System.Drawing.Color.MintCream;
            this.btnCadastroModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroModelo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroModelo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnCadastroModelo.Location = new System.Drawing.Point(174, 155);
            this.btnCadastroModelo.Name = "btnCadastroModelo";
            this.btnCadastroModelo.Size = new System.Drawing.Size(88, 29);
            this.btnCadastroModelo.TabIndex = 45;
            this.btnCadastroModelo.Text = "Cadastrar";
            this.btnCadastroModelo.UseVisualStyleBackColor = false;
            this.btnCadastroModelo.Click += new System.EventHandler(this.btnCadastroModelo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Descrição:";
            // 
            // txtCadastroModelo
            // 
            this.txtCadastroModelo.Location = new System.Drawing.Point(56, 96);
            this.txtCadastroModelo.Name = "txtCadastroModelo";
            this.txtCadastroModelo.Size = new System.Drawing.Size(183, 22);
            this.txtCadastroModelo.TabIndex = 43;
            // 
            // CadastroModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(317, 233);
            this.Controls.Add(this.painelCargo);
            this.Name = "CadastroModelo";
            this.Text = "CadastroModelo";
            this.painelCargo.ResumeLayout(false);
            this.painelCargo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastroModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCadastroModelo;
    }
}