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
    public partial class Frm4Venta : Form
    {
        private Expendedora expendedora;
        private Lata lataExtraida;
        private double vuelto;
        public Frm4Venta(Venta venta, Expendedora expendedora, Form formPropietario)
        {
            this.expendedora = expendedora;
            lataExtraida = venta.LataVendida;
            vuelto = venta.Vuelto;
            this.Owner = formPropietario;
            InitializeComponent();
        }

        private void Frm4Venta_Load(object sender, EventArgs e)
        {
            this.Text = expendedora.Proveedor;
            txtDescripLata.Text = lataExtraida.ToString();
            txtVuelto.Text = "$ " + vuelto.ToString();
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Owner.Owner.Show();
            this.Owner.Dispose();
            this.Dispose();
        }
        private void Frm4Venta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Owner.Show();
            this.Owner.Dispose();
            this.Dispose();
        }

        
    }
}
