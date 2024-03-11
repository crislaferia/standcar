using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace standCarCris
{
    public partial class Clientes : Form
    {
        public MySqlConnection conexao;
        public Clientes()
        {
            InitializeComponent();
            conexao = ConexaodB.ObterConexao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crie uma consulta SQL base que seleciona todos os clientes
            string query = "SELECT * FROM clientes WHERE 1 = 1";

            // Verifique se o TextBox de NIF não está vazio e adicione a condição à consulta SQL
            if (!string.IsNullOrEmpty(nif_in.Text))
            {
                query += $" AND nif = '{nif_in.Text}'";
            }

            // Verifique se o TextBox de nome não está vazio e adicione a condição à consulta SQL
            if (!string.IsNullOrEmpty(nome_in.Text))
            {
                query += $" AND nome LIKE '%{nome_in.Text}%'";
            }

            // Crie um adaptador de dados MySQL para executar a consulta
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexao);

            // Crie um DataTable para armazenar os resultados da consulta
            DataTable dataTable = new DataTable();

            // Preencha o DataTable com os resultados da consulta
            adapter.Fill(dataTable);

            // Vincule o DataTable à DataGridView para exibir os dados
            dataGridView1.DataSource = dataTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // declarar instancia do form novo
            novoCliente novoForm = new novoCliente();
            // mostrar novo formulário bloqueando o acesso ao principal
            novoForm.ShowDialog();
        }

        private void btn_all_cl_Click(object sender, EventArgs e)
        {
            // Crie uma consulta SQL para selecionar todos os clientes
            string query = "SELECT * FROM clientes";

            // Crie um adaptador de dados MySQL para executar a consulta
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexao);

            // Crie um DataTable para armazenar os resultados da consulta
            DataTable dataTable = new DataTable();

            // Preencha o DataTable com os resultados da consulta
            adapter.Fill(dataTable);

            // Vincule o DataTable à DataGridView para exibir os dados
            dataGridView1.DataSource = dataTable;


        }
    }
}
