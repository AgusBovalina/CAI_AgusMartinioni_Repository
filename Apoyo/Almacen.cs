using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum DiasDeSemana { Domingo=1, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado }

namespace Apoyo
{
    class Almacen
    {

        private string tipoProductos;
        private DiasDeSemana franco;
        private DateTime apertura;
        private DateTime cierre;
        private bool delivery;
        private string diasDeAtencion;

        List<DiasDeSemana> dias = new List<DiasDeSemana>();

        

        public string TipoProductos
        {
            get
            {
                return tipoProductos;
            }
            set
            {
                tipoProductos = value;
            }
        }

        public DiasDeSemana Franco
        {
            get
            {
                return franco;
            }

            set
            {
                franco = value;
            }

        }

        public string DiasDeAtencion
        {
            get
            {
                
                return diasDeAtencion;
            }
            set
            {
                foreach (DiasDeSemana dia in dias)
                {
                    if (dia != franco)
                    {
                        diasDeAtencion = diasDeAtencion + " " + dia;
                    }
                }
            }
            
        }

        public string HorarioDeAtencion
        {
            get
            {
                return "De " + apertura + "a" + cierre;
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

        public void RealizarDelivery()
        {
            if (Delivery)
            {

                Console.WriteLine("Realiza delivery");
            }
            else
            {
                Console.WriteLine("No realiza delivery");

            }
        }

        public void Abierto(DiasDeSemana dia, DateTime hora)
        {
            if (dia != franco && hora>apertura && hora < cierre)
            {
                Console.WriteLine("El local se encuentra atendiendo");
            }
            else
            {
                Console.WriteLine("El local se encuentra cerrado");
            }
        }




    }
}
