using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleHelper;

namespace ExpendedoraBO
{
    public class Expendedora
    {
        private List<Lata> latas;
        private List<Venta> ventas;
        private string proveedor;
        private int capacidadMax;
        private double dinero;
        private double saldoInicial;
        private bool encendida;
        private const int cantCapacidad = 100;

        public List<Lata> CargarLatasHardcodeadas()
        {
            List<Lata> listaHC = new List<Lata>();
            Lata a = new Lata("CO1", 20, 250);
            Lata b = new Lata("CO2", 25, 250);
            Lata c = new Lata("FA1", 15, 250);
            Lata d = new Lata("LL1", 20, 400);
            Lata e = new Lata("FA1", 15, 250);

            listaHC.Add(a);
            listaHC.Add(b);
            listaHC.Add(c);
            listaHC.Add(d);
            listaHC.Add(e);

            return listaHC;
        }


        public Expendedora(string proveedor, int capacidad, double dinero)
        {

            this.Latas = new List<Lata>();
            this.Ventas = new List<Venta>();
            this.Proveedor = proveedor;
            this.CapacidadMax = capacidad;
            this.Dinero = dinero;
            this.SaldoInicial = dinero;
            this.Encendida = false;
            LataHelper.AgregarList();

            //Para agregar latasHC
            Latas.AddRange(CargarLatasHardcodeadas());
        }


        public List<Lata> Latas { get => latas; set => latas = value; }

        public List<Venta> Ventas { get => ventas; set => ventas = value; }

        public string Proveedor { get => proveedor; private set => proveedor = value; }
        public int CapacidadMax
        {
            get => capacidadMax;
            private set
            {
                if (capacidadMax >= 0 && capacidadMax <= cantCapacidad)
                {
                    capacidadMax = value;
                }
                else if (capacidadMax <= cantCapacidad)
                {
                    throw new Exception("La capacidad no puede ser menor a cero");
                }

            }
        }

        public double Dinero
        {
            get => dinero;
            set
            {
                if (capacidadMax >= 0)
                {
                    dinero = value;
                }
                else
                {
                    throw new Exception("La monto no puede ser menor a cero");
                }
            }
        }
        public double SaldoInicial
        {
            get => saldoInicial; private set
            {
                if (dinero >= 0)
                {
                    saldoInicial = value;
                }
                else
                {
                    throw new Exception("La monto no puede ser menor a cero");
                }
            }
        }

        public double Ganancia { get => dinero - saldoInicial; }
        public bool Encendida { get => encendida; private set => encendida = value; }


        //MÉTODOS

        
        public void AgregarLata(Lata lata)
        {


            if (LataHelper.GetCodigoCorrecto(lata.Codigo) != "" && this.GetLataSeleccionada(lata.Codigo, lata.Volumen, lata.Precio) == null)
            {
                if (latas.Count < CapacidadMax)
                {
                    latas.Add(lata);
                } else
                {
                    throw new CapacidadInsuficienteException();
                }



            }
            else if (LataHelper.GetCodigoCorrecto(lata.Codigo) != "")
            {
                throw new CodigoInvalidoException();

            }
        }
                          

        public Venta ExtraerLata(Lata lata, double pago)
        {
            Lata l = GetLataSeleccionada(lata.Codigo, lata.Volumen, lata.Precio);


            if (l.Precio <= pago)
            {
                Dinero += l.Precio;
                latas.Remove(l);
            }
            else
            {
                throw new DineroInsuficienteException();
            }

            if (l == null)
            {
                throw new SinStockException();
            }

            Venta nuevaVenta = new Venta(l, CalcVuelto(l.Precio, pago));

            Ventas.Add(nuevaVenta);
            return nuevaVenta;

        }

        public string GetBalance()
        {
            return string.Format("Dinero acumulado: {0}", Dinero);
        }

        public int GetStock(Lata lata, List<Lata> listaLata)
        {
            int stock = 0;
            foreach (Lata l in listaLata)
            {
                if (lata.Codigo == l.Codigo && lata.Volumen == l.Volumen && lata.Precio == l.Precio)
                {
                    stock += 1;
                }
            }

            return stock;
        }
        public int GetCapacidadRestante()
        {
            int capacidadRestante = CapacidadMax - latas.Count;
            if (capacidadRestante >= 0)
            {
                return capacidadRestante;
            }
            else
            {
                return -1;
            }
        }

        public void EncenderMaquina()
        {
            if (!Encendida)
            {
                Encendida = true;
            }
        }

        public bool EstaVacia()
        {
            bool vacia = false;
            if (GetCapacidadRestante() < 0)
            {
                vacia = true;
            }

            return vacia;
        }


        public Lata GetLataSeleccionada(string codigoLata, double volumenLata, double precioLata)
        {
            Lata lataSeleccionada = null;

            foreach (Lata l in Latas)
            {
                if (codigoLata == l.Codigo && volumenLata == l.Volumen && precioLata == l.Precio)
                {
                    return lataSeleccionada = l;
                }

            }

            return lataSeleccionada;
        }

        public double CalcVuelto(double precio, double pago)
        {
            return pago - precio;
        }
    }

}
