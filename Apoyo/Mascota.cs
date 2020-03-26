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
        private string nombreDueño;
        private string nroDueño;
        private double peso;
        private bool cirugiasAnteriores;

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
                return TelefonoDueño;
            }
            set
            {
                TelefonoDueño = value;
            }
        }
    }


}
