using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlHorario.Entidades
{
  public  class Inscripcion
    {
        private int idInscripcion;

        public int IdInscripcion
        {
            get { return idInscripcion; }
            set { idInscripcion = value; }
        }
        private int idCurso;

        public int IdCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
        }
        private int idAlumno;

        public int IdAlumno
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

      // PARA ALMACENAR DATOS DEL ALUMNO , CURSO Y EL COSTO.
        private string nombreAlumno;

        public string NombreAlumno
        {
            get { return nombreAlumno; }
            set { nombreAlumno = value; }
        }
        private string codigoCurso;

        public string CodigoCurso
        {
            get { return codigoCurso; }
            set { codigoCurso = value; }
        }
        
      private string nombreCurso;

        public string NombreCurso
        {
            get { return nombreCurso; }
            set { nombreCurso = value; }
        }
        private double costoCurso;

        public double CostoCurso
        {
            get { return costoCurso; }
            set { costoCurso = value; }
        }

        private double costototal;

        public double CostoTotal
        {
            get { return costototal; }
            set { costototal = value; }
        }

        private DateTime fechainscripcion;

        public DateTime FechaInscripcion
        {
            get { return fechainscripcion; }
            set { fechainscripcion = value; }
        }

        private string smestre;

        public string Semestre
        {
            get { return smestre; }
            set { smestre = value; }
        }

        private bool bandera;

        public bool Bandera
        {
            get { return bandera; }
            set { bandera = value; }
        }

        private string dsipo;

        public string Disponibilidad
        {
            get { return dsipo; }
            set { dsipo = value; }
        }

    }
}
