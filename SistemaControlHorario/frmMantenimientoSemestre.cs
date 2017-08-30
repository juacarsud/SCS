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
    public partial class frmMantenimientoSemestre : Form
    {
        Horas Temp = new Horas();
        List<Mes> listaSemestre;
        public bool condicion=false;
        public frmMantenimientoSemestre()
        {
            InitializeComponent();
            cmbSemestre.Visible = false;
        }

        public frmMantenimientoSemestre(bool bandera)
        {
            InitializeComponent();
            condicion = bandera;

            cmbSemestre.DataSource = this.listaSemestre = ControlEntidades.VerSemestre();
            cmbSemestre.ValueMember = "Codigo";
            cmbSemestre.DisplayMember = "Nombre";
            tbSemestre.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!condicion)
            {
                if (tbSemestre.Text != "")
                {
                    DialogResult rpta = MessageBox.Show("DESEA GUARDAR", "CONFIRMAR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rpta == DialogResult.Yes)
                    {


                   
                    Temp.Descripcion = tbSemestre.Text;
                    ControlEntidades.Registrar(Temp);
                    this.Close();

                    }
                    else {  }
                }
            }
            else {

                frmInicioSesion.ConfigSemestre = cmbSemestre.SelectedValue.ToString();
                DialogResult rpta = MessageBox.Show("SE ASIGNO A LA CONFIGURACION DEL SISTEMA EL " + ControlEntidades.EnviarSemestre(frmInicioSesion.ConfigSemestre).Descripcion + "  ");
              
                this.Close();
            
            
            }
        }

        private void frmMantenimientoSemestre_Load(object sender, EventArgs e)
        {

        }
    }
}
