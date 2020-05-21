using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraBO
{
    public class Variedad
    {
        private string codigo;
        private string nombre;
        private string sabor;


        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Sabor { get => sabor; set => sabor = value; }

        public Variedad(string codigo, string nombre, string sabor)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.sabor = sabor;
        }

        



    }
}
