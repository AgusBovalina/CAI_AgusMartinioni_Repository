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
        private bool encendida;
        private const int cantCapacidad = 100;
        

        public Expendedora(string proveedor, int capacidad, double dinero)
        {
            this.Latas = new List<Lata>();
            this.Ventas = new List<Venta>();
            this.Proveedor = proveedor;
            this.CapacidadMax = capacidad;
            this.Dinero += dinero;
            this.Encendida = false;

        }
        

        public List<Lata> Latas { get => latas; set => latas = value; }

        public List<Venta> Ventas { get => ventas; set => ventas = value; }

        public string Proveedor { get => proveedor; private set => proveedor = value; }
        public int CapacidadMax
        {
            get => capacidadMax;
            private set 
            {
                if (capacidadMax >= 0)
                {
                    capacidadMax = value;
                }
                else
                {
                    throw new Exception("La capacidad no puede ser menor a cero");
                }

            }
        }
       
        public double Dinero { get => dinero; set => dinero = value; }
        public bool Encendida { get => encendida; private set => encendida = value; }
        

        //MÉTODOS

        public void AgregarLata(Lata lata)
        {
            
            if(Lata.GetCodigoCorrecto(lata.Codigo) != "" && this.GetLataSeleccionada(lata.Codigo) == null)
            {
                
                latas.Add(lata);
                
                
            } else if (Lata.GetCodigoCorrecto(lata.Codigo) != "")
            {
                throw new CodigoInvalidoException();

            } else if (this.GetLataSeleccionada(lata.Codigo) != null)
            {
                throw new Exception("El producto ingresado ya existe");
            }
           
            
        }

        public Venta ExtraerLata(string codigo, double pago)
        {
            Lata l = this.GetLataSeleccionada(codigo);
                  

            if (l.Precio <= pago)
            {
                Dinero += l.Precio;
                latas.Remove(l);
            } else
            {
                throw new DineroInsuficienteException();
            }

            if(l == null)
            {
                throw new SinStockException();
            }

            Venta nuevaVenta = new Venta(l, CalcVuelto(l.Precio, pago));

            return nuevaVenta;
            
        }

        public string GetBalance()
        {
            return string.Format("Dinero acumulado: {0}", Dinero);
        }

        public int GetCapacidadRestante()
        {
            int capacidadRestante = CapacidadMax - latas.Count;
            if (capacidadRestante >= 0)
            {
                return capacidadRestante;
            } else
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


        public Lata GetLataSeleccionada(string codigoLata)
        {
            Lata lataSeleccionada = null;

            foreach (Lata l in Latas)
            {
                if (codigoLata == l.Codigo)
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
