using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelper
{
    public class NullOrEmptyStringException : Exception
    {
        
        public NullOrEmptyStringException()
        {
            Console.WriteLine("El valor ingresado no puede ser nulo o estar vacío.");
        }
    }

    public class StringTooLongToCharException : Exception
    {
        public StringTooLongToCharException()
        {
            Console.WriteLine("El valor ingresado debe poseer solo un caracter");
        }
    }
    public class OutOfRangeException : Exception
    {
        
        string msj = "El valor ingresado no se encuentra dentro del rango requerido.\nDebe ingresar un valor entre";

        public OutOfRangeException(int min, int max)
        {
            Console.WriteLine(msj + min + " y " + max);
        }

        public OutOfRangeException(double min, double max)
        {
            Console.WriteLine(msj + min + " y " + max);
        }

        public OutOfRangeException(long min, long max)
        {
            Console.WriteLine(msj + min + " y " + max);
        }

    }




}
