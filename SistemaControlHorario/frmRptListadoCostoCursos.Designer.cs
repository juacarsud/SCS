namespace SistemaControlHorario
{
    partial class frmRptListadoCostoCursos
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
            this.RptCostoCursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsCostoCursos = new SistemaControlHorario.dtsCostoCursos();
            this.RptCostoCursosTableAdapter = new SistemaControlHorario.dtsCostoCursosTableAdapters.RptCostoCursosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RptCostoCursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCostoCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RptCostoCursosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaControlHorario.rptListadoCostoCursos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(656, 448);
            this.reportViewer1.TabIndex = 0;
            // 
            // RptCostoCursosBindingSource
            // 
            this.RptCostoCursosBindingSource.DataMember = "RptCostoCursos";
            this.RptCostoCursosBindingSource.DataSource = this.dtsCostoCursos;
            // 
            // dtsCostoCursos
            // 
            this.dtsCostoCursos.DataSetName = "dtsCostoCursos";
            this.dtsCostoCursos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RptCostoCursosTableAdapter
            // 
            this.RptCostoCursosTableAdapter.ClearBeforeFill = true;
            // 
            // frmRptListadoCostoCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 448);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRptListadoCostoCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTADO DE CURSOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRptListadoCostoCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RptCostoCursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCostoCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RptCostoCursosBindingSource;
        private dtsCostoCursos dtsCostoCursos;
        private dtsCostoCursosTableAdapters.RptCostoCursosTableAdapter RptCostoCursosTableAdapter;
    }
}