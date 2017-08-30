using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlHorario.Entidades
{
    public class VerPagos
    {
        private Double monto;
        private DateTime fecha;


        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }
    }
}
