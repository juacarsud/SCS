namespace SistemaControlHorario
{
    partial class frmDisponibilidadHorario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvhorario = new System.Windows.Forms.DataGridView();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbambiente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhorario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox4);
            this.groupBox7.Controls.Add(this.groupBox1);
            this.groupBox7.Location = new System.Drawing.Point(12, -3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1272, 703);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.dgvhorario);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox4.Location = new System.Drawing.Point(7, 68);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(1258, 627);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // dgvhorario
            // 
            this.dgvhorario.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.dgvhorario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvhorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Horas,
            this.Lunes,
            this.Martes,
            this.Miercoles,
            this.Jueves,
            this.Viernes,
            this.Sabado,
            this.Domingo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhorario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvhorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvhorario.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvhorario.Location = new System.Drawing.Point(4, 16);
            this.dgvhorario.Name = "dgvhorario";
            this.dgvhorario.RowHeadersWidth = 42;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvhorario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvhorario.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvhorario.RowTemplate.Height = 35;
            this.dgvhorario.RowTemplate.ReadOnly = true;
            this.dgvhorario.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvhorario.Size = new System.Drawing.Size(1250, 608);
            this.dgvhorario.TabIndex = 0;
            this.dgvhorario.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvhorario_Paint);
            this.dgvhorario.DoubleClick += new System.EventHandler(this.dgvhorario_DoubleClick);
            // 
            // Horas
            // 
            this.Horas.HeaderText = "HORAS/DIAS";
            this.Horas.Name = "Horas";
            this.Horas.Width = 150;
            // 
            // Lunes
            // 
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            this.Lunes.DefaultCellStyle = dataGridViewCellStyle2;
            this.Lunes.FillWeight = 150F;
            this.Lunes.HeaderText = "LUNES";
            this.Lunes.Name = "Lunes";
            this.Lunes.Width = 150;
            // 
            // Martes
            // 
            this.Martes.FillWeight = 150F;
            this.Martes.HeaderText = "MARTES";
            this.Martes.Name = "Martes";
            this.Martes.Width = 150;
            // 
            // Miercoles
            // 
            this.Miercoles.FillWeight = 150F;
            this.Miercoles.HeaderText = "MIERCOLES";
            this.Miercoles.Name = "Miercoles";
            this.Miercoles.Width = 150;
            // 
            // Jueves
            // 
            this.Jueves.FillWeight = 150F;
            this.Jueves.HeaderText = "JUEVES";
            this.Jueves.Name = "Jueves";
            this.Jueves.Width = 150;
            // 
            // Viernes
            // 
            this.Viernes.FillWeight = 150F;
            this.Viernes.HeaderText = "VIERNES";
            this.Viernes.Name = "Viernes";
            this.Viernes.Width = 150;
            // 
            // Sabado
            // 
            this.Sabado.FillWeight = 150F;
            this.Sabado.HeaderText = "SABADO";
            this.Sabado.Name = "Sabado";
            this.Sabado.Width = 150;
            // 
            // Domingo
            // 
            this.Domingo.FillWeight = 150F;
            this.Domingo.HeaderText = "DOMINGO";
            this.Domingo.Name = "Domingo";
            this.Domingo.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbambiente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(7, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1254, 57);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(977, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(644, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Busqueda de disponibilidad de Horarios en :";
            // 
            // cmbambiente
            // 
            this.cmbambiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbambiente.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbambiente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbambiente.FormattingEnabled = true;
            this.cmbambiente.Location = new System.Drawing.Point(199, 17);
            this.cmbambiente.Name = "cmbambiente";
            this.cmbambiente.Size = new System.Drawing.Size(316, 30);
            this.cmbambiente.TabIndex = 38;
            this.cmbambiente.SelectedIndexChanged += new System.EventHandler(this.cmbambiente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "Seleccionar Laboratorio:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(521, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 33);
            this.button2.TabIndex = 32;
            this.button2.Text = "MOSTRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmDisponibilidadHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 699);
            this.Controls.Add(this.groupBox7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDisponibilidadHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disponibilidad de Horario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDisponibilidadHorario_FormClosing);
            this.Load += new System.EventHandler(this.frmDisponibilidadHorario_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhorario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvhorario;
        private System.Windows.Forms.ComboBox cmbambiente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domingo;
    }
}