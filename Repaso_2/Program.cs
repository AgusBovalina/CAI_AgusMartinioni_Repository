using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleHelper;

namespace Repaso_2
{
    class Program
    {
        static void Main()
        {
            string salir = "n";
            do
            {
                

                string option = Convert.ToString(Validations.InsertInt("Elije el ejercicio a realizar del 11 al 20", 11, 20));
               

                switch (option)
                {
                    /*case "11":
                        Ejercicio11();
                        break;
                    case "12":
                        Ejercicio12();
                        break;
                    case "13":
                        Ejercicio13();
                        break;
                    case "14":
                        Ejercicio14();
                        break;
                    case "15":
                        Ejercicio15();
                        break;
                    case "16":
                        Ejercicio16();
                        break;
                    case "17":
                        Ejercicio17();
                        break;
                    case "18":
                        Ejercicio18();
                        break;
                    case "19":
                        Ejercicio19();
                        break;
                    case "20":
                        Ejercicio20();
                        break;*/
                    default:
                        Console.WriteLine("La opción ingresada no es correcta. Desea salir S/N");
                        salir = Console.ReadLine().ToLower();
                        break;
                }
            } while (salir != "s");


        }
    }
}
