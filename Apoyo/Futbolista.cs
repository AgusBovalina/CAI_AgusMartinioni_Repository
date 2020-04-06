using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoyo
{
    class Futbolista
    {
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private int golesConvertidos;
        private double estatura;
        

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

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string NombreCompleto
        {
            get
            {
                return nombre + " " + apellido;
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

        public int GolesConvertidos
        {
            get
            {
                return golesConvertidos;
            }
            set
            {
                // Para ir sumando a medida que mete goles
                golesConvertidos = value;
            }
        }

        public double Estatura
        {
            get
            {
                return estatura;
            }

            set
            {
                estatura = value;
            }
        }



        public void Gol(int cantGoles)
        {
            Console.WriteLine("El jugador hizo un gol");

            
            golesConvertidos +=  cantGoles;
        }

        public void Jugar()
        {
            if (Edad > 45)
            {
                Console.WriteLine("El jugador no continua ejerciendo");

            } else
            {
                Console.WriteLine("El jugador está en condiciones de continuar jugando");
            }
        }

        
    }


}
