using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoyo
{
    public class Restaurant
    {
        private string nombre;
        private int capacidad;
        private string tipoComida;
        private bool delivery;
        private int capacidadActual;


        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
        public int Capacidad
        {
            get
            {
                return capacidad;
            }

            set
            {
                capacidad = value;
            }
        }

        public string TipoComida
        {
            get
            {
                return tipoComida;
            }
            set
            {
                tipoComida = value;
            }
        }

        public bool Delivery
        {
            get
            {
                return delivery;
            }
            set
            {
                delivery = value;
            }
        }

        public int CapacidadActual
        {
            get
            {
                return capacidadActual;
            }
            set
            {
                capacidadActual= value;
            }
        }

        
        public void RealizarDelivery()
        {
            if (delivery)
            {

                Console.WriteLine("Realiza delivery");
            }
            else
            {
                Console.WriteLine("No realiza delivery");

            }
        }

        public void TomarReserva (int cantComensales)
        {
            if (cantComensales + capacidadActual > capacidad)
            { 
                
                Console.WriteLine("No se aceptan más reservas");
            } else
            {
                Console.WriteLine("Su reserva fue tomada");
                capacidadActual += cantComensales;

            }
        }



    }
}
