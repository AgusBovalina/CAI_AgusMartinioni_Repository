using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Apoyo;

namespace Calculadora
{
    class Program
    {


        static void Main(string[] args)
        {

            string op;
            bool continuar = true;
            int resultado;

            List<int> resultados = new List<int>();


            do
            {

                Console.WriteLine("Elija S para sumar, R para restar, M para Multiplicar, D para dividir o E para salir");
                op = Console.ReadLine().ToUpper();

                switch (op)
                {
                    case "S":

                        resultado = Operaciones.Sumar(PedirInt(), PedirInt());
                        Console.WriteLine("El resultado es: " + resultado);
                        resultados.Add(resultado);

                        break;

                    case "R":

                        resultado = Operaciones.Restar(PedirInt(), PedirInt());
                        Console.WriteLine("El resultado es: " + resultado);
                        resultados.Add(resultado);
                        break;

                    case "M":

                        resultado = Operaciones.Multiplicar(PedirInt(), PedirInt());
                        Console.WriteLine("El resultado es: " + resultado);
                        resultados.Add(resultado);
                        break;

                    case "D":

                        resultado = Operaciones.Dividir(PedirInt(), PedirInt());
                        Console.WriteLine("El resultado es: " + resultado);
                        resultados.Add(resultado);
                        break;

                    case "E":


                        if (resultados.Count() < 2)
                        {
                            Console.WriteLine("Debe hacer como mínimo 2 operaciones antes de salir");
                        }
                        else
                        {
                            foreach (int resu in resultados)
                            {
                                Console.WriteLine(resu);


                            }
                            Console.ReadKey();
                            continuar = false;
                        }

                        break;
                    default:
                        Console.Write("La opción ingresada no es correcta");
                        Console.ReadKey();
                        break;

                }



            } while (continuar);
        }

            public int PedirInt()
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
