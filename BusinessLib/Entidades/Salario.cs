using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib
{
    class Salario
    {
        private double bruto;
        private double descuentos;
        private DateTime fecha;
        private string codigoTransferencia;

        public Salario (double bruto, double descuentos, DateTime fecha, string codigoTransferencia)
        {
            this.bruto = bruto;
            this.descuentos = descuentos;
            this.fecha = fecha;
            this.codigoTransferencia = codigoTransferencia;
        }

        public double Bruto { get => bruto; set => bruto = value; }
        public double Descuentos { get => descuentos; set => descuentos = value; }
        public string CodigoTransferencia { get => codigoTransferencia; set => codigoTransferencia = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        

        
        public double GetSalarioNeto(int legajo, string DudaComoIdentificarReciboParticular)
        {

            return bruto-descuentos;
        }
    }
}
