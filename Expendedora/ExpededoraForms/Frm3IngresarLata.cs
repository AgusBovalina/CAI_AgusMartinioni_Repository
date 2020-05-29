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
    public partial class Frm3IngresarLata : Form
    {
        private Expendedora expendedora;
        private string listLabel;
        public Frm3IngresarLata(Expendedora exp, Form formPropietario)
        {
            this.expendedora = exp;
            this.listLabel = "Elija qué variedad desea ingresar";
            this.Owner = formPropietario;
            InitializeComponent();
        }

        #region "Evento"

        private void Frm3IngresarLata_Load(object sender, EventArgs e)
        {
            lblListLabel.Text = listLabel;

            this.CargarLista();
        }
        private void lstVariedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variedad seleccionada = (Variedad)lstVariedad.SelectedItem;

            if (seleccionada != null)
            {
                CompletarFormularioVariedad(seleccionada);
            }
        }
        private void btnIngresarLata_Click(object sender, EventArgs e)
        {
            Lata l = new Lata(txtCodigo.Text, Convert.ToDouble(txtPrecio), Convert.ToDouble(txtVolumen));
            expendedora.AgregarLata(l);
            this.Dispose();
        }

        private void Frm3IngresarLata_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
        #endregion

        #region "Métodos"
        private bool ValidarCampos()
        {
            throw new NotImplementedException();
        }

        private void LimpiarCampos()
        {
            lstVariedad.SelectedIndex = -1;

            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtSabor.Text = string.Empty;
            txtVolumen.Text = string.Empty;
            txtPrecio.Text = string.Empty;
                        
        }
        private void CargarLista()
        {
            lstVariedad.DataSource = null;
            lstVariedad.DataSource = LataHelper.ListaVariedad;

            LimpiarCampos();
        }


        private void CompletarFormularioVariedad(Variedad seleccionada)
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
            txtSabor.Enabled = false;
            

            txtCodigo.Text = seleccionada.Codigo;
            txtNombre.Text = seleccionada.Nombre;
            txtSabor.Text = seleccionada.Sabor;
        }




        #endregion

        
    }
}
