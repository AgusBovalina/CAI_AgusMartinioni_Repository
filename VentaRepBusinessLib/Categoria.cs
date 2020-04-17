using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepBusinessLib
{
    public class Categoria
    {
        private int codigo;
        private string nombre;
        

        public Categoria (int codigo, string nombre)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return string.Format("Nombre: {0} - Código: {1}\n", Nombre, Codigo);
        }
    }
}
