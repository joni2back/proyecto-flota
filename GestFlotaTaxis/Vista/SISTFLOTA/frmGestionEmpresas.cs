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
    public partial class frmGestionEmpresas : Form
    {
        public frmGestionEmpresas()
        {
            InitializeComponent();
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
    }
}
