namespace standCarCris
{
    partial class homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            this.MenuStrip_princ = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.carros = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ligarBd = new System.Windows.Forms.ToolStripMenuItem();
            this.desligarBd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_conectado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNomeForm = new System.Windows.Forms.Label();
            this.MenuStrip_princ.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip_princ
            // 
            this.MenuStrip_princ.BackColor = System.Drawing.Color.PaleTurquoise;
            this.MenuStrip_princ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MenuStrip_princ.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip_princ.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip_princ.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.vendas,
            this.carros,
            this.clientes,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.MenuStrip_princ.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_princ.Name = "MenuStrip_princ";
            this.MenuStrip_princ.Size = new System.Drawing.Size(890, 33);
            this.MenuStrip_princ.TabIndex = 0;
            this.MenuStrip_princ.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // vendas
            // 
            this.vendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.vendas.Name = "vendas";
            this.vendas.Size = new System.Drawing.Size(89, 29);
            this.vendas.Text = "Vendas";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(257, 34);
            this.toolStripMenuItem7.Text = "Realizar Venda";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(257, 34);
            this.toolStripMenuItem8.Text = "Historico Vendas";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // carros
            // 
            this.carros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.novoToolStripMenuItem});
            this.carros.Name = "carros";
            this.carros.Size = new System.Drawing.Size(82, 29);
            this.carros.Text = "Carros";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.novoToolStripMenuItem.Text = "Novo Carro";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // clientes
            // 
            this.clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem1,
            this.novoClienteToolStripMenuItem});
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(95, 29);
            this.clientes.Text = "Clientes";
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(224, 34);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ligarBd,
            this.desligarBd});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 29);
            this.toolStripMenuItem1.Text = "Banco de dados";
            // 
            // ligarBd
            // 
            this.ligarBd.Name = "ligarBd";
            this.ligarBd.Size = new System.Drawing.Size(183, 34);
            this.ligarBd.Text = "Ligar";
            this.ligarBd.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // desligarBd
            // 
            this.desligarBd.Name = "desligarBd";
            this.desligarBd.Size = new System.Drawing.Size(183, 34);
            this.desligarBd.Text = "Desligar";
            this.desligarBd.Click += new System.EventHandler(this.desligarBd_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(77, 29);
            this.toolStripMenuItem3.Text = "Sobre";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(302, 34);
            this.toolStripMenuItem4.Text = "Sobre o Stand Car Cris";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click_1);
            // 
            // lbl_conectado
            // 
            this.lbl_conectado.AutoSize = true;
            this.lbl_conectado.Location = new System.Drawing.Point(759, 494);
            this.lbl_conectado.Name = "lbl_conectado";
            this.lbl_conectado.Size = new System.Drawing.Size(78, 20);
            this.lbl_conectado.TabIndex = 10;
            this.lbl_conectado.Text = "asdasdas";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::standCarCris.Properties.Resources.stand_car_cris;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(33, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 407);
            this.panel1.TabIndex = 11;
            // 
            // labelNomeForm
            // 
            this.labelNomeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNomeForm.AutoSize = true;
            this.labelNomeForm.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelNomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeForm.Location = new System.Drawing.Point(694, 8);
            this.labelNomeForm.Name = "labelNomeForm";
            this.labelNomeForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNomeForm.Size = new System.Drawing.Size(0, 22);
            this.labelNomeForm.TabIndex = 12;
            this.labelNomeForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::standCarCris.Properties.Resources.stand_car_cris__2_;
            this.ClientSize = new System.Drawing.Size(890, 523);
            this.Controls.Add(this.labelNomeForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_conectado);
            this.Controls.Add(this.MenuStrip_princ);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip_princ;
            this.MaximumSize = new System.Drawing.Size(912, 579);
            this.MinimumSize = new System.Drawing.Size(912, 579);
            this.Name = "homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stand Car Cris";
            this.Activated += new System.EventHandler(this.homepage_Activated);
            this.Load += new System.EventHandler(this.homepage_Load);
            this.Enter += new System.EventHandler(this.homepage_Enter);
            this.MenuStrip_princ.ResumeLayout(false);
            this.MenuStrip_princ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_princ;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ligarBd;
        private System.Windows.Forms.ToolStripMenuItem desligarBd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem vendas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.Label lbl_conectado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Label labelNomeForm;
        private System.Windows.Forms.ToolStripMenuItem carros;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientes;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
    }
}

