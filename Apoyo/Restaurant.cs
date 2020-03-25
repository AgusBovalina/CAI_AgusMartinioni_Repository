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
            set
            {
                delivery = value;
            }
        }

        //Metodos
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
            //ver como codear algo aca
        }

    }
}
