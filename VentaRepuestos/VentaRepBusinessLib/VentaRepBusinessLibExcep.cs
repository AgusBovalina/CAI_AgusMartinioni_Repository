using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepBusinessLib
{
    public class StockMenorCeroException : Exception
    {
        public StockMenorCeroException() : base("El stock no puede ser menor a cero.")
        {

        }
    }

    public class PrecioMenorCeroException : Exception
    {
        public PrecioMenorCeroException() : base("El precio del producto no puede ser menor a cero.")
        {

        }
    }
}
