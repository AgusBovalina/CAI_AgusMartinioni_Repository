using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleHelper;

namespace ExpendedoraBO
{
    public class Lata
    {
        private string codigo;
        private string nombre;
        private string sabor;
        private double precio;
        private double volumen;

        public Lata (string codigo, string nombre, string sabor, double precio, double volumen)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Sabor = sabor;
            this.Precio = precio;
            this.Volumen = volumen;
        }

        public string Codigo { get => codigo; private set => codigo = value; }
        public string Nombre { get => nombre; private set => nombre = value; }
        public string Sabor { get => sabor; private set => sabor = value; }
        public double Precio
        {
            get => precio;
            private set
            {
                if (value >= 0)
                {
                    precio = value;
                } else
                {
                    throw new Exception("El precio debe ser mayor a cero");
                }
                
            }
        }
        public double Volumen
        {
            get => volumen;
            private set
            {
                if (value >= 0)
                {
                    volumen = value;
                }
                else
                {
                    throw new Exception("El volumen debe ser mayor a cero");
                }
            }
        }

        //MÉTODOS

        public double GetPrecioPorLitro()
        {
            const int litro = 1000;

            // volumen ----- precio
            // litro   ----- x

            return ((precio * litro) / volumen);
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0} - Código: {1}\n" +
                "{2} - $ {3} - {4}ml", nombre, codigo, sabor, precio, volumen);

        }
    }
}
