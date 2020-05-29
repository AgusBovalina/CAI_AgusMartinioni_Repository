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




        public Frm3ExtraerLata(Expendedora exp, Form formPropietario)
        {

            this.expendedora = exp;
            this.listLabel = "Doble click para elegir lata";
            this.Owner = formPropietario;
            Frm3MostrarStock mS = new Frm3MostrarStock(expendedora, this, txtCodigo.Text);
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

            //Frm3MostrarStock mS = new Frm3MostrarStock(expendedora, this, txtCodigo.Text);
            mS.Owner = this;
            mS.Show();

        }

        

        private void btnExtraerLata_Click(object sender, EventArgs e)
        {
            Lata lata = new Lata(txtCodigo.Text, Convert.ToDouble(txtVolumen.Text), Convert.ToDouble(txtPrecio.Text));
            Venta nuevaVenta = expendedora.ExtraerLata(lata, Convert.ToDouble(txtIngreseDinero.Text));
            Frm4Venta v = new Frm4Venta(nuevaVenta,expendedora, this);
            v.Owner = this;
            v.Show();
            this.Dispose();
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
            if(txtVolumen.Text=="" && txtPrecio.Text=="")
            {
                lblVolumen.Visible = false;
                txtVolumen.Visible = false;
                lblPrecio.Visible = false;
                txtPrecio.Visible = false;
            }
            else
            {
                lblVolumen.Visible = true;
                txtVolumen.Visible = true;
                lblPrecio.Visible = true;
                txtPrecio.Visible = true;
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

        private void CompletarVolumenPrecio()
        {
            lblVolumen.Visible = true;
            lblPrecio.Visible = true;
            txtVolumen.Visible = true;
            txtPrecio.Visible = true;

            txtVolumen.Text = mS.volumen;
            txtPrecio.Text = mS.precio;
        }

        //no funciona porque no lo puedo llamar, ni siendo publico
        public void prueba(string volumen, string precio)
        {
            lblVolumen.Visible = true;
            lblPrecio.Visible = true;
            txtVolumen.Visible = true;
            txtPrecio.Visible = true;

            txtVolumen.Text = mS.volumen;
            txtPrecio.Text = mS.precio;
        }

        #endregion

        
    }
}
