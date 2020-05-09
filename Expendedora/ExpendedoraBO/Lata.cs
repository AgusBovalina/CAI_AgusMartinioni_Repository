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

        public Lata(string codigo)
        {
            this.Codigo = codigo;
            
        }

        public string Codigo 
        { 
            get => codigo;
            private set
            {
                Validations.Comentario("Un if que valide que los codigos no sea distintos a las const?");
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

        

        public static List<Lata> ListaCodigos()
        {
            List<Lata> listaCodigos = new List<Lata>();
            Lata co1l = new Lata(co1);
            Lata co2l = new Lata(co2);
            Lata sp1l = new Lata(ll1);
            Lata sp2l = new Lata(ll2);
            Lata fa1l = new Lata(na1);
            Lata fa2l = new Lata(na2);
            listaCodigos.Add(co1l);
            listaCodigos.Add(co2l);
            listaCodigos.Add(sp1l);
            listaCodigos.Add(sp2l);
            listaCodigos.Add(fa1l);
            listaCodigos.Add(fa2l);
            return listaCodigos;
        }

        public static string ListarCodigos()
        {
            List<Lata> lista = Lata.ListaCodigos();
            string list = ""; ;
            foreach (Lata l in lista)
            {
                list += string.Format("+ {0} - {1} {2}\n", l.Codigo, l.Nombre, l.Sabor);
            }
            return list;
            
        }

        public static string GetCodigoCorrecto(string codigoLata)
        {
            string lataCodigoSeleccionado = "";

            foreach (Lata l in ListaCodigos())
            {
                if (codigoLata == l.Codigo)
                {
                    return lataCodigoSeleccionado = l.Codigo;
                }
            }

            return lataCodigoSeleccionado;
        }


    }
}
