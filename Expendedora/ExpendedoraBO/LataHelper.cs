using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExpendedoraBO
{
    public class LataHelper
    {
        private static List<Variedad> listaVariedad;


        public static List<Variedad> ListaVariedad { get => listaVariedad; set => listaVariedad = value; }

        static Variedad co1 = new Variedad("CO1", "Cola", "Regular");
        static Variedad co2 = new Variedad("CO2", "Cola", "Light");
        static Variedad ll1 = new Variedad("LL1", "Lima limón", "Regular");
        static Variedad ll2 = new Variedad("LL2", "Lima Limón", "Light");
        static Variedad fa1 = new Variedad("FA1", "Naranja", "Regular");
        static Variedad fa2 = new Variedad("FA2", "Naranja", "Light");




        public static List<Variedad> AgregarList()
        {
            listaVariedad = new List<Variedad>();
            ListaVariedad.Add(co1);
            ListaVariedad.Add(co2);
            ListaVariedad.Add(ll1);
            ListaVariedad.Add(ll2);
            ListaVariedad.Add(fa1);
            ListaVariedad.Add(fa2);

            return ListaVariedad;

        }


        public static List<string> ListaCodigos()
        {
            List<string> listaCodigos = new List<string>()
            {
                co1.Codigo.ToUpper(),
                co2.Codigo.ToUpper(),
                ll1.Codigo.ToUpper(),
                ll2.Codigo.ToUpper(),
                fa1.Codigo.ToUpper(),
                fa2.Codigo.ToUpper()
            };
           

            return listaCodigos;
        }

        

        public static Variedad GetVariedad(string codigo)
        {
            foreach (Variedad v in ListaVariedad)
            {
                if (v.Codigo == codigo)
                {
                    return v;
                    
                }
                
            }
            return null;
        }

        //ver. 
        public static string ListarVariedades()
        {
            
            string list = "";
            foreach (Variedad v in ListaVariedad)
            {
                list += v.ToString();
            }
            return list;

        }



        
        public static string GetCodigoCorrecto(string codigoLata)
        {
            string lataCodigoSeleccionado = "";

            foreach (Variedad v in ListaVariedad)
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
