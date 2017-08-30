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
using SistemaControlHorario.Datos;

namespace SistemaControlHorario
{
    public partial class frmMantenimientoDocente : Form
    {

        private List<Docente> listaDocente;
        private string accion = "guardar";
        private List<Rol> lstRolGrid;
        public bool asigJfe = false;
        public string InsCursos = "no";
        bool asistencia = false;


        public frmMantenimientoDocente()
        {
            InitializeComponent();
            this.Text = "PERSONAL";
            dgvListadoDocentes.DataSource = this.listaDocente = ControlEntidades.VerDocente("todos");
            asigJfe = false;
            inhabilitar();
        }

        

        public frmMantenimientoDocente(bool Codigo,string cond)
        {
            InitializeComponent();
            asigJfe = Codigo;
            this.Text = "PERSONAL";
            if(cond!="asistencia")
            {
            dgvListadoDocentes.DataSource = this.listaDocente = ControlEntidades.VerDocente("");
            }
            else { dgvListadoDocentes.DataSource = this.listaDocente = ControlEntidades.VerDocente("todos"); asistencia = true; }

            inhabilitar();

        }

        public frmMantenimientoDocente(string Codigo)
        {
            InitializeComponent();
            InsCursos = Codigo;
            this.Text = "PERSONAL";
            dgvListadoDocentes.DataSource = this.listaDocente = ControlEntidades.VerDocente("insc");

            inhabilitar();

        }



        public void ocultarColumna()
        {
            dgvListadoDocentes.Columns[0].Visible = false;

            dgvListadoDocentes.Columns[7].Visible = false;
            dgvListadoDocentes.Columns[8].Visible = false;
            dgvListadoDocentes.Columns[10].Visible = false;
            dgvListadoDocentes.Columns[11].Visible = false;
            dgvListadoDocentes.Columns[12].Visible = false;
            dgvListadoDocentes.Columns[13].Visible = false;
            dgvListadoDocentes.Columns[14].Visible = false;

        }

        public void habilitar()
        {

            tbIdDocente.Visible = false;
            tbDni.Enabled = true;
            tbNombre.Enabled = true;
            tbPaterno.Enabled = true;
            tbMaterno.Enabled = true;
            tbDireccion.Enabled = true;
            tbCorreo.Enabled = true;
            tbTitulo.Enabled = true;
            cmbespecialidad.Enabled = true;
            cbEstado.Enabled = true;
            tbTelefono.Enabled = true;
            tbCelular.Enabled = true;
            tbContraseña.Enabled = true;
            cbRol.Enabled = true;
            radioButtonFemenino.Enabled = true;
            radioButtonMasculino.Enabled = true;
            toolStripButtonEditar.Text = "GUARDAR";

            tbDni.Text = "";
            tbNombre.Text = "";
            tbPaterno.Text = "";
            tbMaterno.Text = "";
            tbDireccion.Text = "";
            tbCorreo.Text = "";
            tbTitulo.Text = "";
            cbEstado.Text = "";
            tbTelefono.Text = "";
            tbCelular.Text = "";
            tbContraseña.Text = "";
            cbRol.Text = "";
            radioButtonFemenino.Checked = true;
            radioButtonMasculino.Checked = true;


            toolStripButtonEditar.Visible = false;
            toolStripButtonGuardar.Enabled = true;
            toolStripButtonCancelar.Enabled = true;

        }


        public void inhabilitar()
        {

            tbIdDocente.Visible = false;

            tbDni.Enabled = false;
            tbNombre.Enabled = false;
            tbPaterno.Enabled = false;
            tbMaterno.Enabled = false;
            tbDireccion.Enabled = false;
            tbCorreo.Enabled = false;
            tbTitulo.Enabled = false;
            cmbespecialidad.Enabled = false;
            cbEstado.Enabled = false;
            tbTelefono.Enabled = false;
            tbCelular.Enabled = false;

            tbContraseña.Enabled = false;
            cbRol.Enabled = false;

            radioButtonFemenino.Enabled = false;
            radioButtonMasculino.Enabled = false;



            tbDni.Text = "";
            tbNombre.Text = "";
            tbPaterno.Text = "";
            tbMaterno.Text = "";
            tbDireccion.Text = "";
            tbCorreo.Text = "";
            tbTitulo.Text = "";
            
            cbEstado.Text = "";
            tbTelefono.Text = "";
            tbCelular.Text = "";
            tbContraseña.Text = "";
            cbRol.Text = "";
            radioButtonFemenino.Checked = false;
            radioButtonMasculino.Checked = false;

            toolStripButtonEditar.Visible = false;
            toolStripButtonGuardar.Enabled = false;
            toolStripButtonCancelar.Enabled = false;

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            if (tbDni.Text.Length == 0)
            {
                MessageBox.Show("INGRESAR DNI");
                tbDni.Text = "";

                return;
            } if (tbNombre.Text.Length == 0)
            {
                MessageBox.Show("INGRESAR NOMBRE");
                tbNombre.Text = "";

                return;
            }
            if (tbPaterno.Text.Length == 0)
            {
                MessageBox.Show("INGRESAR APELLIDO PATERNO ");
                tbPaterno.Text = "";

                return;
            } if (tbMaterno.Text.Length == 0)
            {
                MessageBox.Show("INGRESAR APELLIDO MATERNO ");
                tbMaterno.Text = "";

                return;
            }



            Docente tempDocente = new Docente();

            tempDocente.Dni = tbDni.Text;
            tempDocente.Nombre = tbNombre.Text;
            tempDocente.ApellidoPaterno = tbPaterno.Text;
            tempDocente.ApellidoMaterno = tbMaterno.Text;
            tempDocente.Direccion = tbDireccion.Text;
            tempDocente.Correo = tbCorreo.Text;
            tempDocente.Titulo = tbTitulo.Text;
            tempDocente.Especialidad = cmbespecialidad.Text;
            tempDocente.Telefono = tbTelefono.Text;
            tempDocente.Celular = tbCelular.Text;
            
            tempDocente.Contraseña = tbContraseña.Text;
           

            if (accion.Equals("guardar"))
            {
                DataTable dtDocente = new DataTable();

                    inhabilitar();
                

            }
            else if (accion.Equals("editar"))
            {
                inhabilitar();
            }


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
        
       
       
        private void frmMantenimientoDocente_Load(object sender, EventArgs e)
        {
           
            try
            {
                cbRol.DataSource = this.lstRolGrid = ControlEntidades.VerRol("3");
                cbRol.ValueMember = "IdRol";
                cbRol.DisplayMember = "Descripcion";
                ocultarColumna();
                txtseguridad.Visible = false;
            }
            catch { }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            cbEstado.Text = "ACTIVO";
            habilitar();
            toolStripButtonGuardar.Text = "GUARDAR";
            accion="guardar";

           
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar();
            toolStripButtonGuardar.Text = "GUARDAR";
            toolStripButtonGuardar.Enabled = true;
            toolStripButtonEditar.Enabled = false;
           
            
        }

        public void camposolbgatorios()
        {
            label13.Visible = true;
            label16.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
        }

        public void camposolbgatoriosCancelar()
        {

            label13.Visible = false;
            label16.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbEstado.Text.Length == 0)
            {
                MessageBox.Show("SELECCIONE ESTADO DE PERSONAL ");
                camposolbgatorios();

                return;
            }
            if (tbDni.Text.Length == 0)
            {
                MessageBox.Show("INGRESE DNI");
                camposolbgatorios();

                return;
            } if (tbNombre.Text.Length == 0)
            {
                MessageBox.Show("REGISTRAR NOMBRE");
                camposolbgatorios();

                return;
            }
            if (tbPaterno.Text.Length == 0)
            {
                MessageBox.Show("INGRESAR APELLIDO PATERNO");
                camposolbgatorios();

                return;
            } if (tbMaterno.Text.Length == 0)
            {
                MessageBox.Show("INGRESAR APELLIDO MATERNO");
                camposolbgatorios();

                return;
            }
            Docente tempDocente = new Docente();
            
            tempDocente.Dni = tbDni.Text;
            tempDocente.Nombre = tbNombre.Text;
            tempDocente.ApellidoPaterno = tbPaterno.Text;
            tempDocente.ApellidoMaterno = tbMaterno.Text;
            tempDocente.Direccion = tbDireccion.Text;
            tempDocente.Correo = tbCorreo.Text;
            tempDocente.Titulo = tbTitulo.Text;
            tempDocente.Especialidad = cmbespecialidad.Text;
            tempDocente.Estado = cbEstado.Text;
            tempDocente.Telefono = tbTelefono.Text;
            tempDocente.Celular = tbCelular.Text;

            if (radioButtonMasculino.Checked == true)
            {
                tempDocente.Sexo = radioButtonMasculino.Text;
            }
            else
            {
                tempDocente.Sexo = radioButtonFemenino.Text;
            }
            tempDocente.Contraseña = tbContraseña.Text;
            tempDocente.IdRol = Convert.ToInt32(cbRol.SelectedValue);

            if (accion.Equals("guardar"))
            {
                DialogResult rpta = MessageBox.Show("¿SEGURO QUE DESEA GUARDAR? ", "REGISTRAR PERSONAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.Yes)
                {
                    DataTable dtDocente = new DataTable();

                    if (ControlEntidades.EnviarDocente(tbDni.Text, "dni").Dni != tbDni.Text)
                    {
                        ControlEntidades.Registrar(tempDocente);

                        dgvListadoDocentes.DataSource = this.listaDocente = ControlEntidades.VerDocente("todos");
                        inhabilitar();
                        camposolbgatoriosCancelar();
                    }
                    else { MessageBox.Show("EL PERSONAL YA HA SIDO REGISTRADO"); }
                }


            }
            else if (accion.Equals("editar"))
            {
                tempDocente.IdDocente = Int32.Parse(tbIdDocente.Text);
                if (ControlEntidades.EnviarDocente(tbIdDocente.Text, "id").Dni == tbDni.Text )
                {
                     DialogResult rpta = MessageBox.Show("¿SEGURO QUE DESEA MODIFICAR? ", "MODIFICAR PERSONAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     if (rpta == DialogResult.Yes)
                     {
                         if (ControlEntidades.EnviarDocente(tbContraseña.Text, "contraseña").Contraseña != tbContraseña.Text)
                         {

                             ControlEntidades.Editar(tempDocente);
                             dgvListadoDocentes.DataSource = this.listaDocente = ControlEntidades.VerDocente("todos");

                             inhabilitar();
                             camposolbgatoriosCancelar();
                         }
                         else
                         {
                             MessageBox.Show("CONTRASEÑA YA REGISTRADA , MODIFICAR");

                             return;
                         }
                     }
                   
                    
                }
                else {

                      DialogResult rpta = MessageBox.Show("¿DESEA MODIFICAR DNI? ", "MODIFICAR DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                      if (rpta == DialogResult.Yes)
                      {
                          if (ControlEntidades.EnviarDocente(tbDni.Text, "dni").Dni != tbDni.Text)
                          {
                              ControlEntidades.Editar(tempDocente);

                              dgvListadoDocentes.DataSource = this.listaDocente = ControlEntidades.VerDocente("todos");
                              inhabilitar();
                              camposolbgatoriosCancelar();
                          }
                          else { MessageBox.Show("EL PERSONAL YA HA SIDO REGISTRADO"); }


                      }
                      else { return; }
                        
                     }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inhabilitar();
            camposolbgatoriosCancelar();
            toolStripButtonEditar.Text = "GUARDAR";
            toolStripButtonGuardar.Text = "GUARDAR";
            
        }

        private void dgvListadoDocentes_DoubleClick(object sender, EventArgs e)
        {
           
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
            { tbDireccion.Focus(); } 
        }

        private void tbDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { tbCorreo.Focus(); } 
        }

        private void tbCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { tbTitulo.Focus(); } 
        }

        private void tbTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = teclas.soloLetras(e); 
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            {  } 
        }

        private void tbEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            { tbContraseña.Focus(); } 
        }

        private void tbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            {  } 
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMantenimientoDocente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!asigJfe )
            {
            DialogResult rpta = MessageBox.Show("¿SEGURO QUE DESEA SALIR? ", "SALIR DE REGISTRO DE PERSONAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.Yes)
            {


            }
            else { e.Cancel = true; }
            }else{
            
            
            }

        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvListadoDocentes.DataSource = ControlEntidades.VerGridFiltro(this.listaDocente, tbBuscar.Text.ToString().Trim());
        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {
            
            if (tbContraseña.Text.Length ==0)
            {
                txtseguridad.Visible = false;
            }else if (tbContraseña.Text.Length < 6)
            {
                txtseguridad.Text = "BAJA";
                txtseguridad.ForeColor = Color.Red;
                txtseguridad.Visible = true;
            }
            else if (tbContraseña.Text.Length >= 6 && tbContraseña.Text.Length <= 10)
            {
                txtseguridad.Text = "MEDIA";
                txtseguridad.ForeColor = Color.YellowGreen;
                txtseguridad.Visible = true;
            }else{
                txtseguridad.Text = "ALTA";
                txtseguridad.ForeColor = Color.Green;
                txtseguridad.Visible = true;
            }
        }

        private void dgvListadoCursos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvListadoDocentes.Rows.Count > 0)
                {
                    if (!asigJfe)
                    {

                        toolStripButtonGuardar.Text = "EDITAR";
                        habilitar();
                        accion = "editar";

                        tbIdDocente.Text = Convert.ToString(this.dgvListadoDocentes.CurrentRow.Cells[0].Value);
                        tbDni.Text = Convert.ToString(this.dgvListadoDocentes.CurrentRow.Cells[1].Value);
                        tbNombre.Text = Convert.ToString(this.dgvListadoDocentes.CurrentRow.Cells[2].Value);
                        tbPaterno.Text = Convert.ToString(this.dgvListadoDocentes.CurrentRow.Cells[3].Value);
                        tbMaterno.Text = Convert.ToString(this.dgvListadoDocentes.CurrentRow.Cells[4].Value);
                        tbDireccion.Text = Convert.ToString(this.dgvListadoDocentes.CurrentRow.Cells[5].Value);
                        tbCorreo.Text = Convert.ToString(this.dgvListadoDocentes.CurrentRow.Cells[6].Value);
                        tbTitulo.Text = Convert.ToString(this.dgvListadoDocentes.CurrentRow.Cells[7].Value);
                        cbEstado.Text = Convert.ToString(this.dgvListadoDocentes.CurrentRow.Cells[9].Value);
                        cmbespecialidad.Text = Convert.ToString(this.dgvListadoDocentes.CurrentRow.Cells[8].Value);

                        switch (Convert.ToString(this.dgvListadoDocentes.CurrentRow.Cells[14].Value))
                        {
                            case "1": cbRol.Text = "ADMINISTRADOR"; break;
                            case "2": cbRol.Text = "PROFESOR"; break;
                            case "3": cbRol.Text = "PRACTICANTE"; break;
                            case "4": cbRol.Text = "BOLSISTA"; break;
                            case "5": cbRol.Text = "ALUMNO"; break;


                        }


                        tbContraseña.Text = Convert.ToString(this.dgvListadoDocentes.CurrentRow.Cells[13].Value);
                        tbTelefono.Text = Convert.ToString(this.dgvListadoDocentes.CurrentRow.Cells[10].Value);
                        tbCelular.Text = Convert.ToString(this.dgvListadoDocentes.CurrentRow.Cells[11].Value);

                        if (Convert.ToString(this.dgvListadoDocentes.CurrentRow.Cells[12].Value) == "MASCULINO")
                        {
                            radioButtonMasculino.Checked = true;

                        }
                        else
                        {
                            radioButtonFemenino.Checked = true;
                        }



                        if (InsCursos == "si")
                        {

                            frmRegistroHorario.Docente = Convert.ToString(this.dgvListadoDocentes.CurrentRow.Cells[0].Value);
                            asigJfe = true;
                            this.Close();
                        }

                    }
                    else
                    {

                        if (asistencia)
                        {
                            frmMantenimietoLaboratorio.idJefeLab = Convert.ToInt32(this.dgvListadoDocentes.CurrentRow.Cells[0].Value);
                            this.Close();
                            asistencia = false;

                        }
                        else if (ControlEntidades.EnviarLaboratorio(frmMantenimietoLaboratorio.idJefeLab).Nombre == "")
                        {
                            frmMantenimietoLaboratorio.idJefeLab = Convert.ToInt32(this.dgvListadoDocentes.CurrentRow.Cells[0].Value);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("EL PERSONAL YA ESTA CONSIDERADO COMO JEFE DE LABORATORIO"); return;
                        }


                    }




                }
            }
            catch { }
            
        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

