using Mysqlx.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Crud
{
    public partial class Form1 : Form
    {
        //Conexão com o banco de dados Mysql
        
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root;password; database=db_cadastro"
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validação de campos obrigátorios

                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||
                    string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                    string.IsNullOrEmpty(txtCPF.Text.Trim()))
                {
                    MessageBox.Show("Todos os campos devem ser preencher.",
                                    "Validação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; //impede o prosseguimento se algum campo estiver vazio
                }
                
                string cpf = txtCPF.Text.Trim();   
                
                if (!isValidCPFLength(cpf))
                {
                    MessageBox.Show("CPF inválido. Certifique-se  de que o CPF tenha 11 dígitos numéricos.",
                                    "validação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                    return; //impede o prosseguimento se o CPF for inválido
                }
            }

            catch (Exception)
            {

                throw;
            }
        }

        // Função para validar o comprimento e formato do CPF

        private bool isValidCPFLength(String cpf)
        {
            //Remove todos os caracteres não numéricos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            //Verifica se o CPF tem exatamente 11 dígitos

            return cpf.Length > 11;
        }
    }
}
