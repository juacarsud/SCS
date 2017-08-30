using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlHorario.Entidades
{
    public class Curso
    {
        private int idcurso,creditos;
        private string codigo, nombre, tipo, abre, profe, esta, idpro,didispo;
        private DateTime fecha, fechaIni, fechaFi;
        private double monto;

        public int IdCurso
        {
            get { return idcurso; }
            set { idcurso = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public double Costo
        {
            get { return monto; }
            set { monto = value; }
        }

        public DateTime FechaRegistro
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string Abreviatura
        {
            get { return abre; }
            set { abre = value; }
        }
        public DateTime FechaInicial
        {
            get { return fechaIni; }
            set { fechaIni = value; }
        }

        public DateTime FechaFinal
        {
            get { return fechaFi; }
            set { fechaFi = value; }
        }

        public string Profesor
        {
            get { return profe; }
            set { profe = value; }
        }

        public string Estado
        {
            get { return esta; }
            set { esta = value; }
        }

        public string Idprofesor
        {
            get { return idpro; }
            set { idpro = value; }
        }
        

            public string IdDisponibilidad
        {
            get { return didispo; }
            set { didispo = value; }
        }



    }
}
