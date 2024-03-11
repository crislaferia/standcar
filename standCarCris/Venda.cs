using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace standCarCris
{
    public partial class Venda : Form


    {
        public MySqlConnection conexao;
        // Declaração de uma lista para armazenar os itens originais
        List<string> clientesOriginais = new List<string>();
        // Declaração de uma lista para armazenar os métodos de pagamento originais
        List<string> metodosOriginais = new List<string>();

        // Campos para armazenar os valores necessários
        private int codigoCarroSelecionado;
        private int codigoClienteSelecionado;
        private int idMetodoSelecionado;
        private DateTime dataVenda;
        private DateTime dataPagamento;
        private decimal acrescimo;
        private decimal valorFinal;
        // Declare uma variável de classe para armazenar a mensagem da venda
        private string mensagemVenda;

        public Venda()
        {
            InitializeComponent();
            conexao = ConexaodB.ObterConexao();
            CarregarCarros();
            CarregarClientes();
            box_metodo.DropDownStyle = ComboBoxStyle.DropDown;
            CarregarPagamentos();

            // Configurar o preenchimento automático da ComboBox
            box_clientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            box_clientes.AutoCompleteSource = AutoCompleteSource.CustomSource;
            box_clientes.AutoCompleteCustomSource = new AutoCompleteStringCollection();

            // Preencher a fonte de preenchimento automático com os clientes originais
            box_clientes.AutoCompleteCustomSource.AddRange(clientesOriginais.ToArray());
            // Preencher a fonte de preenchimento automático com os métodos de pagamento originais
            box_metodo.AutoCompleteCustomSource.AddRange(metodosOriginais.ToArray());
        }
        private void box_clientes_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = box_clientes.Text.ToLower();
            box_clientes.Items.Clear();

            foreach (var cliente in clientesOriginais)
            {
                if (cliente.ToLower().Contains(textoDigitado))
                {
                    box_clientes.Items.Add(cliente);
                }
            }

            if (box_clientes.Items.Count > 0)
            {
                box_clientes.SelectedIndex = 0;
                box_clientes.DroppedDown = true;
            }
        }

        private void CarregarClientes()
        {
            try
            {
                // Limpar itens existentes na ComboBox
                box_clientes.Items.Clear();

                // Limpar a lista de clientes originais
                clientesOriginais.Clear();

                // Consulta SQL para selecionar os dados dos clientes
                string query = "SELECT CONCAT(codigoCliente, ' - ', nome) AS cliente_info FROM clientes";

                MySqlCommand cmd = new MySqlCommand(query, conexao);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Adicionar cada cliente à ComboBox e à lista de clientes originais
                while (reader.Read())
                {
                    string cliente = reader["cliente_info"].ToString();
                    box_clientes.Items.Add(cliente);
                    clientesOriginais.Add(cliente);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }


        private void CarregarCarros()
        {
            try
            {
                // Consulta SQL para selecionar os dados dos carros e obter o preço base como decimal
                string query = "SELECT codigodocarro, marca, modelo, anodematricula, precoUnitario FROM carros WHERE codigodocarro NOT IN (SELECT codigodocarro FROM vendas)";

                MySqlCommand cmd = new MySqlCommand(query, conexao);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Limpar a lista antes de adicionar novos itens
                list_carros.Items.Clear();

                // Adicionar cada carro à ListBox
                while (reader.Read())
                {
                    // Formatar a linha com os dados do carro para exibição
                    string carroInfo = $"{reader["codigodocarro"]} - {reader["marca"]} {reader["modelo"]} ({reader["anodematricula"]}), {reader["precoUnitario"]:C2}";

                    // Adicionar o carro à ListBox
                    list_carros.Items.Add(carroInfo);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar carros: " + ex.Message);
            }
        }


        private decimal precoBaseCarroSelecionado; // Variável para armazenar o preço base do carro selecionado

        private void list_carros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifique se um item está selecionado na ListBox
            if (list_carros.SelectedItem != null)
            {
                // Obtenha o texto selecionado na ListBox
                string selectedItemText = list_carros.SelectedItem.ToString();
                int.TryParse(selectedItemText.Split('-')[0].Trim(), out int codigoCarro);
                codigoCarroSelecionado = codigoCarro;

                // Divida o texto para obter os valores individuais (código, marca, modelo, ano, preço)
                string[] values = selectedItemText.Split('-', '(', ')', ',');

                // Tente converter o preço base para decimal
                if (decimal.TryParse(values[4].Trim(), out precoBaseCarroSelecionado))
                {
                    // Preencha os campos (labels) com os valores recuperados
                    lb_precobase.Text = precoBaseCarroSelecionado.ToString("C2"); // Exibe o preço base formatado na label
                                                                                  // Chama o método para calcular o IVA
                    
                    CalcularIVA();
                }
                else
                {
                    // Exibe uma mensagem de erro se a conversão falhar
                    MessageBox.Show("Erro: O valor do preço base do carro não é válido.");
                }
                
            }
        }


        private void EsconderCodigoCliente()
        {
            // Verifica se algum item está selecionado na ComboBox
            if (box_clientes.SelectedItem != null)
            {
                // Armazena o código do cliente selecionado no campo oculto
                string clienteSelecionado = box_clientes.SelectedItem.ToString();
                string[] partes = clienteSelecionado.Split('-');
                hiddenCodigoCliente.Text = partes[0].Trim(); // Assume que o código do cliente é a primeira parte antes do traço
            }
        }


        private void box_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            EsconderCodigoCliente();
            // Atualizar o código do cliente selecionado
            if (int.TryParse(hiddenCodigoCliente.Text, out int codigoCliente))
            {
                codigoClienteSelecionado = codigoCliente;
            }
            else
            {
                // Exibir uma mensagem de erro se a conversão falhar
                MessageBox.Show("Erro: Não foi possível obter o código do cliente selecionado.");
            }
        }
       
        //private void box_metodo_TextChanged(object sender, EventArgs e)
        //{
            //string textoDigitado = box_metodo.Text.ToLower();
            //box_metodo.Items.Clear();

            //foreach (var metodo in metodosOriginais)
            //{
            //    if (metodo.ToLower().Contains(textoDigitado))
            //    {
            //        box_metodo.Items.Add(metodo);
            //    }
            //}

            //if (box_metodo.Items.Count > 0)
            //{
            //    box_metodo.SelectedIndex = 0;
            //    box_metodo.DroppedDown = true;
            //}
       // }
        
        private void CarregarPagamentos()
        {
            try
            {
                // Consulta SQL para selecionar os métodos de pagamento
                string query = "SELECT CONCAT(idMetodo, ' - ', nomeMetodo, ' ', acrescimo) as metodo_info FROM MetodoPagamento";

                MySqlCommand cmd = new MySqlCommand(query, conexao);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Limpar a lista antes de adicionar novos itens
                box_metodo.Items.Clear();

                // Adicionar cada método de pagamento à ComboBox
                while (reader.Read())
                {
                    box_metodo.Items.Add(reader["metodo_info"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar métodos de pagamento: " + ex.Message);
            }
        }

        private void box_metodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifique se um item está selecionado na ComboBox de métodos de pagamento
            if (box_metodo.SelectedItem != null)
            {
                // Obtenha o texto selecionado na ComboBox de métodos de pagamento
                string selectedItemText = box_metodo.SelectedItem.ToString();

                // Encontre a posição do último espaço para separar o nome do método do valor do acréscimo
                int lastSpaceIndex = selectedItemText.LastIndexOf(' ');

                // Verifique se o índice do último espaço é válido
                if (lastSpaceIndex != -1)
                {
                    // Obtenha o nome do método (do início até o último espaço)
                    string nomeMetodo = selectedItemText.Substring(0, lastSpaceIndex);

                    // Obtenha o valor do acréscimo (do último espaço até o final)
                    string acrescimo = selectedItemText.Substring(lastSpaceIndex).Trim();

                    // Atribua o valor do acréscimo à lb_acrescimos
                    lb_acrescimos.Text = acrescimo;
                    int.TryParse(selectedItemText.Split('-')[0].Trim(), out int idMetodo);
                    idMetodoSelecionado = idMetodo;
                }
                else
                {
                    // Se não foi possível encontrar o último espaço, exiba uma mensagem de erro
                    MessageBox.Show("Erro: Não foi possível obter o valor do acrescimo.");
                }
            }
            // Chama o método para calcular o IVA
            CalcularIVA();
        }

        private void CalcularIVA()
        {
            Console.WriteLine("Valor de precoBase 1: " + lb_precobase);

            // Obtém o texto em lb_precobase e remove espaços em branco
            //string precoBaseText = lb_precobase.Text.Trim();
            string precoBaseFormatado = lb_precobase.Text; // Exemplo de valor monetário formatado
            Console.WriteLine("Valor de precoBase 2: " + precoBaseFormatado);

            // Remove os caracteres de formatação monetária, como vírgulas e símbolos de moeda
            precoBaseFormatado = precoBaseFormatado.Replace(",", ",").Replace("$", "").Replace("€", ""); // Adicione outros símbolos de moeda, se necessário
                                                                                                        // Use o valor de precoBase como um número decimal
            Console.WriteLine("Valor de precoBase antes: " + precoBaseFormatado);
            // Converte a string formatada em um número decimal
            if (decimal.TryParse(precoBaseFormatado, out decimal precoBase))
            {
                // Use o valor de precoBase como um número decimal
                Console.WriteLine("Valor de precoBase depois: " + precoBase);

                // Calcula o valor do IVA (23% do valor em lb_precobase)
                decimal iva = precoBase * 0.23m;

                // Exibe o valor do IVA na label lb_iva
                lb_iva.Text = iva.ToString("C2");
            }
            
            else
            {
                // Exibe uma mensagem de erro se a conversão falhar
                MessageBox.Show("Erro: O valor em lb_precobase não é válido.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica se todos os valores necessários foram preenchidos
            if (!string.IsNullOrEmpty(lb_precobase.Text) &&
                !string.IsNullOrEmpty(lb_iva.Text) &&
                !string.IsNullOrEmpty(lb_acrescimos.Text) &&
                !string.IsNullOrEmpty(ValorDesc.Text))
            {
                // Converte os valores das labels para decimal
                if (decimal.TryParse(lb_precobase.Text.Replace("€", "").Replace("$", ""), out decimal precoBase) &&
                    decimal.TryParse(lb_iva.Text.Replace("€", "").Replace("$", ""), out decimal iva) &&
                    decimal.TryParse(lb_acrescimos.Text.Replace("€", "").Replace(".", ","), out decimal acrescimo) &&
                    decimal.TryParse(ValorDesc.Text.Replace("€", "").Replace("$", ""), out decimal desconto))
                {
                    // Verifica se os valores estão dentro de limites válidos
                    if (precoBase >= 0 && iva >= 0 && acrescimo >= 0 && acrescimo <= 100 && desconto >= 0 && desconto <= 100)
                    {
                        // Calcula o valor final
                        decimal valorFinal = precoBase + iva + (precoBase * acrescimo) - (precoBase * desconto / 100);

                        // Exibe o valor final
                        
                        //MessageBox.Show($"Valor Final: {valorFinal:C2}");

                        lb_precofinal.Text = valorFinal.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Erro: Os valores devem ser maiores ou iguais a zero, e o acréscimo e desconto devem estar entre 0 e 100.");
                    }
                }
                else
                {
                    // Exibe uma mensagem indicando que a conversão falhou para identificar o valor que está causando o problema
                    MessageBox.Show($"Erro: Um ou mais valores não puderam ser convertidos para decimal. Acréscimo: {lb_acrescimos.Text}");
                }
            }
            else
            {
                MessageBox.Show("Erro: Todos os campos devem estar preenchidos.");
            }
        }
        private void InserirVenda(int codigoCarro, int codigoCliente, decimal precoBase, int idMetodo, decimal desconto, decimal iva, decimal acrescimo, decimal valorFinal, DateTime dataVenda, DateTime dataPagamento)
        {
            try
            {
                // Construir a consulta SQL para inserção na tabela de vendas
                string query = "INSERT INTO vendas (codigodocarro, codigoCliente, dataVenda, precobase, idMetodo, descontos, iva, acrescimo, valorFinal, dataPagamento) " +
                               "VALUES (@codigoCarro, @codigoCliente, @dataVenda, @precoBase, @idMetodo, @desconto, @iva, @acrescimo, @valorFinal, @dataPagamento)";

                // Criar um novo objeto MySqlCommand com a consulta SQL e a conexão
                MySqlCommand cmd = new MySqlCommand(query, conexao);

                // Adicionar parâmetros à consulta SQL para prevenir injeção de SQL
                cmd.Parameters.AddWithValue("@codigoCarro", codigoCarro);
                cmd.Parameters.AddWithValue("@codigoCliente", codigoCliente);
                cmd.Parameters.AddWithValue("@dataVenda", dataVenda);
                cmd.Parameters.AddWithValue("@precoBase", precoBase);
                cmd.Parameters.AddWithValue("@idMetodo", idMetodo);
                cmd.Parameters.AddWithValue("@desconto", desconto);
                cmd.Parameters.AddWithValue("@iva", iva);
                cmd.Parameters.AddWithValue("@acrescimo", acrescimo);
                cmd.Parameters.AddWithValue("@valorFinal", valorFinal);
                cmd.Parameters.AddWithValue("@dataPagamento", dataPagamento);

                // Executar a consulta SQL
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Venda registrada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao registrar venda.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir venda: " + ex.Message);
            }
        }

        private void btn_realizar_venda_Click(object sender, EventArgs e)
        {
             

            // Defina a data da venda como a data atual
            dataVenda = DateTime.Now;

            // Verifica se todos os valores necessários foram preenchidos
            if (codigoCarroSelecionado != 0 && codigoClienteSelecionado != 0 && idMetodoSelecionado != 0 &&
                precoBaseCarroSelecionado != 0 && !string.IsNullOrEmpty(lb_iva.Text) && !string.IsNullOrEmpty(lb_acrescimos.Text) &&
                !string.IsNullOrEmpty(ValorDesc.Text))

            {
                // Converte os valores das labels para decimal
                if (decimal.TryParse(lb_iva.Text.Replace("€", "").Replace("$", ""), out decimal iva) &&
                    decimal.TryParse(lb_acrescimos.Text.Replace("€", "").Replace(".", ","), out decimal acrescimo) &&
                    decimal.TryParse(ValorDesc.Text.Replace("€", "").Replace("$", ""), out decimal desconto))
                {
                    // Verifica se os valores estão dentro de limites válidos
                    if (precoBaseCarroSelecionado >= 0 && iva >= 0 && acrescimo >= 0 && acrescimo <= 100 && desconto >= 0 && desconto <= 100)
                    {
                        // Calcula o valor final
                        decimal valorFinal = precoBaseCarroSelecionado + iva + (precoBaseCarroSelecionado * acrescimo) - (precoBaseCarroSelecionado * desconto / 100);

                        // Exibe o valor final
                        //MessageBox.Show($"Valor Final: {valorFinal:C2}");

                        // Mostra uma MessageBox com as variáveis antes de enviar para o banco de dados
                        string mensagem = $"Código do carro: {codigoCarroSelecionado}\n" +
                                          $"Código do cliente: {codigoClienteSelecionado}\n" +
                                          $"ID do método: {idMetodoSelecionado}\n" +
                                          $"Preço base do carro: {precoBaseCarroSelecionado:C2}\n" +
                                          $"IVA: {iva:C2}\n" +
                                          $"Acréscimo: {acrescimo * 100}%\n" +
                                          $"Desconto: {desconto}%\n" +
                                          $"Data da venda: {dataVenda}\n" +
                                          $"Data do pagamento prevista: {CalcularDataPagamentoPrevista(idMetodoSelecionado)}\n" + // Adiciona a data de pagamento prevista
                                          $"Valor Final : {valorFinal}\n";

                        // Exibe uma caixa de diálogo de confirmação
                        DialogResult resultado = MessageBox.Show(mensagem, "Confirmar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        

                        // Verifica se o usuário confirmou a venda
                        if (resultado == DialogResult.Yes)
                        {
                            

                            dataPagamento = CalcularDataPagamentoPrevista(idMetodoSelecionado);
                            // Exibe uma caixa de diálogo de confirmação
                            DialogResult impressao = MessageBox.Show("Deseja Imprimir o Comprovativo?\n(será automaticamente impresso na impressora padrão)", "Confirmar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (impressao == DialogResult.Yes)
                            {
                                // Atribua a mensagem da venda à variável mensagemVenda
                                mensagemVenda = mensagem;

                                // Crie uma instância da classe PrintDocument para controlar a impressão
                                PrintDocument pd = new PrintDocument();
                                pd.PrintPage += new PrintPageEventHandler(pd_PrintPage); // Adicione um manipulador de eventos para o evento PrintPage

                                // Inicie o processo de impressão
                                pd.Print();
                            }
                            // Chama a função para inserir a venda no banco de dados
                            InserirVenda(codigoCarroSelecionado, codigoClienteSelecionado, precoBaseCarroSelecionado, idMetodoSelecionado, desconto, iva, acrescimo, valorFinal, dataVenda, dataPagamento);

                            AtualizarStatusCarroVendido(codigoCarroSelecionado);
                            LimparCampos();
                            CarregarDadosOriginais();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro: Os valores devem ser maiores ou iguais a zero, e o acréscimo e desconto devem estar entre 0 e 100.");
                    }
                }
                else
                {
                    // Exibe uma mensagem indicando que a conversão falhou para identificar o valor que está causando o problema
                    MessageBox.Show($"Erro: Um ou mais valores não puderam ser convertidos para decimal. Acréscimo: {lb_acrescimos.Text}");
                }
            }
            else
            {
                MessageBox.Show("Erro: Todos os campos devem estar preenchidos.");
            }

        }
        // Método para desenhar o conteúdo a ser impresso
        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Defina a fonte e as configurações de impressão
            Font fonte = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            float linhaAtual = 3;
            string mensagemEditada = $"\n\n Comprovativo de Venda:\n\n{mensagemVenda}";
            // Desenhe a mensagem da venda na página
            e.Graphics.DrawString(mensagemEditada, fonte, brush, new PointF(100, linhaAtual));
        }

        // Função para calcular a data de pagamento prevista com base no tipo de método de pagamento
        private DateTime CalcularDataPagamentoPrevista(int idMetodo)
        {
            DateTime dataPagamentoPrevista = dataVenda; // Por padrão, a data de pagamento prevista é a mesma da data da venda

            // Implementação da lógica para calcular a data de pagamento prevista com base no tipo de método de pagamento
            switch (idMetodo)
            {
                case 1: // Visa - dia seguinte
                    dataPagamentoPrevista = dataVenda.AddDays(1);
                    break;
                case 2: // Cash - mesmo dia
                    dataPagamentoPrevista = dataVenda;
                    break;
                case 3: // 6x - 6 meses depois
                    dataPagamentoPrevista = dataVenda.AddMonths(6);
                    break;
                case 4: // 12x - 12 meses depois
                    dataPagamentoPrevista = dataVenda.AddMonths(12);
                    break;
                case 5: // 24x - 24 meses depois
                    dataPagamentoPrevista = dataVenda.AddMonths(24);
                    break;
                case 6: // 48x - 48 meses depois
                    dataPagamentoPrevista = dataVenda.AddMonths(48);
                    break;
                case 7: // Transf - 3 dias depois
                    dataPagamentoPrevista = dataVenda.AddDays(3);
                    break;
                default:
                    break;
            }

            return dataPagamentoPrevista;
        }

        private void AtualizarStatusCarroVendido(int codigoCarroVendido)
        {
            try
            {
                // Construir a consulta SQL para atualizar o campo "vendido" na tabela de carros
                string query = "UPDATE carros SET vendido = true WHERE codigodocarro = @codigoCarroVendido";

                // Criar um novo objeto MySqlCommand com a consulta SQL e a conexão
                MySqlCommand cmd = new MySqlCommand(query, conexao);

                // Adicionar o parâmetro à consulta SQL para prevenir injeção de SQL
                cmd.Parameters.AddWithValue("@codigoCarroVendido", codigoCarroVendido);

                // Executar a consulta SQL
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    //MessageBox.Show("Status do carro atualizado para vendido.");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar status do carro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar status do carro: " + ex.Message);
            }
        }

        private void lb_acrescimos_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CarregarDadosOriginais();
        }

        private void LimparCampos()
        {
            // Limpar todos os campos da forma
            // Por exemplo:
            box_clientes.Text = string.Empty;
            list_carros.ClearSelected();
            lb_precobase.Text = string.Empty;
            box_metodo.Text = string.Empty;
            lb_precofinal.Text = string.Empty;
            lb_iva.Text = string.Empty;
            hiddenCodigoCliente.Text = string.Empty;    
            lb_acrescimos.Text = string.Empty;
            ValorDesc.Text = string.Empty;
            // Limpar outros campos conforme necessário
        }

        private void CarregarDadosOriginais()
        {
            // Recarregar os dados originais
            CarregarCarros();
            CarregarClientes();
            CarregarPagamentos();
            // Outras operações de recarga conforme necessário
        }

    }
}

