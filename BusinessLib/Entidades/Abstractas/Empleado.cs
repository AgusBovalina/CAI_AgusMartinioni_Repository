using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib
{
    abstract class Empleado : Persona
    {
        protected int legajo;
        //Cambie antiguedad por fecha de ingreso para calcular la antiguedad como int
        protected DateTime fechaIngreso;
        protected int antiguedad;
        protected Salario ultimoSalario;
        //public Empleado() : base() {}

        public Empleado(string nombre, string apellido, DateTime fechaNac, long dni, int legajo, DateTime fechaIngreso)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            this.legajo = legajo;
            this.fechaIngreso = fechaIngreso;

            if(DateTime.Today.Year - fechaNac.Year < 18)
            {
                //throw new MenorEdadException
            } else
            {
                FechaNac = fechaNac;
            }

        }

        public int Legajo { get => legajo; set => legajo = value; }

        public DateTime FechaIngreso { set => fechaIngreso = value; }
        public int Antiguedad { get => antiguedad; private set => antiguedad = (DateTime.Today.Year - fechaIngreso.Year); }
        
        internal Salario UltimoSalario { get => ultimoSalario; set => ultimoSalario = value; }
    }
}
