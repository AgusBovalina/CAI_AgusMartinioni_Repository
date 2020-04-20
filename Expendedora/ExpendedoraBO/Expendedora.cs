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
        private string proveedor;
        private int capacidadMax;
        private double dinero;
        private bool encendida;
        private const int cantCapacidad = 100;
        

        public Expendedora(string proveedor, int capacidad, double dinero)
        {
            this.Latas = new List<Lata>();
            this.Proveedor = proveedor;
            this.CapacidadMax = capacidad;
            this.Dinero += dinero;
            this.Encendida = false;

        }
        

        public List<Lata> Latas { get => latas; set => latas = value; }
       
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

        public Lata ExtraerLata(string codigo, double pago)
        {
            Lata l = this.GetLataSeleccionada(codigo);

            if (l.Precio <= pago)
            {
                Dinero += l.Precio;
                latas.Remove(l);
            } else
            {
                l = null;
            }
             
            if(l == null)
            {
                throw new DineroInsuficienteException(); 
            }
            return l;
            
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
            

            Validations.Duda("La excepción la tiene que devolver el método??. Entiendo que como devuelve int, no debería devolver la excepción pero como se hace sino");
            if (vacia)
            {
                throw new CapacidadInsuficienteException();
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

        
    }
}
