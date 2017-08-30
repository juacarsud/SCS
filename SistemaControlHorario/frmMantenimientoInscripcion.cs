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
    public partial class frmMantenimientoInscripcion : Form
    {

        private List<Inscripcion> listaIncripcion;
        private string accion = "guardar";
        private string alumno, curso,disponbidlidad;
        

        public frmMantenimientoInscripcion()
        {
            InitializeComponent();

            this.Text = "INCRIPCIONES";
            actualizar();
            ocultarColumna();
            inhabilitar();
        }
        public void actualizar()
        {
            dgvListadoInscripcion.DataSource = this.listaIncripcion = ControlEntidades.VerInscripcion();
        }

        public void ocultarColumna()
        {
            dgvListadoInscripcion.Columns[0].Visible = false;
            dgvListadoInscripcion.Columns[1].Visible = false;
            dgvListadoInscripcion.Columns[2].Visible = false;
            dgvListadoInscripcion.Columns[8].Visible = false;
            dgvListadoInscripcion.Columns[9].Visible = false;
            dgvListadoInscripcion.Columns[7].Visible = false;
            dgvListadoInscripcion.Columns[11].Visible = false;
            dgvListadoInscripcion.Columns[12].Visible = false;

        }


        public void habilitar()
        {
            tbIdIscripcion.Visible = false; 
            tbIdAlumno.Visible = true;
            tbCurso.Visible = true;
            tbIdAlumno.Visible = false;
            tbIdCurso.Visible = false;
            
            tbAlumno.Enabled = false;
            tbCurso.Enabled = false;
            tbIdIscripcion.Text = "";
            tbIdCurso.Text = "";

            tbAlumno.Text = "";
            tbCurso.Text = "";
            bAgregarAlumno.Enabled = true;
            bAgregarCurso.Enabled = true;
            toolStripButtonEditar.Visible = false;
            toolStripButtonGuardar.Enabled = true;
            toolStripButtonCancelar.Enabled = true;
        }


        public void inhabilitar()
        {
            tbIdIscripcion.Visible = false;
            tbIdAlumno.Visible = true;
            tbCurso.Visible = true;

            tbIdAlumno.Visible = false;
            tbIdCurso.Visible = false;

            tbAlumno.Enabled = false;
            tbCurso.Enabled = false;

            tbIdIscripcion.Text = "";
            tbIdAlumno.Text = "";
            tbIdCurso.Text = "";

            tbAlumno.Text = "";
            tbCurso.Text = "";

            bAgregarAlumno.Enabled = false;
            bAgregarCurso.Enabled = false;

            toolStripButtonEditar.Visible = false;

            toolStripButtonGuardar.Enabled = false;
            toolStripButtonCancelar.Enabled = false;

        }




        private void toolStripButtonNuevo_Click(object sender, EventArgs e)
        {
            habilitar();
            accion = "guardar";
            toolStripButtonGuardar.Text = "GUARDAR";

        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            if (tbAlumno.Text.Length == 0)
            {
                MessageBox.Show("INGRESAR ALUMNO");
                tbAlumno.Text = "";

                return;
            } if (tbCurso.Text.Length == 0)
            {
                MessageBox.Show("INGRESAR CURSO");
                tbCurso.Text = "";

                return;
            }
            



            Inscripcion tempInscripcion = new Inscripcion();

           
            tempInscripcion.IdAlumno = Convert.ToInt32(tbIdAlumno.Text);
            tempInscripcion.IdCurso = Convert.ToInt32(tbIdCurso.Text);
            if (ControlEntidades.EnviarCurso(tempInscripcion.IdCurso.ToString(),"ID").Tipo == "SEMESTRAL")
            {
            tempInscripcion.Estado = "CANCELADO";
            }
            else { tempInscripcion.Estado = "PENDIENTE"; }
            tempInscripcion.FechaInscripcion = DateTime.Now;
            tempInscripcion.Semestre = frmInicioSesion.ConfigSemestre;

            tempInscripcion.Disponibilidad = disponbidlidad;
            
            




            if (accion.Equals("guardar"))
            {
                DataTable dtInscripcion = new DataTable();
                ControlEntidades.RegistrarInscripcion(tempInscripcion);
                actualizar();
                inhabilitar();
            }
            else if (accion.Equals("editar"))
            {
                DialogResult rpta = MessageBox.Show("¿SEGURO QUE MODIFICAR? ", "MODIFICAR INSCRIPCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.Yes)
                {
                tempInscripcion.IdInscripcion = Int32.Parse(tbIdIscripcion.Text);
                ControlEntidades.EditarInscripcion(tempInscripcion);
                actualizar();
                inhabilitar();
                }
            }


        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            inhabilitar();
            toolStripButtonGuardar.Text = "GUARDAR";

        }

        private void dgvListadoInscripcion_DoubleClick(object sender, EventArgs e)
        {
            if (dgvListadoInscripcion.Rows.Count > 0)
            {

                toolStripButtonGuardar.Text = "EDITAR";
                habilitar();
                accion = "editar";

                tbIdIscripcion.Text = Convert.ToString(this.dgvListadoInscripcion.CurrentRow.Cells[0].Value);
                tbIdCurso.Text = Convert.ToString(this.dgvListadoInscripcion.CurrentRow.Cells[1].Value);
                tbIdAlumno.Text = Convert.ToString(this.dgvListadoInscripcion.CurrentRow.Cells[2].Value);
                tbAlumno.Text = Convert.ToString(this.dgvListadoInscripcion.CurrentRow.Cells[4].Value);
                tbCurso.Text = Convert.ToString(this.dgvListadoInscripcion.CurrentRow.Cells[5].Value);
                DialogResult rpta = MessageBox.Show("¿DESEA REALIZAR PAGO? ", "DESEA REALIZAR PAGO DE INSCRIPCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.Yes)
                {

                    new frmRegistroPagos(tbIdAlumno.Text, tbCurso.Text, tbIdIscripcion.Text).ShowDialog();
                    actualizar();
                }
                else { return; }
            }

        }

        private void bAgregarAlumno_Click(object sender, EventArgs e)
        {
            frmMantenimientoAlumnos FramePer = new frmMantenimientoAlumnos(true);
            FramePer.pasado += new frmMantenimientoAlumnos.pasar(ejecutarAlumno);
            FramePer.BringToFront();
            FramePer.Visible = true;
        }


        private void bAgregarCurso_Click(object sender, EventArgs e)
        {
            if (tbAlumno.Text != "")
            {
                frmMantenimientoCursos FramePer = new frmMantenimientoCursos(true);
                FramePer.pasado += new frmMantenimientoCursos.pasar(ejecutarCurso);
                FramePer.BringToFront();
                FramePer.Visible = true;
            }
            else { MessageBox.Show("RELLENAR DATOS DE ALUMNO"); }

        }


        //codigo para recibir datos del alumno
        public void ejecutarAlumno(string idAlumno, string nombre, string paterno, string materno)
        {
            tbIdAlumno.Text = alumno=idAlumno ;
            tbAlumno.Text = nombre +"  "+ paterno +"  "+ materno;

           

        }

        //codigo para recibir datos del curso
        public void ejecutarCurso(string idCurso, string nombre, string codigo,string programacion)
        {
            tbIdCurso.Text = curso = idCurso;
            tbCurso.Text = codigo;
            disponbidlidad = programacion;
            if (alumno != "")
            {
                if (ControlEntidades.EnviarInscripcionAlumno(alumno, curso, frmInicioSesion.ConfigSemestre, programacion).Bandera)
                {
                    MessageBox.Show("EL ALUMNO YA ESTA INSCRITO AL CURSO"); tbIdCurso.Text = "";
                    tbCurso.Text = ""; return;
                   
                }
                else
                {
                    tbIdCurso.Text = curso = idCurso;
                    tbCurso.Text = codigo;
                }

            }
            else
            {
                MessageBox.Show("RELLENAR DATOS A ALUMNO PARA INSCRIPCION"); tbIdCurso.Text = "";
                tbCurso.Text = ""; return; 
            }
           



        }

        private void frmMantenimientoInscripcion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmRegistroPagos().ShowDialog();
        }

        private void frmMantenimientoInscripcion_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta = MessageBox.Show("¿SEGURO QUE DESEA SALIR? ", "SALIR DE INSCRIPCION DE CURSOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.Yes)
            {


            }
            else { e.Cancel = true; }
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            tbAlumno.Enabled = true;
            accion = "editar";
            tbCurso.Enabled = true;
        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { } 
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvListadoInscripcion.DataSource = ControlEntidades.VerGridFiltroInscripcion(this.listaIncripcion, tbBuscar.Text.Trim());
        }

      




    }
}
