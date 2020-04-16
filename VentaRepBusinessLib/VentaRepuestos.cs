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
           this.ListaProductos.Add(repuesto);
        }

        public void QuitarRepuesto (int codigoRepuesto)
        {
            
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
            
            //validar que el stock no sea menor a cero
            
            foreach (Repuesto r in ListaProductos)
            {
                if (r.Codigo == codigoRepuesto)
                {
                    r.Stock -= deltaStock;
                }
            }
        }

        
        public List<Repuesto> TraerPorCategoria(int codigoCategoria)
        {
            List<Repuesto> listaFiltradaPorCat = new List<Repuesto>();
            foreach (Repuesto r in ListaProductos)
            {
                if (r.Categoria.Codigo == codigoCategoria)
                {
                    listaFiltradaPorCat.Add(r);
                }
            }
            return listaFiltradaPorCat;

        }

        public bool VerificarCodigoRepuesto(int codigoRepuesto)
        {
            
            foreach (Repuesto r in ListaProductos)
            {
                if (r.Codigo == codigoRepuesto)
                {
                    return false;
                }

            }
            throw new Exception("No existe un producto con este codigo");
        }

        public bool VerificarCodigoCategoria(int codigoCategoria)
        {

            foreach (Categoria c in ListaCategorias)
            {
                if (c.Codigo == codigoCategoria)
                {
                    return false;
                }

            }
            throw new Exception("No existe la categoría seleccionada");
        }
    }
}
