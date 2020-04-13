using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2
{
    class Program
    {
        static void Main()
        {
            DateTime fechaNac = new DateTime(1995, 4, 14);
            double edad;

            edad = (double )(DateTime.Today - fechaNac).TotalDays / 365;

            Console.WriteLine(edad);
            Console.ReadKey();
        }
    }
}
