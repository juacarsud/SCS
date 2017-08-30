namespace SistemaControlHorario
{
    partial class frmRptEstadoCancelacion
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsCostoCursos = new SistemaControlHorario.dtsCostoCursos();
            this.ESTADO_DE_CANCELACION_DE_ALUMNOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ESTADO_DE_CANCELACION_DE_ALUMNOSTableAdapter = new SistemaControlHorario.dtsCostoCursosTableAdapters.ESTADO_DE_CANCELACION_DE_ALUMNOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCostoCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTADO_DE_CANCELACION_DE_ALUMNOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ESTADO_DE_CANCELACION_DE_ALUMNOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaControlHorario.rptEstadoCancelacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(647, 459);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtsCostoCursos
            // 
            this.dtsCostoCursos.DataSetName = "dtsCostoCursos";
            this.dtsCostoCursos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ESTADO_DE_CANCELACION_DE_ALUMNOSBindingSource
            // 
            this.ESTADO_DE_CANCELACION_DE_ALUMNOSBindingSource.DataMember = "ESTADO DE CANCELACION DE ALUMNOS";
            this.ESTADO_DE_CANCELACION_DE_ALUMNOSBindingSource.DataSource = this.dtsCostoCursos;
            // 
            // ESTADO_DE_CANCELACION_DE_ALUMNOSTableAdapter
            // 
            this.ESTADO_DE_CANCELACION_DE_ALUMNOSTableAdapter.ClearBeforeFill = true;
            // 
            // frmRptEstadoCancelacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 459);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRptEstadoCancelacion";
            this.Text = "ESTADO DE CANCELACION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEstadoCancelacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsCostoCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTADO_DE_CANCELACION_DE_ALUMNOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ESTADO_DE_CANCELACION_DE_ALUMNOSBindingSource;
        private dtsCostoCursos dtsCostoCursos;
        private dtsCostoCursosTableAdapters.ESTADO_DE_CANCELACION_DE_ALUMNOSTableAdapter ESTADO_DE_CANCELACION_DE_ALUMNOSTableAdapter;
    }
}