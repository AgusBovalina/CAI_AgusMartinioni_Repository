using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraBO
{
    public static class XQA
    {

        public static List<Lata> CargarLatasHardcodeadas()
        {
            List<Lata> listaHC = new List<Lata>();
            Lata a = new Lata("CO1", 20, 250);
            Lata b = new Lata("CO2", 25, 250);
            Lata c = new Lata("FA1", 15, 250);
            Lata d = new Lata("LL1", 20, 400);
            Lata e = new Lata("FA1", 15, 250);

            listaHC.Add(a);
            listaHC.Add(b);
            listaHC.Add(c);
            listaHC.Add(d);
            listaHC.Add(e);

            return listaHC;
        }
    }
}
