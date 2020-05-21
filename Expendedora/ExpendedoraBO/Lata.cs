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
        private const string co1 = "CO1";
        private const string co2 = "CO2";
        private const string ll1 = "LL1";
        private const string ll2 = "LL2";
        private const string na1 = "NA1";
        private const string na2 = "NA2";
        private const string cocaCola = "Cola";
        private const string sprite = "Lima Limón";
        private const string fanta = "Naranja";
        private const string regular = "Regular";
        private const string zero = "Light";
        
        



        
        public Lata (string codigo,  double precio, double volumen)
        {
            this.Codigo = codigo;
            this.Precio = precio;
            this.Volumen = volumen;
        }


        public string Codigo 
        { 
            get => codigo;
            private set
            {
                // 1. Un if que valide que los codigos no sea distintos a las const?;
                codigo = value.ToUpper();
            } 
        }
        public string Nombre 
        { 
            get => nombre;
            private set
            {
                switch (Codigo)
                {
                    case co1:
                        nombre = cocaCola;
                        break;
                    case co2:
                        nombre = cocaCola;
                        break;
                    case ll1:
                        nombre = sprite;
                        break;
                    case ll2:
                        nombre = sprite;
                        break;
                    case na1:
                        nombre = fanta;
                        break;
                    case na2:
                        nombre = fanta;
                        break;
                }
            }
        }
        public string Sabor
        {
            get => sabor;
            private set
            {
                switch (Codigo)
                {
                    case co1:
                        sabor = regular;
                        break;
                    case co2:
                        sabor = zero;
                        break;
                    case ll1:
                        sabor = regular;
                        break;
                    case ll2:
                        sabor = zero;
                        break;
                    case na1:
                        sabor = regular;
                        break;
                    case na2:
                        sabor = zero;
                        break;
                }
            }
        }
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
            
            return string.Format("{0} - {1} - $ {2} / $/L {3}", Nombre, Sabor, Precio, GetPrecioPorLitro());

        }



        //ver. Debería trabajar con listaVariedad
        public static string ListarCodigos()
        {
            
            string list = "";
            foreach (Variedad v in ListaVariedad())
            {
                list += string.Format("+ {0} - {1} {2}\n", v.Codigo, v.Nombre, v.Sabor);
            }
            return list;
            
        }

        //ver Este metodo debería ir en latahelper?
        public static string GetCodigoCorrecto(string codigoLata)
        {
            string lataCodigoSeleccionado = "";

            foreach (Variedad v in ListaVariedad())
            {
                if (codigoLata == v.Codigo)
                {
                    return lataCodigoSeleccionado = v.Codigo;
                }
            }

            return lataCodigoSeleccionado;
        }


    }
}
