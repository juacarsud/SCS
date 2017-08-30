using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlHorario.Entidades
{
    public class ProgramacionHorarios
    {
        private string fecha, hora, curso, docente, laboratorio, idprogra, semestre;
        private DateTime fechainicial, fechafinal;
        bool bandera;


        public string IdProgramacion
        {
            get { return idprogra; }
            set { idprogra = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public string Docente
        {
            get { return docente; }
            set { docente = value; }
        }

        public string Laboratorio
        {
            get { return laboratorio; }
            set { laboratorio = value; }
        }

        public DateTime FechaInicial
        {
            get { return fechainicial; }
            set { fechainicial = value; }
        }

        public DateTime FechaFinal
        {
            get { return fechafinal; }
            set { fechafinal = value; }
        }

        public bool Bandera
        {
            get { return bandera; }
            set { bandera = value; }
        }

        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
    }
}
