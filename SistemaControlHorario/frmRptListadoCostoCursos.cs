using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlHorario
{
    public partial class frmRptListadoCostoCursos : Form
    {
        int fech1, fech2, Anio;

        public frmRptListadoCostoCursos(int fe1, int fe2, int anio)
        {
            InitializeComponent();
            fech1 = fe1;
            fech2 = fe2;
            Anio = anio;
        }

        private void frmRptListadoCostoCursos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsCostoCursos.RptCostoCursos' table. You can move, or remove it, as needed.
            this.RptCostoCursosTableAdapter.Fill(this.dtsCostoCursos.RptCostoCursos ,fech1, fech2,Anio);

            this.reportViewer1.RefreshReport();
        }
    }
}
