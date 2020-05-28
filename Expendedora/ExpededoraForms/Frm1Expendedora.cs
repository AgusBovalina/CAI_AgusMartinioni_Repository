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
    public partial class Frm1Expendedora : Form
    {

        private Expendedora expendedora;

        public Expendedora Expendedora { get => expendedora; }
    
        public Frm1Expendedora(Expendedora exp)
        {
            this.expendedora = exp;
                       
            InitializeComponent();
                                   
        }

        private void FrmExpededora_Load(object sender, EventArgs e)
        {
            LataHelper.AgregarList();
            this.Text = expendedora.Proveedor;
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            //revisar
            Frm2MenuPrincipal mP = new Frm2MenuPrincipal(expendedora);
            mP.Show();
            this.Hide();
        }
    }
}
