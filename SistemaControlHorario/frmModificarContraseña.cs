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
    public partial class frmModificarContraseña : Form
    {
        Docente tempDocente = new Docente();

        public frmModificarContraseña()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtcontraseña.Clear();
            txtcontraseña1.Clear();

        }

        private void frmModificarContraseña_Load(object sender, EventArgs e)
        {

        }

        public void ingreso()
        {
            if (txtcontraseña.Text != "" && txtcontraseña1.Text!="")
            {
                if (txtcontraseña.Text == txtcontraseña1.Text)
                {

                    tempDocente.Contraseña = txtcontraseña.Text;
                    tempDocente.IdDocente = ControlEntidades.EnviarDocente(frmInicioSesion.ContraseñaPersonal, "contraseña").IdDocente;
                    ControlEntidades.ModificarContraseña(tempDocente);
                    frmInicioSesion.ContraseñaPersonal = tempDocente.Contraseña;
                    MessageBox.Show("MODIFICADO");
                    this.Close();

                }
                else { MessageBox.Show("LAS CONTRASEÑAS NO SON IDENTICAS"); }
            }
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            { txtcontraseña1.Focus(); }
        }

        private void txtcontraseña1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)(Keys.Enter))
            { ingreso(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingreso();
        }
    }
}
