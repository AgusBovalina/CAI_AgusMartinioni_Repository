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

    }
}
