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

namespace ExpendedoraForms
{
    public partial class Frm3ObtenerBalance : Form
    {
        private double saldoInicial;
        private double balanceTotal;
        private double ganancias;
        public Frm3ObtenerBalance(Expendedora expendedora, Form formPropietario)
        {
            this.Owner = formPropietario;
            this.saldoInicial = expendedora.SaldoInicial;
            this.balanceTotal = expendedora.Dinero;
            this.ganancias = balanceTotal - saldoInicial;
            InitializeComponent();
        }

        private void FrmObtenerBalance_Load(object sender, EventArgs e)
        {
            
            this.txtSaldoInicial.Text = Convert.ToString(saldoInicial);
            this.txtGanacias.Text = Convert.ToString( ganancias);
            this.txtBalanceTtal.Text = Convert.ToString(balanceTotal);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Dispose();
        }

        private void Frm3ObtenerBalance_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
    }
}
