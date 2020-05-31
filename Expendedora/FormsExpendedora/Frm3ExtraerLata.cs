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
        

        private void BtnMostrarStock_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == string.Empty)
            {
                mS = new Frm3MostrarStock(expendedora, this);
                
                mS.Owner = this;
                mS.Show();
                this.Hide();
            }
            else                
            {
                mS = new Frm3MostrarStock(expendedora, this);
                mS.Codigo = txtCodigo.Text;
                mS.Owner = this;
                mS.Show();
                this.Hide();
            }
            
        }


        private void BtnExtraerLata_Click(object sender, EventArgs e)
        {

            if (txtIngreseDinero.Text == string.Empty)
            {
                MessageBox.Show("Por favor ingrese el pago");
                               
            }
            else
            {
                try
                {                                    
                    Lata lata = new Lata(txtCodigo.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToDouble(txtVolumen.Text));
                    Venta nuevaVenta = expendedora.ExtraerLata(lata, Convert.ToDouble(txtIngreseDinero.Text));
                    Frm4Venta v = new Frm4Venta(nuevaVenta, expendedora, this);
                    v.Owner = this;
                    v.Show();
                    this.Hide();
                }
                catch (DineroInsuficienteException ex )
                {
                    MessageBox.Show(ex.Message);
                }
                catch (SinStockException ex)
                {
                    MessageBox.Show(ex.Message);

                }
                catch(FormatException )
                {
                    
                    MessageBox.Show("El formato ingresado de dinero no es el correcto");
                    txtIngreseDinero.Text = string.Empty;
                    //aca tira el error del objeto?

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }

        private void LstVariedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variedad seleccionada = (Variedad)lstVariedad.SelectedItem;

            LimpiarCampos();

            if (seleccionada != null)
            {
                CompletarFormularioVariedad(seleccionada);
            }
        }

        private void Frm3ExtraerLata_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
            {
                CloseWindow();
            }
        }

        private void Frm3ExtraerLata_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseWindow();
        }


        #endregion


        #region "Métodos"
        private bool ValidarCampos()
        {
            bool valido = true;
            string msg = string.Empty;

            if (txtCodigo.Text == string.Empty)
                msg = "Debe seleccionar una variedad\n";



            if (msg != string.Empty)
            {
                valido = false;
                MessageBox.Show(msg);
            }

            return valido;
        }

        private void LimpiarIndiceLista()
        {
            lstVariedad.SelectedIndex = -1;
                       
        }
        private void LimpiarCampos()
        {
            
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

            LimpiarIndiceLista();

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

        public void CompletarCamposStock()
        {
            txtCodigo.Text = mS.Codigo;
            txtNombre.Text = mS.Nombre;
            txtSabor.Text = mS.Sabor;
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

        private void CloseWindow()
        {
            this.Owner.Show();
            this.Dispose();
        }





        #endregion

        
    }
}
