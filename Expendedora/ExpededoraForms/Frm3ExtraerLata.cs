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
    public partial class Frm3ExtraerLata : Form
    {
        private Expendedora expendedora;
        private string listLabel;
        private Frm3MostrarStock mS;
        private string codigo;

        public string Codigo { get => codigo; set => codigo = value; }

        public Frm3ExtraerLata(Expendedora exp, Form formPropietario)
        {
            //Frm3MostrarStock mS = new Frm3MostrarStock(expendedora, this);
            
            this.expendedora = exp;
            this.listLabel = "Doble click para elegir lata";
            this.Owner = formPropietario;
            
            InitializeComponent();
        }

        #region "Eventos"
        private void Frm3ExtraerLata_Load(object sender, EventArgs e)
        {
            
            
            lblListlabel.Text = listLabel;
            
            this.CargarLista();

        }
        

        private void btnMostrarStock_Click(object sender, EventArgs e)
        {

            mS = new Frm3MostrarStock(expendedora, this);
            mS.Codigo = txtCodigo.Text;
            mS.Owner = this;
            mS.Show();
            this.Hide();

        }


        private void btnExtraerLata_Click(object sender, EventArgs e)
        {
            Lata lata = new Lata(txtCodigo.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToDouble(txtVolumen.Text));
            Venta nuevaVenta = expendedora.ExtraerLata(lata, Convert.ToDouble(txtIngreseDinero.Text));
            Frm4Venta v = new Frm4Venta(nuevaVenta,expendedora, this);
            v.Owner = this;
            v.Show();
            this.Hide();
        }

        private void lstVariedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variedad seleccionada = (Variedad)lstVariedad.SelectedItem;

            if (seleccionada != null)
            {
                CompletarFormularioVariedad(seleccionada);
            }
        }

        private void Frm3ExtraerLata_FormClosing(object sender, FormClosingEventArgs e)
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
            txtIngreseDinero.Text = string.Empty;

            GrisarCampos();
            
        }
        private void CargarLista()
        {
            lstVariedad.DataSource = null;
            lstVariedad.DataSource = LataHelper.ListaVariedad;

            LimpiarCampos();
        }

        private void GrisarCampos()
        {
            if(txtVolumen.Text == string.Empty && txtPrecio.Text== string.Empty)
            {
                lblVolumen.Visible = false;
                txtVolumen.Visible = false;
                lblPrecio.Visible = false;
                txtPrecio.Visible = false;
                lblPago.Visible = false;
                txtIngreseDinero.Visible = false;

                btnExtraerLata.Enabled = false;
            }
            
        }

        private void CompletarFormularioVariedad(Variedad seleccionada)
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
            txtSabor.Enabled = false;
            txtVolumen.Enabled = false;
            txtPrecio.Enabled = false;

            txtCodigo.Text = seleccionada.Codigo;
            txtNombre.Text = seleccionada.Nombre;
            txtSabor.Text = seleccionada.Sabor;
        }

        public void CompletarVolumenPrecio()
        {
            txtVolumen.Text = mS.Volumen;
            txtPrecio.Text = mS.Precio;

            lblVolumen.Visible = true;
            lblPrecio.Visible = true;
            lblPago.Visible = true;
            txtVolumen.Visible = true;

            txtPrecio.Visible = true;
            txtIngreseDinero.Visible = true;

            btnExtraerLata.Enabled = true;
            

            
        }

        



        #endregion

        
    }
}
