using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlHorario.Entidades
{
    public class Asistencia
    {
        private int idasistencia, idpersonal, idlaboratorio, condicion;
        private DateTime fecha,horaingreso,horasalida;
        private string observacion, estado, clas;

        public int IdAsistencia
        {
            get { return idasistencia; }
            set { idasistencia = value; }
        }

        public int IdPersonal
        {
            get { return idpersonal; }
            set { idpersonal = value; }
        }

        public int IdLaboratorio
        {
            get { return idlaboratorio; }
            set { idlaboratorio = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public DateTime HoraIngreso
        {
            get { return horaingreso; }
            set { horaingreso = value; }
        }

        public DateTime HoraSalida
        {
            get { return horasalida; }
            set { horasalida = value; }
        }

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int Condicion
        {
            get { return condicion; }
            set { condicion = value; }
        }

        public string Clasificacion
        {
            get { return clas; }
            set { clas = value; }
        }
    }
}
