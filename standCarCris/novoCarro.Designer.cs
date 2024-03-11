namespace standCarCris
{
    partial class novoCarro
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
            this.marca_nv = new System.Windows.Forms.TextBox();
            this.modelo_nv = new System.Windows.Forms.TextBox();
            this.ano_nv = new System.Windows.Forms.TextBox();
            this.preco_nv = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano de matricula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço Base(€):";
            // 
            // marca_nv
            // 
            this.marca_nv.Location = new System.Drawing.Point(423, 65);
            this.marca_nv.Name = "marca_nv";
            this.marca_nv.Size = new System.Drawing.Size(204, 26);
            this.marca_nv.TabIndex = 4;
            // 
            // modelo_nv
            // 
            this.modelo_nv.Location = new System.Drawing.Point(425, 127);
            this.modelo_nv.Name = "modelo_nv";
            this.modelo_nv.Size = new System.Drawing.Size(204, 26);
            this.modelo_nv.TabIndex = 5;
            // 
            // ano_nv
            // 
            this.ano_nv.Location = new System.Drawing.Point(425, 180);
            this.ano_nv.Name = "ano_nv";
            this.ano_nv.Size = new System.Drawing.Size(202, 26);
            this.ano_nv.TabIndex = 6;
            // 
            // preco_nv
            // 
            this.preco_nv.Location = new System.Drawing.Point(425, 233);
            this.preco_nv.Name = "preco_nv";
            this.preco_nv.Size = new System.Drawing.Size(204, 26);
            this.preco_nv.TabIndex = 7;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(198, 331);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(180, 45);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(450, 331);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(178, 45);
            this.btn_gravar.TabIndex = 9;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // novoCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 453);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.preco_nv);
            this.Controls.Add(this.ano_nv);
            this.Controls.Add(this.modelo_nv);
            this.Controls.Add(this.marca_nv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "novoCarro";
            this.Text = "Novo Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox marca_nv;
        private System.Windows.Forms.TextBox modelo_nv;
        private System.Windows.Forms.TextBox ano_nv;
        private System.Windows.Forms.TextBox preco_nv;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_gravar;
    }
}