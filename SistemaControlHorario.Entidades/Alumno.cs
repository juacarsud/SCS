using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlHorario.Entidades
{
    public class Alumno
    {
        private string condinscri,nombre, paterno, materno, procedencia, contraseña, telefono, celular, sexo;
        private int dni, rol,idalumno;

        public int IdAlumno
        {
            get { return idalumno; }
            set { idalumno = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Paterno
        {
            get { return paterno; }
            set { paterno = value; }
        }

        public string Materno
        {
            get { return materno; }
            set { materno = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Procedencia
        {
            get { return procedencia; }
            set { procedencia = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public int IdRol
        {
            get { return rol; }
            set { rol = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string CondInscripcion
        {
            get { return condinscri; }
            set { condinscri = value; }
        }

       
    }
}
