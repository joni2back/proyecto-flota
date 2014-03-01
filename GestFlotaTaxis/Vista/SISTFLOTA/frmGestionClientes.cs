using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista.SISTFLOTA
{
    public partial class frmGestionClientes : Form
    {
        public frmGestionClientes()
        {
            InitializeComponent();
        }

        private void frmGestionClientes_Load(object sender, EventArgs e)
        {

        }

        private void grpFiltros_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCliente ofrmCliente = new frmCliente();

            DialogResult drABIERTO = ofrmCliente.ShowDialog();
            if (drABIERTO == DialogResult.OK)
            {
                ArmarGrilla();
                MessageBox.Show("El Cliente se agregó correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grpVehiculos_Enter(object sender, EventArgs e)
        {

        }

        private void bdsChoferes_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
