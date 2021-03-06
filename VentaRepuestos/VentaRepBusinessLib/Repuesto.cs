﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleHelper;

namespace VentaRepBusinessLib
{
   public class Repuesto
    {
        private int codigo;
        private string nombre;
        private double precio;
        private int stock;
        private Categoria categoria;

        public Repuesto(int codigo, string nombre, double precio, int stock, Categoria cat)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
            this.categoria = cat;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio
        {
            get => precio;
            set
            {
                if (value >= 0)
                {
                    precio = value;
                }
                else
                {
                    throw new PrecioMenorCeroException();
                }

            }
        }
        public int Stock 
        {
            get => codigo;
            set 
            {
                if (value >= 0)
                {
                    stock = value;
                }
                else
                {
                    throw new StockMenorCeroException();
                }
            }
        }
        public Categoria Categoria { get => categoria; set => categoria = value; }
    

        //METODOS

        public override string ToString()
        {
           return string.Format("Nombre: {0} - Código: {1}\n" +
                            "Cantidad en stock: {2} - Precio: {3:C2}\n", Nombre, Codigo, Stock, Precio);
        }

        
    
    
    
    
    
    }
}
