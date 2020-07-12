namespace Marfrig.Formularios.Compra
{
    partial class frmCompra
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gpbInformacoes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPecuarista = new System.Windows.Forms.Label();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtDataEntrega = new System.Windows.Forms.TextBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.Cellid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellPecuarista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellDataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDireita = new System.Windows.Forms.Button();
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.gpbInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(12, 72);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(93, 72);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(174, 72);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(255, 72);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Al&terar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(336, 72);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // gpbInformacoes
            // 
            this.gpbInformacoes.Controls.Add(this.label1);
            this.gpbInformacoes.Controls.Add(this.textBox1);
            this.gpbInformacoes.Controls.Add(this.txtId);
            this.gpbInformacoes.Controls.Add(this.comboBox1);
            this.gpbInformacoes.Controls.Add(this.lblPecuarista);
            this.gpbInformacoes.Controls.Add(this.lblDataEntrega);
            this.gpbInformacoes.Controls.Add(this.lblid);
            this.gpbInformacoes.Controls.Add(this.txtDataEntrega);
            this.gpbInformacoes.Location = new System.Drawing.Point(12, 12);
            this.gpbInformacoes.Name = "gpbInformacoes";
            this.gpbInformacoes.Size = new System.Drawing.Size(683, 54);
            this.gpbInformacoes.TabIndex = 10;
            this.gpbInformacoes.TabStop = false;
            this.gpbInformacoes.Text = "Informações";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Até:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(577, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(34, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // lblPecuarista
            // 
            this.lblPecuarista.AutoSize = true;
            this.lblPecuarista.Location = new System.Drawing.Point(143, 23);
            this.lblPecuarista.Name = "lblPecuarista";
            this.lblPecuarista.Size = new System.Drawing.Size(60, 13);
            this.lblPecuarista.TabIndex = 5;
            this.lblPecuarista.Text = "Pecuarista:";
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.Location = new System.Drawing.Point(336, 23);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(102, 13);
            this.lblDataEntrega.TabIndex = 2;
            this.lblDataEntrega.Text = "Data de entrega de:";
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
            // txtDataEntrega
            // 
            this.txtDataEntrega.Location = new System.Drawing.Point(440, 20);
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(100, 20);
            this.txtDataEntrega.TabIndex = 3;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cellid,
            this.CellPecuarista,
            this.CellDataEntrega,
            this.CellValorTotal});
            this.dgvConsulta.Location = new System.Drawing.Point(12, 112);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(683, 279);
            this.dgvConsulta.TabIndex = 11;
            // 
            // Cellid
            // 
            this.Cellid.HeaderText = "ID";
            this.Cellid.Name = "Cellid";
            this.Cellid.Width = 80;
            // 
            // CellPecuarista
            // 
            this.CellPecuarista.HeaderText = "Pecuarista";
            this.CellPecuarista.Name = "CellPecuarista";
            this.CellPecuarista.Width = 200;
            // 
            // CellDataEntrega
            // 
            this.CellDataEntrega.HeaderText = "Data Entrega";
            this.CellDataEntrega.Name = "CellDataEntrega";
            this.CellDataEntrega.Width = 180;
            // 
            // CellValorTotal
            // 
            this.CellValorTotal.HeaderText = "Valor Total";
            this.CellValorTotal.Name = "CellValorTotal";
            this.CellValorTotal.Width = 180;
            // 
            // btnDireita
            // 
            this.btnDireita.Location = new System.Drawing.Point(361, 397);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(75, 23);
            this.btnDireita.TabIndex = 12;
            this.btnDireita.Text = ">";
            this.btnDireita.UseVisualStyleBackColor = true;
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.Location = new System.Drawing.Point(280, 397);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(75, 23);
            this.btnEsquerda.TabIndex = 13;
            this.btnEsquerda.Text = "<";
            this.btnEsquerda.UseVisualStyleBackColor = true;
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 428);
            this.Controls.Add(this.btnEsquerda);
            this.Controls.Add(this.btnDireita);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.gpbInformacoes);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "frmCompra";
            this.Text = "Consulta de compra de gado";
            this.gpbInformacoes.ResumeLayout(false);
            this.gpbInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gpbInformacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPecuarista;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtDataEntrega;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cellid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellPecuarista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellDataEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellValorTotal;
        private System.Windows.Forms.Button btnDireita;
        private System.Windows.Forms.Button btnEsquerda;
    }
}