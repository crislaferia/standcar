using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace standCarCris
{
    public class ConexaodB
    {
        private static MySqlConnection conexao;
        public static MySqlConnection ObterConexao()
        {
            
            return conexao;
        }

        public static bool EstabelecerConexao(string strconexao)
        {
            if (conexao == null || conexao.State== System.Data.ConnectionState.Closed)
            {
                conexao = new MySqlConnection(strconexao);
                try { conexao.Open();
                    return true;
                }

                catch { MessageBox.Show("Erro na Ligação à BD"); return false; }
            }
            return true;
        }
        public static void Desconectar()
        {
            if (conexao != null && conexao.State != System.Data.ConnectionState.Closed)
            {
                conexao.Close();
            }
        }

    }
}