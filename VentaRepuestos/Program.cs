using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleHelper;
using VentaRepBusinessLib;

namespace VentaRepuestos1
{
    class Program
    {
        //Duda: List<Repuesto>como devolver una lista filtrada
        static void Main()
        {
            bool loop = true;
            string menu = "1) Listar Repuestos " +
                "\n2) Agregar Repuesto " +
                "\n3) Quitar Repuesto" +
                "\n4) Modificar Precio " +
                "\n5) Agregar Stock " +
                "\n6) Quitar Stock " +
                "\n7) Listar Repuestos por Categoría " +
                "\n8) Agregar Categoría " +
                "\n9) Borrar Categoría " +
                "\n10) Salir";

            VentaRepuestos DonMario = new VentaRepuestos("Don Mario Repuestos", "Avenida Santa Fe 1234");

            Console.WriteLine("Bienvenido a " + DonMario.NombreComercio);

            do
            {
                Console.WriteLine(menu);

                try
                {
                    string opcion = Validations.StringInsert("Ingrese la opción elegida");

                    switch (opcion)
                    {
                        case "1":
                            break;

                        case "2":
                            break;

                        case "3":
                            break;

                        case "4":
                            break;

                        case "5":
                            break;

                        case "6":
                            break;

                        case "7":
                            break;

                        case "8":
                            break;

                        case "9":
                            break;

                        case "10":
                            Console.WriteLine("Presione una tecla para salir");
                            Console.ReadKey();
                            loop = false;
                            break;

                        default:
                            Console.WriteLine("Opción invalida");
                            break;


                    }

                }





            } while (loop);


        }

        private static void AgregarRepuesto(VentaRepuestos local)
        {
            int codigoRepuesto = Validations.IntInsert("Ingrese el código del nuevo repuesto", 0, int.MaxValue);
            string nombreRepuesto = Validations.StringInsert("Ingrese el nombre del nuevo repuesto");
            double precio = Validations.DoubleInsert("Ingrese el precio del nuevo repuesto", 0, double.MaxValue);
            int stock = Validations.IntInsert("Ingrese la cantidad de stock del nuevo repuesto",0, int.MaxValue);

            Repuesto r = new Repuesto(codigoRepuesto, nombreRepuesto, precio, stock);
            
            local.AgregarRepuesto(r);
        }

        private static void QuitarRepuesto(VentaRepuestos local)
        {
            int codigoRepuesto = Validations.IntInsert("Ingrese el codigo del repuesto a eliminar", 0, int.MaxValue);            

            local.QuitarRepuesto(codigoRepuesto);
        }

        private static void ModificarPrecio(VentaRepuestos local)
        {
            int codigoRepuesto = Validations.IntInsert("Ingrese el codigo del repuesto al que desea cambiarle el precio", 0, int.MaxValue);
            double precioNuevo = Validations.DoubleInsert("Ingrese el nuevo precio", 0, double.MaxValue);

            local.ModificarPrecio(codigoRepuesto, precioNuevo);
        }

        private static void AgregarStock(VentaRepuestos local)
        {
            int codigoRepuesto = Validations.IntInsert("Ingrese el codigo del repuesto al que desea agregarle stock", 0, int.MaxValue);
            int deltaStock = Validations.IntInsert("Ingrese el stock a agregar", 0, int.MaxValue);

            local.AgregarStock(codigoRepuesto, deltaStock);
        }

        private static void QuitarStock(VentaRepuestos local)
        {
            int codigoRepuesto = Validations.IntInsert("Ingrese el codigo del repuesto al que desea quitarle stock", 0, int.MaxValue);
            int deltaStock = Validations.IntInsert("Ingrese el stock a quitar", 0, int.MaxValue);

            local.QuitarStock(codigoRepuesto, deltaStock);
        }

        private static void ListarRepPorCat (VentaRepuestos local)
        {
            throw new NotImplementedException();
        }

        private static void AgregarCategoría(VentaRepuestos local)
        {
            throw new NotImplementedException();
        }

        private static void QuitarCategoría(VentaRepuestos local)
        {
            throw new NotImplementedException();
        }
    }
}
