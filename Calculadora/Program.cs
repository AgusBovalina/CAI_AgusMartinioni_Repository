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
            int a=0;
            int b=0;

            string op;
            bool continuar = true;

            List<int> resultados = new List<int>();

            
            do
            {

                Console.WriteLine("Elija S para sumar, R para restar o E para salir");
                op = Console.ReadLine().ToUpper();

                switch (op)
                {
                    case "S":

                        
                        resultados.Add(Operaciones.Sumar(Pedidos.IngresoNros(), Pedidos.IngresoNros()));
                        
                        break;

                    case "R":
                        
                        resultados.Add(Operaciones.Restar(Pedidos.IngresoNros(), Pedidos.IngresoNros()));                        
                        break;

                    case "E":

                        
                            if (resultados.Count()<2)
                            { 
                                Console.WriteLine("Debe hacer como mínimo 2 operaciones antes de salir");
                            }
                            else
                            {
                                foreach (int resultado in resultados)
                                {
                                    Console.WriteLine(resultado);

                                   
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
    }
}
