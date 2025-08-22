﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_composta
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }

        private Operacao OperacaSelecionada {  get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Divisao,
            Multiplicacao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            
        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            OperacaSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                    
            }
            txtResultado.Text = Convert.ToString(Resultado);
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            txtResultado.Text += ",";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }
    }
}
