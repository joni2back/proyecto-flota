using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo.SEGURIDAD;


namespace Vista.AUDITORIA
{
    public partial class frmAudGastos : Form
    {
        Modelo.SEGURIDAD.Usuario oUsuarioActual;
        Controladora.AUDITORIA.ControladoraAudGastos crtlAudGastos = new Controladora.AUDITORIA.ControladoraAudGastos();


        public frmAudGastos(Usuario miUsuario)
        {
            oUsuarioActual = miUsuario;

            InitializeComponent();
        }

        private void ArmarGrilla()
        {
            lblSinResultados.Visible = false;
            bsAudGastos.Sort = null;
            bsAudGastos.DataSource = null;
            bsAudGastos.Clear();
            bsAudGastos.DataSource = crtlAudGastos.ListarGastos();
        }

        private void frmAudGastos_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            cbxOperacion.SelectedIndex = 0;
            ArmarGrilla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            dtpFecha.Value = DateTime.Now;

            cbxOperacion.SelectedIndex = 0;
            ArmarGrilla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblSinResultados.Visible = false;

            bsAudGastos.DataSource = crtlAudGastos.FiltrarAudGastos(txtUsuario.Text, dtpFecha.Value.Date, cbxOperacion.SelectedItem.ToString());

            if (bsAudGastos.Count == 0)
                lblSinResultados.Visible = true;
        }
    }
}
