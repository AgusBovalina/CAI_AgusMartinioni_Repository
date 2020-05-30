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
    public partial class Frm3MostrarStock : Form
    {
        private Expendedora expendedora;


        private string codigo;
        private string volumen;
        private string precio;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Volumen { get => volumen; set => volumen = value; }
        public string Precio { get => precio; set => precio = value; }

        public Frm3MostrarStock(Expendedora exp, Form formPropietario)
        {
            this.Owner = formPropietario;
            this.expendedora = exp;
            //Para agregar latas
            this.expendedora.Latas.AddRange( this.expendedora.CargarLatasHardcodeadas());
            InitializeComponent();
        }

        

        #region "Eventos"
        private void Frm3MostrarStock_Load(object sender, EventArgs e)
        {
            CargarComboCodigoLata();

            if (this.Owner is Frm3ExtraerLata)
            {
                
                CompletarCamposConInfoExterna();
                CargarListaFiltrada();
            }
            else if (this.Owner is Frm2MenuPrincipal)
            {
                               
                CargarListaCompleta();
                LimpiarCampos();
                
            }

        }

       private void LstLataToString_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lata seleccionada = (Lata)lstLataToString.SelectedItem;
            
            if (seleccionada != null)
            {
                CompletarFormularioLata(seleccionada);
                      
            }
       }

        

        private void CmbCodigo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarListaFiltrada();
            txtStock.Text=LatasFiltrada(cmbCodigo.Text).Count.ToString();

            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

            CargarListaCompleta();
            LimpiarCampos();


        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Owner is Frm3ExtraerLata)
            {
                try
                {

                
                    if (ValidarCampos())
                    {
                        Volumen = txtVolumen.Text;
                        Precio = txtPrecio.Text;
                        ((Frm3ExtraerLata)this.Owner).CompletarVolumenPrecio();
                        this.Owner.Show();
                        this.Dispose();
                    }
                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (this.Owner is Frm2MenuPrincipal)
            {
                this.Owner.Show();
                this.Dispose();
            }
        }
        

        private void Frm3MostrarStock_FormClosing(object sender, FormClosingEventArgs e)
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

            if (cmbCodigo.SelectedValue.ToString() == "-SELECCIONE-")
                msg = "Debe Seleccionar un tipo\n";



            if (msg != string.Empty)
            {
                valido = false;
                MessageBox.Show(msg);
            }

            return valido;
        }


        private void LimpiarCampos()
        {

            
            lstLataToString.SelectedIndex = -1;

            cmbCodigo.SelectedIndex = 0;
            cmbCodigo.Enabled = true;
            txtNombre.Text = string.Empty;
            txtSabor.Text = string.Empty;
            txtVolumen.Text = string.Empty;
            txtPrecio.Text = string.Empty;

            CompletarStockTotal();

            

        }

        private void CargarListaCompleta()
        {
            lstLataToString.DataSource = null;

            lstLataToString.DataSource = expendedora.Latas;


        }

        private List<Lata> LatasFiltrada(string codigo)
        {
            List<Lata> latasFiltrada = new List<Lata>();
            foreach (Lata l in expendedora.Latas)
            {
                if (l.Codigo == codigo)
                {
                    latasFiltrada.Add(l);

                }
            }

            return latasFiltrada;
        }

        private void CargarListaFiltrada()
        {
            lstLataToString.DataSource = null;
            
            lstLataToString.DataSource = LatasFiltrada(cmbCodigo.Text);

            
                      
                       
        }

        private void CargarComboCodigoLata()
        {
            List<string> listaCodigos = new List<string>();
            listaCodigos.Add("-SELECCIONE-");
            listaCodigos.AddRange(LataHelper.ListaCodigos());
            cmbCodigo.DataSource = listaCodigos;
        }

        private void CompletarFormularioLata(Lata seleccionada)
        {
            cmbCodigo.Enabled = false;
            txtNombre.Enabled = false;
            txtSabor.Enabled = false;
            txtPrecio.Enabled = false;
            txtVolumen.Enabled = false;

            cmbCodigo.Text = seleccionada.Codigo;
            txtNombre.Text = seleccionada.Nombre;
            txtSabor.Text = seleccionada.Sabor;
            txtPrecio.Text = seleccionada.Precio.ToString();
            txtVolumen.Text = seleccionada.Volumen.ToString();

            CompletarStock();

            
           
            
        }
        
        private void CompletarCamposConInfoExterna()
        {
            
            cmbCodigo.Enabled = false;
            txtNombre.Enabled = false;
            txtSabor.Enabled = false;


            cmbCodigo.Text = Codigo;
            
            txtNombre.Text = LataHelper.GetVariedad(cmbCodigo.Text).Nombre;
            txtSabor.Text = LataHelper.GetVariedad(cmbCodigo.Text).Sabor;
            txtVolumen.Text = string.Empty;
            txtPrecio.Text = string.Empty;

            CompletarStock();
            
            
        }

        private void CompletarStockTotal()
        {
            
            txtStock.Text = this.expendedora.Latas.Count().ToString();
            
        }

        private void CompletarStock()
        {
            Lata lata = new Lata(cmbCodigo.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToDouble(txtVolumen.Text));
            txtStock.Text= this.expendedora.GetStock(lata, LatasFiltrada(cmbCodigo.Text)).ToString();
        }













        #endregion

        
    }
}
