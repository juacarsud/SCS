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
    public partial class frmRegistroHorario : Form
    {
        private List<Mes> listaDias;
        private List<Mes> listaHoras;
        private List<Mes> listaSemestre;
        private List<Laboratorio> listaLaboratorios;
        private List<Curso> listaCursos;
        private ProgramacionHorarios TempProgra = new ProgramacionHorarios();

        private List<ProgramacionHorarios> listaHorarios;
        private int band = 0;
        bool modificar = false;

        public static String Docente="";


        public frmRegistroHorario()
        {
            InitializeComponent();
            Iniciar();
            Desabilitar();
        }

        public frmRegistroHorario(string docente,string curso,string codDocente)
        {
            InitializeComponent();
            band++;
            dgvhorarios.Enabled = true;
            Habilitar();
            modificar = true;
            tbprofesor.Text = docente;
            Docente = codDocente;
            cmbcursos.DataSource = this.listaCursos = ControlEntidades.VerCursos("todos", frmInicioSesion.ConfigSemestre);
            cmbcursos.ValueMember = "IdCurso";
            cmbcursos.DisplayMember = "Nombre";
            cmbcursos.Text = curso;

            VerProgamcion2(cmbcursos.SelectedValue.ToString(), Docente);

           

            Iniciar();
            


        }
        public void Desabilitar()
        {
            cmbdias.Enabled = false;
            cmbambiente.Enabled = false;
            cmbhoras.Enabled = false;
            cmbSemestre.Enabled = false;
            groupBox2.Enabled = true;


        }

        public void Habilitar()
        {
            cmbdias.Enabled = true;
            cmbambiente.Enabled = true;
            cmbhoras.Enabled = true;
            
            groupBox2.Enabled = false;
        }

        private void frmRegistroHorario_Load(object sender, EventArgs e)
        {
           

        }
        public void Iniciar()
        {

           

            if (band == 0)
            {

                cmbcursos.DataSource = this.listaCursos = ControlEntidades.VerCursos("todos", frmInicioSesion.ConfigSemestre);
                cmbcursos.ValueMember = "IdCurso";
                cmbcursos.DisplayMember = "Nombre";
            }

            txtcapacidad.Enabled = false;

            cmbdias.DataSource = this.listaDias = ControlEntidades.VerDias();
            cmbdias.ValueMember = "Codigo";
            cmbdias.DisplayMember = "Nombre";

            cmbambiente.DataSource = this.listaLaboratorios = ControlEntidades.VerLaboratorio();
            cmbambiente.ValueMember = "IdLaboratorio";
            cmbambiente.DisplayMember = "Nombre";



            cmbhoras.DataSource = this.listaHoras = ControlEntidades.VerHoras();
            cmbhoras.ValueMember = "Codigo";
            cmbhoras.DisplayMember = "Nombre";

            cmbSemestre.DataSource = this.listaSemestre = ControlEntidades.VerSemestre();
            cmbSemestre.ValueMember = "Codigo";
            cmbSemestre.DisplayMember = "Nombre";

            cmbSemestre.Text = ControlEntidades.EnviarSemestre(frmInicioSesion.ConfigSemestre).Descripcion;
        }

        public void VerProgamcion()
        {
            try
            {
                dgvhorarios.DataSource = listaHorarios = ControlEntidades.VerProgramacion();
                dgvhorarios.Columns[0].Visible = false;
                dgvhorarios.Columns[3].Visible = false;
                dgvhorarios.Columns[4].Visible = false;
                dgvhorarios.Columns[6].Visible = false;
                dgvhorarios.Columns[7].Visible = false;
                dgvhorarios.Columns[8].Visible = false;
                dgvhorarios.Columns[9].Visible = false;

            }
            catch { }
        }

        public void VerProgamcion2(string curso, string docente)
        {
            try
            {
                dgvhorarios.DataSource = listaHorarios = ControlEntidades.VerProgramacion2(curso,docente,frmInicioSesion.ConfigSemestre);
                dgvhorarios.Columns[0].Visible = false;
                dgvhorarios.Columns[3].Visible = false;
                dgvhorarios.Columns[4].Visible = false;
                dgvhorarios.Columns[6].Visible = false;
                dgvhorarios.Columns[7].Visible = false;
                dgvhorarios.Columns[8].Visible = false;
                dgvhorarios.Columns[9].Visible = false;

            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmMantenimientoDocente("si").ShowDialog();
            tbcodigoDocente.Text= ControlEntidades.EnviarDocente(Docente,"id").Dni;
            tbprofesor.Text = ControlEntidades.EnviarDocente(Docente, "id").Nombre + " " + ControlEntidades.EnviarDocente(Docente, "id").ApellidoPaterno + " " + ControlEntidades.EnviarDocente(Docente, "id").ApellidoMaterno;  

        }

        private void cmbambiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtcapacidad.Text = ControlEntidades.EnviarLaboratorio(Convert.ToInt32(cmbambiente.SelectedValue)).Capacidad.ToString();
            }
            catch { }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            string prueba;
            if (band == 0)
            {
                TempProgra.Curso = Convert.ToString(cmbcursos.SelectedValue);
                TempProgra.Docente = Convert.ToString(Docente);
                prueba =Convert.ToString(cmbcursos.SelectedValue)+    Convert.ToString(Docente);

                if (!ControlEntidades.EnviarProgramacionCurso(TempProgra.Curso, "", TempProgra.Docente).Bandera )
                {
                    if (TempProgra.Docente != "" && TempProgra.Curso != "")
                    {
                        DialogResult rpta = MessageBox.Show("¿DESEA REGISTRAR PROGRAMACION DE CURSOS? ", "PROGRAMACION DE CURSO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rpta == DialogResult.Yes)
                        {
                            dgvhorarios.Enabled = true;
                            TempProgra.FechaInicial = dtpfechainicial.Value;
                            TempProgra.FechaFinal = dtmfechafinal.Value;
                            TempProgra.Semestre = frmInicioSesion.ConfigSemestre;
                            ControlEntidades.RegistrarProgramacion(TempProgra, "1", "", "");
                            band++;
                            Habilitar();
                            VerProgamcion();
                            btncancelar.Text = "GUARDAR HORARIO";
                        }
                    }
                    else { MessageBox.Show("DEBE SELECCIONAR UN DOCENTE PARA LA PROGRAMACION DE CURSOS"); }
                }
                else {

                    VerProgamcion2(cmbcursos.SelectedValue.ToString(), Docente );
                    DialogResult rpta = MessageBox.Show("¿DESEA MODIFICAR REGISTRO DE HORARIOS? ", "EL DOCENTE YA ESTA DICTANDO EL CURSO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rpta == DialogResult.Yes)
                    {
                        dgvhorarios.Enabled = true; 
                        Habilitar();
                        band++;
                        modificar = true;
                    }
                    else { dgvhorarios.Enabled = false; }
                  
                }


            }
            else {
                dgvhorarios.Enabled = true; 

                TempProgra.Fecha = Convert.ToString(cmbdias.SelectedValue.ToString());
                TempProgra.Hora = Convert.ToString(cmbhoras.SelectedValue);
                TempProgra.Laboratorio = Convert.ToString(cmbambiente.SelectedValue);
                prueba = TempProgra.Fecha+TempProgra.Hora +TempProgra.Laboratorio;
                if (!ControlEntidades.EnviarHorarios(prueba,"",frmInicioSesion.ConfigSemestre).Bandera)
                {
                    TempProgra.Laboratorio = Convert.ToString(cmbambiente.SelectedValue);
                    if (modificar)
                    {
                        ControlEntidades.RegistrarProgramacion(TempProgra, "3", cmbcursos.SelectedValue.ToString(), Docente);

                        VerProgamcion2(cmbcursos.SelectedValue.ToString(), Docente);
                    }
                    else { ControlEntidades.RegistrarProgramacion(TempProgra, "2", "", ""); VerProgamcion(); }

                }
                else { MessageBox.Show("EL HORARIO YA ESTA ASIGNADO A OTRO CURSO  CAMBIAR DE HORARIO"); }
                  }
              
        }

        private void cmbcursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistroHorario_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta = MessageBox.Show("¿SEGURO QUE DESEA SALIR? ", "SALIR DE REGISTRO DE HORARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.Yes)
            {


            }
            else { e.Cancel = true; }
        }

        private void qUITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Indice;
            if (dgvhorarios.Rows.Count > 0)
            {
                try
                {
                    Indice = Convert.ToString(this.dgvhorarios.CurrentRow.Cells[0].Value);
                    ControlEntidades.EiminarRegistroProgramacion(Indice);

                    VerProgamcion2(cmbcursos.SelectedValue.ToString(), Docente);

                }
                catch { }

            }
        }
    }
}
