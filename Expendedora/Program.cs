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
            bool loop = true;
            string menu = "0) Encender la máquina expendedora " +
                "\n1) Listar Latas Disponibles " +
                "\n2) Ingresar Lata" +
                "\n3) Extraer Lata " +
                "\n4) Mostrar Balance " +
                "\n5) Mostrar Stock y descripción de los productos " +
                "\n6) Salir";

            Expendedora exp1 = new Expendedora("Coca Cola Company", 100, 0);

            Console.WriteLine("Expendedora " + exp1.Proveedor);

            

            do
            {
                Console.WriteLine(menu);

                try
                {
                    string opcion = Validations.StringInsert("Ingrese la opción elegida");

                    switch (opcion)
                    {
                        case "0":
                            Program.EstaEncendida(exp1);
                            break;
                        case "1":
                            Lata.ListarCodigos();
                            break;

                        case "2":
                            if (Program.EstaEncendida(exp1))
                            {
                                Lata.ListarCodigos();
                                Program.IngresarLata(exp1);
                            }
                            else
                            {
                                Console.WriteLine("La máquina expendedora se encuentra apagada. Encender");
                            }
                            break;

                        case "3":
                            if (Program.EstaEncendida(exp1) && !exp1.EstaVacia())
                            {
                                Lata.ListarCodigos();
                                Program.ExtraerLata(exp1);
                            }
                            else if (exp1.EstaVacia())
                            {
                                throw new CapacidadInsuficienteException();
                            }
                            else
                            {
                                Console.WriteLine("La máquina expendedora se encuentra apagada. Encender");
                            }
                            
                            break;

                        case "4":
                            if (Program.EstaEncendida(exp1))
                            {
                                Program.ObtenerBalance(exp1);
                            }
                            else
                            {
                                Console.WriteLine("La máquina expendedora se encuentra apagada. Encender");
                            }
                            break;

                        case "5":
                            if (Program.EstaEncendida(exp1) && !exp1.EstaVacia())
                            {
                                
                                Program.MostrarStock(exp1);
                            }
                            else if (exp1.EstaVacia())
                            {
                                throw new CapacidadInsuficienteException();
                            }
                            else
                            {
                                Console.WriteLine("La máquina expendedora se encuentra apagada. Encender");
                            }
                            break;

                        case "6":

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

        static bool EstaEncendida(Expendedora expendedora)
        {
            bool encendida;
            expendedora.EncenderMaquina();
            Console.WriteLine("Encendido");

            return encendida = true;
            
        }
        
        static void IngresarLata (Expendedora expendedora)
        {
            try
            {
                
                string codigo = Validations.StringInsert("Ingrese el codigo del producto").ToUpper();
                if (Lata.GetCodigoCorrecto(codigo) != "")
                {
                   
                    double precio = Validations.DoubleInsert("Ingrese el precio del producto", 0, 10000);
                    double volumen = Validations.DoubleInsert("Ingrese el volumen del producto", 0, 10000);
                    Lata lata = new Lata(codigo, precio, volumen);
                    expendedora.AgregarLata(lata);
                }
                else
                {
                    Console.WriteLine("El producto ingresado no existe");
                    Program.IngresarLata(expendedora);
                }
            }
            catch (CodigoInvalidoException e)
            {
                Console.WriteLine(e.Message + "Ingrese el producto nuevamente.");
                Program.IngresarLata(expendedora);
            }
            catch (CapacidadInsuficienteException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        static void ExtraerLata(Expendedora expendedora)
        {
            try
            {


                string codigo = Validations.StringInsert("Ingrese el codigo del producto");
                if (Lata.GetCodigoCorrecto(codigo) != "" && expendedora.GetLataSeleccionada(codigo) != null)
                {
                    double pago = Validations.DoubleInsert("Ingrese el dinero", 0, double.MaxValue);
                    expendedora.ExtraerLata(codigo, pago);
                }
                else if (expendedora.EstaVacia())
                {
                    Validations.Duda("Esto es correcto en program?");
                    throw new CapacidadInsuficienteException();

                }
            
        }
            catch (CodigoInvalidoException e)
            {
                Console.WriteLine(e.Message + "Ingrese el codigo del producto nuevamente.");
                Program.ExtraerLata(expendedora);
            }
            catch (DineroInsuficienteException e)
            {
                Console.WriteLine(e.Message + "Comience nuevamente");
                //Program.ExtraerLata(expendedora); Por si no posee el dinero.
            }
            catch(SinStockException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static void ObtenerBalance(Expendedora expendedora)
        {
            //expendedora.EncenderMaquina();
            Console.WriteLine(string.Format("El dinero disponible en la expendedora {0} es $ {1}. Hay {2} latas disponibles en stock", expendedora, expendedora.GetBalance(), expendedora.Latas.Count));
        }
        static void MostrarStock(Expendedora expendedora)
        {
            
            Console.WriteLine(string.Format("El stock disponible en la expendedora {0} es {1}.", expendedora, expendedora.GetCapacidadRestante()));
            foreach (Lata l in expendedora.Latas)
            {
                Console.WriteLine(l.ToString());
            }
        }


    }
}
