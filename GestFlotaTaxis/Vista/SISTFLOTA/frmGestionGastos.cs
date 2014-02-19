using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vista.SistFlota;
using Modelo.SEGURIDAD;


namespace Vista
{
    public partial class frmGestionGastos : Form
    {
        Modelo.Gasto oGasto;
        Usuario oUsuarioActual;
        Controladora.AUDITORIA.ControladoraAudGastos ctrlAudGastos = new Controladora.AUDITORIA.ControladoraAudGastos();
        Controladora.ControladoraTiposdeGasto ctrlTipoGasto = new Controladora.ControladoraTiposdeGasto();
        Controladora.ControladoraVehiculos ctrlVehiculos = Controladora.ControladoraVehiculos.getINSTANCIA;
        Controladora.ControladoraGastos ctrlGastos = new Controladora.ControladoraGastos();

        public frmGestionGastos(Usuario oUsuario)
        {
            oUsuarioActual = oUsuario;
            InitializeComponent();

            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

        }

        private void CargarCombos()
        {
            bdsVehiculos.Sort = null;
            bdsVehiculos.DataSource = null;
            bdsVehiculos.Clear();
            bdsVehiculos.DataSource = ctrlVehiculos.ListarVehiculos();
            cbxVehiculoFiltro.SelectedItem = null;
            
            bdsTipodeGasto.Sort = null;
            bdsTipodeGasto.DataSource = null;
            bdsTipodeGasto.Clear();
            bdsTipodeGasto.DataSource = ctrlTipoGasto.ListarTiposdeGasto();
            cbxTipoGastoFiltro.SelectedItem = null;

            if (cbxEstadoFiltro.Items.Count == 0)
            {
                cbxEstadoFiltro.Items.Add("PENDIENTE");
                cbxEstadoFiltro.Items.Add("PAGADO");
            }

            cbxEstadoFiltro.SelectedItem = null;
        }


        private void ArmarGrilla()
        {
            lblSinResultados.Visible = false;
            bdsGastos.Sort = null;
            bdsGastos.DataSource = null;
            bdsGastos.Clear();
            bdsGastos.DataSource = ctrlGastos.ListarGastos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkFechasFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFechasFiltro.Checked == true)
                grpFechasFiltro.Enabled = true;
            else
                grpFechasFiltro.Enabled = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            frmGasto ofrmGasto = new frmGasto(oUsuarioActual);

            DialogResult drABIERTO = ofrmGasto.ShowDialog();
            if (drABIERTO == DialogResult.OK)
            {
                ArmarGrilla();
                MessageBox.Show("El Gasto se generó correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (bdsGastos.Current != null)
            {
                oGasto = (Modelo.Gasto)bdsGastos.Current;

                frmGasto ofrmGasto = new frmGasto("CONSULTA", oGasto, oUsuarioActual);
                DialogResult drABIERTO = ofrmGasto.ShowDialog();
                if (drABIERTO == DialogResult.OK)
                {
                    ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Gasto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (bdsGastos.Current != null)
            {
                oGasto = (Modelo.Gasto)bdsGastos.Current;

                frmGasto ofrmGasto = new frmGasto("MODIFICACION", oGasto, oUsuarioActual);
                DialogResult drABIERTO = ofrmGasto.ShowDialog();
                if (drABIERTO == DialogResult.OK)
                {
                    MessageBox.Show("El Gasto ha sido modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Gasto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (bdsGastos.Current != null)
            {
                oGasto = (Modelo.Gasto)bdsGastos.Current;
                int gastoid = oGasto.Id;

                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el Gasto número " + gastoid + " ?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    ctrlAudGastos.AuditarGastosBAJA(oGasto);

                    ctrlGastos.EliminarGasto((Modelo.Gasto)bdsGastos.Current);
                        ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Gasto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            txtIdFiltro.Clear();
            txtMontoFiltro.Clear();
            txtDescripcionFiltro.Clear();               
            chkFechasFiltro.Checked = false;

            //CargarCombos();
            cbxVehiculoFiltro.SelectedItem = null;
            cbxTipoGastoFiltro.SelectedItem = null;
            cbxEstadoFiltro.SelectedItem = null;
            ArmarGrilla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblSinResultados.Visible = false;
            string Id = txtIdFiltro.Text;

            Modelo.Vehiculo oVehiculoF = null;
            if (cbxVehiculoFiltro.SelectedItem != null)
            {
                oVehiculoF = (Modelo.Vehiculo)bdsVehiculos.Current;
            }

            Modelo.TipodeGasto oTipodeGastoF = null;
            if (cbxTipoGastoFiltro.SelectedItem != null)
            {
                oTipodeGastoF = (Modelo.TipodeGasto)bdsTipodeGasto.Current;
            }

            string Monto = txtMontoFiltro.Text;
            string Estado = "";
            if (cbxEstadoFiltro.Text != "")
            {
                Estado = cbxEstadoFiltro.Text.ToUpper();
            }
                string Descripcion = txtDescripcionFiltro.Text.ToUpper();

            DateTime VenceDesde = dtpFechaDesdeFiltro.MinDate;
            DateTime VenceHasta = dtpFechaHastaFiltro.MaxDate;

            if (chkFechasFiltro.Checked == true)
            {
                VenceDesde = dtpFechaDesdeFiltro.Value.Date;
                VenceHasta = dtpFechaHastaFiltro.Value.Date;
            }


            bdsGastos.DataSource = ctrlGastos.ListarGastosFiltrados(Id, oVehiculoF, oTipodeGastoF, Monto, Estado, Descripcion, VenceDesde, VenceHasta);

            if (bdsGastos.Count == 0)
                lblSinResultados.Visible = true;
            // MessageBox.Show("No se encontraron resultados con los parámetros de busqueda introducidos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void frmGestGastos_Load(object sender, EventArgs e)
        {
            ArmarGrilla();
            CargarCombos();
            ArmarPerfil();
        }

        private void ArmarPerfil()
        {
            bool admin = false;

            foreach (Grupo g in oUsuarioActual.Grupo)
                if (g.IDgrupo == "Administrador")
                {
                    admin = true;
                }

            if (admin)
            {
                btnNuevo.Enabled = true;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
            else
            {
                Controladora.SEGURIDAD.ControladoraPerfiles ctrlPerfiles = new Controladora.SEGURIDAD.ControladoraPerfiles();

                List<Modelo.SEGURIDAD.Permiso> _PERMISOS = new List<Modelo.SEGURIDAD.Permiso>();
                _PERMISOS = ctrlPerfiles.ObtenerPermisos(this.Name.ToString().Substring(3), oUsuarioActual);

                foreach (Modelo.SEGURIDAD.Permiso oPERMISO in _PERMISOS)
                {
                    switch (oPERMISO.IDpermiso)
                    {
                        case "ALTA": btnNuevo.Enabled = true; break;
                        case "BAJA": btnEliminar.Enabled = true; break;
                        case "MODIFICACION": btnModificar.Enabled = true; break;
                        case "TOTAL": btnNuevo.Enabled = true; btnEliminar.Enabled = true; btnModificar.Enabled = true; break;
                    }
                }
            }
        }
    }
}
