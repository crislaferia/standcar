namespace standCarCris
{
    partial class ligaBD
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
            this.servidor_in = new System.Windows.Forms.TextBox();
            this.user_in = new System.Windows.Forms.TextBox();
            this.senha_in = new System.Windows.Forms.TextBox();
            this.banco_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ligarBd = new System.Windows.Forms.Button();
            this.lbl_conectado = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // servidor_in
            // 
            this.servidor_in.Location = new System.Drawing.Point(287, 114);
            this.servidor_in.Name = "servidor_in";
            this.servidor_in.Size = new System.Drawing.Size(206, 26);
            this.servidor_in.TabIndex = 0;
            // 
            // user_in
            // 
            this.user_in.Location = new System.Drawing.Point(287, 170);
            this.user_in.Name = "user_in";
            this.user_in.Size = new System.Drawing.Size(206, 26);
            this.user_in.TabIndex = 1;
            // 
            // senha_in
            // 
            this.senha_in.Location = new System.Drawing.Point(287, 230);
            this.senha_in.Name = "senha_in";
            this.senha_in.Size = new System.Drawing.Size(206, 26);
            this.senha_in.TabIndex = 2;
            // 
            // banco_in
            // 
            this.banco_in.Location = new System.Drawing.Point(287, 278);
            this.banco_in.Name = "banco_in";
            this.banco_in.Size = new System.Drawing.Size(206, 26);
            this.banco_in.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Servidor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Banco de Dados";
            // 
            // btn_ligarBd
            // 
            this.btn_ligarBd.Location = new System.Drawing.Point(548, 176);
            this.btn_ligarBd.Name = "btn_ligarBd";
            this.btn_ligarBd.Size = new System.Drawing.Size(181, 57);
            this.btn_ligarBd.TabIndex = 8;
            this.btn_ligarBd.Text = "Conectar";
            this.btn_ligarBd.UseVisualStyleBackColor = true;
            this.btn_ligarBd.Click += new System.EventHandler(this.btn_ligarBd_Click);
            // 
            // lbl_conectado
            // 
            this.lbl_conectado.AutoSize = true;
            this.lbl_conectado.Location = new System.Drawing.Point(642, 23);
            this.lbl_conectado.Name = "lbl_conectado";
            this.lbl_conectado.Size = new System.Drawing.Size(32, 20);
            this.lbl_conectado.TabIndex = 9;
            this.lbl_conectado.Text = "yhy";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(548, 343);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(181, 58);
            this.btn_voltar.TabIndex = 10;
            this.btn_voltar.Text = "Continuar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ligaBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_conectado);
            this.Controls.Add(this.btn_ligarBd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.banco_in);
            this.Controls.Add(this.senha_in);
            this.Controls.Add(this.user_in);
            this.Controls.Add(this.servidor_in);
            this.Name = "ligaBD";
            this.Text = "Ligação ao Banco de Dados";
            this.Load += new System.EventHandler(this.ligaBD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox servidor_in;
        private System.Windows.Forms.TextBox user_in;
        private System.Windows.Forms.TextBox senha_in;
        private System.Windows.Forms.TextBox banco_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ligarBd;
        private System.Windows.Forms.Label lbl_conectado;
        private System.Windows.Forms.Button btn_voltar;
    }
}