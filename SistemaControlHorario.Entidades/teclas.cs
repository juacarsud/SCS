using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;//para poder utilizar el evento key press

namespace SistemaControlHorario.Entidades
{
    public class teclas
    {
        public static Boolean soloLetras(KeyPressEventArgs e)
        {
            Boolean rpta = false;
            if (!char.IsLetter(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    if (e.KeyChar != '.')
                        if (e.KeyChar != ' ')
                            rpta = true;
                }
            }
            return rpta;
        }

        public static Boolean soloNumEntPos(KeyPressEventArgs tecla)
        {
            Boolean estado = false;//por defecto las variables booleanas 
            //inicia en false
            if (!char.IsDigit(tecla.KeyChar))
                if (tecla.KeyChar != '\b')
                    estado = true;
            return (estado);
        }

       

        public static Boolean solonumentposneg(KeyPressEventArgs tecla, String texto)
        {
            Boolean estado = false;
            if (!char.IsDigit(tecla.KeyChar))//si no es un digito
                if (tecla.KeyChar != '\b') //si tecla es diferente de backspace
                    if (texto.Length != 0 || tecla.KeyChar != '-')
                        estado = true;
            return (estado);
        }
        public static Boolean solorealpos(KeyPressEventArgs tecla, String texto)
        {
            Boolean estado = false;
            if (!char.IsDigit(tecla.KeyChar))
                if (tecla.KeyChar != '\b')
                    if (tecla.KeyChar != '.' || texto.Contains("."))
                        estado = true;
            return (estado);
        }

        public static Boolean solorealposCobrar(KeyPressEventArgs tecla, String texto)
        {
            Boolean estado = false;
            if (!char.IsDigit(tecla.KeyChar))
                if (tecla.KeyChar != '\b')
                    if (tecla.KeyChar != '.' || texto.Contains("."))
                        estado = true;
            return (estado);
        }
        public static Boolean solorealposneg(KeyPressEventArgs tecla, String texto)
        {
            Boolean estado = false;
            if (!char.IsDigit(tecla.KeyChar))//isdigit toma 0 al 9 devuelve true
                if (tecla.KeyChar != '\b')
                    if (tecla.KeyChar != '.' || texto.Contains("."))
                        if (texto.Length != 0 || tecla.KeyChar != '-')
                            estado = true;
            return (estado);
        }
    }
}
