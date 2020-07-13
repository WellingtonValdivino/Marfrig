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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gpbInformacoes = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbPecuarista = new System.Windows.Forms.ComboBox();
            this.lblPecuarista = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.Cellid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellPecuarista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellDataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gpbInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(440, 16);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnIncluirProduto_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(521, 16);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Al&terar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAtualizaProduto_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(602, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnDeletarProduto_Click);
            // 
            // gpbInformacoes
            // 
            this.gpbInformacoes.Controls.Add(this.txtId);
            this.gpbInformacoes.Controls.Add(this.cmbPecuarista);
            this.gpbInformacoes.Controls.Add(this.lblPecuarista);
            this.gpbInformacoes.Controls.Add(this.lblid);
            this.gpbInformacoes.Controls.Add(this.btnExcluir);
            this.gpbInformacoes.Controls.Add(this.btnAlterar);
            this.gpbInformacoes.Controls.Add(this.btnAdicionar);
            this.gpbInformacoes.Location = new System.Drawing.Point(12, 12);
            this.gpbInformacoes.Name = "gpbInformacoes";
            this.gpbInformacoes.Size = new System.Drawing.Size(683, 54);
            this.gpbInformacoes.TabIndex = 10;
            this.gpbInformacoes.TabStop = false;
            this.gpbInformacoes.Text = "Informações";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(71, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(63, 20);
            this.txtId.TabIndex = 0;
            // 
            // cmbPecuarista
            // 
            this.cmbPecuarista.DisplayMember = "(none)";
            this.cmbPecuarista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPecuarista.FormattingEnabled = true;
            this.cmbPecuarista.Location = new System.Drawing.Point(209, 19);
            this.cmbPecuarista.Name = "cmbPecuarista";
            this.cmbPecuarista.Size = new System.Drawing.Size(121, 21);
            this.cmbPecuarista.TabIndex = 4;
            this.cmbPecuarista.SelectedIndexChanged += new System.EventHandler(this.cmbPecuarista_SelectedIndexChanged);
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
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(7, 22);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(58, 13);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "Nº Pedido:";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cellid,
            this.CellPecuarista,
            this.CellDataEntrega,
            this.CellValorTotal});
            this.dgvConsulta.Location = new System.Drawing.Point(12, 72);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(683, 306);
            this.dgvConsulta.TabIndex = 11;
            this.dgvConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellClick);
            // 
            // Cellid
            // 
            this.Cellid.HeaderText = "Nº Item";
            this.Cellid.Name = "Cellid";
            this.Cellid.ReadOnly = true;
            this.Cellid.Width = 80;
            // 
            // CellPecuarista
            // 
            this.CellPecuarista.HeaderText = "Pecuarista";
            this.CellPecuarista.Name = "CellPecuarista";
            this.CellPecuarista.ReadOnly = true;
            this.CellPecuarista.Width = 200;
            // 
            // CellDataEntrega
            // 
            this.CellDataEntrega.HeaderText = "Data Entrega";
            this.CellDataEntrega.Name = "CellDataEntrega";
            this.CellDataEntrega.ReadOnly = true;
            this.CellDataEntrega.Width = 180;
            // 
            // CellValorTotal
            // 
            this.CellValorTotal.HeaderText = "Valor Total";
            this.CellValorTotal.Name = "CellValorTotal";
            this.CellValorTotal.ReadOnly = true;
            this.CellValorTotal.Width = 180;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(620, 393);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 428);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.gpbInformacoes);
            this.Name = "frmCompra";
            this.Text = "Consulta de compra de gado";
            this.gpbInformacoes.ResumeLayout(false);
            this.gpbInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gpbInformacoes;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbPecuarista;
        private System.Windows.Forms.Label lblPecuarista;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cellid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellPecuarista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellDataEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellValorTotal;
        private System.Windows.Forms.Button btnImprimir;
    }
}