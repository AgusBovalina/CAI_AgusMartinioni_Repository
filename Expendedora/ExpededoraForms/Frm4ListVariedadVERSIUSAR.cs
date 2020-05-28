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
    public partial class Frm4ListVariedadVERSIUSAR : Form
    {
        private string label;
        private Expendedora expendedora;

        public Frm4ListVariedadVERSIUSAR(string label, Expendedora exp)
        {
            this.label = label;
            this.expendedora = exp;
            InitializeComponent();
        }

        private void frm4ListVariedad_Load(object sender, EventArgs e)
        {
            lblEncabezadoList.Text = label;
            this.CargarLista();
        }


        
        private void CargarLista()
        {
            lstVariedad.DataSource = LataHelper.ListaVariedad;
        }

    }
}
