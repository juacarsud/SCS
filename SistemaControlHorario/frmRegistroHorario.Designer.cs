namespace SistemaControlHorario
{
    partial class frmRegistroHorario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtcapacidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbambiente = new System.Windows.Forms.ComboBox();
            this.cmbdias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbhoras = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbcursos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpfechainicial = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbprofesor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbcodigoDocente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.dtmfechafinal = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvhorarios = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.qUITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhorarios)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcapacidad
            // 
            this.txtcapacidad.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcapacidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtcapacidad.Location = new System.Drawing.Point(548, 133);
            this.txtcapacidad.Name = "txtcapacidad";
            this.txtcapacidad.Size = new System.Drawing.Size(108, 29);
            this.txtcapacidad.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 22);
            this.label9.TabIndex = 29;
            this.label9.Text = "AMBIENTE";
            // 
            // cmbambiente
            // 
            this.cmbambiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbambiente.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbambiente.FormattingEnabled = true;
            this.cmbambiente.Location = new System.Drawing.Point(431, 16);
            this.cmbambiente.Name = "cmbambiente";
            this.cmbambiente.Size = new System.Drawing.Size(225, 30);
            this.cmbambiente.TabIndex = 31;
            this.cmbambiente.SelectedIndexChanged += new System.EventHandler(this.cmbambiente_SelectedIndexChanged);
            // 
            // cmbdias
            // 
            this.cmbdias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdias.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdias.FormattingEnabled = true;
            this.cmbdias.Location = new System.Drawing.Point(104, 16);
            this.cmbdias.Name = "cmbdias";
            this.cmbdias.Size = new System.Drawing.Size(199, 30);
            this.cmbdias.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "DIA";
            // 
            // cmbhoras
            // 
            this.cmbhoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbhoras.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbhoras.FormattingEnabled = true;
            this.cmbhoras.Location = new System.Drawing.Point(104, 58);
            this.cmbhoras.Name = "cmbhoras";
            this.cmbhoras.Size = new System.Drawing.Size(199, 30);
            this.cmbhoras.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "HORARIO";
            // 
            // cmbcursos
            // 
            this.cmbcursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcursos.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcursos.FormattingEnabled = true;
            this.cmbcursos.Location = new System.Drawing.Point(104, 133);
            this.cmbcursos.Name = "cmbcursos";
            this.cmbcursos.Size = new System.Drawing.Size(304, 30);
            this.cmbcursos.TabIndex = 37;
            this.cmbcursos.SelectedIndexChanged += new System.EventHandler(this.cmbcursos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 36;
            this.label3.Text = "CURSO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "CAPACIDAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 39;
            this.label5.Text = "Fecha Inicio";
            // 
            // dtpfechainicial
            // 
            this.dtpfechainicial.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechainicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechainicial.Location = new System.Drawing.Point(104, 98);
            this.dtpfechainicial.Name = "dtpfechainicial";
            this.dtpfechainicial.Size = new System.Drawing.Size(95, 29);
            this.dtpfechainicial.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 42;
            this.label6.Text = "PROFESOR";
            // 
            // tbprofesor
            // 
            this.tbprofesor.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbprofesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbprofesor.Location = new System.Drawing.Point(104, 61);
            this.tbprofesor.Name = "tbprofesor";
            this.tbprofesor.Size = new System.Drawing.Size(452, 29);
            this.tbprofesor.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 22);
            this.label7.TabIndex = 44;
            this.label7.Text = "DNI";
            // 
            // tbcodigoDocente
            // 
            this.tbcodigoDocente.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcodigoDocente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbcodigoDocente.Location = new System.Drawing.Point(104, 22);
            this.tbcodigoDocente.Name = "tbcodigoDocente";
            this.tbcodigoDocente.Size = new System.Drawing.Size(117, 29);
            this.tbcodigoDocente.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(244, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 33);
            this.button1.TabIndex = 47;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(529, 599);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(121, 33);
            this.btnguardar.TabIndex = 48;
            this.btnguardar.Text = "FINALIZAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(431, 52);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(225, 36);
            this.btncancelar.TabIndex = 49;
            this.btncancelar.Text = "GUARDAR PROGRAMACION";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // dtmfechafinal
            // 
            this.dtmfechafinal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmfechafinal.Location = new System.Drawing.Point(304, 99);
            this.dtmfechafinal.Name = "dtmfechafinal";
            this.dtmfechafinal.Size = new System.Drawing.Size(95, 29);
            this.dtmfechafinal.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(205, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 22);
            this.label8.TabIndex = 50;
            this.label8.Text = "Fecha Final";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvhorarios);
            this.groupBox1.Location = new System.Drawing.Point(9, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 311);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // dgvhorarios
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvhorarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvhorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvhorarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvhorarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvhorarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvhorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhorarios.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvhorarios.Location = new System.Drawing.Point(7, 19);
            this.dgvhorarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvhorarios.MultiSelect = false;
            this.dgvhorarios.Name = "dgvhorarios";
            this.dgvhorarios.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvhorarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvhorarios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvhorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhorarios.Size = new System.Drawing.Size(650, 286);
            this.dgvhorarios.TabIndex = 53;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qUITARToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 26);
            // 
            // qUITARToolStripMenuItem
            // 
            this.qUITARToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qUITARToolStripMenuItem.Name = "qUITARToolStripMenuItem";
            this.qUITARToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.qUITARToolStripMenuItem.Text = "QUITAR";
            this.qUITARToolStripMenuItem.Click += new System.EventHandler(this.qUITARToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSemestre);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtmfechafinal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbcodigoDocente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbprofesor);
            this.groupBox2.Controls.Add(this.dtpfechainicial);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbcursos);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtcapacidad);
            this.groupBox2.Location = new System.Drawing.Point(9, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 176);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemestre.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Location = new System.Drawing.Point(400, 15);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(257, 36);
            this.cmbSemestre.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(315, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 22);
            this.label10.TabIndex = 52;
            this.label10.Text = "Semestre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btncancelar);
            this.groupBox3.Controls.Add(this.cmbhoras);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbdias);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbambiente);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(9, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 99);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            // 
            // frmRegistroHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 644);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnguardar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistroHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE HORARIOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistroHorario_FormClosing);
            this.Load += new System.EventHandler(this.frmRegistroHorario_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhorarios)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtcapacidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbambiente;
        private System.Windows.Forms.ComboBox cmbdias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbhoras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbcursos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpfechainicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbprofesor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbcodigoDocente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DateTimePicker dtmfechafinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvhorarios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qUITARToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.Label label10;
    }
}