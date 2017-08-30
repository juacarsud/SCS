namespace SistemaControlHorario
{
    partial class frmRptAlumnosInscritos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AlmunosInscritosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsCostoCursos = new SistemaControlHorario.dtsCostoCursos();
            this.AlmunosInscritosTableAdapter = new SistemaControlHorario.dtsCostoCursosTableAdapters.AlmunosInscritosTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sisteControlHorariosDataSet1 = new SistemaControlHorario.SisteControlHorariosDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.AlmunosInscritosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCostoCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisteControlHorariosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // AlmunosInscritosBindingSource
            // 
            this.AlmunosInscritosBindingSource.DataMember = "AlmunosInscritos";
            this.AlmunosInscritosBindingSource.DataSource = this.dtsCostoCursos;
            // 
            // dtsCostoCursos
            // 
            this.dtsCostoCursos.DataSetName = "dtsCostoCursos";
            this.dtsCostoCursos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AlmunosInscritosTableAdapter
            // 
            this.AlmunosInscritosTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.AlmunosInscritosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaControlHorario.rptAlumnosInscritos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(584, 403);
            this.reportViewer1.TabIndex = 0;
            // 
            // sisteControlHorariosDataSet1
            // 
            this.sisteControlHorariosDataSet1.DataSetName = "SisteControlHorariosDataSet";
            this.sisteControlHorariosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmRptAlumnosInscritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 403);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRptAlumnosInscritos";
            this.Text = "AlUMNOS INSCRITOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRptAlumnosInscritos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlmunosInscritosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCostoCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisteControlHorariosDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource AlmunosInscritosBindingSource;
        private dtsCostoCursos dtsCostoCursos;
        private dtsCostoCursosTableAdapters.AlmunosInscritosTableAdapter AlmunosInscritosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SisteControlHorariosDataSet sisteControlHorariosDataSet1;
    }
}