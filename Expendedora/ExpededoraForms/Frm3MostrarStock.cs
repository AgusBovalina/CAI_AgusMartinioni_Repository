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
        public Frm3MostrarStock(Expendedora exp, Form formPropietario)
        {

            this.Owner = formPropietario;
            this.Owner.Hide();
            this.expendedora = exp;
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
            lstLataToString.DataSource = null;

            //tener en consideración que hay que buscar por codigo una vez seleccionada por combobox
            //lstLataToString.DataSource = ;

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
