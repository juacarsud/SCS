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
    public partial class frmRegistroAsistencia : Form
    {
        
        public static int BandIngreso = 1;
        public static string  ObservacionAsistencia;
        Asistencia TempAsistencia = new Asistencia();
        private List<VistaAsistencia> lstvistaAsistencia;
        public bool condicion = false;

        public frmRegistroAsistencia(bool Condi)
        {
            InitializeComponent();
            timer1.Enabled = true;
            condicion = Condi;

        }
        
        public frmRegistroAsistencia(string laboratorio)
        {
            InitializeComponent();
            timer1.Enabled = true;
            try
            {
                BandIngreso = ControlEntidades.EnviarHorasPersonal(frmInicioSesion.ContraseñaPersonal, DateTime.Now).Condicion + 1;
            }
            catch { }

            frmInicioSesion.LaboratorioAsistencia = laboratorio;


        }

        public frmRegistroAsistencia(bool Condi,string laboratorio)
        {
            InitializeComponent();
            timer1.Enabled = true;
            condicion= Condi;
            frmInicioSesion.LaboratorioAsistencia = laboratorio;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (DateTime.Now.Hour.ToString().Length == 1 && DateTime.Now.Minute.ToString().Length == 1 && DateTime.Now.Second.ToString().Length == 1)
            {
                label11.Text = "0" + DateTime.Now.Hour.ToString() + ":" + "0" + DateTime.Now.Minute.ToString() + ":" + "0" + DateTime.Now.Second.ToString();
            }
            else if (DateTime.Now.Hour.ToString().Length == 2 && DateTime.Now.Minute.ToString().Length == 2 && DateTime.Now.Second.ToString().Length == 1)
            {
                label11.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + "0" + DateTime.Now.Second.ToString();

            }
            else if (DateTime.Now.Hour.ToString().Length == 2 && DateTime.Now.Minute.ToString().Length == 1 && DateTime.Now.Second.ToString().Length == 1)
            {
                label11.Text = DateTime.Now.Hour.ToString() + ":" + "0" + DateTime.Now.Minute.ToString() + ":" + "0" + DateTime.Now.Second.ToString();


            }
            else if (DateTime.Now.Hour.ToString().Length == 2 && DateTime.Now.Minute.ToString().Length == 1 && DateTime.Now.Second.ToString().Length == 2)
            {
                label11.Text = DateTime.Now.Hour.ToString() + ":" + "0" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();


            }
            else if (DateTime.Now.Hour.ToString().Length == 1 && DateTime.Now.Minute.ToString().Length == 2 && DateTime.Now.Second.ToString().Length == 2)
            {
                label11.Text = "0" + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();


            }
            else if (DateTime.Now.Hour.ToString().Length == 1 && DateTime.Now.Minute.ToString().Length == 1 && DateTime.Now.Second.ToString().Length == 2)
            {
                label11.Text = "0" + DateTime.Now.Hour.ToString() + ":" + "0" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();


            }
            else if (DateTime.Now.Hour.ToString().Length == 1 && DateTime.Now.Minute.ToString().Length == 2 && DateTime.Now.Second.ToString().Length == 1)
            {
                label11.Text = "0" + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + "0" + DateTime.Now.Second.ToString();


            }
            else { label11.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(); }
        }


        public void actualizar()
        {
            try
            {
                
                    dgvListadoAsistencia.DataSource = lstvistaAsistencia = ControlEntidades.VerAsistencia(ControlEntidades.EnviarDocente(frmInicioSesion.ContraseñaPersonal, "contraseña").IdDocente);
                    dgvListadoAsistencia.Columns[0].Visible = false;
                    dgvListadoAsistencia.Columns[1].Visible = false;
                
               
            }
            catch { }


        }

        public void BuscarPersonal(string dni)
        {
            int docente = ControlEntidades.EnviarDocente(tbDni.Text, "dni").IdDocente;
            try
            {
                dgvListadoAsistencia.DataSource = lstvistaAsistencia = ControlEntidades.VerAsistencia(ControlEntidades.EnviarDocente(dni, "dni").IdDocente);
                dgvListadoAsistencia.Columns[0].Visible = false;
                dgvListadoAsistencia.Columns[1].Visible = false;

                tbtardanza.Text = ControlEntidades.EnviarTardanza(docente).ToString();
                
                if (lstvistaAsistencia.Count == 0)
                {
                    MessageBox.Show("EL PERSONAL AUN NO TIENE REGSITRO DE ASISTENCIA");
                }
            }
            catch { }


        }

        public void VisualizaAsistenciaPersonal()
        {

            if (ControlEntidades.EnviarDocente(frmInicioSesion.ContraseñaPersonal, "contraseña").IdRol != 1)
            {
                if (ControlEntidades.EnviarHorasPersonal(frmInicioSesion.ContraseñaPersonal, DateTime.Now).Estado == "" && BandIngreso != 3)
                {
                    tbPersonal.Text = ControlEntidades.EnviarDocente(frmInicioSesion.ContraseñaPersonal, "contraseña").Nombre + " " + ControlEntidades.EnviarDocente(frmInicioSesion.ContraseñaPersonal, "contraseña").ApellidoPaterno;
                    tbfecha.Text = DateTime.Now.ToLongDateString();

                    if (BandIngreso == 1 && ControlEntidades.EnviarHorasPersonal(frmInicioSesion.ContraseñaPersonal, DateTime.Now).HoraIngreso.Day != DateTime.Now.Day)
                    {
                        tbhoraingreso.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + " Hrs";
                        tbobservacion.Enabled = false;

                        try
                        {
                            cmbLaboratorio.Text = ControlEntidades.EnviarLaboratorio(Convert.ToInt32( frmInicioSesion.LaboratorioAsistencia)).Nombre;
                        }
                        catch { }
                        RegistroAsistencia();


                        this.Close();

                    }
                    else
                    {
                        cmbLaboratorio.Enabled = false;
                        tbobservacion.Enabled = true;
                        tbhoraingreso.Enabled = false;
                        tbhoraingreso.Text = ControlEntidades.EnviarHorasPersonal(frmInicioSesion.ContraseñaPersonal, DateTime.Now).HoraIngreso.Hour.ToString() + ":" + ControlEntidades.EnviarHorasPersonal(frmInicioSesion.ContraseñaPersonal, DateTime.Now).HoraIngreso.Minute.ToString();

                        cmbLaboratorio.Text = ControlEntidades.EnviarLaboratorio(ControlEntidades.EnviarDocente(frmInicioSesion.ContraseñaPersonal, "contraseña").IdDocente, DateTime.Now.ToShortDateString()).Nombre;

                        RegistroAsistencia();
                       

                        this.Close();
                    }

                    tbhorasalida.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + " Hrs"; ;

                }
                else
                {

                    if (1 == ControlEntidades.EnviarDocente(frmInicioSesion.ContraseñaPersonal, "contraseña").IdRol)
                    {

                        if (condicion)
                        {
                            tbPersonal.Text = ControlEntidades.EnviarDocente(frmInicioSesion.ContraseñaPersonal, "contraseña").Nombre + " " + ControlEntidades.EnviarDocente(frmInicioSesion.ContraseñaPersonal, "contraseña").ApellidoPaterno;
                            tbfecha.Text = DateTime.Now.ToLongDateString();

                            tbhoraingreso.Enabled = false;
                            tbhoraingreso.Text = ControlEntidades.EnviarHorasPersonal(frmInicioSesion.ContraseñaPersonal, DateTime.Now).HoraIngreso.Hour.ToString() + ":" + ControlEntidades.EnviarHorasPersonal(frmInicioSesion.ContraseñaPersonal, DateTime.Now).HoraIngreso.Minute.ToString();

                            tbhorasalida.Text = ControlEntidades.EnviarHorasPersonal(frmInicioSesion.ContraseñaPersonal, DateTime.Now).HoraSalida.Hour.ToString() + ":" + ControlEntidades.EnviarHorasPersonal(frmInicioSesion.ContraseñaPersonal, DateTime.Now).HoraSalida.Minute.ToString();

                            cmbLaboratorio.Text = ControlEntidades.EnviarLaboratorio(ControlEntidades.EnviarDocente(frmInicioSesion.ContraseñaPersonal, "contraseña").IdDocente, DateTime.Now.ToShortDateString()).Nombre;

                            tbobservacion.Text = ControlEntidades.EnviarHorasPersonal(frmInicioSesion.ContraseñaPersonal, DateTime.Now).Observacion;

                            groupBox1.Enabled = false;
                            tbDni.Enabled = true;
                        }
                        else { this.Close(); }

                    }
                    else { this.Close(); }

                }
            }
            else {groupBox1.Enabled=false; }

        }

        private void frmRegistroAsistencia_Load(object sender, EventArgs e)
        {

            actualizar();
            Inhabilitar();

            VisualizaAsistenciaPersonal();
        }

        public void Inhabilitar()
        {
            tbPersonal.Enabled = false;
            tbfecha.Enabled = false;
           
            tbtardanza.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            
                

            
        }

        public void RegistroAsistencia()
        {
            Double Hora;
            if (BandIngreso == 1 && ControlEntidades.EnviarHorasPersonal(frmInicioSesion.ContraseñaPersonal, DateTime.Now).HoraIngreso.Day != DateTime.Now.Day)
            {
                tbhoraingreso.Enabled = false;
                tbobservacion.Enabled = true;
                TempAsistencia.IdPersonal = ControlEntidades.EnviarDocente(frmInicioSesion.ContraseñaPersonal, "contraseña").IdDocente;
                try
                {
                    TempAsistencia.IdLaboratorio = Convert.ToInt32( frmInicioSesion.LaboratorioAsistencia);
                }
                catch { }
                TempAsistencia.Fecha = DateTime.Now;
                TempAsistencia.HoraIngreso = DateTime.Now;
                TempAsistencia.Estado = "";

                //VERIFICACION DE CLASIFICACION DE ASISTENCIA
                try
                {
                    Hora = DateTime.Now.Minute - ControlEntidades.EnviarHoras(ControlEntidades.EnviarCodigoHora(DateTime.Now)).HoraInicial.Minute;
               


                if (Hora>=30)
                {
                    TempAsistencia.Clasificacion = "INASISTENCIA";
                }
                else if (Hora >= 15 && Hora <= 29)
                {
                    TempAsistencia.Clasificacion = "TARDANZA";
                }
                else if (Hora >= 0 && Hora <= 14)
                {
                    TempAsistencia.Clasificacion = "PUNTUAL";
                }

                }
                catch { }
              //------------------------------------------------------------------------  
                ControlEntidades.Registrar(TempAsistencia, ControlEntidades.EnviarDocente(frmInicioSesion.ContraseñaPersonal, "contraseña").IdDocente);



                cmbLaboratorio.Enabled = false;
                actualizar();
                MessageBox.Show(ControlEntidades.EnviarDocente(frmInicioSesion.ContraseñaPersonal, "contraseña").Nombre + " " + " SU ASISTENCIA DE INGRESO FUE REGISTRADA CON EXITO, NO OLVIDAR REGISTRAR A TIEMPO SU HORA DE SALIDA,  YA QUE SI NO ESTA DENTRO DE SU HORA PROGRAMADA EL SISTEMA NO LE PERMITIRA REGISTRAR SU SALIDA ");

                BandIngreso++;                  
            }
            else if (BandIngreso == 2 || ControlEntidades.EnviarHorasPersonal(frmInicioSesion.ContraseñaPersonal, DateTime.Now).HoraIngreso.Day == DateTime.Now.Day)
            {
                TempAsistencia.Estado = "COMPLETO";

                DialogResult rpta = MessageBox.Show("¿DESEA REGISTRAR ALGUNA OBSERVACION A LA ASISTENCIA? ", "GUARDAR OBSERVACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.Yes)
                {

                    new frmObservacion().ShowDialog();

                    TempAsistencia.Observacion = ObservacionAsistencia;

                }

                TempAsistencia.Fecha = DateTime.Now;
                TempAsistencia.HoraSalida = DateTime.Now;
                
                ControlEntidades.Registrar(TempAsistencia, ControlEntidades.EnviarDocente(frmInicioSesion.ContraseñaPersonal, "contraseña").IdDocente);

                cmbLaboratorio.Enabled = false;
                BandIngreso++;
                tbobservacion.Enabled = false;
                tbhoraingreso.Enabled = false;
                tbhorasalida.Enabled = false;
                actualizar();
                MessageBox.Show(ControlEntidades.EnviarDocente(frmInicioSesion.ContraseñaPersonal, "contraseña").Nombre +" "+"SU ASISTENCIA DE SALIDA FUE REGISTRADA CON EXITO");

            }
            else
            {
                BandIngreso = 3;
            }

        }

        private void tbobservacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { } 
        }

        private void frmRegistroAsistencia_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmMantenimientoDocente(true,"asistencia").ShowDialog();
            if (frmMantenimietoLaboratorio.idJefeLab != 0)
            {
                tbDni.Text = ControlEntidades.EnviarDocente(frmMantenimietoLaboratorio.idJefeLab.ToString(), "").Dni;
                tbPersonal.Text = ControlEntidades.EnviarDocente(frmMantenimietoLaboratorio.idJefeLab.ToString(), "").Nombre+" "+ControlEntidades.EnviarDocente(frmMantenimietoLaboratorio.idJefeLab.ToString(), "").ApellidoPaterno+" "+ControlEntidades.EnviarDocente(frmMantenimietoLaboratorio.idJefeLab.ToString(), "").ApellidoMaterno;
                tbfecha.Text = DateTime.Now.ToLongDateString();
                
                BuscarPersonal(tbDni.Text);
            }
            else { MessageBox.Show("NO SELECCIONO NINGUN PERSONAL"); }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dgvListadoAsistencia.Rows.Count > 0)
            {

                new frmModificarAsistencia(Convert.ToString(this.dgvListadoAsistencia.CurrentRow.Cells[0].Value)).ShowDialog();
                actualizar();

            }
        }

        private void tbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
             e.Handled = teclas.soloNumEntPos(e);
           
            if (e.KeyChar == (char)(Keys.Enter))
            { BuscarPersonal(tbDni.Text); } 
        
        }
    }
}
