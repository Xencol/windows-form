using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        private string imagemlocalizada;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerImagem_Click(object sender, EventArgs e)
        {
            pbCidade.Image = Image.FromFile(@"C:\Users\luis.mobastos\Downloads\Sampa.PNG");
            pbCidade.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {


                //Caixa de dialogo para abrir arquivo
                OpenFileDialog abrirarquivo = new OpenFileDialog();
                abrirarquivo.Filter = "jpg files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
                if (abrirarquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagemlocalizada = abrirarquivo.FileName;

                    pbAnexarImagem.ImageLocation = imagemlocalizada;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
