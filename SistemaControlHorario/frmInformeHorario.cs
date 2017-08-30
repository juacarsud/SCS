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
    public partial class frmInformeHorario : Form
    {
       string Dia, Hora,  Laborat,Disponibilidad;
        public frmInformeHorario()
        {
            InitializeComponent();
        }

        public frmInformeHorario(string dia,string hora, string laborat)
        {
            InitializeComponent();
            Dia = dia;
            Hora = hora;
            Laborat=laborat;
           
            groupBox2.Enabled = false;
            tbhora.Enabled = false;
            tbdia.Enabled = false;
            tbdia.Text = ControlEntidades.EnviarProgramacion(dia, hora, laborat, frmInicioSesion.ConfigSemestre).Fecha;


            tbdocente.Text = ControlEntidades.EnviarProgramacion(dia, hora, laborat, frmInicioSesion.ConfigSemestre).Docente;
            tbcurso.Text = ControlEntidades.EnviarProgramacion(dia, hora, laborat, frmInicioSesion.ConfigSemestre).Curso;



            tbambiente.Text = ControlEntidades.EnviarProgramacion(dia, hora, laborat, frmInicioSesion.ConfigSemestre).Laboratorio;


            tbfechaInicio.Text = ControlEntidades.EnviarProgramacion(dia, hora, laborat, frmInicioSesion.ConfigSemestre).FechaInicial.ToShortDateString();

            tbfechafinal.Text = ControlEntidades.EnviarProgramacion(dia, hora, laborat, frmInicioSesion.ConfigSemestre).FechaFinal.ToShortDateString();

            tbhora.Text = ControlEntidades.EnviarProgramacion(dia, hora, laborat, frmInicioSesion.ConfigSemestre).Hora;




        }

        private void frmInformeHorario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmRegistroHorario(ControlEntidades.EnviarProgramacion(Dia, Hora, Laborat, frmInicioSesion.ConfigSemestre).Docente, ControlEntidades.EnviarProgramacion(Dia, Hora, Laborat, frmInicioSesion.ConfigSemestre).Curso, ControlEntidades.EnviarProgramacionDocente(Dia, Hora, Laborat).Docente).ShowDialog();
        }
    }
}
