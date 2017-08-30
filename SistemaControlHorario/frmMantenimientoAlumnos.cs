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
    public partial class frmMantenimientoAlumnos : Form
    {

        private List<Alumno> lstAlumnoGrid;
        Alumno tempCliente = new Alumno();

        public bool bandAlumno = false;

        private List<Rol> lstRolGrid;
        Rol tempRol = new Rol();

        Boolean editar = false;

        public delegate void pasar(String idAlumno, String Nombre, String paterno, string materno);
        public event pasar pasado;


        public frmMantenimientoAlumnos()
        {
            InitializeComponent();
            tbDni.Focus();
            btnEditar.Enabled = false;
            bandAlumno = false;
            Actualizar();
        }

        public frmMantenimientoAlumnos(bool band)
        {
            InitializeComponent();
            tbDni.Focus();
            btnEditar.Enabled = false;
            bandAlumno = band;
            ActualizarAlumnosInscritos();
           

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Borrar();
            InHabilitar();
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            camposolbgatoriosCancelar();
           
        }

        private void Borrar()
        {
            tbCelular.Clear();
            tbDni.Clear();
            tbNombre.Clear();
            tbPaterno.Clear();
            tbMaterno.Clear();
            tbProcedencia.Clear();
            tbTelefono.Clear();
            
        }

        private void Habilitar()
        {
            tbCelular.Enabled=true;
            tbDni.Enabled = true;
            tbNombre.Enabled = true;
            tbPaterno.Enabled = true;
            tbMaterno.Enabled = true;
            tbProcedencia.Enabled = true;
            tbTelefono.Enabled = true;
            
        }

        private void InHabilitar()
        {
            tbCelular.Enabled = false;
            tbDni.Enabled = false;
            tbNombre.Enabled = false;
            tbPaterno.Enabled = false;
            tbMaterno.Enabled = false;
            tbProcedencia.Enabled = false;
            tbTelefono.Enabled = false;
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }
        public void camposolbgatorios()
        {

            label13.Visible = true;
            label16.Visible = true;
            label18.Visible = true;
            label21.Visible = true;


        }

        public void camposolbgatoriosCancelar()
        {

            label13.Visible = false;
            label16.Visible = false;
            label18.Visible = false;
            label21.Visible = false;
        }


        private void frmMantenimientoAlumnos_Load(object sender, EventArgs e)
        {
            
            InHabilitar();
            btnEditar.Enabled = false;
            try
            {
                cmbRol.DataSource = this.lstRolGrid = ControlEntidades.VerRol("1");
                cmbRol.ValueMember = "IdRol";
                cmbRol.DisplayMember = "Descripcion";
            }
            catch { }
        }

        public void ActualizarAlumnosInscritos()
        {
            try
            {
                dgvListadoAlumnos.DataSource = this.lstAlumnoGrid = ControlEntidades.VerAlumno("inscritos");
                dgvListadoAlumnos.Columns[0].Visible = false;
                dgvListadoAlumnos.Columns[6].Visible = false;
                dgvListadoAlumnos.Columns[7].Visible = false;
                dgvListadoAlumnos.Columns[8].Visible = false;
                dgvListadoAlumnos.Columns[11].Visible = false;
            }
            catch { }
        }

        public void Actualizar()
        {
            try
            {
                dgvListadoAlumnos.DataSource = this.lstAlumnoGrid =ControlEntidades.VerAlumno("todos");
                dgvListadoAlumnos.Columns[0].Visible = false;
                dgvListadoAlumnos.Columns[6].Visible = false;
                dgvListadoAlumnos.Columns[7].Visible = false;
                dgvListadoAlumnos.Columns[8].Visible = false;
                dgvListadoAlumnos.Columns[11].Visible = false;
            }
             catch {  }
        }
        public void EditarAlumno()
        {
            tempCliente.IdAlumno = Convert.ToInt32(dgvListadoAlumnos[0, dgvListadoAlumnos.CurrentCell.RowIndex].Value.ToString());
                        tempCliente.Dni = Convert.ToInt32(tbDni.Text);
                        tempCliente.Nombre = tbNombre.Text;
                        tempCliente.Paterno = tbPaterno.Text;
                        tempCliente.Materno = tbMaterno.Text;
                        tempCliente.Procedencia = tbProcedencia.Text;
                        tempCliente.Telefono = tbTelefono.Text;
                        tempCliente.Celular = tbCelular.Text;

                        if (rdbMasculino.Checked)
                        {
                            tempCliente.Sexo = "Masculino";
                        }
                        else
                        {
                            tempCliente.Sexo = "Femenino";
                        }
                        tempCliente.IdRol = Convert.ToInt32(cmbRol.SelectedValue.ToString());
                        

                        ControlEntidades.Modifica(tempCliente);
                        MessageBox.Show("MODIFICACION EXITOSO DE ALUMNO");
                        Borrar();

                        Actualizar();
                        btnEditar.Enabled = false;
                        InHabilitar();
                        camposolbgatoriosCancelar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbDni.Text != "" && tbNombre.Text != "" && tbPaterno.Text != "" && tbMaterno.Text != ""  && (rdbMasculino.Checked || rdbfemenino.Checked))
            {
                if (editar)
                {
                     DialogResult rpta = MessageBox.Show("¿SEGURO QUE DESEA MODIFICAR? ", "MODIFICAR ALUMNOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     if (rpta == DialogResult.Yes)
                     {
                         if (ControlEntidades.EnviarAlumno(tbDni.Text, "dni").Dni == Convert.ToInt32(tbDni.Text))
                         {
                             EditarAlumno();
                         }
                         else
                         {

                             DialogResult rptaS = MessageBox.Show("¿DESEA MODIFICARLO?", "OBSERVACION : EL NUMERO DE DNI ES DIFERENTE ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                             if (rptaS == DialogResult.Yes)
                             {

                                 EditarAlumno();
                             }
                             else { return; }

                         }
                     }
                }
                else
                {
                    if (ControlEntidades.EnviarAlumno(tbDni.Text, "dni").Dni != Convert.ToInt32(tbDni.Text))
                    {
                        DialogResult rpta = MessageBox.Show("¿SEGURO QUE DESEA GUARDAR? ", "REGISTRAR ALUMNOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rpta == DialogResult.Yes)
                        {

                            tempCliente.Dni = Convert.ToInt32(tbDni.Text);
                            tempCliente.Nombre = tbNombre.Text;
                            tempCliente.Paterno = tbPaterno.Text;
                            tempCliente.Materno = tbMaterno.Text;
                            tempCliente.Procedencia = tbProcedencia.Text;
                            tempCliente.Telefono = tbTelefono.Text;
                            tempCliente.Celular = tbCelular.Text;
                            if (rdbMasculino.Checked)
                            {
                                tempCliente.Sexo = "Masculino";
                            }
                            else
                            {
                                tempCliente.Sexo = "Femenino";
                            }
                            tempCliente.IdRol = Convert.ToInt32(cmbRol.SelectedValue.ToString());


                            ControlEntidades.Registrar(tempCliente);
                            MessageBox.Show("REGISTRO EXITOSO DE ALUMNO");
                            Borrar();

                            Actualizar();
                            camposolbgatoriosCancelar();
                            btnEditar.Enabled = false;
                            InHabilitar();
                        }
                    }
                    else { MessageBox.Show("EL ALUMNO YA HA SIDO REGISTRADO"); }
                }

            }
            else
            {
                MessageBox.Show("RELLENAR LOS DATOS OBLIGATORIOS");
                camposolbgatorios();
                
            }
        }

        private void tbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = teclas.soloNumEntPos(e);
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { tbNombre.Focus(); } 
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = teclas.soloLetras(e); 
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { tbPaterno.Focus(); } 
        }

        private void tbPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = teclas.soloLetras(e); 
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { tbMaterno.Focus(); } 
        }

        private void tbMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = teclas.soloLetras(e);
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { tbProcedencia.Focus(); } 
        }

        private void tbProcedencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = teclas.soloLetras(e); 
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { tbTelefono.Focus(); } 
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = teclas.soloNumEntPos(e); 
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { tbCelular.Focus(); } 
        }

        private void tbCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = teclas.soloNumEntPos(e); 
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            {  } 
        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false; 
            Borrar();
            Habilitar();
            editar = false;
            btnGuardar.Enabled = true;
        }

        private void dgvListadoAlumnos_DoubleClick(object sender, EventArgs e)
        { 
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar();
            editar = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvListadoAlumnos.DataSource = ControlEntidades.VerGridFiltroAlumnos(this.lstAlumnoGrid, tbBuscar.Text.Trim());
        }

        private void frmMantenimientoAlumnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bandAlumno)
            {
            DialogResult rpta = MessageBox.Show("¿SEGURO QUE DESEA SALIR? ", "SALIR DE REGISTRO DE ALUMNO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.Yes)
            {


            }
            else { e.Cancel = true; }
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxHabitacion_Enter(object sender, EventArgs e)
        {

        }

        private void dgvListadoAlumnos_DoubleClick_1(object sender, EventArgs e)
        {
            string sexo = "";
            try
            {

                if (dgvListadoAlumnos.Rows.Count > 0)
                {
                    btnGuardar.Enabled = false;

                    tbNombre.Text = dgvListadoAlumnos[1, dgvListadoAlumnos.CurrentCell.RowIndex].Value.ToString();
                    tbPaterno.Text = dgvListadoAlumnos[2, dgvListadoAlumnos.CurrentCell.RowIndex].Value.ToString();
                    tbMaterno.Text = dgvListadoAlumnos[3, dgvListadoAlumnos.CurrentCell.RowIndex].Value.ToString();
                    tbDni.Text = dgvListadoAlumnos[4, dgvListadoAlumnos.CurrentCell.RowIndex].Value.ToString();
                    tbProcedencia.Text = dgvListadoAlumnos[5, dgvListadoAlumnos.CurrentCell.RowIndex].Value.ToString();
                    sexo = dgvListadoAlumnos[6, dgvListadoAlumnos.CurrentCell.RowIndex].Value.ToString();

                    if ("Masculino" == sexo)
                    {
                        rdbMasculino.Checked = true;
                    }
                    else
                    {

                        rdbfemenino.Checked = true;
                    }

                    tbTelefono.Text = dgvListadoAlumnos[9, dgvListadoAlumnos.CurrentCell.RowIndex].Value.ToString();
                    tbCelular.Text = dgvListadoAlumnos[10, dgvListadoAlumnos.CurrentCell.RowIndex].Value.ToString();
                    switch (dgvListadoAlumnos[8, dgvListadoAlumnos.CurrentCell.RowIndex].Value.ToString())
                    {
                        case "1": cmbRol.Text = "Administrador"; break;
                        case "2": cmbRol.Text = "Practicante"; break;
                        case "3": cmbRol.Text = "Bolsista"; break;
                        case "4": cmbRol.Text = "Alumno"; break;

                    }

                    if (bandAlumno)
                    {

                        pasado(dgvListadoAlumnos.CurrentRow.Cells[0].Value.ToString(), dgvListadoAlumnos.CurrentRow.Cells[1].Value.ToString(), dgvListadoAlumnos.CurrentRow.Cells[2].Value.ToString(), dgvListadoAlumnos.CurrentRow.Cells[3].Value.ToString());
                        this.Close();

                    }

                    btnEditar.Enabled = true;
                    InHabilitar();
                }

            }
            catch { }
        }
    }
}
