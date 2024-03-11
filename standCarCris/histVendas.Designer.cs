namespace standCarCris
{
    partial class histVendas
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
            this.data_hist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.date_inicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.date_fim = new System.Windows.Forms.DateTimePicker();
            this.btn_proc_vendas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_hist)).BeginInit();
            this.SuspendLayout();
            // 
            // data_hist
            // 
            this.data_hist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.data_hist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_hist.Location = new System.Drawing.Point(34, 78);
            this.data_hist.Name = "data_hist";
            this.data_hist.RowHeadersVisible = false;
            this.data_hist.RowHeadersWidth = 62;
            this.data_hist.RowTemplate.Height = 28;
            this.data_hist.Size = new System.Drawing.Size(746, 278);
            this.data_hist.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde:";
            // 
            // date_inicio
            // 
            this.date_inicio.Location = new System.Drawing.Point(140, 29);
            this.date_inicio.Name = "date_inicio";
            this.date_inicio.Size = new System.Drawing.Size(214, 26);
            this.date_inicio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Até:";
            // 
            // date_fim
            // 
            this.date_fim.Location = new System.Drawing.Point(404, 29);
            this.date_fim.Name = "date_fim";
            this.date_fim.Size = new System.Drawing.Size(216, 26);
            this.date_fim.TabIndex = 4;
            // 
            // btn_proc_vendas
            // 
            this.btn_proc_vendas.Location = new System.Drawing.Point(644, 28);
            this.btn_proc_vendas.Name = "btn_proc_vendas";
            this.btn_proc_vendas.Size = new System.Drawing.Size(98, 35);
            this.btn_proc_vendas.TabIndex = 5;
            this.btn_proc_vendas.Text = "Procurar";
            this.btn_proc_vendas.UseVisualStyleBackColor = true;
            this.btn_proc_vendas.Click += new System.EventHandler(this.btn_proc_vendas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(747, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // histVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_proc_vendas);
            this.Controls.Add(this.date_fim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_inicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_hist);
            this.Name = "histVendas";
            this.Text = "Historico Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.data_hist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_hist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_inicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_fim;
        private System.Windows.Forms.Button btn_proc_vendas;
        private System.Windows.Forms.Button button1;
    }
}