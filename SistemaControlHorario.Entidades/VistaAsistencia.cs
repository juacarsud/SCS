using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlHorario.Entidades
{
    public class VistaAsistencia
    {
        private int idpersonal,asistencial;
        private string dni, nombre, apellido, fecha, laboratorio, estado;
        DateTime horaingreso, horasalida;

        public int IdAsistencia
        {
            get { return asistencial; }
            set { asistencial = value; }
        }

        public int IdPersonal
        {
            get { return idpersonal; }
            set { idpersonal = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Fecha
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

        public string Laboratorio
        {
            get { return laboratorio; }
            set { laboratorio = value; }
        }

        public string EstadoAsistencia
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
