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
    public partial class Frm1Expendedora : Form
    {

        private Expendedora expendedora;

        public Expendedora Expendedora { get => expendedora; }
    
        public Frm1Expendedora(Expendedora exp)
        {
            this.expendedora = exp;
            
            LataHelper.AgregarList();
            InitializeComponent();
                                   
        }

        private void Frm1Expendedora_Load(object sender, EventArgs e)
        {
            Text = expendedora.Proveedor;
        }

        private void BtnEncender_Click(object sender, EventArgs e)
        {
            expendedora.EncenderMaquina();
            Frm2MenuPrincipal mP = new Frm2MenuPrincipal(expendedora, this);
            mP.Owner = this;
            mP.Show();
            this.Hide();
        }
        private void Frm1Expendedora_FormClosing(object sender, FormClosingEventArgs e)
        {
           this.Dispose();
        }

    }
}
