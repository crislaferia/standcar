using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace standCarCris
{
    public partial class Carros : Form
    {
        public MySqlConnection conexao;
        public Carros()
        {
            InitializeComponent();
            conexao = ConexaodB.ObterConexao();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_proc_car_Click(object sender, EventArgs e)
        {
            // Crie uma consulta SQL base que seleciona todos os clientes
            string query = "SELECT * FROM carros WHERE 1 = 1";

            // Verifique se o TextBox de NIF não está vazio e adicione a condição à consulta SQL
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                query += $" AND marca = '{comboBox1.Text}'";
            }

            // Verifique se o TextBox de nome não está vazio e adicione a condição à consulta SQL
            if (!string.IsNullOrEmpty(comboBox2.Text))
            {
                query += $" AND anodematricula LIKE '%{comboBox2.Text}%'";
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
    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // Armazenar o valor selecionado antes de limpar os itens
            string valorSelecionado = comboBox1.SelectedItem?.ToString();

            // Remover o manipulador de eventos SelectedIndexChanged
            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;

            // Limpar itens existentes no ComboBox
            comboBox1.Items.Clear();

            // Criar um conjunto para armazenar as marcas únicas
            HashSet<string> marcasUnicas = new HashSet<string>();

            // Crie uma consulta SQL para selecionar os nomes dos clientes
            string query = "SELECT DISTINCT marca FROM carros";

            // Crie um comando MySqlCommand para executar a consulta
            MySqlCommand command = new MySqlCommand(query, conexao);

            // Execute o comando e crie um leitor de dados para ler os resultados
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                // Verifique se há linhas retornadas
                if (reader.HasRows)
                {
                    // Iterar sobre as linhas retornadas
                    while (reader.Read())
                    {
                        // Obter a marca do carro da linha atual
                        string marca = reader["marca"].ToString();

                        // Adicionar a marca ao conjunto se ela ainda não estiver presente
                        if (!marcasUnicas.Contains(marca))
                        {
                            comboBox1.Items.Add(marca);
                            marcasUnicas.Add(marca);
                        }
                    }
                }
            }

            // Defina o índice selecionado no ComboBox para o valor selecionado armazenado anteriormente
            comboBox1.SelectedItem = valorSelecionado;

            // Restaurar o manipulador de eventos SelectedIndexChanged
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            // Armazenar o valor selecionado antes de limpar os itens
            string valorSelecionado = comboBox2.SelectedItem?.ToString();

            // Remover o manipulador de eventos SelectedIndexChanged
            comboBox2.SelectedIndexChanged -= comboBox2_SelectedIndexChanged;

            // Limpar itens existentes no ComboBox
            comboBox2.Items.Clear();

            // Criar um conjunto para armazenar as marcas únicas
            HashSet<string> anoUnico = new HashSet<string>();

            // Crie uma consulta SQL para selecionar os nomes dos clientes
            string query = "SELECT DISTINCT anodematricula FROM carros";

            // Crie um comando MySqlCommand para executar a consulta
            MySqlCommand command = new MySqlCommand(query, conexao);

            // Execute o comando e crie um leitor de dados para ler os resultados
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                // Verifique se há linhas retornadas
                if (reader.HasRows)
                {
                    // Iterar sobre as linhas retornadas
                    while (reader.Read())
                    {
                        // Obter a marca do carro da linha atual
                        string ano = reader["anodematricula"].ToString();

                        // Adicionar a marca ao conjunto se ela ainda não estiver presente
                        if (!anoUnico.Contains(ano))
                        {
                            comboBox2.Items.Add(ano);
                            anoUnico.Add(ano);
                        }
                    }
                }
            }

            // Defina o índice selecionado no ComboBox para o valor selecionado armazenado anteriormente
            comboBox2.SelectedItem = valorSelecionado;

            // Restaurar o manipulador de eventos SelectedIndexChanged
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }

        private void btn_novo_car_Click(object sender, EventArgs e)
        {
            // declarar instancia do form novo
            novoCarro novoForm = new novoCarro();
            // mostrar novo formulário bloqueando o acesso ao principal
            novoForm.ShowDialog();
        }
    }
    }
    
