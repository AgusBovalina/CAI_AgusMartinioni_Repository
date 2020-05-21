using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExpendedoraBO
{
    public class LataHelper
    {
        private List<Variedad> listaVariedad = new List<Variedad>();

        Variedad co1 = new Variedad("CO1", "Cola", "Regular");
        Variedad co2 = new Variedad("CO2", "Cola", "Light");
        Variedad ll1 = new Variedad("LL1", "Lima limón", "Regular");
        Variedad ll2 = new Variedad("LL2", "Lima Limón", "Light");
        Variedad fa1 = new Variedad("FA1", "Fanta", "Regular");
        Variedad fa2 = new Variedad("FA2", "Fanta", "Light");

        public List<Variedad> ListaVariedad { get => listaVariedad; private set => listaVariedad = value; }

        
        ListaVariedad.Add(co1);
        ListaVariedad.Add(co2);
        ListaVariedad.Add(ll1);
        ListaVariedad.Add(ll2);
        ListaVariedad.Add(fa1);
        ListaVariedad.Add(fa2);
               

       

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
    }
}
