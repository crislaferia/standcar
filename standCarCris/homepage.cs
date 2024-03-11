using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace standCarCris
{
    public partial class homepage : Form
    {
        public homepage()
        {
            
            InitializeComponent();
            // Defina o tamanho mínimo do formulário principal com base no tamanho do Panel mais uma margem adicional
            panel1.Location = new Point((this.ClientSize.Width - panel1.Width) / 2, (this.ClientSize.Height - panel1.Height) / 2);
            // Desabilita os ToolStripMenuItems que devem ser bloqueados antes da conexão ser estabelecida
            DesabilitarMenuItens();

        }

        private void DesabilitarMenuItens()
        {
            panel1.Visible= false;
            // Desabilita os ToolStripMenuItems que devem ser bloqueados antes da conexão ser estabelecida
            vendas.Enabled = false; // Substitua "toolStripMenuItem2" pelo nome do ToolStripMenuItem que deseja desabilitar
            clientes.Enabled = false; // Substitua "toolStripMenuItem3" pelo nome do ToolStripMenuItem que deseja desabilitar
            carros.Enabled = false; // Substitua "toolStripMenuItem3" pelo nome do ToolStripMenuItem que deseja desabilitar
                                                // Adicione mais linhas conforme necessário para desabilitar outros ToolStripMenuItems
        }

        public void HabilitarMenuItens()
        {
            panel1.Visible = true;
            // Habilita os ToolStripMenuItems que devem ser desbloqueados após a conexão ser estabelecida
            vendas.Enabled = true; // Substitua "toolStripMenuItem2" pelo nome do ToolStripMenuItem que deseja habilitar
            clientes.Enabled = true; // Substitua "toolStripMenuItem3" pelo nome do ToolStripMenuItem que deseja habilitar
            carros.Enabled = true; // Substitua "toolStripMenuItem3" pelo nome do ToolStripMenuItem que deseja habilitar
                                               // Adicione mais linhas conforme necessário para habilitar outros ToolStripMenuItems
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ligaBD novoform = new ligaBD();
            //AbrirFormNoPainel(new ligaBD());
            novoform.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new Venda());
        }

        private void carrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new Carros());
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new Clientes());
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new histVendas());
        }

        private void homepage_Activated(object sender, EventArgs e)
        {
            if (ConexaodB.ObterConexao() != null && ConexaodB.ObterConexao().State == ConnectionState.Open)
            {
                lbl_conectado.Text = "Conectado";

            }
            else
                lbl_conectado.Text = "Desconectado";
        }

        private void AbrirFormNoPainel(Form form)
        {
            // Limpa o painel antes de adicionar um novo formulário
            panel1.Controls.Clear();

            // Ajusta as propriedades do formulário filho
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Anchor = AnchorStyles.None; // Define a âncora como None
            form.Margin = new Padding(0); // Define a margem como Auto

            // Define a altura do Panel baseado na altura do formulário filho
            //panel1.Height = form.Height;

            // Ajusta a posição do Panel para centralizá-lo dentro do formulário principal
            panel1.Location = new Point((this.ClientSize.Width - panel1.Width) / 2, (this.ClientSize.Height - panel1.Height) / 2);

            // Adiciona o formulário ao painel
            panel1.Controls.Add(form);

            // Exibe o nome da form atualmente exibida em algum lugar do formulário principal
            labelNomeForm.Text = form.Text;


            // Exibe o formulário
            form.Show();
        }

        private void homepage_Enter(object sender, EventArgs e)
        {
            if (ConexaodB.ObterConexao() != null && ConexaodB.ObterConexao().State == ConnectionState.Open)
            {
                lbl_conectado.Text = "Conectado";
            }
            else
                lbl_conectado.Text = "Desconectado";
        }

        private void desligarBd_Click(object sender, EventArgs e)
        {
            ConexaodB.Desconectar();
            MessageBox.Show("Desconectado com Sucesso!");
            DesabilitarMenuItens();
            panel1.Controls.Clear();
            labelNomeForm.Text = string.Empty;
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new sobre());
            panel1.Visible = true;
        }

        public void homepage_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("O evento homepage_Load foi acionado.");
            if (ConexaodB.ObterConexao() != null && ConexaodB.ObterConexao().State == ConnectionState.Open)
            {
                //MessageBox.Show("chedou ao habilitar.");
                HabilitarMenuItens();
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new Carros());
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new Clientes());
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new novoCliente());
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new novoCarro());
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            labelNomeForm.Text = string.Empty;
        }
    }
}
