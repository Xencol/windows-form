namespace Crud
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNomeSocial = new System.Windows.Forms.TextBox();
            this.lblNomeSocial = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panelTopo.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.Gold;
            this.panelTopo.Controls.Add(this.lblTitulo);
            this.panelTopo.Location = new System.Drawing.Point(-4, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(807, 74);
            this.panelTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(17, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(277, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de Cliente";
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tabPage1);
            this.tbControl.Controls.Add(this.tabPage2);
            this.tbControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControl.Location = new System.Drawing.Point(12, 97);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(776, 283);
            this.tbControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.btnEnviar);
            this.tabPage1.Controls.Add(this.pbImagem);
            this.tabPage1.Controls.Add(this.txtCPF);
            this.tabPage1.Controls.Add(this.lblCPF);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.txtNomeSocial);
            this.tabPage1.Controls.Add(this.lblNomeSocial);
            this.tabPage1.Controls.Add(this.txtNomeCompleto);
            this.tabPage1.Controls.Add(this.lblNomeCompleto);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados do Cliente";
            // 
            // pbImagem
            // 
            this.pbImagem.Location = new System.Drawing.Point(579, 24);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(100, 133);
            this.pbImagem.TabIndex = 8;
            this.pbImagem.TabStop = false;
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCPF.ForeColor = System.Drawing.Color.White;
            this.txtCPF.Location = new System.Drawing.Point(162, 189);
            this.txtCPF.Mask = "###,###,###-##";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(122, 26);
            this.txtCPF.TabIndex = 7;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.ForeColor = System.Drawing.Color.Gold;
            this.lblCPF.Location = new System.Drawing.Point(23, 190);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(162, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Gold;
            this.lblEmail.Location = new System.Drawing.Point(23, 134);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // txtNomeSocial
            // 
            this.txtNomeSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNomeSocial.ForeColor = System.Drawing.Color.White;
            this.txtNomeSocial.Location = new System.Drawing.Point(162, 76);
            this.txtNomeSocial.Name = "txtNomeSocial";
            this.txtNomeSocial.Size = new System.Drawing.Size(276, 26);
            this.txtNomeSocial.TabIndex = 3;
            // 
            // lblNomeSocial
            // 
            this.lblNomeSocial.AutoSize = true;
            this.lblNomeSocial.ForeColor = System.Drawing.Color.Gold;
            this.lblNomeSocial.Location = new System.Drawing.Point(23, 76);
            this.lblNomeSocial.Name = "lblNomeSocial";
            this.lblNomeSocial.Size = new System.Drawing.Size(98, 20);
            this.lblNomeSocial.TabIndex = 2;
            this.lblNomeSocial.Text = "Nome Social";
            this.lblNomeSocial.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNomeCompleto.ForeColor = System.Drawing.Color.White;
            this.txtNomeCompleto.Location = new System.Drawing.Point(162, 20);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(276, 26);
            this.txtNomeCompleto.TabIndex = 1;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.ForeColor = System.Drawing.Color.Gold;
            this.lblNomeCompleto.Location = new System.Drawing.Point(23, 21);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(123, 20);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome Completo";
            this.lblNomeCompleto.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Gold;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(21, 395);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(118, 45);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Black;
            this.btnRemover.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.Gold;
            this.btnRemover.Location = new System.Drawing.Point(145, 395);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(155, 45);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover Dados";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Gold;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(579, 178);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 32);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.panelTopo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblNomeSocial;
        private System.Windows.Forms.TextBox txtNomeSocial;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Button btnEnviar;
    }
}

