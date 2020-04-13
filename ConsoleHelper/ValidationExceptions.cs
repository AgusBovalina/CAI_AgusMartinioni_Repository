using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelper
{
    public class NullOrEmptyStringException : Exception
    {
        
        public NullOrEmptyStringException() : base ("El valor ingresado no puede ser nulo o estar vacío.")
        {

        }
    }

    public class StringTooLongToCharException : Exception
    {
        public StringTooLongToCharException() : base ("El valor ingresado debe poseer solo un caracter")
        {
            
        }
    }
    public class OutOfRangeException : Exception
    {

        public OutOfRangeException(int min, int max) : base ("El valor ingresado no se encuentra dentro del rango requerido.\nDebe ingresar un valor entre " + min + " y " + max)
        {
            
        }

        public OutOfRangeException(double min, double max) : base("El valor ingresado no se encuentra dentro del rango requerido.\nDebe ingresar un valor entre " + min + " y " + max)
        {
            
        }

        public OutOfRangeException(long min, long max) : base("El valor ingresado no se encuentra dentro del rango requerido.\nDebe ingresar un valor entre " + min + " y " + max)
        {
            
        }

    }




}
