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
        private void LstVariedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variedad seleccionada = (Variedad)lstVariedad.SelectedItem;

            if (seleccionada != null)
            {
                CompletarFormularioVariedad(seleccionada);
            }
        }
        private void BtnIngresarLata_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {              
                
                    Lata l = new Lata(txtCodigo.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToDouble(txtVolumen.Text));
                    expendedora.AgregarLata(l);
                    CargarLista();
                    MessageBox.Show("La lata ha sido ingresada exitosamente");
                    
                }
                catch (CapacidadInsuficienteException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (FormatException)
                {
                    try
                    {
                        Convert.ToDouble(txtVolumen.Text);

                    }
                    catch(FormatException)
                    {
                        MessageBox.Show("El formato ingresado de volumen no es el correcto o está vacío");
                        txtVolumen.Text = string.Empty;
                    }
                    try
                    {
                        Convert.ToDouble(txtPrecio.Text);
                    }
                    catch(FormatException)
                    {
                        MessageBox.Show("El formato ingresado de precio no es el correcto o está vacío");
                        txtPrecio.Text = string.Empty;
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

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
            bool valido = true;
            string msg = string.Empty;

            if (txtCodigo.Text == "-SELECCIONE-")
                msg = "Debe seleccionar una variedad\n";



            if (msg != string.Empty)
            {
                valido = false;
                MessageBox.Show(msg);
            }

            return valido;
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
