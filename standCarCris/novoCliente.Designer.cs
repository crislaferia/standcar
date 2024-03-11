namespace standCarCris
{
    partial class novoCliente
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
            this.btn_nv_cliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nome_nv = new System.Windows.Forms.TextBox();
            this.contacto_nv = new System.Windows.Forms.TextBox();
            this.nif_nv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contacto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIF:";
            // 
            // btn_nv_cliente
            // 
            this.btn_nv_cliente.Location = new System.Drawing.Point(553, 298);
            this.btn_nv_cliente.Name = "btn_nv_cliente";
            this.btn_nv_cliente.Size = new System.Drawing.Size(110, 48);
            this.btn_nv_cliente.TabIndex = 3;
            this.btn_nv_cliente.Text = "Gravar";
            this.btn_nv_cliente.UseVisualStyleBackColor = true;
            this.btn_nv_cliente.Click += new System.EventHandler(this.btn_nv_cliente_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nome_nv
            // 
            this.nome_nv.Location = new System.Drawing.Point(386, 71);
            this.nome_nv.Name = "nome_nv";
            this.nome_nv.Size = new System.Drawing.Size(223, 26);
            this.nome_nv.TabIndex = 5;
            // 
            // contacto_nv
            // 
            this.contacto_nv.Location = new System.Drawing.Point(386, 139);
            this.contacto_nv.Name = "contacto_nv";
            this.contacto_nv.Size = new System.Drawing.Size(223, 26);
            this.contacto_nv.TabIndex = 6;
            // 
            // nif_nv
            // 
            this.nif_nv.Location = new System.Drawing.Point(386, 210);
            this.nif_nv.Name = "nif_nv";
            this.nif_nv.Size = new System.Drawing.Size(223, 26);
            this.nif_nv.TabIndex = 7;
            // 
            // novoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 457);
            this.Controls.Add(this.nif_nv);
            this.Controls.Add(this.contacto_nv);
            this.Controls.Add(this.nome_nv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_nv_cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "novoCliente";
            this.Text = "Novo Cliente";
            this.Load += new System.EventHandler(this.novoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_nv_cliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nome_nv;
        private System.Windows.Forms.TextBox contacto_nv;
        private System.Windows.Forms.TextBox nif_nv;
    }
}