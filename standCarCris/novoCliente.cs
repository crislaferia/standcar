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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace standCarCris
{
    public partial class novoCliente : Form
    {
        public MySqlConnection conexao;

        public novoCliente()
        {
            InitializeComponent();
            conexao = ConexaodB.ObterConexao();
        }

        private void btn_nv_cliente_Click(object sender, EventArgs e)
        {
            // Verificar se o NIF e o contato contêm apenas números e têm um comprimento total de 9 dígitos
            Regex regex = new Regex(@"^\d{9}$"); // Expressão regular para 9 dígitos numéricos

            // Verificar NIF
            if (!regex.IsMatch(nif_nv.Text))
            {
                MessageBox.Show("O NIF deve conter apenas 9 dígitos numéricos.");
                return;
            }

            // Verificar contato
            if (!regex.IsMatch(contacto_nv.Text))
            {
                MessageBox.Show("O contato deve conter apenas 9 dígitos numéricos.");
                return;
            }
            // Verificar se todos os campos obrigatórios estão preenchidos
            if (string.IsNullOrEmpty(nome_nv.Text) || string.IsNullOrEmpty(contacto_nv.Text) || string.IsNullOrEmpty(nif_nv.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            // Construir a consulta SQL apenas se todos os campos obrigatórios estiverem preenchidos
            string query = $"INSERT INTO clientes (nome, contacto, nif) VALUES ('{nome_nv.Text}', '{contacto_nv.Text}', '{nif_nv.Text}')";
            try
            {
                // Crie um objeto MySqlCommand
                MySqlCommand command = new MySqlCommand(query, conexao);

                // Abra a conexão, execute o comando e feche a conexão
                
                int linhasAfetadas = command.ExecuteNonQuery();
                

                // Verifique se a inserção foi bem-sucedida
                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Cliente inserido com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Falha ao inserir cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir cliente: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
