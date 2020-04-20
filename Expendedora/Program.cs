using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpendedoraBO;
using ConsoleHelper;

namespace EjExpendedora
{
    static class Program
    {
        static void Main()
        {
            Validations.Comentario("Implementar");
            throw new NotImplementedException();
        }

        static void IngresarLata (Expendedora expendedora)
        {
            try
            {
                string codigo = Validations.StringInsert("Ingrese el codigo del producto");
                if (expendedora.GetLataSeleccionada(codigo) == null)
                {
                    string nombre = Validations.StringInsert("Ingrese el nombre del producto");
                    string sabor = Validations.StringInsert("Ingrese el sabor del producto");
                    double precio = Validations.DoubleInsert("Ingrese el precio del producto", 0, 10000);
                    double volumen = Validations.DoubleInsert("Ingrese el volumen del producto", 0, 10000);
                    Lata lata = new Lata(codigo, nombre, sabor, precio, volumen);
                    expendedora.AgregarLata(lata);
                }
                else
                {
                    Console.WriteLine("El producto ingresado ya existe");
                    Program.IngresarLata(expendedora);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "Ingrese el producto nuevamente.");
                Program.IngresarLata(expendedora);
            }
            
        }
        static void ExtraerLata(Expendedora expendedora)
        {
            try
            {
                string codigo = Validations.StringInsert("Ingrese el codigo del producto");
                if (expendedora.GetLataSeleccionada(codigo) != null)
                {                    
                    expendedora.GetLataSeleccionada(codigo);
                }
                else
                {
                    Console.WriteLine("El producto ingresado no existe");
                    Program.ExtraerLata(expendedora);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "Ingrese el codigo del producto nuevamente.");
                Program.ExtraerLata(expendedora);
            }

        }
        static void ObtenerBalance(Expendedora expendedora)
        {
            Console.WriteLine(string.Format("El dinero disponible en la expendedora {0} es $ {1}.", expendedora, expendedora.GetBalance()));
        }
        static void MostrarStock(Expendedora expendedora)
        {
            Console.WriteLine(string.Format("El stock disponible en la expendedora {0} es {1}.", expendedora, expendedora.GetCapacidadRestante()));
        }


    }
}
