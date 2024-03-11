namespace standCarCris
{
    partial class Venda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_precofinal = new System.Windows.Forms.Label();
            this.ValorDesc = new System.Windows.Forms.TextBox();
            this.list_carros = new System.Windows.Forms.ListBox();
            this.btn_realizar_venda = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_iva = new System.Windows.Forms.Label();
            this.lb_acrescimos = new System.Windows.Forms.Label();
            this.lb_precobase = new System.Windows.Forms.Label();
            this.box_clientes = new System.Windows.Forms.ComboBox();
            this.hiddenCodigoCliente = new System.Windows.Forms.TextBox();
            this.box_metodo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço base:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Método de Pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Iva 23%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descontos (%):";
            // 
            // lb_precofinal
            // 
            this.lb_precofinal.AutoSize = true;
            this.lb_precofinal.Location = new System.Drawing.Point(479, 337);
            this.lb_precofinal.Name = "lb_precofinal";
            this.lb_precofinal.Size = new System.Drawing.Size(74, 20);
            this.lb_precofinal.TabIndex = 6;
            this.lb_precofinal.Text = "-------------";
            // 
            // ValorDesc
            // 
            this.ValorDesc.Location = new System.Drawing.Point(611, 176);
            this.ValorDesc.Name = "ValorDesc";
            this.ValorDesc.Size = new System.Drawing.Size(92, 26);
            this.ValorDesc.TabIndex = 11;
            // 
            // list_carros
            // 
            this.list_carros.FormattingEnabled = true;
            this.list_carros.ItemHeight = 20;
            this.list_carros.Location = new System.Drawing.Point(47, 68);
            this.list_carros.Name = "list_carros";
            this.list_carros.Size = new System.Drawing.Size(260, 244);
            this.list_carros.TabIndex = 14;
            this.list_carros.SelectedIndexChanged += new System.EventHandler(this.list_carros_SelectedIndexChanged);
            // 
            // btn_realizar_venda
            // 
            this.btn_realizar_venda.Location = new System.Drawing.Point(641, 325);
            this.btn_realizar_venda.Name = "btn_realizar_venda";
            this.btn_realizar_venda.Size = new System.Drawing.Size(146, 46);
            this.btn_realizar_venda.TabIndex = 17;
            this.btn_realizar_venda.Text = "Confirmar";
            this.btn_realizar_venda.UseVisualStyleBackColor = true;
            this.btn_realizar_venda.Click += new System.EventHandler(this.btn_realizar_venda_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Acréscimos (*100):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 58);
            this.button1.TabIndex = 20;
            this.button1.Text = "Calcular Valor Final";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 46);
            this.button2.TabIndex = 21;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_iva
            // 
            this.lb_iva.AutoSize = true;
            this.lb_iva.Location = new System.Drawing.Point(629, 279);
            this.lb_iva.Name = "lb_iva";
            this.lb_iva.Size = new System.Drawing.Size(74, 20);
            this.lb_iva.TabIndex = 22;
            this.lb_iva.Text = "-------------";
            // 
            // lb_acrescimos
            // 
            this.lb_acrescimos.AutoSize = true;
            this.lb_acrescimos.Location = new System.Drawing.Point(629, 228);
            this.lb_acrescimos.Name = "lb_acrescimos";
            this.lb_acrescimos.Size = new System.Drawing.Size(74, 20);
            this.lb_acrescimos.TabIndex = 23;
            this.lb_acrescimos.Text = "-------------";
            this.lb_acrescimos.Click += new System.EventHandler(this.lb_acrescimos_Click);
            // 
            // lb_precobase
            // 
            this.lb_precobase.AutoSize = true;
            this.lb_precobase.Location = new System.Drawing.Point(629, 80);
            this.lb_precobase.Name = "lb_precobase";
            this.lb_precobase.Size = new System.Drawing.Size(74, 20);
            this.lb_precobase.TabIndex = 24;
            this.lb_precobase.Text = "-------------";
            // 
            // box_clientes
            // 
            this.box_clientes.FormattingEnabled = true;
            this.box_clientes.Location = new System.Drawing.Point(607, 31);
            this.box_clientes.Name = "box_clientes";
            this.box_clientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.box_clientes.Size = new System.Drawing.Size(194, 28);
            this.box_clientes.TabIndex = 25;
            this.box_clientes.Text = "Selecione:";
            this.box_clientes.SelectedIndexChanged += new System.EventHandler(this.box_clientes_SelectedIndexChanged);
            // 
            // hiddenCodigoCliente
            // 
            this.hiddenCodigoCliente.Location = new System.Drawing.Point(775, 68);
            this.hiddenCodigoCliente.Name = "hiddenCodigoCliente";
            this.hiddenCodigoCliente.Size = new System.Drawing.Size(26, 26);
            this.hiddenCodigoCliente.TabIndex = 26;
            this.hiddenCodigoCliente.Visible = false;
            // 
            // box_metodo
            // 
            this.box_metodo.FormattingEnabled = true;
            this.box_metodo.Location = new System.Drawing.Point(610, 123);
            this.box_metodo.Name = "box_metodo";
            this.box_metodo.Size = new System.Drawing.Size(92, 28);
            this.box_metodo.TabIndex = 27;
            this.box_metodo.Text = "Escolha:";
            this.box_metodo.SelectedIndexChanged += new System.EventHandler(this.box_metodo_SelectedIndexChanged);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 408);
            this.Controls.Add(this.box_metodo);
            this.Controls.Add(this.hiddenCodigoCliente);
            this.Controls.Add(this.box_clientes);
            this.Controls.Add(this.lb_precobase);
            this.Controls.Add(this.lb_acrescimos);
            this.Controls.Add(this.lb_iva);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_realizar_venda);
            this.Controls.Add(this.list_carros);
            this.Controls.Add(this.ValorDesc);
            this.Controls.Add(this.lb_precofinal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Venda";
            this.Text = "Venda de Veiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_precofinal;
        private System.Windows.Forms.TextBox ValorDesc;
        private System.Windows.Forms.ListBox list_carros;
        private System.Windows.Forms.Button btn_realizar_venda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_iva;
        private System.Windows.Forms.Label lb_acrescimos;
        private System.Windows.Forms.Label lb_precobase;
        private System.Windows.Forms.ComboBox box_clientes;
        private System.Windows.Forms.TextBox hiddenCodigoCliente;
        private System.Windows.Forms.ComboBox box_metodo;
    }
}