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
    public partial class frmPreguntaReporte : Form
    {
        List<Mes> templisMes;
        List<Mes> listaSemestre;
        public static String Condicion;


        public frmPreguntaReporte()
        {
            InitializeComponent();
        }

        public frmPreguntaReporte(string condicion)
        {
            InitializeComponent();
            Condicion = condicion;
            switch(condicion)
            {
                case "alumnos": gbmeses.Enabled = false; rdbmeses.Enabled = false; rdbTotal.Enabled = false; gbsemestre.Enabled = true; break;
                case "inscripcion": gbmeses.Enabled = true; gbsemestre.Enabled = false; break;
            }
            
        }


        private void frmPreguntaReporte_Load(object sender, EventArgs e)
        {
            cmbMes1.DataSource = templisMes = ControlEntidades.VerMes();
            cmbMes1.DisplayMember = "Nombre";
            cmbMes1.ValueMember = "Codigo";

            cmbMes2.DataSource = templisMes = ControlEntidades.VerMes();
            cmbMes2.DisplayMember = "Nombre";
            cmbMes2.ValueMember = "Codigo";

            cmbSemestre.DataSource = this.listaSemestre = ControlEntidades.VerSemestre();
            cmbSemestre.ValueMember = "Codigo";
            cmbSemestre.DisplayMember = "Nombre";
            
        }

        private void rdbTotal_CheckedChanged(object sender, EventArgs e)
        {
            gbmeses.Enabled = false;
           
        }

        private void rdbmeses_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbmeses.Checked == true)
            {
                gbmeses.Enabled = true;
            }
            else
            {
                gbmeses.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int difmes;
            //new frmRptEstadoCancelacion().ShowDialog();
            
                        string mes1, mes2;
                switch(Condicion)
                {
                    case "inscripcion":

                        if (rdbmeses.Checked)
                        {
                            if(txtAño.Text!="")
                            {
                            mes1 = cmbMes1.SelectedValue.ToString();
                            mes2 = cmbMes2.SelectedValue.ToString();

                            difmes = Convert.ToInt32(mes1) - Convert.ToInt32(mes2);


                            if (difmes == 0 && txtAño.Text != "")
                            {

                                new frmRptListadoCostoCursos(Convert.ToInt32(cmbMes1.SelectedValue.ToString()), Convert.ToInt32(cmbMes2.SelectedValue.ToString()), Convert.ToInt32(txtAño.Text)).ShowDialog();



                            }
                            else if (Convert.ToInt32(mes2) > Convert.ToInt32(mes1) && txtAño.Text != "")
                            {

                                new frmRptListadoCostoCursos(Convert.ToInt32(cmbMes1.SelectedValue.ToString()), Convert.ToInt32(cmbMes2.SelectedValue.ToString()), Convert.ToInt32(txtAño.Text)).ShowDialog();



                            }
                            else
                            {
                                MessageBox.Show("LAS FECHAS ESTAN MAL INGRESADAS VERIFICAR ");

                            }
                            }
                            else { MessageBox.Show("CONFIRMAR EL AÑO PARA EL REPORTE"); }

                        }
                        else if (rdbTotal.Checked)
                        {
                            new frmRptListadoCostoCursos(1, 12, DateTime.Now.Year).ShowDialog();
                        }
                        else { MessageBox.Show("MARCAR UN CONDICION PARA REALIZAR EL REPORTE "); }
                        break;

                    case "alumnos":



                        new frmRptEstadoCancelacion(Convert.ToInt32 (cmbSemestre.SelectedValue)).ShowDialog();







                        break;

            }



                
            
        }
    }
}
