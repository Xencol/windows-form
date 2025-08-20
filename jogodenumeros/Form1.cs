using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodenumeros
{
    public partial class frmJogoDeNumeros : Form
    {

        int randomNumber;
        int numeroTentativas = 10;
        int palpitedoJogador;
        bool jogoGanho = false;
        string dica;

        public frmJogoDeNumeros()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblsubTitulo_Click(object sender, EventArgs e)
        {

        }

        private void frmJogoDeNumeros_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101); //Número aleatório de 1 a 100
        }

        private void btnTentativas_Click(object sender, EventArgs e)
        {
            //verifica se o jogo já foi ganho

            if (jogoGanho)
            {
                txtResultado.Text = "Você já acertou o número! Reinicie para jogar novamente.";
                return;
            }

            //verifica se o número de tentativas chegou à 0

            if (numeroTentativas == 0)
            {
                txtResultado.Text = "Você não tem mais tentativas. Fim de jogo";
                return;
            }

            //validação do valor de palpite (entre 1 a 100)

            if(!int.TryParse(txtNumeroInserido.Text, out palpitedoJogador) || palpitedoJogador <1 || palpitedoJogador >100)
            {
                txtResultado.Text = "Insira um número entre 1 e 100";
                return;
            }

            numeroTentativas--;
            lblNumeroTentativas.Text = numeroTentativas.ToString(); 

            if (palpitedoJogador == randomNumber)
            {
                jogoGanho = true;
                dica = "Você acertou!";
            }

            else if (palpitedoJogador < randomNumber)
            {
                dica = "o número que você digitou é menor, digite um número maior";
            }

            else 
            {
                dica = "o número que você digitou é maior, digite um número menor";
            }

            txtResultado.Text = dica;
        }
    }
}
