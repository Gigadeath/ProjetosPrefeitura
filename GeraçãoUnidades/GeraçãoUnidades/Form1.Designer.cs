namespace GeraçãoUnidades
{
    partial class Form1
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UnidadesDataSet = new GeraçãoUnidades.UnidadesDataSet();
            this.UnidadesSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UnidadesSetTableAdapter = new GeraçãoUnidades.UnidadesDataSetTableAdapters.UnidadesSetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadesSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelatorioUnidades";
            reportDataSource1.Value = this.UnidadesSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GeraçãoUnidades.Busca.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.reportViewer1.Size = new System.Drawing.Size(1008, 730);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // UnidadesDataSet
            // 
            this.UnidadesDataSet.DataSetName = "UnidadesDataSet";
            this.UnidadesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UnidadesSetBindingSource
            // 
            this.UnidadesSetBindingSource.DataMember = "UnidadesSet";
            this.UnidadesSetBindingSource.DataSource = this.UnidadesDataSet;
            // 
            // UnidadesSetTableAdapter
            // 
            this.UnidadesSetTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnidadesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadesSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource UnidadesSetBindingSource;
        private GeraçãoUnidades.UnidadesDataSet UnidadesDataSet;
        private GeraçãoUnidades.UnidadesDataSetTableAdapters.UnidadesSetTableAdapter UnidadesSetTableAdapter;
    }
}