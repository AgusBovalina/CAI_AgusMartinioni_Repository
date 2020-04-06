using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoyo
{
    class Mascota
    {
        private string nombre;
        private string especie;
        private DateTime fechaDeNacimiento;
        private bool cirugiasAnteriores;
        private bool castrado;
        private string nombreDueño;
        private string telefonoDueño;

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

        public string Especie
        {
            get
            {
                return especie;
            }
            set
            {
                especie = value;
            }
        }

        public DateTime FechaDeNacimiento
        {
            get
            {
                return fechaDeNacimiento;
            }

            set
            {
                //como hacer para ingresar dia, mes, año por separado
                fechaDeNacimiento = value;
            }
        }

        public int Edad
        {
            get
            {
                DateTime today = DateTime.Today;

                return Convert.ToInt32(today - fechaDeNacimiento);
            }

        }

        public bool Cirugias
        {
            get
            {
                return cirugiasAnteriores;
            }
            set
            {
                cirugiasAnteriores = value;
            }
        }

        public bool Castrado
        {
            get
            {
                return castrado;
            }
            set
            {
                castrado = value;
            }
        }
        public string NombreDueño
        {
            get
            {
                return nombreDueño;
            }
            set
            {
                nombreDueño = value;
            }
        }

        public string TelefonoDueño
        {
            get
            {
                return telefonoDueño;
            }
            set
            {
                telefonoDueño = value;
            }
        }

        public void Comer()
        {
            Console.WriteLine("La mascota come correctamente");
        }

        public void Riesgo(bool llueve)
        {
           
            if (Edad > 10 && especie == "perro")
            {
                Console.WriteLine("No se recomienda cirugía");        
            } 
        }


    }


}
