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
    public partial class frmRptAlumnosInscritos : Form
    {
        public frmRptAlumnosInscritos()
        {
            InitializeComponent();
        }

        private void frmRptAlumnosInscritos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsCostoCursos.AlmunosInscritos' table. You can move, or remove it, as needed.
            this.AlmunosInscritosTableAdapter.Fill(this.dtsCostoCursos.AlmunosInscritos);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
