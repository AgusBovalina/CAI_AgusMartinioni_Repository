using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepBusinessLib
{
   public class Repuesto
    {
        private int codigo;
        private string nombre;
        private double precio;
        private int stock;
        private Categoria categoria;

        public Repuesto(int codigo, string nombre, double precio, int stock)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;

            //this.categoria = objeto puntual, teniendo que haber recorrido la lista de categorias
            //Inicia una nueva categoria cada vez que se agrega un repuesto??
            //this.categoria = new Categoria(codigoCat, nombreCat);pasar objeto de categoria ya armado 
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }
    

        //METODOS

        public virtual string ToString()
        {
            throw new NotImplementedException();
        }

        
    
    
    
    
    
    }
}
