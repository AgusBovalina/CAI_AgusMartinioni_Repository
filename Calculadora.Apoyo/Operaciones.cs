using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Apoyo
{
    public static class Operaciones
    {
        public static int Sumar(int a, int b)
        {
            Console.WriteLine(a+b);
            return a + b;
        }

        public static int Restar(int a, int b)
        {
            Console.WriteLine(a - b);
            return a - b;
        }

    }

    public static class Pedidos
    { 

        public static int IngresoNros()
        {
            int a;
            

            Console.WriteLine("Ingrese un número");

            return a = Convert.ToInt32(Console.ReadLine());

            
        }
    }
}
