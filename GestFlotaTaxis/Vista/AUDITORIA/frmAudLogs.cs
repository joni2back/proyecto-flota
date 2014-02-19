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
    public partial class frmAudLogs : Form
    {
        Modelo.SEGURIDAD.Usuario oUsuarioActual;
        Controladora.AUDITORIA.ControladoraAudLog ctrlAudLog = new Controladora.AUDITORIA.ControladoraAudLog();


        public frmAudLogs(Usuario miUsuario)
        {
            oUsuarioActual = miUsuario;
            InitializeComponent();

        }

        private void ArmarGrilla()
        {
            lblSinResultados.Visible = false;
            bsAudLogs.Sort = null;
            bsAudLogs.DataSource = null;
            bsAudLogs.Clear();
            bsAudLogs.DataSource = ctrlAudLog.ListarLogs();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAudLogs_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            cbxOperacion.SelectedIndex = 0;
            ArmarGrilla();
        }





        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblSinResultados.Visible = false;

            bsAudLogs.DataSource = ctrlAudLog.FiltrarLogs(txtUsuario.Text, dtpFecha.Value.Date, cbxOperacion.SelectedItem.ToString());

           if (bsAudLogs.Count == 0)
                lblSinResultados.Visible = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
        
            txtUsuario.Clear();
            dtpFecha.Value = DateTime.Now;
            cbxOperacion.SelectedIndex = 0;
            ArmarGrilla();
        }
    }
}
