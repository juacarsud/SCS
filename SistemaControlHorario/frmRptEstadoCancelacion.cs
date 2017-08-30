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
    public partial class frmRptEstadoCancelacion : Form
    {
        int Semestre;

        public frmRptEstadoCancelacion(int semestre)
        {
            InitializeComponent();
            Semestre = semestre;
        }

        private void frmEstadoCancelacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsCostoCursos.ESTADO_DE_CANCELACION_DE_ALUMNOS' table. You can move, or remove it, as needed.
            this.ESTADO_DE_CANCELACION_DE_ALUMNOSTableAdapter.Fill(this.dtsCostoCursos.ESTADO_DE_CANCELACION_DE_ALUMNOS, Semestre);

            this.reportViewer1.RefreshReport();
        }
    }
}
