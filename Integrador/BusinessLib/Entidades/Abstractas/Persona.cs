using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected DateTime fechaNac;
        protected int edad;
        protected long dni;

        public Persona(string nombre, string apellido, DateTime fechaNac, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NombreCompleto { get => apellido; set => apellido = nombre + " " + apellido; }
        public DateTime FechaNac
        {
            get => fechaNac;
            set
            {
                if ((DateTime.Today.Year - fechaNac.Year) >= 120)
                { //throw new EdadException 
                }
                else { fechaNac = value; }
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            private set
            {
                //Resta solo los años y no tiene en cuenta los días y las fechas, por lo que es no correcto esto
                edad = (fechaNac.Year - DateTime.Today.Year);


            }
        }

        public long Dni { get => dni; set => dni = value; }


        public abstract string GetCredencial();

        /* public virtual string GetNombreCompleto()
         {
             return string.Format("{0}, {1}", this._apellido, this._nombre);
         }*/
    }
}
