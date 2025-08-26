namespace PictureBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbComputador = new System.Windows.Forms.PictureBox();
            this.pbCidade = new System.Windows.Forms.PictureBox();
            this.pbAnexarImagem = new System.Windows.Forms.PictureBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnVerImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnexarImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pbComputador
            // 
            this.pbComputador.Image = ((System.Drawing.Image)(resources.GetObject("pbComputador.Image")));
            this.pbComputador.Location = new System.Drawing.Point(24, 37);
            this.pbComputador.Name = "pbComputador";
            this.pbComputador.Size = new System.Drawing.Size(503, 127);
            this.pbComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbComputador.TabIndex = 0;
            this.pbComputador.TabStop = false;
            // 
            // pbCidade
            // 
            this.pbCidade.Location = new System.Drawing.Point(24, 182);
            this.pbCidade.Name = "pbCidade";
            this.pbCidade.Size = new System.Drawing.Size(503, 127);
            this.pbCidade.TabIndex = 1;
            this.pbCidade.TabStop = false;
            // 
            // pbAnexarImagem
            // 
            this.pbAnexarImagem.Location = new System.Drawing.Point(577, 37);
            this.pbAnexarImagem.Name = "pbAnexarImagem";
            this.pbAnexarImagem.Size = new System.Drawing.Size(211, 272);
            this.pbAnexarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnexarImagem.TabIndex = 2;
            this.pbAnexarImagem.TabStop = false;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.Chocolate;
            this.btnValidar.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Location = new System.Drawing.Point(591, 347);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(186, 63);
            this.btnValidar.TabIndex = 4;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnVerImagem
            // 
            this.btnVerImagem.BackColor = System.Drawing.Color.Chocolate;
            this.btnVerImagem.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerImagem.ForeColor = System.Drawing.Color.White;
            this.btnVerImagem.Location = new System.Drawing.Point(177, 347);
            this.btnVerImagem.Name = "btnVerImagem";
            this.btnVerImagem.Size = new System.Drawing.Size(186, 63);
            this.btnVerImagem.TabIndex = 3;
            this.btnVerImagem.Text = "Ver Imagem";
            this.btnVerImagem.UseVisualStyleBackColor = false;
            this.btnVerImagem.Click += new System.EventHandler(this.btnVerImagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnVerImagem);
            this.Controls.Add(this.pbAnexarImagem);
            this.Controls.Add(this.pbCidade);
            this.Controls.Add(this.pbComputador);
            this.Name = "Form1";
            this.Text = "X";
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnexarImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbComputador;
        private System.Windows.Forms.PictureBox pbCidade;
        private System.Windows.Forms.PictureBox pbAnexarImagem;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnVerImagem;
    }
}

