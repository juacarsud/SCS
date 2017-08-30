using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlHorario.Datos
{
    public class Herramienta
    {
        public static string transformar(int cod)
        {
            string conteoCodigo;
            int numero = 0;

            conteoCodigo = Convert.ToString(cod).Trim();
            numero = conteoCodigo.Length;

            for (int i = numero; i < 4; i++)
            {
                conteoCodigo = "0" + conteoCodigo;
            }
            return conteoCodigo;

        }

        public static int ContDias2Fechas(DateTime fechahoy, DateTime fechaprevista)
        {
            int cant = 0, mes=0, dias=0, año=0;

            año = fechaprevista.Year - fechahoy.Year;
            mes = fechaprevista.Month - fechahoy.Month;
            dias = fechaprevista.Day - fechahoy.Day;

            if (año >= 0)
            {
                if (año == 0)
                {
                    if (mes <= 1)
                    {
                        if (mes == 0)
                        {
                            if (dias >= 0)
                            {
                                if (dias == 0)
                                {
                                    cant = 0;
                                }
                                else { cant = dias; }
                            }
                            else
                            {
                                cant = dias;
                            }
                        }
                        else
                        {
                            dias = ContDiasMes(fechahoy.Month) - fechahoy.Day;
                            //dias = mes * 30 + dias;
                            dias = fechaprevista.Day + dias;
                            cant = dias;
                        }
                    }
                    else
                    {
                        

                        dias = ContDiasMes(fechahoy.Month) - fechahoy.Day;
                        dias = mes * 30 + dias;
                        dias = fechaprevista.Day + dias;
                        cant = dias;

                        return cant = -1;
                    }
                }
                else
                {

                    if (año == 1)
                    {

                        switch (fechaprevista.Month)
                        {
                            case 1:


                                dias = ContDiasMes(fechahoy.Month) - fechahoy.Day;
                                mes = 12 - fechahoy.Month;

                                dias = mes * 30 + dias + fechaprevista.Day;
                                cant = dias;

                                return cant;
                            case 2:
                                dias = ContDiasMes(fechahoy.Month) - fechahoy.Day;
                                mes = 12 - fechahoy.Month;

                                dias = mes * 30 + dias + fechaprevista.Day + (fechaprevista.Month - 1) * 30;
                                cant = dias;

                                return cant;
                            case 3:
                                dias = ContDiasMes(fechahoy.Month) - fechahoy.Day;
                                mes = 12 - fechahoy.Month;

                                dias = mes * 30 + dias + fechaprevista.Day + (fechaprevista.Month - 1) * 30;
                                cant = dias;

                                return cant;
                            case 4:

                                dias = ContDiasMes(fechahoy.Month) - fechahoy.Day;
                                mes = 12 - fechahoy.Month;

                                dias = mes * 30 + dias + fechaprevista.Day + (fechaprevista.Month - 1) * 30;
                                cant = dias;

                                return cant;

                            default: return cant = -1;
                        }
                    }
                    else { return cant = -1; }
                }
            }
            else { return cant = -1; }
            return cant;
        }

        public static int ContDiasMes(int mes)
        {
            int diasmes = 0;

            switch (mes)
            {
                case 1: diasmes = 31; break;
                case 2: diasmes = 28; break;
                case 3: diasmes = 31; break;
                case 4: diasmes = 30; break;
                case 5: diasmes = 31; break;
                case 6: diasmes = 30; break;
                case 7: diasmes = 31; break;
                case 8: diasmes = 31; break;
                case 9: diasmes = 30; break;
                case 10: diasmes = 31; break;
                case 11: diasmes = 30; break;
                case 12: diasmes = 31; break;

            }

            return diasmes;


        }

        public static string MesDescrito(int cod)
        {
            string mes="";

            switch(cod)
            {
                case 1: mes = "ENERO"; break;
                case 2: mes = "FEBRERO"; break;
                case 3: mes = "MARZO"; break;
                case 4: mes = "ABRIL"; break;
                case 5: mes = "MAYO"; break;
                case 6: mes = "JUNIO"; break;
                case 7: mes = "JULIO"; break;
                case 8: mes = "AGOSTO"; break;
                case 9: mes = "SETIEMBRE"; break;
                case 10: mes = "OCTUBRE"; break;
                case 11: mes = "NOVIEMBRE"; break;
                case 12: mes = "DICIEMBRE"; break;


            }


            
            return mes;


        }
        public static int DescricionDia(string dia)
        {
            int mes = 0;

            switch (dia)
            {
                case "Monday": mes = 1; break;
                case "Tuesday": mes = 2; break;
                case "Wednesday": mes = 3; break;
                case "Thursday": mes = 4; break;
                case "Friday": mes = 5; break;
                case "Saturday": mes = 6; break;
                case "Sunday": mes = 7; break;

            }

            return mes;


        }

        public static string transformarserie(string cod,string indice)
        {
            string cadena;
            int numero,ind;
            
            cadena = Convert.ToString(cod).Trim();
            numero = cadena.Length;
            cadena = "-" + cadena;
            ind = Convert.ToInt32(indice);
            if (numero == 4)
            {
                ind++;
                cadena = Convert.ToString(ind) + cadena;

                for (int i = numero + 2; i < 7; i++)
                {

                    cadena = "0" + cadena;
                }
                return cadena;
            }
            else
            {

                cadena = Convert.ToString(ind) + cadena;

                for (int i = numero + 2; i < 7; i++)
                {

                    cadena = "0" + cadena;
                }
                return cadena;
            }
    }
    }
}
