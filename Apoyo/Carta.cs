using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Apoyo
{
    enum palo  { Pica, Corazón, Trébol, Diamante};
    
    
    
    class Carta
    {
        //Atributos
        private palo palo;
        private int valor;

        //Propiedades
        public palo Palo
        {
            get 
            {
                return palo;
            }

            set
            {
                palo = value;
            }

        }

        public int Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }


        }

        //Métodos
        

    }
}
