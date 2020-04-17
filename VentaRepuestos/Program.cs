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
        //Duda: List<Repuesto>como mostrar una lista filtrada
        //Duda: de que me sirve implementar una logica en el set de una propiedad, si el metodo accede a la variable de instancia directamente. Ej: que el stock no puede ser menor a cero.


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

            Validations.Duda("Esta bien poner el do while por fuera del try??");

            do
            {
                Console.WriteLine(menu);

                try
                {
                    string opcion = Validations.StringInsert("Ingrese la opción elegida");

                    switch (opcion)
                    {
                        case "1":
                            Program.ListarRepuestos(DonMario);
                            break;

                        case "2":
                            Program.AgregarRepuesto(DonMario);
                            break;

                        case "3":
                            Program.QuitarRepuesto(DonMario);
                            break;

                        case "4":
                            Program.ModificarPrecio(DonMario);
                            break;

                        case "5":
                            Program.AgregarStock(DonMario);
                            break;

                        case "6":
                            Program.QuitarStock(DonMario);
                            break;

                        case "7":
                            Program.ListarRepPorCat(DonMario);
                            break;

                        case "8":
                            Program.AgregarCategoría(DonMario);
                            break;

                        case "9":
                            Program.QuitarCategoría(DonMario);
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
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }





            } while (loop);


        }

        private static void ListarRepuestos (VentaRepuestos local)
        {
           
            foreach (Repuesto r in local.ListaProductos)
            {
                Console.WriteLine("");
            }
           
        }
        private static void AgregarRepuesto(VentaRepuestos local)
        {
            bool loop = true;
            do
            {   try
                {
                    int codigoRepuesto = Validations.IntInsert("Ingrese el código del nuevo repuesto", 0, int.MaxValue);
                    loop = !local.VerificarCodigoRepuesto(codigoRepuesto);

                    string nombreRepuesto = Validations.StringInsert("Ingrese el nombre del nuevo repuesto");
                    double precio = Validations.DoubleInsert("Ingrese el precio del nuevo repuesto", 0, double.MaxValue);
                    int stock = Validations.IntInsert("Ingrese la cantidad de stock del nuevo repuesto", 0, int.MaxValue);

                    Repuesto r = new Repuesto(codigoRepuesto, nombreRepuesto, precio, stock);

                    local.AgregarRepuesto(r);
                }
                catch (StockMenorCeroException)
                {
                    loop = true;
                }
                catch (PrecioMenorCeroException)
                {
                    loop = true;
                }
            } while (loop);
        }

        private static void QuitarRepuesto(VentaRepuestos local)
        {
            bool loop = true;
            do
            {
                int codigoRepuesto = Validations.IntInsert("Ingrese el codigo del repuesto a eliminar", 0, int.MaxValue);
                loop = !local.VerificarCodigoRepuesto(codigoRepuesto);

                local.QuitarRepuesto(codigoRepuesto);
            } while (loop);
        }

        private static void ModificarPrecio(VentaRepuestos local)
        {
            Validations.Duda("Es correcta esta forma de trabajar con el loop y la excepcion?");
            bool loop = true;
            do
            {
                try
                {
                    int codigoRepuesto = Validations.IntInsert("Ingrese el codigo del repuesto al que desea cambiarle el precio", 0, int.MaxValue);
                    loop = local.VerificarCodigoRepuesto(codigoRepuesto);

                    double precioNuevo = Validations.DoubleInsert("Ingrese el nuevo precio", 0, double.MaxValue);

                    local.ModificarPrecio(codigoRepuesto, precioNuevo);

                }
                catch (PrecioMenorCeroException)
                {
                    loop = true;
                }
                } while (loop);
             }

        private static void AgregarStock(VentaRepuestos local)
        {
            
            Validations.Duda("Es correcta esta forma de trabajar con el loop y la excepcion?");
            bool loop = true;
            
            do
            {
                try
                {

                    int codigoRepuesto = Validations.IntInsert("Ingrese el codigo del repuesto al que desea agregarle stock", 0, int.MaxValue);
                    int deltaStock = Validations.IntInsert("Ingrese el stock a agregar", 0, int.MaxValue);

                    loop = local.VerificarCodigoRepuesto(codigoRepuesto);
                    local.AgregarStock(codigoRepuesto, deltaStock);
                }

                catch (StockMenorCeroException)
                {
                    loop = true;
                }
            } while (loop);
        }

        private static void QuitarStock(VentaRepuestos local)
        {
            Validations.Duda("Es correcta esta forma de trabajar con el loop y la excepcion?");
            bool loop = true;
            do
            {
                try
                {
                    int codigoRepuesto = Validations.IntInsert("Ingrese el codigo del repuesto al que desea quitarle stock", 0, int.MaxValue);
                    loop = local.VerificarCodigoRepuesto(codigoRepuesto);

                    int deltaStock = Validations.IntInsert("Ingrese el stock a quitar", 0, int.MaxValue);

                    local.QuitarStock(codigoRepuesto, deltaStock);
                }
                catch (StockMenorCeroException)
                {
                    loop = true;
                }
            } while (loop);
            }

        private static void ListarRepPorCat (VentaRepuestos local)
        {
            bool loop = true;
            do
            {
                try
                {
                    int codigoCategoria = Validations.IntInsert("Ingrese el código de la categoría que desea ver", 0, int.MaxValue);
                    local.VerificarCodigoCategoria(codigoCategoria);


                    
                    foreach (Categoria c in local.ListaCategorias)
                    {
                        if (c.Codigo == codigoCategoria)
                        {
                            Console.WriteLine("Categoría: " + c.ToString());
                        }
                    }
                    foreach (Repuesto rc in local.TraerPorCategoria(codigoCategoria))
                    {
                        Console.WriteLine(rc.ToString());
                    }
                }
                catch (Exception)
                {
                    loop = true;
                }

            } while (loop);
        }

        private static void AgregarCategoría(VentaRepuestos local)
        {
            bool loop = true;
            do
            {
                int codigoCategoria= Validations.IntInsert("Ingrese el código de la nueva categoría", 0, int.MaxValue);
                loop = !local.VerificarCodigoCategoria(codigoCategoria);

                string nombreCategoría = Validations.StringInsert("Ingrese el nombre de la nueva categoría");
                
                Categoria c = new Categoria(codigoCategoria, nombreCategoría);

                local.AgregarCategoria(c);
            } while (loop);

        }

        private static void QuitarCategoría(VentaRepuestos local)
        {
            bool loop = true;
            do
            {
                int codigoCategoria = Validations.IntInsert("Ingrese el codigo de la categoría a eliminar", 0, int.MaxValue);
                loop = !local.VerificarCodigoCategoria(codigoCategoria);

                local.QuitarRepuesto(codigoCategoria);
            } while (loop);
        }
    }
}
