namespace SistemaControlHorario
{
    partial class frmMantenimientoInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoInscripcion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBoxListadoHabitacion = new System.Windows.Forms.GroupBox();
            this.dgvListadoInscripcion = new System.Windows.Forms.DataGridView();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxHabitacion = new System.Windows.Forms.GroupBox();
            this.tbIdCurso = new System.Windows.Forms.TextBox();
            this.tbIdAlumno = new System.Windows.Forms.TextBox();
            this.bAgregarCurso = new System.Windows.Forms.Button();
            this.bAgregarAlumno = new System.Windows.Forms.Button();
            this.tbIdIscripcion = new System.Windows.Forms.TextBox();
            this.tbAlumno = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip2.SuspendLayout();
            this.groupBoxListadoHabitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoInscripcion)).BeginInit();
            this.groupBoxHabitacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 2, 8);
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator10,
            this.toolStripButtonNuevo,
            this.toolStripSeparator12,
            this.toolStripButtonGuardar,
            this.toolStripSeparator13,
            this.toolStripButtonEditar,
            this.toolStripSeparator14,
            this.toolStripButtonCancelar,
            this.toolStripSeparator15});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(9, 9);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(115, 146);
            this.toolStrip2.Stretch = true;
            this.toolStrip2.TabIndex = 211;
            this.toolStrip2.Text = "toolStrip1";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(113, 6);
            // 
            // toolStripButtonNuevo
            // 
            this.toolStripButtonNuevo.AutoSize = false;
            this.toolStripButtonNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonNuevo.ForeColor = System.Drawing.Color.Navy;
            this.toolStripButtonNuevo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNuevo.Image")));
            this.toolStripButtonNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNuevo.Name = "toolStripButtonNuevo";
            this.toolStripButtonNuevo.Size = new System.Drawing.Size(120, 22);
            this.toolStripButtonNuevo.Text = "NUEVO";
            this.toolStripButtonNuevo.Click += new System.EventHandler(this.toolStripButtonNuevo_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(113, 6);
            // 
            // toolStripButtonGuardar
            // 
            this.toolStripButtonGuardar.AutoSize = false;
            this.toolStripButtonGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonGuardar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonGuardar.ForeColor = System.Drawing.Color.Navy;
            this.toolStripButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuardar.Image")));
            this.toolStripButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuardar.Name = "toolStripButtonGuardar";
            this.toolStripButtonGuardar.Size = new System.Drawing.Size(120, 22);
            this.toolStripButtonGuardar.Text = "GUARDAR";
            this.toolStripButtonGuardar.ToolTipText = "Productos           ";
            this.toolStripButtonGuardar.Click += new System.EventHandler(this.toolStripButtonGuardar_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(113, 6);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.AutoSize = false;
            this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEditar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonEditar.ForeColor = System.Drawing.Color.Navy;
            this.toolStripButtonEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditar.Image")));
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(120, 22);
            this.toolStripButtonEditar.Text = "EDITAR";
            this.toolStripButtonEditar.Click += new System.EventHandler(this.toolStripButtonEditar_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(113, 6);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.AutoSize = false;
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.ForeColor = System.Drawing.Color.Navy;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(120, 22);
            this.toolStripButtonCancelar.Text = "CANCELAR";
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(113, 6);
            // 
            // groupBoxListadoHabitacion
            // 
            this.groupBoxListadoHabitacion.Controls.Add(this.dgvListadoInscripcion);
            this.groupBoxListadoHabitacion.Controls.Add(this.tbBuscar);
            this.groupBoxListadoHabitacion.Controls.Add(this.label8);
            this.groupBoxListadoHabitacion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxListadoHabitacion.ForeColor = System.Drawing.Color.Navy;
            this.groupBoxListadoHabitacion.Location = new System.Drawing.Point(12, 184);
            this.groupBoxListadoHabitacion.Name = "groupBoxListadoHabitacion";
            this.groupBoxListadoHabitacion.Size = new System.Drawing.Size(883, 434);
            this.groupBoxListadoHabitacion.TabIndex = 210;
            this.groupBoxListadoHabitacion.TabStop = false;
            this.groupBoxListadoHabitacion.Text = "LISTA DE INSCRIPCIONES";
            // 
            // dgvListadoInscripcion
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListadoInscripcion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoInscripcion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListadoInscripcion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListadoInscripcion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListadoInscripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListadoInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoInscripcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoInscripcion.Location = new System.Drawing.Point(7, 53);
            this.dgvListadoInscripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvListadoInscripcion.MultiSelect = false;
            this.dgvListadoInscripcion.Name = "dgvListadoInscripcion";
            this.dgvListadoInscripcion.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListadoInscripcion.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListadoInscripcion.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListadoInscripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoInscripcion.Size = new System.Drawing.Size(869, 375);
            this.dgvListadoInscripcion.TabIndex = 5;
            this.dgvListadoInscripcion.DoubleClick += new System.EventHandler(this.dgvListadoInscripcion_DoubleClick);
            // 
            // tbBuscar
            // 
            this.tbBuscar.ForeColor = System.Drawing.Color.Blue;
            this.tbBuscar.Location = new System.Drawing.Point(231, 18);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(318, 29);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            this.tbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscar_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(3, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "BUSCAR INCRIPCIONES";
            // 
            // groupBoxHabitacion
            // 
            this.groupBoxHabitacion.Controls.Add(this.tbIdCurso);
            this.groupBoxHabitacion.Controls.Add(this.tbIdAlumno);
            this.groupBoxHabitacion.Controls.Add(this.bAgregarCurso);
            this.groupBoxHabitacion.Controls.Add(this.bAgregarAlumno);
            this.groupBoxHabitacion.Controls.Add(this.tbIdIscripcion);
            this.groupBoxHabitacion.Controls.Add(this.tbAlumno);
            this.groupBoxHabitacion.Controls.Add(this.label17);
            this.groupBoxHabitacion.Controls.Add(this.tbCurso);
            this.groupBoxHabitacion.Controls.Add(this.label2);
            this.groupBoxHabitacion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHabitacion.ForeColor = System.Drawing.Color.Navy;
            this.groupBoxHabitacion.Location = new System.Drawing.Point(127, 12);
            this.groupBoxHabitacion.Name = "groupBoxHabitacion";
            this.groupBoxHabitacion.Size = new System.Drawing.Size(768, 166);
            this.groupBoxHabitacion.TabIndex = 209;
            this.groupBoxHabitacion.TabStop = false;
            this.groupBoxHabitacion.Text = "INSCRIPCION";
            // 
            // tbIdCurso
            // 
            this.tbIdCurso.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbIdCurso.Location = new System.Drawing.Point(102, 131);
            this.tbIdCurso.Name = "tbIdCurso";
            this.tbIdCurso.Size = new System.Drawing.Size(82, 29);
            this.tbIdCurso.TabIndex = 50;
            // 
            // tbIdAlumno
            // 
            this.tbIdAlumno.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbIdAlumno.Location = new System.Drawing.Point(14, 131);
            this.tbIdAlumno.Name = "tbIdAlumno";
            this.tbIdAlumno.Size = new System.Drawing.Size(82, 29);
            this.tbIdAlumno.TabIndex = 49;
            // 
            // bAgregarCurso
            // 
            this.bAgregarCurso.Location = new System.Drawing.Point(591, 63);
            this.bAgregarCurso.Name = "bAgregarCurso";
            this.bAgregarCurso.Size = new System.Drawing.Size(30, 32);
            this.bAgregarCurso.TabIndex = 48;
            this.bAgregarCurso.Text = "+";
            this.bAgregarCurso.UseVisualStyleBackColor = true;
            this.bAgregarCurso.Click += new System.EventHandler(this.bAgregarCurso_Click);
            // 
            // bAgregarAlumno
            // 
            this.bAgregarAlumno.Location = new System.Drawing.Point(591, 31);
            this.bAgregarAlumno.Name = "bAgregarAlumno";
            this.bAgregarAlumno.Size = new System.Drawing.Size(30, 32);
            this.bAgregarAlumno.TabIndex = 47;
            this.bAgregarAlumno.Text = "+";
            this.bAgregarAlumno.UseVisualStyleBackColor = true;
            this.bAgregarAlumno.Click += new System.EventHandler(this.bAgregarAlumno_Click);
            // 
            // tbIdIscripcion
            // 
            this.tbIdIscripcion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdIscripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbIdIscripcion.Location = new System.Drawing.Point(665, 19);
            this.tbIdIscripcion.Name = "tbIdIscripcion";
            this.tbIdIscripcion.Size = new System.Drawing.Size(44, 29);
            this.tbIdIscripcion.TabIndex = 46;
            // 
            // tbAlumno
            // 
            this.tbAlumno.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbAlumno.Location = new System.Drawing.Point(102, 29);
            this.tbAlumno.MaxLength = 8;
            this.tbAlumno.Name = "tbAlumno";
            this.tbAlumno.Size = new System.Drawing.Size(483, 29);
            this.tbAlumno.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Navy;
            this.label17.Location = new System.Drawing.Point(15, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 22);
            this.label17.TabIndex = 37;
            this.label17.Text = "ALUMNO";
            // 
            // tbCurso
            // 
            this.tbCurso.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbCurso.Location = new System.Drawing.Point(102, 64);
            this.tbCurso.MaxLength = 15;
            this.tbCurso.Name = "tbCurso";
            this.tbCurso.Size = new System.Drawing.Size(483, 29);
            this.tbCurso.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "CURSO";
            // 
            // frmMantenimientoInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 630);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.groupBoxListadoHabitacion);
            this.Controls.Add(this.groupBoxHabitacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMantenimientoInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSCRIPCION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMantenimientoInscripcion_FormClosing);
            this.Load += new System.EventHandler(this.frmMantenimientoInscripcion_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBoxListadoHabitacion.ResumeLayout(false);
            this.groupBoxListadoHabitacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoInscripcion)).EndInit();
            this.groupBoxHabitacion.ResumeLayout(false);
            this.groupBoxHabitacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton toolStripButtonNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.GroupBox groupBoxListadoHabitacion;
        private System.Windows.Forms.DataGridView dgvListadoInscripcion;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxHabitacion;
        private System.Windows.Forms.Button bAgregarCurso;
        private System.Windows.Forms.Button bAgregarAlumno;
        private System.Windows.Forms.TextBox tbIdIscripcion;
        private System.Windows.Forms.TextBox tbAlumno;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIdAlumno;
        private System.Windows.Forms.TextBox tbIdCurso;
    }
}