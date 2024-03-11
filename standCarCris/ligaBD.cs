using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace standCarCris
{
    public partial class ligaBD : Form
    {
        public MySqlConnection conexao;
        public ligaBD()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ligaBD_Load(object sender, EventArgs e)
        {
            
            if (ConexaodB.ObterConexao() != null && ConexaodB.ObterConexao().State == ConnectionState.Open)
            {
                lbl_conectado.Text = "Conectado";
            }
            
            else 
                lbl_conectado.Text = "Desconectado";
        }


        private void btn_ligarBd_Click(object sender, EventArgs e)
        {
            var strconexao = "server=localhost;uid=root;pwd=;database=stand_de_carros";
            //var strconexao = "server=" + servidor_in.Text + ";user=" + user_in.Text + ";password=" + senha_in.Text + ";database=" + banco_in.Text;
            //public MySqlConnection conexao;

            if (ConexaodB.EstabelecerConexao(strconexao))
            {

                MessageBox.Show("Conexão estabelecida com sucesso!");
                lbl_conectado.Text = "Connectado";

                // Mensagem de depuração
                Console.WriteLine("Antes de chamar HabilitarMenuItens");

                if (Application.OpenForms["homepage"] != null)
                {
                    // Obtém a instância existente da homepage
                    homepage formHomePage = (homepage)Application.OpenForms["homepage"];

                    // Chama o método HabilitarMenuItens da instância existente da homepage
                    formHomePage.HabilitarMenuItens();

                    // Mensagem de depuração
                    Console.WriteLine("Após chamar HabilitarMenuItens");
                }
            }
            else
            {
                MessageBox.Show("Falha ao estabelecer a conexão com o banco de dados.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
