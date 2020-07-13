namespace Marfrig.Formularios.Cadastro
{
    partial class frmCadastro
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
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.cmbPecuarista = new System.Windows.Forms.ComboBox();
            this.lblPecuarista = new System.Windows.Forms.Label();
            this.gpbAnimais = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAnimal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.gpbInformacoes = new System.Windows.Forms.GroupBox();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.qtdGado = new System.Windows.Forms.NumericUpDown();
            this.gpbAnimais.SuspendLayout();
            this.gpbInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtdGado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.Location = new System.Drawing.Point(235, 22);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(87, 13);
            this.lblDataEntrega.TabIndex = 2;
            this.lblDataEntrega.Text = "Data de entrega:";
            // 
            // cmbPecuarista
            // 
            this.cmbPecuarista.FormattingEnabled = true;
            this.cmbPecuarista.Location = new System.Drawing.Point(69, 18);
            this.cmbPecuarista.Name = "cmbPecuarista";
            this.cmbPecuarista.Size = new System.Drawing.Size(161, 21);
            this.cmbPecuarista.TabIndex = 4;
            // 
            // lblPecuarista
            // 
            this.lblPecuarista.AutoSize = true;
            this.lblPecuarista.Location = new System.Drawing.Point(7, 22);
            this.lblPecuarista.Name = "lblPecuarista";
            this.lblPecuarista.Size = new System.Drawing.Size(60, 13);
            this.lblPecuarista.TabIndex = 5;
            this.lblPecuarista.Text = "Pecuarista:";
            // 
            // gpbAnimais
            // 
            this.gpbAnimais.Controls.Add(this.qtdGado);
            this.gpbAnimais.Controls.Add(this.txtTotal);
            this.gpbAnimais.Controls.Add(this.label5);
            this.gpbAnimais.Controls.Add(this.cmbAnimal);
            this.gpbAnimais.Controls.Add(this.label2);
            this.gpbAnimais.Controls.Add(this.label1);
            this.gpbAnimais.Controls.Add(this.label3);
            this.gpbAnimais.Controls.Add(this.txtPreco);
            this.gpbAnimais.Location = new System.Drawing.Point(12, 81);
            this.gpbAnimais.Name = "gpbAnimais";
            this.gpbAnimais.Size = new System.Drawing.Size(539, 61);
            this.gpbAnimais.TabIndex = 8;
            this.gpbAnimais.TabStop = false;
            this.gpbAnimais.Text = "Animais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "R$";
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.Location = new System.Drawing.Point(59, 28);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.Size = new System.Drawing.Size(121, 21);
            this.cmbAnimal.TabIndex = 6;
            this.cmbAnimal.SelectedIndexChanged += new System.EventHandler(this.cmbAnimal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Preço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Animal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Qtd:";
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(334, 29);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(60, 20);
            this.txtPreco.TabIndex = 9;
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.Location = new System.Drawing.Point(452, 152);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(99, 23);
            this.btnConfirmarCompra.TabIndex = 0;
            this.btnConfirmarCompra.Text = "&Confirmar Compra";
            this.btnConfirmarCompra.UseVisualStyleBackColor = true;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // gpbInformacoes
            // 
            this.gpbInformacoes.Controls.Add(this.dtpDataEntrega);
            this.gpbInformacoes.Controls.Add(this.cmbPecuarista);
            this.gpbInformacoes.Controls.Add(this.lblPecuarista);
            this.gpbInformacoes.Controls.Add(this.lblDataEntrega);
            this.gpbInformacoes.Location = new System.Drawing.Point(12, 12);
            this.gpbInformacoes.Name = "gpbInformacoes";
            this.gpbInformacoes.Size = new System.Drawing.Size(539, 54);
            this.gpbInformacoes.TabIndex = 9;
            this.gpbInformacoes.TabStop = false;
            this.gpbInformacoes.Text = "Informações";
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.Location = new System.Drawing.Point(322, 19);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(211, 20);
            this.dtpDataEntrega.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(436, 29);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(97, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // qtdGado
            // 
            this.qtdGado.Location = new System.Drawing.Point(221, 28);
            this.qtdGado.Name = "qtdGado";
            this.qtdGado.Size = new System.Drawing.Size(60, 20);
            this.qtdGado.TabIndex = 13;
            this.qtdGado.ValueChanged += new System.EventHandler(this.qtdGado_ValueChanged);
            this.qtdGado.Enter += new System.EventHandler(this.qtdGado_ValueChanged);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 187);
            this.Controls.Add(this.gpbInformacoes);
            this.Controls.Add(this.gpbAnimais);
            this.Controls.Add(this.btnConfirmarCompra);
            this.Name = "frmCadastro";
            this.Text = "Cadastro de compra de gado";
            this.gpbAnimais.ResumeLayout(false);
            this.gpbAnimais.PerformLayout();
            this.gpbInformacoes.ResumeLayout(false);
            this.gpbInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtdGado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.ComboBox cmbPecuarista;
        private System.Windows.Forms.Label lblPecuarista;
        private System.Windows.Forms.GroupBox gpbAnimais;
        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.GroupBox gpbInformacoes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAnimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.NumericUpDown qtdGado;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
    }
}