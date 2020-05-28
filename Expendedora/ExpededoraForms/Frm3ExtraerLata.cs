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
        public Frm3ExtraerLata(Expendedora exp, Form formPropietario)
        {

            this.expendedora = exp;
            this.listLabel = "Doble click para elegir lata";
            this.Owner = formPropietario;
            this.Owner.Hide();
            InitializeComponent();
        }

        #region "Métodos"
        private bool ValidarCampos()
        {
            throw new NotImplementedException();
        }

        private void LimpiarCampos()
        {
            throw new NotImplementedException();
        }
        private void CargarLista()
        {
            lstVariedad.DataSource = null;
            lstVariedad.DataSource = LataHelper.ListaVariedad;

            LimpiarCampos();
        }

        private void GrisarCampos()
        {
            throw new NotImplementedException();
        }

        private void CompletarFormularioVariedad(Variedad seleccionada)
        {
            throw new NotImplementedException();
        }


        #endregion

        private void Frm3ExtraerLata_Load(object sender, EventArgs e)
        {
            lblListlabel.Text = listLabel;
            this.CargarLista();
                                  
        }
               

        private void btnMostrarStock_Click(object sender, EventArgs e)
        {
            //Abre la ventana de stock con todos los campos grisados, y solo muestra lista segun datos en este form
            throw new NotImplementedException();
        }
    }
}
