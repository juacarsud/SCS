using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaControlHorario.Entidades;
using SistemaControlHorario.Negocio;
using System.Windows.Forms;

namespace SistemaControlHorario
{
    public partial class frmModificarAsistencia : Form
    {
        public string IdAsistencia;
        Asistencia tempAsistencia = new Asistencia();

        public frmModificarAsistencia()
        {
            InitializeComponent();
        }

        public frmModificarAsistencia(string CodAsistencia)
        {
            InitializeComponent();
            IdAsistencia = CodAsistencia;
            tbHoraFinal.Text = ControlEntidades.EnviarAsistencia(IdAsistencia).HoraSalida.ToShortDateString();
            tbHoraInicial.Text = ControlEntidades.EnviarAsistencia(IdAsistencia).HoraIngreso.ToShortDateString();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificarAsistencia_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                     DialogResult rpta = MessageBox.Show("¿SEGURO QUE DESEA GUARDAR? ", "VERIFICAR LOS DATOS ANTES DE GUARDAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rpta == DialogResult.Yes)
                    {
                tempAsistencia.IdAsistencia =Convert.ToInt32( IdAsistencia);
                tempAsistencia.HoraIngreso = Convert.ToDateTime(tbHoraInicial.Text);
                tempAsistencia.HoraSalida = Convert.ToDateTime(tbHoraFinal.Text);
                tempAsistencia.Observacion = tbobserva.Text;

                if (tempAsistencia.HoraIngreso.ToShortDateString() != ControlEntidades.EnviarAsistencia(IdAsistencia).HoraIngreso.ToShortDateString())
                {
                    MessageBox.Show("VERIFICAR REGISTRO, TIENE QUE ESTAR DEACUERDO A LA POLITICA DE MODFICACION DE ASISTENCIA");
                    return;
                }
        
                if (tempAsistencia.HoraIngreso.Hour != ControlEntidades.EnviarAsistencia(IdAsistencia).HoraIngreso.Hour)
                {
                    MessageBox.Show("VERIFICAR REGISTRO, TIENE QUE ESTAR DEACUERDO A LA POLITICA DE MODFICACION DE ASISTENCIA");
                    return;
                }
                if (tempAsistencia.HoraIngreso.Minute >= ControlEntidades.EnviarAsistencia(IdAsistencia).HoraIngreso.Minute)
                {
                    MessageBox.Show("VERIFICAR REGISTRO, TIENE QUE ESTAR DEACUERDO A LA POLITICA DE MODFICACION DE ASISTENCIA");
                    return;
                }
                ControlEntidades.ModificaAsistencia(tempAsistencia);
                MessageBox.Show("LA ASISTENCIA SE MODIFICO CON EXITO");
                this.Close();
          }
                    else { }
            }
            catch { MessageBox.Show("VERIFICAR FORMATO DE REGISTRO DE FECHA "); }
        }

        private void tbobserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = teclas.soloLetras(e);
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void tbHoraInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = teclas.soloNumEntPos(e);
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { tbHoraFinal.Focus(); } 
        }

        private void tbHoraFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = teclas.soloNumEntPos(e);
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { button2.Focus(); } 
        }
    }
}
