using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaControlHorario.Datos;
using SistemaControlHorario.Negocio;
using SistemaControlHorario.Entidades;

namespace SistemaControlHorario
{
    public partial class frmInicioSesion : Form
    {
        private List<Rol> lstRolGrid;
        private List<Laboratorio> listaLaboratorios;
        
        Rol tempRol = new Rol();
        string Contraseña;
        string Rol;
        public static string ContraseñaPersonal,LaboratorioAsistencia;
        public static int TerminarSesion=0;
        public static string  ConfigSemestre;
        
        public frmInicioSesion()
        {
            InitializeComponent();
            timer1.Enabled = true;
           
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void metroTileItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTileItem11_Click(object sender, EventArgs e)
        {
            //new frmRegistroAsistencia().ShowDialog();
        }


        public void BotonesMenu()
        {
            
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            
            BotonesMenu();
            cmbLaboratorio.DataSource = this.listaLaboratorios = ControlEntidades.VerLaboratorio();
            cmbLaboratorio.ValueMember = "IdLaboratorio";
            cmbLaboratorio.DisplayMember = "Nombre";
            
            try
            {
                cmbRol.DataSource = this.lstRolGrid =ControlEntidades.VerRol("3");
                cmbRol.ValueMember = "IdRol";
                cmbRol.DisplayMember = "Descripcion";
                
            }
            catch { }
        }

        private void metroTileItem19_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TerminarSesion = 2;
            this.Close();
        }

        public void IngresoSistema()
        {
            string dia;
            int  fecha;

            Contraseña = ContraseñaPersonal = ControlEntidades.EnviarDocente(txtcontraseña.Text, "contraseña").Contraseña;
            Rol = ControlEntidades.EnviarDocente(txtcontraseña.Text, "contraseña").Nombre;
            LaboratorioAsistencia = cmbLaboratorio.SelectedValue.ToString();
            if (txtcontraseña.Text != "")
            {
                if (cmbRol.SelectedValue.ToString() == "1")
                {
                    if (Contraseña == txtcontraseña.Text)
                    {
                        this.Hide();
                     
                        new frmMenuPrincipal().ShowDialog();

                        if (TerminarSesion == 2)
                        {
                            this.Close();
                        }
                        else { new frmInicioSesion().ShowDialog(); }
                    }
                    else { MessageBox.Show("CONTRASEÑA INCORRECTA"); txtcontraseña.Clear(); }
                }
                else
                {
                    if (Contraseña == txtcontraseña.Text && Rol == txtusuario.Text)
                    {
                        dia = DateTime.Now.DayOfWeek.ToString();
                        fecha = Herramienta.DescricionDia(dia);

                        if (ControlEntidades.EnviarDocente(txtcontraseña.Text, "contraseña").IdRol != 2)
                        {

                            this.Hide();

                            new frmRegistroAsistencia(cmbLaboratorio.SelectedValue.ToString()).ShowDialog();
                            if (TerminarSesion == 2)
                            {
                                this.Close();

                            }
                            else { new frmInicioSesion().ShowDialog(); }
                            

                        }
                        else {

                            try
                            {

                                if (ControlEntidades.EnviarDocente(txtcontraseña.Text, "contraseña").IdDocente == VerificaPresenciaClases(ControlEntidades.EnviarCodigoHora(DateTime.Now), fecha))
                                {
                                    this.Hide();

                                    new frmRegistroAsistencia(cmbLaboratorio.SelectedValue.ToString()).ShowDialog();
                                    if (TerminarSesion == 2)
                                    {
                                        this.Close();

                                    }
                                    else { new frmInicioSesion().ShowDialog(); }
                                }
                                else { MessageBox.Show("NO TIENE PERMISO PARA INGRESO AL LABORATORIO, VERIFICAR PROGRAMACION DE HORARIOS"); txtcontraseña.Clear(); }



                            }
                            catch { }
                        
                        
                        }

                    }
                    else { MessageBox.Show("CONTRASEÑA INCORRECTA"); txtcontraseña.Clear(); }

                }

            }
            else { MessageBox.Show("INGRESAR CONTRASEÑA"); txtcontraseña.Clear(); }

            
        }

        public int VerificaPresenciaClases(int hora, int dia)
        {
            int band = 0;


            try
            {
                band = ControlEntidades.VerificarDiponibilidad(hora, dia,frmInicioSesion.LaboratorioAsistencia,ControlEntidades.EnviarSemestre().IdHoras);
            }
            catch
            {  
            }
            return band;

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

            IngresoSistema();
           
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch(cmbRol.SelectedValue.ToString())
            {
                case "1": label1.Visible = false; txtusuario.Visible = false;
                    txtcontraseña.Location = new System.Drawing.Point(181, 75);
                    label5.Location = new System.Drawing.Point(9, 76);
                    
                    label9.Visible = false;
                    cmbLaboratorio.Visible = false;
                    break;
                case "2": label1.Visible = true; txtusuario.Visible = true;
                    txtcontraseña.Location = new System.Drawing.Point(180, 114);
                    label5.Location = new System.Drawing.Point(8, 115);
                    
                    label9.Visible = true;
                    cmbLaboratorio.Visible = true;
                    break;
                case "3": label1.Visible = true; txtusuario.Visible = true;
                    txtcontraseña.Location = new System.Drawing.Point(180, 114);
                    label5.Location = new System.Drawing.Point(8, 115);
                    
                    label9.Visible = true;
                    cmbLaboratorio.Visible = true;
                    break;

                case "4": label1.Visible = true; txtusuario.Visible = true;
                    txtcontraseña.Location = new System.Drawing.Point(180, 114);
                    label5.Location = new System.Drawing.Point(8, 115);
                   
                    label9.Visible = true;
                    cmbLaboratorio.Visible = true;
                    break;
                case "5": label1.Visible = false; txtusuario.Visible = false; 
                    txtcontraseña.Location = new System.Drawing.Point(181, 75);
                    label5.Location = new System.Drawing.Point(9, 76);
                    
                    label9.Visible = true;
                    cmbLaboratorio.Visible = true;
                    break;
            
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (TerminarSesion == 0 || TerminarSesion == 3)
            {
                
                    if (DateTime.Now.Hour.ToString().Length == 1 && DateTime.Now.Minute.ToString().Length == 1 && DateTime.Now.Second.ToString().Length == 1)
                    {
                        label7.Text = "0" + DateTime.Now.Hour.ToString() + ":" + "0" + DateTime.Now.Minute.ToString() + ":" + "0" + DateTime.Now.Second.ToString();
                    }
                    else if (DateTime.Now.Hour.ToString().Length == 2 && DateTime.Now.Minute.ToString().Length == 2 && DateTime.Now.Second.ToString().Length == 1)
                    {
                        label7.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + "0" + DateTime.Now.Second.ToString();

                    }
                    else if (DateTime.Now.Hour.ToString().Length == 2 && DateTime.Now.Minute.ToString().Length == 1 && DateTime.Now.Second.ToString().Length == 1)
                    {
                        label7.Text = DateTime.Now.Hour.ToString() + ":" + "0" + DateTime.Now.Minute.ToString() + ":" + "0" + DateTime.Now.Second.ToString();


                    }
                    else if (DateTime.Now.Hour.ToString().Length == 2 && DateTime.Now.Minute.ToString().Length == 1 && DateTime.Now.Second.ToString().Length == 2)
                    {
                        label7.Text = DateTime.Now.Hour.ToString() + ":" + "0" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();


                    }
                    else if (DateTime.Now.Hour.ToString().Length == 1 && DateTime.Now.Minute.ToString().Length == 2 && DateTime.Now.Second.ToString().Length == 2)
                    {
                        label7.Text = "0" + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();


                    }
                    else if (DateTime.Now.Hour.ToString().Length == 1 && DateTime.Now.Minute.ToString().Length == 1 && DateTime.Now.Second.ToString().Length == 2)
                    {
                        label7.Text = "0" + DateTime.Now.Hour.ToString() + ":" + "0" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();


                    }
                    else if (DateTime.Now.Hour.ToString().Length == 1 && DateTime.Now.Minute.ToString().Length == 2 && DateTime.Now.Second.ToString().Length == 1)
                    {
                        label7.Text = "0" + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + "0" + DateTime.Now.Second.ToString();


                    }
                    else { label7.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(); }
               
               
            }
            else { this.Close(); }
            
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                
                    IngresoSistema();
              
                
            }
        }

        private void frmInicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (TerminarSesion == 2 || TerminarSesion == 0)
            {


            }
            else { e.Cancel = true;   }
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { txtcontraseña.Focus(); }
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
