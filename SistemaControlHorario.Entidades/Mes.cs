using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlHorario.Entidades
{

    public class Mes
    {
        string nombre;
        int codigo;

        public Mes()
        {
            nombre = "";
        }

        public String Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public int Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
    }
}
