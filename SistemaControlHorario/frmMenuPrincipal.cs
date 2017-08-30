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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            frmInicioSesion.ConfigSemestre = ControlEntidades.EnviarSemestre().IdHoras.ToString();
            //DialogResult rpta = MessageBox.Show("EL SISTEMA INICIA CON UNA CONFIGURACION DE "+ ControlEntidades.EnviarSemestre().Descripcion +"  ", "CONFIGURAR SEMESTRE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (rpta == DialogResult.Yes)
            //{


            //}
            //else { new frmMantenimientoSemestre().ShowDialog(); }



        }

        private void rEGISTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMantenimientoDocente().ShowDialog();
        }

        private void rEGISTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmRegistroAsistencia(true,"").ShowDialog();

            
        }

        private void aLUMNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMantenimientoAlumnos().ShowDialog();
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(frmInicioSesion.TerminarSesion!=3)
            {
            DialogResult rpta = MessageBox.Show("¿SEGURO QUE DESEA SALIR? ", "SALIR DE MENU PRINCIPAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.Yes)
            {


            }
            else { e.Cancel = true; }
            }
        }

        private void cURSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMantenimientoCursos().ShowDialog();
        }

        private void hORARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lABORATORIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMantenimietoLaboratorio().ShowDialog();
        }

        private void iNSCRIPCIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pAGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMantenimientoInscripcion().ShowDialog();
        }

        private void pAGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cOSTODECURSOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        public void VisualizarSemestre()
        {
            toolStripStatusLabel2.Text = ControlEntidades.EnviarSemestre(frmInicioSesion.ConfigSemestre).Descripcion;
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            VisualizarSemestre();
        }

        private void mODIFICARCONTRASEÑAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmModificarContraseña().ShowDialog();
        }

        private void cAMBIARUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicioSesion.TerminarSesion = 3;
            this.Close();
        }

        private void cERRARSESIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicioSesion.TerminarSesion = 2;
            this.Close();
        }

        private void dISPONIBILIDADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDisponibilidadHorario().ShowDialog();
        }

        private void rEGISTROToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmRegistroHorario().ShowDialog();
        }

        private void cOSTODECURSOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmPreguntaReporte("inscripcion").ShowDialog();
        }

        private void aLUMNOSINSCRITOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmRptAlumnosInscritos().ShowDialog();
        }

        private void aLUMNOSCONDEUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new frmPreguntaReporte("alumnos").ShowDialog();
//            new frmRptEstadoCancelacion().ShowDialog();
        }

        private void cONFIGURARAMBIENTEDELSISTEMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cONFIGURARSEMESTREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rEGISTRARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmMantenimientoSemestre().ShowDialog();
            VisualizarSemestre();
        }

        private void aSIGNARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMantenimientoSemestre(true).ShowDialog();
            VisualizarSemestre();
        }
    }
}
