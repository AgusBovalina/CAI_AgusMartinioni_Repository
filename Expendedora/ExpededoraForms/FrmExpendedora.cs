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
    public partial class FrmExpendedora : Form
    {

        private Expendedora expendedora;

        public Expendedora Expendedora { get => expendedora; }
    
        public FrmExpendedora(Expendedora exp)
        {
                       
            InitializeComponent();
                                   
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {

        }
    }
}
