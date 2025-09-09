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
using System.Security.Cryptography;

namespace Crud
{
    public partial class Form1 : Form
    {
        //Conexão com o banco de dados Mysql
        
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=db_cadastro";
        public Form1()
        {
            InitializeComponent();

            //Configuração inicial do ListView para exibição dos dados dos clientes
            lstCliente.View = View.Details; //Define avisualisação em "detalhes"
            lstCliente.LabelEdit = true; //Permite editar os títulos das colunas 
            lstCliente.AllowColumnReorder = true; //Permite reordenar as colunas
            lstCliente.FullRowSelect = true; //Seleciona a linha inteira ao clicar
            lstCliente.GridLines = true; //Exibe as linhas de grade Listview

            //Definindo as colunas do ListView
            lstCliente.Columns.Add("Codigo", 100, HorizontalAlignment.Left); //Coluna de código
            lstCliente.Columns.Add("Nome Completo", 200, HorizontalAlignment.Left); //Coluna de código
            lstCliente.Columns.Add("Nome Social", 200, HorizontalAlignment.Left); //Coluna de código
            lstCliente.Columns.Add("E-mail", 200, HorizontalAlignment.Left); //Coluna de código
            lstCliente.Columns.Add("CPF", 200, HorizontalAlignment.Left); //Coluna de código

            //Carrega od Dados dos clientes na interface
            carregar_cliente();
        }

        private void carregar_clientes_com_query(string query)
        {
            try
            {
                //Cria conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Executa a consulta SQL fornecida
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                //Se a consulta contém  o párametro @q, adiciona o valor da caixa de pesquisa
                if (query.Contains("@q"))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");
                }

                //Executa o comando e ob´tém os resultados
                MySqlDataReader reader = cmd.ExecuteReader();

                //Limpa os itens existentes no listView antes de adicionarr novos
                lstCliente.Items.Clear();

                //Prenche o ListView com os dados do cliente
                while (reader.Read())
                {

                    //Cria uma liha para cada cliente com os dados retornados  da consulta
                    string[] row =
                    {
                        Convert.ToString(reader.GetInt32(0)), //Codigo
                        reader.GetString(1),                  //Nome completo
                        reader.GetString(2),                  //Nome Social
                        reader.GetString(3),                  //E-mail
                        reader.GetString(4),                  //CPF

                    };

                    //Adiciona a linha ao ListView
                    lstCliente.Items.Add(new ListViewItem(row));
                }

              }


            catch (MySqlException ex)
            {
                //Trata erros relacionados ao MYSQL
                MessageBox.Show("Erro" + ex.Number + " ocorreu: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                //Trata outros tipos de erro
                MessageBox.Show("Ocorreu: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro

                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }

        //Metodo para carregar todos os clientes no ListView (usando uma consulta sem parametros)

        private void carregar_cliente()
        {
            string query = "SELECT * FROM dadosdocliente ORDER BY idcliente DESC";
            carregar_clientes_com_query(query);
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

                //Cria conexão com o banco de dados

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Comando SQL para inserir um novo cliente no banco de dados
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Conexao
                };



                cmd.Prepare();
                cmd.CommandText = "INSERT INTO dadosdocliente ( nomecompleto, nomesocial, email, cpf)" + "VALUES(@nomecompleto, @nomesocial, @email, @cpf)";


                //Adiciona parametros com dados do formulário

                cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@cpf", cpf);

                //Executa o comando de inserção no banco

                cmd.ExecuteNonQuery();

                //Mensagem de sucesso
                MessageBox.Show("Contato inserido com Sucesso:",
                    "Sucsso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //Limpa os campos após o sucesso
                txtNomeCompleto.Text = String.Empty;
                txtNomeSocial.Text = "";
                txtEmail.Text = "";
                txtCPF.Text = "";

                //recarregava os clientes np listView
                carregar_cliente();

                //Muda para aba de pesquisa 
                tbControl.SelectedIndex = 1;


            }



            catch (MySqlException ex)
            {
                //Trata erros relacionados ao MYSQL
                MessageBox.Show("Erro" + ex.Number + " ocorreu: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                //Trata outros tipos de erro
                MessageBox.Show("Ocorreu: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally 
            { 
                //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro

                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }


        // Função para validar o comprimento e formato do CPF

        private bool isValidCPFLength(String cpf)
        {
            //Remove todos os caracteres não numéricos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            //Verifica se o CPF tem exatamente 11 dígitos

            return cpf.Length == 11;
        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dadosdocliente WHERE nomecompleto LIKE @q OR nomesocial LIKE @q ORDER BY idcliente DESC";
            carregar_clientes_com_query(query);
        }
    }
}
