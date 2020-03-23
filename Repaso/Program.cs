using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        
        
        {
            
            Console.WriteLine("Elije el ejercicio a realizar del 1 al 10");
            string option = Console.ReadLine();
            string salir =  "n";
            do
            {

                switch (option)
                {
                    case "1":
                        Ejercicio1();
                        break;
                    case "2":
                        Ejercicio2();
                        break;
                    case "3":
                        Ejercicio3();
                        break;
                    case "4":
                        Ejercicio4();
                        break;
                    case "5":
                        Ejercicio5();
                        break;
                    case "6":
                        Ejercicio6();
                        break;
                    case "7":
                        Ejercicio7();
                        break;
                    case "8":
                        Ejercicio8();
                        break;
                    /*case "9":
                        Ejercicio9();
                        break;
                    case "10":
                        Ejercicio10();
                        break;*/
                    default:
                        Console.WriteLine("La opción ingresada no es correcta. Desea salir S/N");
                        salir = Console.ReadLine().ToLower();
                        break;
                }
            } while (salir != "s");


        }
    

        public static void Ejercicio1()
        {
            
            //Ejercicio 1

            int nroRegistro;
            string registroString;

            Console.WriteLine("Ingrese los últimos 3 digitos de su registro");

            registroString = Console.ReadLine();


            int.TryParse(registroString, out nroRegistro);


            if (nroRegistro < 100)
            {
                nroRegistro = nroRegistro + 100;
            }

            string[] resultado = new string[nroRegistro+1];
            
            for (int i = 0; i <= nroRegistro; i++)
            {
                resultado[i] = i.ToString();


               
                if (i % 3 == 0 || i % 5 == 0)
                {
                    resultado[i] = resultado[i] + " - ";
                }
                

                if (i % 3 == 0)
                {
                    resultado[i] = resultado[i] + "Foo";
                }

                if (i % 5 == 0)
                {
                    resultado[i] = resultado[i] + "Bar";
                }

                Console.WriteLine(resultado[i]);
            }
            Console.ReadKey();
        }

        public static void Ejercicio2()
        {
            int nroRegistro;
            string registroString;
            bool primo = false;

            Console.WriteLine("Ingrese los últimos 3 digitos de su registro");
            registroString = Console.ReadLine();

            int.TryParse(registroString, out nroRegistro);

            if (nroRegistro < 100)
            {
                nroRegistro = nroRegistro + 100;
            }

            string[] resultado = new string[nroRegistro];

            for (int i = 1; i <= nroRegistro; i++)
            {

                resultado[i - 1] = i.ToString();
                primo = true;



                for (int a = nroRegistro; a > 1; a--)
                {

                    if (a != i && i % a == 0)
                    {
                        primo = false;
                    }
                }



                if (primo)
                {
                    resultado[i - 1] = resultado[i - 1] + " - Es primo";
                }

                if (i % 3 == 0 && i != 3 && primo)
                {
                    resultado[i - 1] = resultado[i - 1] + " y es divisible por 3";
                }
                else if (i % 3 == 0 && i != 3)
                {
                    resultado[i - 1] = resultado[i - 1] + " - Es divisible por 3";
                }

                Console.WriteLine(resultado[i - 1]);
            }
            Console.ReadKey();

        }

        public static void Ejercicio3()
        {
            string palabra1;
            bool palindromo = false ;

            Console.WriteLine("Ingrese una palabra");
            palabra1 = Console.ReadLine();

            for (int i = 0; i < palabra1.Length; i++)
            {
                if (palabra1[i] == palabra1[palabra1.Length - 1 - i])
                {
                    palindromo = true;
                } else
                {
                    palindromo = false;
                }

            }
                if (palindromo)
                {
                    Console.WriteLine("La palabra es un palindromo");
                } else
                {
                    Console.WriteLine("La palabra no es un palindromo");
                }

            Console.ReadKey();
            
            
        }

        public static void Ejercicio4()
        {
            string palabra1;
            string palabra2;
            bool anagrama = false;

            Console.WriteLine("Ingrese una palabra");
            palabra1 = Console.ReadLine();

            Console.WriteLine("Ingrese otra palabra");
            palabra2 = Console.ReadLine();

            string[] array1 = new string[palabra1.Length];
            string[] array2 = new string[palabra2.Length];


            if (palabra1.Length != palabra2.Length)
            {
                anagrama = false;
            }
            else
            {

                for (int i = 0; i < palabra1.Length; i++)
                {
                    array1[i] = palabra1[i].ToString();
                    array2[i] = palabra2[i].ToString();
                }
                Array.Sort(array1);
                Array.Sort(array2);

                for (int i = 0; i < palabra1.Length; i++)
                {
                    

                    if (array1[i] == array2[i])
                    {
                        anagrama = true;
                    }
                    else
                    {
                        anagrama = false;
                    }
                }

                if (anagrama)
                {
                    Console.WriteLine("Las palabras ingresadas son un anagrama");
                }
                else
                {
                    Console.WriteLine("Las palabras ingresadas no son un anagrama");
                }
                
            }

            Console.ReadKey();


        }

        public static void Ejercicio5()
        {
            Console.WriteLine("Ingrese un número de 5 cifras palabra");
            string nroIngresado = Console.ReadLine();
            string[] aux = new string[nroIngresado.Length];
            string nroFinal = "";

            for (int i = 0; i < nroIngresado.Length; i++)
            {
                aux[i] = nroIngresado[nroIngresado.Length - 1 - i].ToString();
                nroFinal += aux[i];
            }

            Console.WriteLine(nroFinal);

            Console.ReadKey();

        }

        public static void Ejercicio6()
        {
            int a;
            int b;

            Console.WriteLine("Ingrese un número entero");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Ingrese otro número entero");
            int.TryParse(Console.ReadLine(), out b);

            int suma = a + b;
            int resta = a - b;

            int resultado = suma * resta;

            Console.WriteLine("El resultado es: " + resultado);

            Console.ReadKey();
            
            
            

        }

        public static void Ejercicio7()
        {
            int[] nros = new int[5];

            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Escribe un número");
                int.TryParse(Console.ReadLine(), out nros[i]);
            }

            Array.Sort(nros);

            
            Console.WriteLine("El máximo es: " + nros[nros.Length-1] + "el intermedio es: " + nros[nros.Length/2] + "el mínimo es; " + nros[nros.Length-nros.Length]);
            Console.ReadKey();

        }

        public static void Ejercicio8()
        {
            int dia;
            int mes;
            int año;

            int diferencia;


            DateTime hoy = DateTime.Today;

            Console.WriteLine("Escribe día");
            int.TryParse(Console.ReadLine(), out dia);

            Console.WriteLine("Escribe mes");
            int.TryParse(Console.ReadLine(), out mes);

            Console.WriteLine("Escribe año");
            int.TryParse(Console.ReadLine(), out año);


            DateTime fecha = new DateTime(año, mes, dia);

            diferencia = (hoy - fecha).Days;

            Console.WriteLine("La cantidad de días de diferencia son: " + diferencia);

            Console.ReadKey();

        }

        public static void Ejercicio9()
        {

        }

        public static void Ejercicio10()
        {

        }








    }
        
 }


