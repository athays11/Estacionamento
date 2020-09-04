namespace Estacionamento
{
    partial class Cadastro
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
            this.btnCadastroCargo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cadastroCargo = new System.Windows.Forms.TextBox();
            this.painelCargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelCargo
            // 
            this.painelCargo.BackColor = System.Drawing.Color.Pink;
            this.painelCargo.Controls.Add(this.label2);
            this.painelCargo.Controls.Add(this.btnCadastroCargo);
            this.painelCargo.Controls.Add(this.label3);
            this.painelCargo.Controls.Add(this.cadastroCargo);
            this.painelCargo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painelCargo.Location = new System.Drawing.Point(3, 9);
            this.painelCargo.Name = "painelCargo";
            this.painelCargo.Size = new System.Drawing.Size(293, 212);
            this.painelCargo.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Cargo";
            // 
            // btnCadastroCargo
            // 
            this.btnCadastroCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(135)))), ((int)(((byte)(150)))));
            this.btnCadastroCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCargo.ForeColor = System.Drawing.Color.White;
            this.btnCadastroCargo.Location = new System.Drawing.Point(179, 155);
            this.btnCadastroCargo.Name = "btnCadastroCargo";
            this.btnCadastroCargo.Size = new System.Drawing.Size(83, 29);
            this.btnCadastroCargo.TabIndex = 45;
            this.btnCadastroCargo.Text = "Cadastrar";
            this.btnCadastroCargo.UseVisualStyleBackColor = false;
            this.btnCadastroCargo.Click += new System.EventHandler(this.btnCadastroCargo_Click);
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
            // cadastroCargo
            // 
            this.cadastroCargo.Location = new System.Drawing.Point(56, 96);
            this.cadastroCargo.Name = "cadastroCargo";
            this.cadastroCargo.Size = new System.Drawing.Size(183, 22);
            this.cadastroCargo.TabIndex = 43;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(297, 233);
            this.Controls.Add(this.painelCargo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.painelCargo.ResumeLayout(false);
            this.painelCargo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastroCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cadastroCargo;



    }
}