using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controladora;
using Modelo.SEGURIDAD;

namespace Vista.SISTFLOTA
{
    public partial class frmGestionEmpresas : Form
    {
        Controladora.ControladoraEmpresas ctrlEmpresas = Controladora.ControladoraEmpresas.getINSTANCIA;
        Usuario oUsuarioActual;

        public frmGestionEmpresas(Usuario oUsuario)
        {
            oUsuarioActual = oUsuario;
            InitializeComponent();

            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void ArmarGrilla()
        {
            lblSinResultados.Visible = false;
            bdsEmpresa.Sort = null;
            bdsEmpresa.DataSource = null;
            bdsEmpresa.Clear();
            bdsEmpresa.DataSource = ctrlEmpresas.ListarEmpresas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEmpresa ofrmEmpresa = new frmEmpresa();

            DialogResult drABIERTO = ofrmEmpresa.ShowDialog();
            if (drABIERTO == DialogResult.OK)
            {
                ArmarGrilla();
                MessageBox.Show("La Empresa se agregó correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
