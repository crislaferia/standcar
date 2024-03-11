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
    public partial class novoCarro : Form
    {
        public MySqlConnection conexao;

        public novoCarro()
        {
            InitializeComponent();
            conexao = ConexaodB.ObterConexao();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            // Verificar se o NIF e o contato contêm apenas números e têm um comprimento total de x dígitos
            Regex regexano = new Regex(@"^\d{4}$"); // Expressão regular para 4 dígitos numéricos
            Regex regexpreco = new Regex(@"^\d{7}$"); // Expressão regular para 7 dígitos numéricos

            // Verificar ano
            if (!regexano.IsMatch(ano_nv.Text))
            {
                MessageBox.Show("O Ano deve conter apenas 4 dígitos numéricos.");
                return;
            }

            // Verificar preco
            if (!Regex.IsMatch(preco_nv.Text, @"^\d*\.?\d*$"))
            {
                // Se não corresponder ao padrão, limpa o texto do TextBox
                preco_nv.Text = Regex.Replace(preco_nv.Text, @"[^\d\.]", "");
                preco_nv.SelectionStart = preco_nv.Text.Length; // Define o cursor para o final do texto
                MessageBox.Show("Por favor, insira um valor válido.");
                return;

            }
            // Verificar se todos os campos obrigatórios estão preenchidos
            if (string.IsNullOrEmpty(marca_nv.Text) || string.IsNullOrEmpty(modelo_nv.Text) || string.IsNullOrEmpty(ano_nv.Text) || string.IsNullOrEmpty(preco_nv.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            // Construir a consulta SQL apenas se todos os campos obrigatórios estiverem preenchidos
            string query = $"INSERT INTO carros (marca, modelo, anodematricula, precoUnitario) VALUES ('{marca_nv.Text}', '{modelo_nv.Text}', '{ano_nv.Text}', '{preco_nv.Text}')";
            try
            {
                // Crie um objeto MySqlCommand
                MySqlCommand command = new MySqlCommand(query, conexao);

                // Abra a conexão, execute o comando e feche a conexão

                int linhasAfetadas = command.ExecuteNonQuery();


                // Verifique se a inserção foi bem-sucedida
                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Carro inserido com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Falha ao inserir carro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir carro: " + ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
    }
}
