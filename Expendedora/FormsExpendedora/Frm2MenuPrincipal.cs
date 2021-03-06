﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpendedoraBO;

namespace ExpendedoraForms
{
    public partial class Frm2MenuPrincipal : Form
    {
        private Expendedora expendedora;
        

        public Frm2MenuPrincipal(Expendedora expendedora, Form formPropietario)
        {
            this.Owner = formPropietario;
            this.expendedora = expendedora;
            InitializeComponent();
        }
       

        private void Frm2MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.label1.Text = expendedora.Proveedor;
        }

        private void BtnExtraerLata_Click(object sender, EventArgs e)
        {
            Frm3ExtraerLata eL = new Frm3ExtraerLata(expendedora, this);
            eL.Owner = this;
            eL.Show();
            this.Hide();
            
        }

        private void BtnIngresarLata_Click(object sender, EventArgs e)
        {
            Frm3IngresarLata iL = new Frm3IngresarLata(expendedora, this);
            iL.Owner = this;
            iL.Show();
            this.Hide();
        }

        private void BtnMostrarStock_Click(object sender, EventArgs e)
        {
            Frm3MostrarStock mS = new Frm3MostrarStock(expendedora, this);
            mS.Owner = this;
            mS.Show();
            this.Hide();
        }

        private void BtnBalance_Click(object sender, EventArgs e)
        {
            Frm3ObtenerBalance b = new Frm3ObtenerBalance(expendedora, this);
            b.Owner = this;
            b.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }


        private void Frm2MenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
            {
                CloseWindow();
            }
        }

            private void Frm2MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseWindow();
        }

        
                    
            
        

        private void CloseWindow()
        {
            this.Owner.Dispose();
            this.Dispose();
        }
    }
}
