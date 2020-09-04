namespace Estacionamento
{
    partial class CadastroCarroM
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
            this.btnAddCarroM = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxModeloCarroM = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddModCarro = new System.Windows.Forms.Button();
            this.painelCarroMod = new System.Windows.Forms.Panel();
            this.btnModCarro = new System.Windows.Forms.Button();
            this.lblcad = new System.Windows.Forms.Label();
            this.descMod = new System.Windows.Forms.TextBox();
            this.cbxCor = new System.Windows.Forms.ComboBox();
            this.btnAddCarroCor = new System.Windows.Forms.Button();
            this.painelCorCarroM = new System.Windows.Forms.Panel();
            this.btnAddCorCarroM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorCarroM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.placaCarroM = new System.Windows.Forms.MaskedTextBox();
            this.painelCarroMod.SuspendLayout();
            this.painelCorCarroM.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCarroM
            // 
            this.btnAddCarroM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(135)))), ((int)(((byte)(150)))));
            this.btnAddCarroM.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAddCarroM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCarroM.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnAddCarroM.ForeColor = System.Drawing.Color.White;
            this.btnAddCarroM.Location = new System.Drawing.Point(344, 188);
            this.btnAddCarroM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCarroM.Name = "btnAddCarroM";
            this.btnAddCarroM.Size = new System.Drawing.Size(87, 30);
            this.btnAddCarroM.TabIndex = 39;
            this.btnAddCarroM.Text = "Adicionar";
            this.btnAddCarroM.UseVisualStyleBackColor = false;
            this.btnAddCarroM.UseWaitCursor = true;
            this.btnAddCarroM.Click += new System.EventHandler(this.btnAddCarroM_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Modelo";
            this.label9.UseWaitCursor = true;
            // 
            // cbxModeloCarroM
            // 
            this.cbxModeloCarroM.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cbxModeloCarroM.FormattingEnabled = true;
            this.cbxModeloCarroM.Location = new System.Drawing.Point(36, 188);
            this.cbxModeloCarroM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxModeloCarroM.Name = "cbxModeloCarroM";
            this.cbxModeloCarroM.Size = new System.Drawing.Size(130, 25);
            this.cbxModeloCarroM.TabIndex = 37;
            this.cbxModeloCarroM.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Cor:";
            this.label11.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Placa:";
            this.label12.UseWaitCursor = true;
            // 
            // btnAddModCarro
            // 
            this.btnAddModCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddModCarro.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAddModCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddModCarro.Location = new System.Drawing.Point(174, 188);
            this.btnAddModCarro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddModCarro.Name = "btnAddModCarro";
            this.btnAddModCarro.Size = new System.Drawing.Size(24, 25);
            this.btnAddModCarro.TabIndex = 40;
            this.btnAddModCarro.Text = "+";
            this.btnAddModCarro.UseVisualStyleBackColor = false;
            this.btnAddModCarro.UseWaitCursor = true;
            this.btnAddModCarro.Click += new System.EventHandler(this.btnAddModCarro_Click);
            // 
            // painelCarroMod
            // 
            this.painelCarroMod.Controls.Add(this.btnModCarro);
            this.painelCarroMod.Controls.Add(this.lblcad);
            this.painelCarroMod.Controls.Add(this.descMod);
            this.painelCarroMod.Location = new System.Drawing.Point(36, 256);
            this.painelCarroMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.painelCarroMod.Name = "painelCarroMod";
            this.painelCarroMod.Size = new System.Drawing.Size(420, 97);
            this.painelCarroMod.TabIndex = 41;
            this.painelCarroMod.Visible = false;
            // 
            // btnModCarro
            // 
            this.btnModCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(135)))), ((int)(((byte)(150)))));
            this.btnModCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModCarro.ForeColor = System.Drawing.Color.White;
            this.btnModCarro.Location = new System.Drawing.Point(282, 33);
            this.btnModCarro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModCarro.Name = "btnModCarro";
            this.btnModCarro.Size = new System.Drawing.Size(42, 30);
            this.btnModCarro.TabIndex = 42;
            this.btnModCarro.Text = "Ok";
            this.btnModCarro.UseVisualStyleBackColor = false;
            this.btnModCarro.UseWaitCursor = true;
            this.btnModCarro.Click += new System.EventHandler(this.btnModCarro_Click);
            // 
            // lblcad
            // 
            this.lblcad.AutoSize = true;
            this.lblcad.Location = new System.Drawing.Point(86, 16);
            this.lblcad.Name = "lblcad";
            this.lblcad.Size = new System.Drawing.Size(57, 17);
            this.lblcad.TabIndex = 37;
            this.lblcad.Text = "Modelo:";
            this.lblcad.UseWaitCursor = true;
            // 
            // descMod
            // 
            this.descMod.Location = new System.Drawing.Point(90, 37);
            this.descMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descMod.Name = "descMod";
            this.descMod.Size = new System.Drawing.Size(185, 22);
            this.descMod.TabIndex = 36;
            this.descMod.UseWaitCursor = true;
            // 
            // cbxCor
            // 
            this.cbxCor.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cbxCor.FormattingEnabled = true;
            this.cbxCor.Location = new System.Drawing.Point(283, 116);
            this.cbxCor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCor.Name = "cbxCor";
            this.cbxCor.Size = new System.Drawing.Size(130, 25);
            this.cbxCor.TabIndex = 43;
            this.cbxCor.UseWaitCursor = true;
            // 
            // btnAddCarroCor
            // 
            this.btnAddCarroCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddCarroCor.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAddCarroCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCarroCor.Location = new System.Drawing.Point(421, 116);
            this.btnAddCarroCor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCarroCor.Name = "btnAddCarroCor";
            this.btnAddCarroCor.Size = new System.Drawing.Size(24, 24);
            this.btnAddCarroCor.TabIndex = 44;
            this.btnAddCarroCor.Text = "+";
            this.btnAddCarroCor.UseVisualStyleBackColor = false;
            this.btnAddCarroCor.UseWaitCursor = true;
            this.btnAddCarroCor.Click += new System.EventHandler(this.btnAddCarroCor_Click);
            // 
            // painelCorCarroM
            // 
            this.painelCorCarroM.Controls.Add(this.btnAddCorCarroM);
            this.painelCorCarroM.Controls.Add(this.label1);
            this.painelCorCarroM.Controls.Add(this.txtCorCarroM);
            this.painelCorCarroM.Location = new System.Drawing.Point(36, 259);
            this.painelCorCarroM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.painelCorCarroM.Name = "painelCorCarroM";
            this.painelCorCarroM.Size = new System.Drawing.Size(420, 97);
            this.painelCorCarroM.TabIndex = 43;
            this.painelCorCarroM.Visible = false;
            // 
            // btnAddCorCarroM
            // 
            this.btnAddCorCarroM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(135)))), ((int)(((byte)(150)))));
            this.btnAddCorCarroM.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAddCorCarroM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCorCarroM.ForeColor = System.Drawing.Color.White;
            this.btnAddCorCarroM.Location = new System.Drawing.Point(282, 33);
            this.btnAddCorCarroM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCorCarroM.Name = "btnAddCorCarroM";
            this.btnAddCorCarroM.Size = new System.Drawing.Size(42, 30);
            this.btnAddCorCarroM.TabIndex = 42;
            this.btnAddCorCarroM.Text = "Ok";
            this.btnAddCorCarroM.UseVisualStyleBackColor = false;
            this.btnAddCorCarroM.UseWaitCursor = true;
            this.btnAddCorCarroM.Click += new System.EventHandler(this.btnAddCorCarroM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Cor:";
            this.label1.UseWaitCursor = true;
            // 
            // txtCorCarroM
            // 
            this.txtCorCarroM.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtCorCarroM.Location = new System.Drawing.Point(90, 37);
            this.txtCorCarroM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorCarroM.Name = "txtCorCarroM";
            this.txtCorCarroM.Size = new System.Drawing.Size(185, 22);
            this.txtCorCarroM.TabIndex = 36;
            this.txtCorCarroM.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(172, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Cadastrar Carro";
            // 
            // placaCarroM
            // 
            this.placaCarroM.Cursor = System.Windows.Forms.Cursors.Default;
            this.placaCarroM.Location = new System.Drawing.Point(36, 116);
            this.placaCarroM.Mask = "AAA-####";
            this.placaCarroM.Name = "placaCarroM";
            this.placaCarroM.Size = new System.Drawing.Size(100, 22);
            this.placaCarroM.TabIndex = 48;
            // 
            // CadastroCarroM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(470, 371);
            this.Controls.Add(this.placaCarroM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddCarroCor);
            this.Controls.Add(this.cbxCor);
            this.Controls.Add(this.btnAddModCarro);
            this.Controls.Add(this.btnAddCarroM);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxModeloCarroM);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.painelCorCarroM);
            this.Controls.Add(this.painelCarroMod);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CadastroCarroM";
            this.Text = "CadastroCarroM";
            this.Load += new System.EventHandler(this.CadastroCarroM_Load);
            this.painelCarroMod.ResumeLayout(false);
            this.painelCarroMod.PerformLayout();
            this.painelCorCarroM.ResumeLayout(false);
            this.painelCorCarroM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCarroM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxModeloCarroM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddModCarro;
        private System.Windows.Forms.Panel painelCarroMod;
        private System.Windows.Forms.Button btnModCarro;
        private System.Windows.Forms.Label lblcad;
        private System.Windows.Forms.TextBox descMod;
        private System.Windows.Forms.ComboBox cbxCor;
        private System.Windows.Forms.Button btnAddCarroCor;
        private System.Windows.Forms.Panel painelCorCarroM;
        private System.Windows.Forms.Button btnAddCorCarroM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorCarroM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox placaCarroM;
    }
}