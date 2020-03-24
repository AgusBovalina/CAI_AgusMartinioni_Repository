using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Apoyo
{
    public static class Operaciones
    {
        public static int Sumar()
        {
            int a;
            int b;

            a = Pedidos.PedirInt();

            b = Pedidos.PedirInt();

            Console.WriteLine("El resultado es: " + (a + b));
            return a + b;
        }

        public static int Restar()
        {
            int a;
            int b;

            a = Pedidos.PedirInt();

            b = Pedidos.PedirInt();

            Console.WriteLine("El resultado es: " + (a - b));
            return a - b;
        }

    }

    public static class Pedidos
    {

        public static int PedirInt()
        {
            bool loop = true;
            int a;

            do
            {

                Console.WriteLine("Ingrese un número");

                if (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("El número ingresado no es correcto");
                    loop = true;

                }
                else
                {
                    loop = false;
                    return a;
                }
            } while (loop); 

            return a;
        }
    }
}
