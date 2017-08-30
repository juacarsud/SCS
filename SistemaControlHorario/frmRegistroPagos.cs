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
    public partial class frmRegistroPagos : Form
    {
        public String CodAlumno, CodCurso,IdInscripcion;
        public Inscripcion tempInscripcion= new Inscripcion();
        private List<VerPagos> listaPagos;

        
        public frmRegistroPagos()
        {
            InitializeComponent();
        }


        public frmRegistroPagos(string IdAlumno, string codCurso, string incripcion)
        {
            InitializeComponent();
            CodAlumno = IdAlumno;
            CodCurso= codCurso;
            IdInscripcion = incripcion;
            
            tbDni.Text = ControlEntidades.EnviarAlumno(IdAlumno.ToString(),"id").Dni.ToString();
            tbNombre.Text = ControlEntidades.EnviarAlumno(IdAlumno.ToString(), "id").Nombre.ToString();
            tbPaterno.Text = ControlEntidades.EnviarAlumno(IdAlumno.ToString(), "id").Paterno.ToString();
            tbMaterno.Text = ControlEntidades.EnviarAlumno(IdAlumno.ToString(), "id").Materno.ToString();

            tbCodigo.Text = ControlEntidades.EnviarCurso(codCurso,"").Codigo;
            tbnombrecur.Text = ControlEntidades.EnviarCurso(codCurso, "").Nombre;
            tbCreditos.Text = ControlEntidades.EnviarCurso(codCurso, "").Creditos.ToString();
            tbCosto.Text = "S/. " +ControlEntidades.EnviarCurso(codCurso, "").Costo.ToString();

         tbcancelado.Text ="S/. "+ ControlEntidades.EnviarInscripcion(IdInscripcion).CostoTotal.ToString();
         try
         {
             tbsaldo.Text = (ControlEntidades.EnviarCurso(codCurso, "").Costo - ControlEntidades.EnviarInscripcion(IdInscripcion).CostoTotal).ToString();
             tbcancelado.Enabled = false;
             tbsaldo.Enabled = false;
         }
         catch { }

         if (Convert.ToDouble( tbsaldo.Text)==0)
            {
                btnguardar.Enabled = false;
                tbrecibido.Enabled = false;
            
            }





        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (tbrecibido.Text != "" )
            {
                if (Convert.ToDouble(tbrecibido.Text) <= Convert.ToDouble(tbsaldo.Text))
                {
                tempInscripcion.IdInscripcion = Convert.ToInt32(IdInscripcion);
                tempInscripcion.CostoTotal = Convert.ToDouble(tbrecibido.Text);
                tempInscripcion.FechaInscripcion = DateTime.Now;

                ControlEntidades.RegistrarInscripcionPagos(tempInscripcion);
                this.Close();
                }
                else { MessageBox.Show("INGRESAR UN MONTO MENOR O IGUAL AL SALDO"); }

            }else{
            
            MessageBox.Show("INGRESAR UN MONTO PARA GUARDAR");
            }
        }

        private void frmRegistroPagos_Load(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                dgvListadoCursos.DataSource = this.listaPagos = ControlEntidades.VerPagos(IdInscripcion);
            }
            catch { }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbrecibido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = teclas.solorealposCobrar(e, tbrecibido.Text); 
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { btnguardar.Focus(); } 
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
