namespace Marfrig.Formularios.Relatorio
{
    partial class frmRelatorio
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.marfrigDataSet = new Marfrig.Formularios.MarfrigDataSet();
            this.marfrigDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marfrigDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.marfrigDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marfrigDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marfrigDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "CompraGadoItem";
            reportDataSource1.Value = this.marfrigDataSetBindingSource;
            reportDataSource2.Name = "Animal";
            reportDataSource2.Value = this.marfrigDataSetBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Marfrig.Formularios.Relatorio.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 130);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(726, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // marfrigDataSet
            // 
            this.marfrigDataSet.DataSetName = "MarfrigDataSet";
            this.marfrigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marfrigDataSetBindingSource
            // 
            this.marfrigDataSetBindingSource.DataSource = this.marfrigDataSet;
            this.marfrigDataSetBindingSource.Position = 0;
            // 
            // marfrigDataSetBindingSource1
            // 
            this.marfrigDataSetBindingSource1.DataSource = this.marfrigDataSet;
            this.marfrigDataSetBindingSource1.Position = 0;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorio";
            this.Text = "Relatório de compra de gado";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marfrigDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marfrigDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marfrigDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource marfrigDataSetBindingSource;
        private MarfrigDataSet marfrigDataSet;
        private System.Windows.Forms.BindingSource marfrigDataSetBindingSource1;
    }
}