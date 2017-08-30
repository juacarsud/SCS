using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlHorario.Entidades
{
    public class Rol
    {
        private int rol;
        private string descripcion;

        public int IdRol
        {
            get { return rol; }
            set { rol = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


    }
}

