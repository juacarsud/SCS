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
using SistemaControlHorario.Datos;


namespace SistemaControlHorario
{
    public partial class frmMantenimietoLaboratorio : Form
    {
        private List<Laboratorio> listaLaboratorio;
        public static int idJefeLab=0;
        private string accion = "guardar";
        public string codigo;

        public frmMantenimietoLaboratorio()
        {
            InitializeComponent();

            this.Text = "LABORATORIO";
            ActualizarData();
            inhabilitar();
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            inhabilitar();
            toolStripButtonGuardar.Text = "GUARDAR";
        }
        public void ActualizarData()
        {
            dgvListadoLaboratorio.DataSource = this.listaLaboratorio = ControlEntidades.VerLaboratorio();
            ocultarColumna();
        }
       

        private void frmMantenimietoLaboratorio_Load(object sender, EventArgs e)
        {
            Convertir_la_Imagen_Byte();
            tbfejelaboratorio.Enabled = false;
        }

        string RutaImagen;
        public void Convertir_la_Imagen_Byte()
        {
            //this.Disenio.SizeMode = PictureBoxSizeMode.StretchImage;
            // Cargando la Imagen desde Archivo
            String Ruta = System.Environment.CurrentDirectory + "\\SinFotos.png";
            ptbImagen.Load(Ruta);
            /* //RutaImagen = System.Environment.CurrentDirectory + "\\SinFotos.png";
             this.ptbImagen.Image = Image.FromFile(Ruta);
             this.ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
             // Convertiendo la Imagen a Bytes 
             // Recuperando la Informacion de la Imagen, para Obtener su Longitud 
             FileInfo InfImagen = new FileInfo(Ruta);
             long LongdeImagen = InfImagen.Length;
             // Abriendo el Archivo en Memoria con FileStream, Estableciendo el Tipo de Acceso 
             FileStream Fs = new FileStream(Ruta, FileMode.Open, FileAccess.Read, FileShare.Read);
             // Estableciendo el Tamaño al Arreglo, en Base a la Longitud de la Imagen Seleccionada 
             ImagenCliente = new byte[LongdeImagen];
             // Iniciando el Desplazamiento de Bytes, al Arreglo Imagen de la Empresa
             Fs.Read(ImagenCliente, 0, Convert.ToInt32(LongdeImagen));
             Fs.Flush(); // Limpiando el Archivo en Memoria 
             Fs.Close(); // Liberando el Recurso*/
        }

        public void ocultarColumna()
        {
            dgvListadoLaboratorio.Columns[0].Visible = false;
            dgvListadoLaboratorio.Columns[5].Visible = false;
            
        }

        public void habilitar()
        {
            tbIdLaboratorio.Visible = false;
            tbCodigo.Enabled = true;
            tbNombre.Enabled = true;
            tbCapacidad.Enabled = true;
            
            tbCodigo.Text = "";
            tbNombre.Text = "";
            tbCapacidad.Text = "";
            tbfejelaboratorio.Text = "";
            
            toolStripButtonEditar.Visible = false;
            toolStripButtonGuardar.Enabled = true;
            toolStripButtonCancelar.Enabled = true;
        }


        public void inhabilitar()
        {
            tbIdLaboratorio.Visible = false;
            tbCodigo.Enabled = false;
            tbNombre.Enabled = false;
            tbCapacidad.Enabled = false;
            
            tbCodigo.Text = "";
            tbNombre.Text = "";
            tbCapacidad.Text = "";
            tbfejelaboratorio.Text = "";
            toolStripButtonEditar.Visible = false;
            toolStripButtonGuardar.Enabled = false;
            toolStripButtonCancelar.Enabled = false;

        }

        private void toolStripButtonNuevo_Click(object sender, EventArgs e)
        {
            habilitar();
            accion = "guardar";
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text.Length == 0)
            {
                MessageBox.Show("INGRESAR CODIGO ");
                return;
            } if (tbNombre.Text.Length == 0)
            {
                MessageBox.Show("INGRESAR NOMBRE");
                return;
            }
            if (tbfejelaboratorio.Text.Length == 0)
            {
                MessageBox.Show("INGRESAR JEFE DE LABORATORIO");
                return;
            }

            if(codigo.CompareTo(tbCodigo.Text)!=0)
            {

            if (ControlEntidades.BuscarCodigoLaboratorio(tbCodigo.Text))
            {
                MessageBox.Show("CODIGO DE LABORATORIO YA REGISTRADO");
                return;
            }

            if (ControlEntidades.EnviarLaboratorio(idJefeLab, "").Codigo == tbCodigo.Text)
            {
                MessageBox.Show("CODIGO DE LABORATORIO YA REGISTRADO");
                return;
            }
            }
            


            Laboratorio tempLaboratorio = new Laboratorio();

            tempLaboratorio.Codigo = tbCodigo.Text;
            tempLaboratorio.Nombre = tbNombre.Text;
            tempLaboratorio.Capacidad = Convert.ToInt32(tbCapacidad.Text);
            tempLaboratorio.Ubicacion = cmbTipo.Text;
            tempLaboratorio.Imagen = RutaImagen;
            tempLaboratorio.JefeLaboratorio = idJefeLab.ToString();

            if (accion.Equals("guardar"))
            {

                

                DialogResult rpta = MessageBox.Show("¿SEGURO QUE DESEA GUARDAR? ", "REGISTRAR LABORATORIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.Yes)
                {
                    DataTable dtLaboratorio = new DataTable();
                    ControlEntidades.Registrar(tempLaboratorio);
                    ActualizarData();
                    inhabilitar();
                }
            }
            else if (accion.Equals("editar"))
            {

                tempLaboratorio.IdLaboratorio = Int32.Parse(tbIdLaboratorio.Text);
                ControlEntidades.Editar(tempLaboratorio);
                ActualizarData();
                inhabilitar();
            }

        }
        private void dgvListadoLaboratorio_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { tbNombre.Focus(); } 
        }

        private void tbNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            { tbCapacidad.Focus(); } 
        }

        private void tbCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = teclas.soloNumEntPos(e);
            if (e.KeyChar == (char)(Keys.Enter))
            { } 
        }

        private void tbUbicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)(Keys.Enter))
            {  } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "C:\\";//ruta donde inicias a buscar
            openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png|GIF(*… *.Png, *.Gif, *.Tiff, *.Jpeg, *.Bmp)|*.Jpg; *.Png; *.Gif; *.Tiff; *.Jpeg; *.Bmp"; //formatos soportados
            openFileDialog1.FilterIndex = 4;//4 si te das cuenta arribita dice todos 4 es el indice que sera el predeterminado
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ptbImagen.Image = Image.FromFile(openFileDialog1.FileName);
                RutaImagen = openFileDialog1.FileName;
            }
            else
            {
                if (string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    MessageBox.Show("NO HA SELECCIONADO NINGUNA IMAGEN");
                    Convertir_la_Imagen_Byte();
                }
            }
        }
      

        private void dgvListadoLaboratorio_DoubleClick(object sender, EventArgs e)
        {

            
        }

        private void frmMantenimietoLaboratorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta = MessageBox.Show("¿SEGURO QUE DESEA SALIR? ", "SALIR DE REGISTRO DE LABORATORIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.Yes)
            {


            }
            else { e.Cancel = true; }
        }

        private void dgvListadoLaboratorio_DoubleClick_1(object sender, EventArgs e)
        {
            toolStripButtonGuardar.Text = "EDITAR";
            habilitar();
            accion = "editar";

            try
            {
                if (dgvListadoLaboratorio.Rows.Count > 0)
                {

                    tbIdLaboratorio.Text = dgvListadoLaboratorio[0, dgvListadoLaboratorio.CurrentCell.RowIndex].Value.ToString();
                   codigo= tbCodigo.Text = dgvListadoLaboratorio[1, dgvListadoLaboratorio.CurrentCell.RowIndex].Value.ToString();
                    tbNombre.Text = dgvListadoLaboratorio[2, dgvListadoLaboratorio.CurrentCell.RowIndex].Value.ToString();
                    tbCapacidad.Text = dgvListadoLaboratorio[3, dgvListadoLaboratorio.CurrentCell.RowIndex].Value.ToString();
                    cmbTipo.Text = dgvListadoLaboratorio[4, dgvListadoLaboratorio.CurrentCell.RowIndex].Value.ToString();
                    tbfejelaboratorio.Text = ControlEntidades.EnviarDocente(ControlEntidades.EnviarLaboratorio(Convert.ToInt32(tbIdLaboratorio.Text), "").JefeLaboratorio, "id").Nombre + " " + ControlEntidades.EnviarDocente(ControlEntidades.EnviarLaboratorio(Convert.ToInt32(tbIdLaboratorio.Text), "").JefeLaboratorio, "id").ApellidoPaterno + " " + ControlEntidades.EnviarDocente(ControlEntidades.EnviarLaboratorio(Convert.ToInt32(tbIdLaboratorio.Text), "").JefeLaboratorio, "id").ApellidoMaterno;
                    idJefeLab =Convert.ToInt32( ControlEntidades.EnviarLaboratorio(Convert.ToInt32(tbIdLaboratorio.Text), "").JefeLaboratorio);


                    
                }
            }
            catch { }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvListadoLaboratorio.DataSource = ControlEntidades.VerGridFiltroLaboratorio(this.listaLaboratorio, tbBuscar.Text.ToString().Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmMantenimientoDocente(true,"").ShowDialog();
            if (idJefeLab != 0)
            {
                tbfejelaboratorio.Text = ControlEntidades.EnviarDocente(idJefeLab.ToString(), "").Nombre + " " + ControlEntidades.EnviarDocente(idJefeLab.ToString(), "").ApellidoPaterno + " " + ControlEntidades.EnviarDocente(idJefeLab.ToString(), "").ApellidoMaterno;
            }
            else { MessageBox.Show("NO SELECCIONO NINGUN PERSONAL"); }
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {

        }
        

    }
}
