﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleHelper;

namespace ExpendedoraBO
{
    public class Lata
    {
        private string codigo;
        private string nombre;
        private string sabor;
        private double precio;
        private double volumen;
        /*Eliminar:
         * private const string co1 = "CO1";
        private const string co2 = "CO2";
        private const string ll1 = "LL1";
        private const string ll2 = "LL2";
        private const string na1 = "NA1";
        private const string na2 = "NA2";
        private const string cocaCola = "Cola";
        private const string sprite = "Lima Limón";
        private const string fanta = "Naranja";
        private const string regular = "Regular";
        private const string zero = "Light";*/
        


        
        public Lata (string codigo, double precio, double volumen)
        {
            Variedad var = LataHelper.GetVariedad(codigo);
            this.Codigo = codigo;
            this.Nombre = var.Nombre;
            this.Sabor = var.Sabor;
            this.Precio = precio;
            this.Volumen = volumen;
            
        }


        public string Codigo 
        { 
            get => codigo;
            private set
            {
                
                codigo = value.ToUpper();
            } 
        }

        public string Nombre { get => nombre; private set => nombre = value; }
        public string Sabor { get => sabor; private set => sabor = value; }

        public double Precio
        {
            get => precio;
            private set
            {
                if (value >= 0)
                {
                    precio = value;
                } else
                {
                    throw new Exception("El precio debe ser mayor a cero");
                }
                
            }
        }
        public double Volumen
        {
            get => volumen;
            private set
            {
                if (value >= 0)
                {
                    volumen = value;
                }
                else
                {
                    throw new Exception("El volumen debe ser mayor a cero");
                }
            }
        }

        






        //MÉTODOS

        public double GetPrecioPorLitro()
        {
            const int litro = 1000;

            // volumen ----- precio
            // litro   ----- x

            return ((precio * litro) / volumen);
        }

        public override string ToString()
        {
            
            return string.Format("{0} - {1} - $ {2} / $/L {3}", Nombre, Sabor, Precio, GetPrecioPorLitro());

        }



        


    }
}
