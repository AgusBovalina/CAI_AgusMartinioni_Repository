using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepBusinessLib
{
    public class VentaRepuestos
    {
        private List<Repuesto> listaProductos; 
        private List<Categoria> listaCategorias;
        private string nombreComercio;
        private string direccion;

        public VentaRepuestos(string nombreComercio, string direccion)
        {
            this.listaProductos = new List<Repuesto>();
            this.nombreComercio = nombreComercio;
            this.direccion = direccion;
        }

        public List<Repuesto> ListaProductos { get => listaProductos; set => listaProductos = value; }

        public List<Categoria> ListaCategorias { get => listaCategorias; set => listaCategorias = value; }
        public string NombreComercio { get => nombreComercio; set => nombreComercio = value; }

        public string Direccion { get => direccion; set => direccion = value; }


        //METODOS

        public void AgregarRepuesto (Repuesto repuesto)
        {
            if(this.ListaProductos.SingleOrDefault(x => x.Codigo == repuesto.Codigo) != null)
            {
                throw new Exception("El código de repuesto ya existe");
            }
            else
            {
                this.ListaProductos.Add(repuesto);
            }
            
            
        }

        public void QuitarRepuesto (int codigoRepuesto)
        {
            //ver como validar primero si el codigo no exite, que devuelva "el codigo ingresado no existe o ya fue eliminado anteriormente"
            foreach (Repuesto r in ListaProductos)
            {
                if(r.Codigo == codigoRepuesto)
                {
                    ListaProductos.Remove(r);
                }
            }
        }

        public void ModificarPrecio(int codigoRepuesto, double precioNuevo)
        {
            //validar que exista el repuesto
            foreach (Repuesto r in ListaProductos)
            {
                if (r.Codigo == codigoRepuesto)
                {
                    r.Precio = precioNuevo;
                }
            }
        }

        public void AgregarStock(int codigoRepuesto, int deltaStock)
        {
            //validar que exista el repuesto
            foreach (Repuesto r in ListaProductos)
            {
                if (r.Codigo == codigoRepuesto)
                {
                    r.Stock += deltaStock;
                }
            }
        }

        public void QuitarStock(int codigoRepuesto, int deltaStock)
        {
            //validar que exista el repuesto
            //validar que el stock no sea menor a cero
            
            foreach (Repuesto r in ListaProductos)
            {
                if (r.Codigo == codigoRepuesto)
                {
                    r.Stock -= deltaStock;
                }
            }
        }

        //Como hacer para que devuelva lista filtrada, creo una nueva lista publica dentro del método?
        public List<Repuesto> TraerPorCategoria(int codigoCategoria)
        {
            foreach (Repuesto r in ListaProductos)
            {
                if (r.Categoria.Codigo == codigoCategoria)
                {
                    throw new NotImplementedException();
                }
            }


        }





    }
}
