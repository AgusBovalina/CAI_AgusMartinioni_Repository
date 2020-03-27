using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Apoyo
{
    enum palo  { Pica=1, Corazón, Trébol, Diamante, Oro, Espada, Copa, Basto, Comodin };
    
    
    
    class Carta
    {
        //Atributos
        private string mazo;
        private palo palo;
        private int valor;

        //Propiedades

        public string Mazo
        {
            get
            {
                return mazo;
            }

            private set 
            {
                if (palo > palo.Diamante && palo <palo.Comodin)
                {
                    mazo = "Español";
                }
                else
                {
                    mazo = "Poker";
                }
            }
        }
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

        public void Jugar()
        {
            if (palo != palo.Comodin)
            {

                Console.WriteLine("La carta a jugada es el " + valor + " de " + palo);
            }
        }


        

    }
}
