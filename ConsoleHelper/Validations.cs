using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelper
{
    public static class Validations
    {
        public static string StringInsert(string mensaje)
        {
            string valor;
            bool loop; //Ver si este flago esta bien usado

            do
            {

                Console.WriteLine(mensaje);
                valor = Console.ReadLine();

                if (string.IsNullOrEmpty(valor))
                {
                    throw new NullOrEmptyStringException();
                }
                else
                {

                    return valor;
                }
            } while (loop);
        }

        public static char CharInsert(string mensaje)
        {
            string valor;
            bool loop;

            do
            {

               
                Console.WriteLine(mensaje);
                valor = Console.ReadLine();
                                
                if (string.IsNullOrEmpty(valor))
                {
                    throw new NullOrEmptyStringException();
                }
                else 
                {
                    
                    return Convert.ToChar(valor);
                }
                
            } while (loop);
        }

        public static int IntInsert(string mensaje, int min, int max)
        {
           
            bool loop;

            do
            {
                Console.WriteLine(mensaje);
                if (!int.TryParse(Console.ReadLine(), out int valor))
                {
                    throw new ArgumentException();
                }
                else if (valor < min || valor > max)
                {
                    throw new OutOfRangeException(min, max);
                }
                else
                {
                    
                    return valor;
                }

            } while (loop);

        }
        public static double DoubleInsert(string mensaje, double min, double max)
        {
           
            bool loop;

            do
            {
                Console.WriteLine(mensaje);
                if (!double.TryParse(Console.ReadLine(), out double valor))
                {
                    throw new ArgumentException();
                }
                else if (valor < min || valor > max)
                {
                    throw new OutOfRangeException(min, max);
                }
                else
                {
                    
                    return valor;
                }

            } while (loop);

        }

        public static long LongInsert(string mensaje, long min, long max)
        {
            
            bool loop = true;

            do
            {
                Console.WriteLine(mensaje);
                if (!long.TryParse(Console.ReadLine(), out long valor))
                {
                    throw new ArgumentException();
                }
                else if (valor < min || valor > max)
                {
                    throw new OutOfRangeException(min, max);
                }
                else
                {
                  
                    return valor;
                }

            } while (loop);
        }

        public static DateTime DateInsert(string mensaje)
        {
            int dia = IntInsert("Ingrese día", 1, 31);
            int mes = IntInsert("Ingrese mes", 1, 12);
            int año = IntInsert("Ingrese año", 1, 9999);

            DateTime date = new DateTime(año, mes, dia);

            return date;
        }

    }
}