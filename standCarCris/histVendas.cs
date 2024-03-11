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
    public partial class histVendas : Form
    {
        public MySqlConnection conexao;
        // Declaração de uma lista para armazenar os itens originais
        public histVendas()
        {
            InitializeComponent();
            conexao = ConexaodB.ObterConexao();
        }

        private void btn_proc_vendas_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = date_inicio.Value.Date;
            DateTime dataFim = date_fim.Value.Date;

            // Realizar a consulta SQL para obter as vendas dentro do período especificado
            string query = "SELECT clientes.nome, \r\n       CONCAT(carros.marca, ' ', carros.modelo) AS carro, \r\n       vendas.dataVenda, \r\n       vendas.valorFinal \r\nFROM vendas \r\nJOIN carros ON vendas.codigodocarro = carros.codigodocarro \r\nJOIN clientes ON vendas.codigoCliente = clientes.codigoCliente \r\nWHERE vendas.dataVenda BETWEEN @dataInicio AND @dataFim;";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@dataInicio", dataInicio);
                    cmd.Parameters.AddWithValue("@dataFim", dataFim);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        data_hist.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar vendas: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = date_inicio.Value.Date;
            DateTime dataFim = date_fim.Value.Date;

            // Realizar a consulta SQL para obter as vendas dentro do período especificado
            string query = "SELECT * FROM stand_de_carros.vendas";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        data_hist.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar vendas: " + ex.Message);
            }
        }
    }
}
