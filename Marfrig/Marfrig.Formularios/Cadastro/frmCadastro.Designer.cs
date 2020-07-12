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
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.txtDataEntrega = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPecuarista = new System.Windows.Forms.Label();
            this.gpbAnimais = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpbInformacoes = new System.Windows.Forms.GroupBox();
            this.CellAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbAnimais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(34, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(7, 22);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 13);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "ID:";
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.Location = new System.Drawing.Point(144, 22);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(87, 13);
            this.lblDataEntrega.TabIndex = 2;
            this.lblDataEntrega.Text = "Data de entrega:";
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Location = new System.Drawing.Point(237, 19);
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(100, 20);
            this.txtDataEntrega.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(412, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // lblPecuarista
            // 
            this.lblPecuarista.AutoSize = true;
            this.lblPecuarista.Location = new System.Drawing.Point(346, 23);
            this.lblPecuarista.Name = "lblPecuarista";
            this.lblPecuarista.Size = new System.Drawing.Size(60, 13);
            this.lblPecuarista.TabIndex = 5;
            this.lblPecuarista.Text = "Pecuarista:";
            // 
            // gpbAnimais
            // 
            this.gpbAnimais.Controls.Add(this.dataGridView1);
            this.gpbAnimais.Controls.Add(this.button3);
            this.gpbAnimais.Controls.Add(this.button2);
            this.gpbAnimais.Controls.Add(this.button1);
            this.gpbAnimais.Location = new System.Drawing.Point(12, 81);
            this.gpbAnimais.Name = "gpbAnimais";
            this.gpbAnimais.Size = new System.Drawing.Size(539, 320);
            this.gpbAnimais.TabIndex = 8;
            this.gpbAnimais.TabStop = false;
            this.gpbAnimais.Text = "Animais";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(177, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "A&lterar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CellAnimal,
            this.CellQuantidade,
            this.CellPreco,
            this.CellValorTotal});
            this.dataGridView1.Location = new System.Drawing.Point(20, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(498, 243);
            this.dataGridView1.TabIndex = 3;
            // 
            // gpbInformacoes
            // 
            this.gpbInformacoes.Controls.Add(this.txtId);
            this.gpbInformacoes.Controls.Add(this.comboBox1);
            this.gpbInformacoes.Controls.Add(this.lblPecuarista);
            this.gpbInformacoes.Controls.Add(this.lblDataEntrega);
            this.gpbInformacoes.Controls.Add(this.lblid);
            this.gpbInformacoes.Controls.Add(this.txtDataEntrega);
            this.gpbInformacoes.Location = new System.Drawing.Point(12, 12);
            this.gpbInformacoes.Name = "gpbInformacoes";
            this.gpbInformacoes.Size = new System.Drawing.Size(539, 54);
            this.gpbInformacoes.TabIndex = 9;
            this.gpbInformacoes.TabStop = false;
            this.gpbInformacoes.Text = "Informações";
            // 
            // CellAnimal
            // 
            this.CellAnimal.HeaderText = "Animal";
            this.CellAnimal.Name = "CellAnimal";
            this.CellAnimal.Width = 80;
            // 
            // CellQuantidade
            // 
            this.CellQuantidade.HeaderText = "Quantidade";
            this.CellQuantidade.Name = "CellQuantidade";
            this.CellQuantidade.Width = 125;
            // 
            // CellPreco
            // 
            this.CellPreco.HeaderText = "Preço";
            this.CellPreco.Name = "CellPreco";
            this.CellPreco.Width = 125;
            // 
            // CellValorTotal
            // 
            this.CellValorTotal.HeaderText = "Valor Total";
            this.CellValorTotal.Name = "CellValorTotal";
            this.CellValorTotal.Width = 125;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 431);
            this.Controls.Add(this.gpbInformacoes);
            this.Controls.Add(this.gpbAnimais);
            this.Name = "frmCadastro";
            this.Text = "Cadastro de compra de gado";
            this.gpbAnimais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbInformacoes.ResumeLayout(false);
            this.gpbInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.TextBox txtDataEntrega;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPecuarista;
        private System.Windows.Forms.GroupBox gpbAnimais;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellValorTotal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gpbInformacoes;
    }
}