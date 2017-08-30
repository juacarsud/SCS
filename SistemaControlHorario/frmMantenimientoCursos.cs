using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaControlHorario.Negocio;
using SistemaControlHorario.Entidades;

namespace SistemaControlHorario
{
    public partial class frmMantenimientoCursos : Form
    {
        private List<Curso> lstCursosGrid;
        Curso tempCurso = new Curso();

        public delegate void pasar(String idCurso, String codigo, String Nombre,string profesor);

        public event pasar pasado;

        public bool banderaInscripcion = false;
        
        Curso tempCliente = new Curso();

        Boolean editar = false;

        public frmMantenimientoCursos()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            banderaInscripcion = false;
            tbabrev.Enabled = false;
            Actualizar();
        }

        public frmMantenimientoCursos(bool band)
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            banderaInscripcion = band;
            tbabrev.Enabled = false;
           
            ActualizarCursosActivos();

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantenimientoCursos_Load(object sender, EventArgs e)
        {
            
            InHabilitar();
        }

        private void Borrar()
        {
            tbCodigo.Clear();
            tbNombre.Clear();
            tbCreditos.Clear();
            tbCosto.Clear();
            tbabrev.Clear() ;
        }

        private void Habilitar()
        {
            
            tbCodigo.Enabled = true;
            tbNombre.Enabled = true;
            tbCreditos.Enabled = true;
            tbCosto.Enabled = true;
            cmbTipo.Enabled = true;
            tbabrev.Enabled = true;
            
        }

        private void InHabilitar()
        {
            tbCodigo.Enabled = false;
            tbNombre.Enabled = false;
            tbCreditos.Enabled = false;
            tbCosto.Enabled = false;
            cmbTipo.Enabled = false;
            tbabrev.Enabled = false;
            
        }

        public void Actualizar()
        {
            try
            {
                dgvListadoCursos.DataSource = this.lstCursosGrid = ControlEntidades.VerCursos("todos", frmInicioSesion.ConfigSemestre);
                dgvListadoCursos.Columns[0].Visible = false;
                dgvListadoCursos.Columns[8].Visible = false;
                dgvListadoCursos.Columns[9].Visible = false;
                dgvListadoCursos.Columns[10].Visible = false;
                dgvListadoCursos.Columns[11].Visible = false;
                dgvListadoCursos.Columns[12].Visible = false;
                dgvListadoCursos.Columns[13].Visible = false;
               
            }
            catch { }
        }

        public void ActualizarCursosActivos()
        {
           
            try
            {
                dgvListadoCursos.DataSource = this.lstCursosGrid = ControlEntidades.VerCursos("activos",frmInicioSesion.ConfigSemestre);
                dgvListadoCursos.Columns[0].Visible = false;
                dgvListadoCursos.Columns[3].Visible = false;
                dgvListadoCursos.Columns[6].Visible = false;
                dgvListadoCursos.Columns[7].Visible = false;
                dgvListadoCursos.Columns[11].Visible = false;
                dgvListadoCursos.Columns[12].Visible = false;
                dgvListadoCursos.Columns[13].Visible = false;
              
             
            }
            catch { }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Borrar();
            InHabilitar();
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            Borrar();
            editar = false;
            Habilitar();
            btnGuardar.Enabled = true;
            cmbTipo.Text = "SEMESTRAL";
            tbCosto.Enabled = false;
            tbCosto.Text = "0.0";
            groupBoxHabitacion.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tbNombre.Enabled = true;
            editar = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            cmbTipo.Enabled = false;
            tbCodigo.Enabled = true;
            tbabrev.Enabled = true;
            if (cmbTipo.Text!="SEMESTRAL")
            {
            tbCosto.Enabled = true;
            }
            
            
            tbCreditos.Enabled = true;
            groupBoxHabitacion.Enabled = true;
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
         
            if (tbCreditos.Text != "" && tbNombre.Text != "" && tbCosto.Text != "" && tbCodigo.Text != "" && cmbTipo.Text!="")
            {
                if (editar)
                {
                        tempCliente.IdCurso = Convert.ToInt32(dgvListadoCursos[0, dgvListadoCursos.CurrentCell.RowIndex].Value.ToString());
                        tempCliente.Codigo = tbCodigo.Text;
                        tempCliente.Nombre = tbNombre.Text;
                        tempCliente.Creditos = Convert.ToInt32(tbCreditos.Text);
                        tempCliente.Costo = Convert.ToDouble(tbCosto.Text);
                        tempCliente.Abreviatura = tbabrev.Text;

                        ControlEntidades.Modifica(tempCliente, cmbTipo.Text);

                        MessageBox.Show("MODIFICACION EXITOSO DE CURSO");
                        Borrar();

                        Actualizar();
                        btnEditar.Enabled = false;
                        InHabilitar();

                }
                else
                {
                    if (ControlEntidades.EnviarCurso(tbCodigo.Text, "").Codigo != tbCodigo.Text)
                    {
                        tempCliente.Codigo = tbCodigo.Text;
                        tempCliente.Nombre = tbNombre.Text;
                        tempCliente.Creditos = Convert.ToInt32(tbCreditos.Text);
                        tempCliente.Tipo = cmbTipo.Text;
                        tempCliente.Costo = Convert.ToDouble(tbCosto.Text);
                        tempCliente.Abreviatura = tbabrev.Text;
                        //REGISTRO DEL COSTO DE CURSO
                        ControlEntidades.Registrar(tempCliente);
                        MessageBox.Show("REGISTRO EXITOSO DE CURSO");
                        Borrar();
                        Actualizar();
                        btnEditar.Enabled = false;
                        InHabilitar();
                    }
                    else { MessageBox.Show("EL CURSO INGRESADO YA HA SIDO REGISTRADO"); }
                }

            }
            else
            {
                MessageBox.Show("RELLENAR LOS DATOS OBLIGATORIOS");
            }
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { tbNombre.Focus(); }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { tbCreditos.Focus(); }
        }

        private void tbCreditos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = teclas.soloNumEntPos(e);
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { tbCosto.Focus(); }
        }

        private void tbCosto_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = teclas.solorealpos(e, tbCosto.Text); ;
            if (e.KeyChar == (char)(Keys.Enter))
            { }
        }

        private void dgvListadoCursos_DoubleClick(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvListadoCursos.DataSource = ControlEntidades.VerGridFiltroAlumnos(this.lstCursosGrid, tbBuscar.Text.Trim());
        }

        private void dgvListadoCursos_DoubleClick_1(object sender, EventArgs e)
        {
            if (dgvListadoCursos.Rows.Count > 0)
            {
                if (banderaInscripcion)
                {
                    try
                    {
                        pasado(dgvListadoCursos.CurrentRow.Cells[0].Value.ToString(), dgvListadoCursos.CurrentRow.Cells[1].Value.ToString(), dgvListadoCursos.CurrentRow.Cells[2].Value.ToString(), dgvListadoCursos.CurrentRow.Cells[13].Value.ToString());
                    }
                    catch { }
                    this.Close();




                }
                if (!banderaInscripcion)
                {

                    tbCodigo.Text = dgvListadoCursos[1, dgvListadoCursos.CurrentCell.RowIndex].Value.ToString();
                    tbNombre.Text = dgvListadoCursos[2, dgvListadoCursos.CurrentCell.RowIndex].Value.ToString();
                    tbCreditos.Text = dgvListadoCursos[3, dgvListadoCursos.CurrentCell.RowIndex].Value.ToString();
                    tbCosto.Text = dgvListadoCursos[5, dgvListadoCursos.CurrentCell.RowIndex].Value.ToString();
                    cmbTipo.Text = dgvListadoCursos[4, dgvListadoCursos.CurrentCell.RowIndex].Value.ToString();

                   
                    tbabrev.Text = dgvListadoCursos[7, dgvListadoCursos.CurrentCell.RowIndex].Value.ToString();
                    btnEditar.Enabled = true;
                    editar = true;
                    groupBoxHabitacion.Enabled = false;
                    btnGuardar.Enabled = false;
                }
                
            }
        }

        private void frmMantenimientoCursos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!banderaInscripcion)
            {
                DialogResult rpta = MessageBox.Show("¿SEGURO QUE DESEA SALIR? ", "SALIR DE REGISTRO DE CURSOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.Yes)
                {


                }
                else { e.Cancel = true; }
            }
        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "SEMESTRAL")
            {
                tbCosto.Text = "0.00";
                tbCosto.Enabled = false;
            }
            else
            {
                tbCosto.Enabled = true;
            }
            
        }

        private void tbabrev_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
