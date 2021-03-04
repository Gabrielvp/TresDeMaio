
namespace Teste.Forms
{
    partial class frmTDM_Report
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
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tresdemaiodbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tresdemaio_dbDataSet1 = new Teste.tresdemaio_dbDataSet();
            this.socioPorNomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.socioPorNomeTableAdapter = new Teste.tresdemaio_dbDataSetTableAdapters.SocioPorNomeTableAdapter();
            this.socioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.socioTableAdapter1 = new Teste.tresdemaio_dbDataSetTableAdapters.socioTableAdapter();
            this.socioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tresdemaiodbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tresdemaio_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioPorNomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // socioBindingSource
            // 
            this.socioBindingSource.DataMember = "socio";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "socio";
            reportDataSource1.Value = this.socioBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Teste.Reports.repSocios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(732, 600);
            this.reportViewer1.TabIndex = 0;
            // 
            // tresdemaio_dbDataSet1
            // 
            this.tresdemaio_dbDataSet1.DataSetName = "tresdemaio_dbDataSet";
            this.tresdemaio_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // socioPorNomeBindingSource
            // 
            this.socioPorNomeBindingSource.DataMember = "SocioPorNome";
            this.socioPorNomeBindingSource.DataSource = this.tresdemaio_dbDataSet1;
            // 
            // socioPorNomeTableAdapter
            // 
            this.socioPorNomeTableAdapter.ClearBeforeFill = true;
            // 
            // socioBindingSource1
            // 
            this.socioBindingSource1.DataMember = "socio";
            this.socioBindingSource1.DataSource = this.tresdemaio_dbDataSet1;
            // 
            // socioTableAdapter1
            // 
            this.socioTableAdapter1.ClearBeforeFill = true;
            // 
            // socioBindingSource2
            // 
            this.socioBindingSource2.DataMember = "socio";
            this.socioBindingSource2.DataSource = this.tresdemaio_dbDataSet1;
            // 
            // frmTDM_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 600);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmTDM_Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tresdemaiodbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tresdemaio_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioPorNomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tresdemaiodbDataSetBindingSource;
        private tresdemaio_dbDataSet tresdemaio_dbDataSet;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private tresdemaio_dbDataSetTableAdapters.socioTableAdapter socioTableAdapter;
        private tresdemaio_dbDataSet tresdemaio_dbDataSet1;
        private System.Windows.Forms.BindingSource socioPorNomeBindingSource;
        private tresdemaio_dbDataSetTableAdapters.SocioPorNomeTableAdapter socioPorNomeTableAdapter;
        private System.Windows.Forms.BindingSource socioBindingSource1;
        private tresdemaio_dbDataSetTableAdapters.socioTableAdapter socioTableAdapter1;
        private System.Windows.Forms.BindingSource socioBindingSource2;
    }
}