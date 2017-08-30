using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlHorario.Entidades
{
    public class Laboratorio
    {

        private int idLaboratorio;

        public int IdLaboratorio
        {
            get { return idLaboratorio; }
            set { idLaboratorio = value; }
        }
        private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int capacidad;

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        private string ubicacion;

        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }

        private string imagen;

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        private string idpersonal;

        public string JefeLaboratorio
        {
            get { return idpersonal; }
            set { idpersonal = value; }
        }

    }
}
