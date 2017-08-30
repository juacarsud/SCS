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

namespace SistemaControlHorario
{
    public partial class frmObservacion : Form
    {
        public frmObservacion()
        {
            InitializeComponent();
        }


        private void frmObservacion_Load(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRegistroAsistencia.ObservacionAsistencia = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistroAsistencia.ObservacionAsistencia= tbobservacion.Text;
            this.Close();

        }

        private void tbobservacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = teclas.soloLetras(e);
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
