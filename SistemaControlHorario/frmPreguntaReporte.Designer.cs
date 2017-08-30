namespace SistemaControlHorario
{
    partial class frmPreguntaReporte
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
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbmeses = new System.Windows.Forms.RadioButton();
            this.gbmeses = new System.Windows.Forms.GroupBox();
            this.cmbMes1 = new System.Windows.Forms.ComboBox();
            this.cmbMes2 = new System.Windows.Forms.ComboBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbTotal = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.gbsemestre = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.gbmeses.SuspendLayout();
            this.gbsemestre.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(244, 267);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 44);
            this.button3.TabIndex = 12;
            this.button3.Text = "Generar Reporte";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbmeses);
            this.groupBox2.Controls.Add(this.gbmeses);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rdbTotal);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(503, 180);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // rdbmeses
            // 
            this.rdbmeses.AutoSize = true;
            this.rdbmeses.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmeses.Location = new System.Drawing.Point(12, 62);
            this.rdbmeses.Name = "rdbmeses";
            this.rdbmeses.Size = new System.Drawing.Size(55, 21);
            this.rdbmeses.TabIndex = 14;
            this.rdbmeses.TabStop = true;
            this.rdbmeses.Text = "Mes";
            this.rdbmeses.UseVisualStyleBackColor = true;
            this.rdbmeses.CheckedChanged += new System.EventHandler(this.rdbmeses_CheckedChanged);
            // 
            // gbmeses
            // 
            this.gbmeses.Controls.Add(this.cmbMes1);
            this.gbmeses.Controls.Add(this.cmbMes2);
            this.gbmeses.Controls.Add(this.txtAño);
            this.gbmeses.Controls.Add(this.label6);
            this.gbmeses.Controls.Add(this.label3);
            this.gbmeses.Controls.Add(this.label4);
            this.gbmeses.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbmeses.Location = new System.Drawing.Point(69, 43);
            this.gbmeses.Name = "gbmeses";
            this.gbmeses.Size = new System.Drawing.Size(427, 94);
            this.gbmeses.TabIndex = 15;
            this.gbmeses.TabStop = false;
            // 
            // cmbMes1
            // 
            this.cmbMes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMes1.FormattingEnabled = true;
            this.cmbMes1.Location = new System.Drawing.Point(65, 17);
            this.cmbMes1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbMes1.Name = "cmbMes1";
            this.cmbMes1.Size = new System.Drawing.Size(135, 26);
            this.cmbMes1.TabIndex = 41;
            // 
            // cmbMes2
            // 
            this.cmbMes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMes2.FormattingEnabled = true;
            this.cmbMes2.Location = new System.Drawing.Point(285, 18);
            this.cmbMes2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbMes2.Name = "cmbMes2";
            this.cmbMes2.Size = new System.Drawing.Size(135, 26);
            this.cmbMes2.TabIndex = 40;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(66, 54);
            this.txtAño.MaxLength = 4;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(134, 25);
            this.txtAño.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(144, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "CONDICION DE REPORTE";
            // 
            // rdbTotal
            // 
            this.rdbTotal.AutoSize = true;
            this.rdbTotal.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTotal.Location = new System.Drawing.Point(12, 143);
            this.rdbTotal.Name = "rdbTotal";
            this.rdbTotal.Size = new System.Drawing.Size(149, 21);
            this.rdbTotal.TabIndex = 13;
            this.rdbTotal.TabStop = true;
            this.rdbTotal.Text = "Sin Fecha - Total";
            this.rdbTotal.UseVisualStyleBackColor = true;
            this.rdbTotal.CheckedChanged += new System.EventHandler(this.rdbTotal_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(384, 267);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemestre.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Location = new System.Drawing.Point(135, 13);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(196, 29);
            this.cmbSemestre.TabIndex = 58;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Navy;
            this.label17.Location = new System.Drawing.Point(17, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 22);
            this.label17.TabIndex = 57;
            this.label17.Text = "SEMESTRE";
            // 
            // gbsemestre
            // 
            this.gbsemestre.Controls.Add(this.cmbSemestre);
            this.gbsemestre.Controls.Add(this.label17);
            this.gbsemestre.Location = new System.Drawing.Point(13, 200);
            this.gbsemestre.Name = "gbsemestre";
            this.gbsemestre.Size = new System.Drawing.Size(486, 56);
            this.gbsemestre.TabIndex = 59;
            this.gbsemestre.TabStop = false;
            // 
            // frmPreguntaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 345);
            this.Controls.Add(this.gbsemestre);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPreguntaReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONDICION DE REPORTE";
            this.Load += new System.EventHandler(this.frmPreguntaReporte_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbmeses.ResumeLayout(false);
            this.gbmeses.PerformLayout();
            this.gbsemestre.ResumeLayout(false);
            this.gbsemestre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbmeses;
        private System.Windows.Forms.GroupBox gbmeses;
        private System.Windows.Forms.ComboBox cmbMes1;
        private System.Windows.Forms.ComboBox cmbMes2;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox gbsemestre;
    }
}