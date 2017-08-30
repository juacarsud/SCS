using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlHorario.Entidades
{
    public class Horas
    {
        private int horas;
        private string descripcion;
        private DateTime horainicial, horafinal;

        public int IdHoras
        {
            get { return horas; }
            set { horas = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public DateTime HoraInicial
        {
            get { return horainicial; }
            set { horainicial = value; }
        }
        public DateTime HoraFinal
        {
            get { return horafinal; }
            set { horafinal = value; }
        }
    }
}
