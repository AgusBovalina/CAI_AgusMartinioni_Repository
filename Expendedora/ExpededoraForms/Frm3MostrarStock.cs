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
        private string codigoLata;
        public string volumen;
        public string precio;
       
        
        public Frm3MostrarStock(Expendedora exp, Form formPropietario)
        {
            this.Owner = formPropietario;
            this.expendedora = exp;
            InitializeComponent();
        }

        public Frm3MostrarStock(Expendedora exp, Form formPropietario, string codigoLata)
        {
            this.Owner = formPropietario;
            this.expendedora = exp;
            this.codigoLata = codigoLata;
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

        private void lstLataToString_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lata seleccionada = (Lata)lstLataToString.SelectedItem;
            
            if (seleccionada != null)
            {
                CompletarFormularioLata(seleccionada);
                      
            }
        }

       
        private void cmbCodigo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarListaFiltrada();
            txtStock.Text=LatasFiltrada(cmbCodigo.Text).Count.ToString();

            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            CargarListaCompleta();
            LimpiarCampos();


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Owner is Frm3ExtraerLata)
            {
                

                //aceptar debería pasarle data a extraerlata

            }
            else if (this.Owner is Frm2MenuPrincipal)
            {
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
            throw new NotImplementedException();
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

            txtStock.Text = expendedora.Latas.Count().ToString();

            

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

            txtStock.Text = expendedora.GetStock(seleccionada).ToString();
           
            
        }
        
        private void CompletarCamposConInfoExterna()
        {
            
                cmbCodigo.Enabled = false;
                txtNombre.Enabled = false;
                txtSabor.Enabled = false;


                cmbCodigo.Text = codigoLata;
            //considerar excepcion por falta de latas
                txtNombre.Text = LataHelper.GetVariedad(cmbCodigo.Text).Nombre;
                txtSabor.Text = LataHelper.GetVariedad(cmbCodigo.Text).Sabor;
            
            
        }

        











        #endregion


    }
}
