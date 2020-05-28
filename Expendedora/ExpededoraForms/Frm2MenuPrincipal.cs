using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpendedoraBO;

namespace ExpededoraForms
{
    public partial class Frm2MenuPrincipal : Form
    {
        private Expendedora expendedora;
        private string proveedor;

        public Frm2MenuPrincipal(Expendedora expendedora)
        {
            this.expendedora = expendedora;
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.label1.Text = expendedora.Proveedor;

        }

        private void btnExtraerLata_Click(object sender, EventArgs e)
        {
            Frm3ExtraerLata eL = new Frm3ExtraerLata(expendedora, this);
            //Sirve esto acá? que me cambia?
            eL.Owner = this;
            eL.Show();
            this.Hide();
            


        }

        private void btnIngresarLata_Click(object sender, EventArgs e)
        {
            Frm3IngresarLata iL = new Frm3IngresarLata(expendedora, this);
            //Sirve esto acá? que me cambia?
            iL.Owner = this;
            iL.Show();
            this.Hide();
        }

        private void btnMostrarStock_Click(object sender, EventArgs e)
        {
            Frm3MostrarStock mS = new Frm3MostrarStock(expendedora, this);
            //Sirve esto acá? que me cambia?
            mS.Owner = this;
            mS.Show();
            this.Hide();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            Frm3ObtenerBalance b = new Frm3ObtenerBalance(expendedora, this);
            //Sirve esto acá? que me cambia?
            b.Owner = this;
            b.Show();
            this.Hide();
        }
    }
}
