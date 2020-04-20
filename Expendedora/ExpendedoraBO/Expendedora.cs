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
        private int capacidad;
        private double dinero;
        private bool encendida;

        public Expendedora(string proveedor, int capacidad, double dinero)
        {
            this.Latas = new List<Lata>();
            this.Proveedor = proveedor;
            this.Capacidad = capacidad;
            this.Dinero += dinero;
            this.Encendida = false;

        }

        public List<Lata> Latas { get => latas; set => latas = value; }
        public string Proveedor { get => proveedor; private set => proveedor = value; }
        public int Capacidad
        {
            get => capacidad;
            private set
            {
                if (value >= 0)
                {
                    capacidad = value;
                }
                else
                {
                    throw new Exception("El precio debe ser mayor a cero");
                }

            }
        }
       
        public double Dinero { get => dinero; set => dinero = value; }
        public bool Encendida { get => encendida; private set => encendida = value; }
        
        //MÉTODOS

        public void AgregarLata(Lata lata)
        {
            this.GetLataSeleccionada(lata.Codigo);

            if (this.GetLataSeleccionada(lata.Codigo) == null)
            {
                latas.Add(lata);
            }
            else
            {
                throw new Exception("El producto ingresado ya existe.");
            }
            
        }

        public Lata ExtraerLata(string codigo, double pago)
        {
            Lata l = this.GetLataSeleccionada(codigo);
            Dinero += l.Precio;
            Capacidad--;

            Validations.Duda("Para que necesito el precio si ya tengo la lata seleccionada");
            return l;
            
        }

        public string GetBalance()
        {
            return string.Format("Dinero acumulado: {0}", Dinero);
        }

        public int GetCapacidadRestante()
        {
            Validations.Comentario("Capacidad total, sin diferenciar sabores");
            return Latas.Count();
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
            if (Capacidad == 0)
            {
                return vacia = true;
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
