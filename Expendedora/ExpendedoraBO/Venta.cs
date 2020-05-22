using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraBO
{
    public class Venta
    {
        private Lata lataVendida;
        private double vuelto;

        public Lata LataVendida { get => lataVendida; set => lataVendida = value; }
        public double Vuelto { get => vuelto; set => vuelto = value; }

        public Venta (Lata lata, double vuelto)
        {
            this.lataVendida = lata;
            this.vuelto = vuelto;
        }

        public override string ToString()
        {
            return string.Format( "Su vuelto es: {0},\nUsted compró:\n{1}", Vuelto, LataVendida.ToString());
        }


    }
}
