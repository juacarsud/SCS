using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaControlHorario.Entidades;
using SistemaControlHorario.Negocio;

namespace SistemaControlHorario
{
    public partial class frmDisponibilidadHorario : Form
    {

        private List<Laboratorio> listaLaboratorios;
        public int Bandera = 0,compara=0,Laboratorio=0;
        public bool cambio = false;




        public frmDisponibilidadHorario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDisponibilidadHorario_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        public void MostrarDatos()
        {
            cmbambiente.DataSource = this.listaLaboratorios = ControlEntidades.VerLaboratorio();
            cmbambiente.ValueMember = "IdLaboratorio";
            cmbambiente.DisplayMember = "Nombre";

            dgvhorario.Rows.Add(15);
            for (int i = 0; i < 16; i++)
            {
                try
                {
                    dgvhorario[0, i].Value = ControlEntidades.EnviarHoras(i).Descripcion;

                }
                catch { }
            }
        }

        private void dgvhorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbambiente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Laboratorio=Bandera = Convert.ToInt32(cmbambiente.SelectedValue.ToString());

            if (Bandera != compara)
            {
                label4.Text =" ( "+ cmbambiente.Text+" ) ";
                cambio = true;
                compara = Bandera;
            }


            if (cambio)
            {
                dgvhorario.Rows.Clear();
              
              MostrarDatos();
              mostrarHorario();
               cambio = false; 

            }
            else {

             
            }
        }

        public void mostrarHorario()
        {
            int a = 0, b = 0;
            string band;

        for (int j = 1; j <= 119; j++)
            {
                try
                {
                    band = ControlEntidades.EnviarDisponibilidad(Laboratorio, j, "fecha",frmInicioSesion.ConfigSemestre).Fecha;
                    if (band != "")
                    {
                        a = Convert.ToInt32(ControlEntidades.EnviarDisponibilidad(Laboratorio, j, "fecha", frmInicioSesion.ConfigSemestre).Fecha);
                        b = Convert.ToInt32(ControlEntidades.EnviarDisponibilidad(Laboratorio, j, "hora", frmInicioSesion.ConfigSemestre).Hora);
                        try
                        {
                            dgvhorario[a, b].Value = Convert.ToString(ControlEntidades.EnviarDisponibilidad(Laboratorio, j, "", frmInicioSesion.ConfigSemestre).Curso);
                        }
                        catch { }
                    }
                    else {  }

                }
                catch { }
            }
        
        }

        private void dgvhorario_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void frmDisponibilidadHorario_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta = MessageBox.Show("¿SEGURO QUE DESEA SALIR? ", "SALIR DE DISPONIBILIDAD DE HORARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.Yes)
            {


            }
            else { e.Cancel = true; }
        }

        private void dgvhorario_DoubleClick(object sender, EventArgs e)
        {
            string dia,hora,disponibilidad;
            try
            {
               
                hora = dgvhorario.CurrentCell.RowIndex.ToString();
                dia = dgvhorario.CurrentCell.ColumnIndex.ToString();
               disponibilidad= ControlEntidades.EnviarProgramacion(dia, hora, Laboratorio.ToString(),frmInicioSesion.ConfigSemestre).IdProgramacion;

                new frmInformeHorario(dia, hora, Laboratorio.ToString()).ShowDialog();
                dgvhorario.Rows.Clear();

                MostrarDatos();
                mostrarHorario();
            }
            catch { }


        }
    }
}
