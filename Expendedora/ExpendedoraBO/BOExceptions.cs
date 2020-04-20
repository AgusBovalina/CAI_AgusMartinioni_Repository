using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleHelper;

namespace ExpendedoraBO
{
    public class CapacidadInsuficienteException : Exception
    {
        public CapacidadInsuficienteException() : base("")
        {

        }
    }
    public class DineroInsuficienteException : Exception
    {
        public DineroInsuficienteException() : base("Dinero insuficiente para completar la compra.")
        {

        }
    }
    public class SinStockException : Exception
    {
        public SinStockException() : base ("Stock insuficiente del producto seleccionado.")
        {

        }
    }
    public class CodigoInvalidoException : Exception
    {
        public CodigoInvalidoException() : base("El producto seleccionado no existe.")
        {

        }
    }







}

