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
    public partial class frmGestionTurnos : Form
    {
        Modelo.Turno oTurno;
        Usuario oUsuarioActual;
        Controladora.ControladoraChoferes ctrlChoferes = Controladora.ControladoraChoferes.getINSTANCIA;
        Controladora.ControladoraVehiculos ctrlVehiculos = Controladora.ControladoraVehiculos.getINSTANCIA;
        Controladora.ControladoraTurnos ctrlTurnos = Controladora.ControladoraTurnos.getINSTANCIA;

        public frmGestionTurnos(Usuario oUsuario)
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
            
            bdsChoferes.Sort = null;
            bdsChoferes.DataSource = null;
            bdsChoferes.Clear();
            bdsChoferes.DataSource = ctrlChoferes.ListarChoferes();
            cbxChoferFiltro.SelectedItem = null;

            if (cbxTurnoFiltro.Items.Count == 0)
            {
                cbxTurnoFiltro.Items.Add("MAÑANA");
                cbxTurnoFiltro.Items.Add("TARDE");
                cbxTurnoFiltro.Items.Add("NOCHE");
            }

            cbxTurnoFiltro.SelectedItem = null;
        }


        private void ArmarGrilla()
        {
            lblSinResultados.Visible = false;
            bdsTurnos.Sort = null;
            bdsTurnos.DataSource = null;
            bdsTurnos.Clear();
            bdsTurnos.DataSource = ctrlTurnos.ListarTurnos();
        }

        private void frmGestionTurnos_Load(object sender, EventArgs e)
        {
            ArmarGrilla();
            CargarCombos();
            ArmarPerfil();
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

            frmTurno ofrmTurno = new frmTurno(oUsuarioActual);

            DialogResult drABIERTO = ofrmTurno.ShowDialog();
            if (drABIERTO == DialogResult.OK)
            {
                ArmarGrilla();
                MessageBox.Show("El Turno se generó correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (bdsChoferes.Current != null)
            {
                oTurno = (Modelo.Turno)bdsTurnos.Current;

                frmTurno ofrmTurno = new frmTurno("CONSULTA", oTurno, oUsuarioActual);
                DialogResult drABIERTO = ofrmTurno.ShowDialog();
                if (drABIERTO == DialogResult.OK)
                {
                    ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Turno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (bdsTurnos.Current != null)
            {
                oTurno = (Modelo.Turno)bdsTurnos.Current;

                frmTurno ofrmTurno = new frmTurno("MODIFICACION", oTurno, oUsuarioActual);
                DialogResult drABIERTO = ofrmTurno.ShowDialog();
                if (drABIERTO == DialogResult.OK)
                {
                    MessageBox.Show("El Turno ha sido modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Turno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (bdsChoferes.Current != null)
            {
                oTurno = (Modelo.Turno)bdsChoferes.Current;
                int turnoid = oTurno.Id;

                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el Turno número " + turnoid + " ?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    //ctrlAudTurnos.AuditarTurnosBAJA(oTurno);

                    ctrlTurnos.EliminarTurno((Modelo.Turno)bdsTurnos.Current);
                        ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Turno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            txtIdFiltro.Clear();
            //txtMontoFiltro.Clear();
            //txtDescripcionFiltro.Clear();               
            chkFechasFiltro.Checked = false;

            //CargarCombos();
            cbxVehiculoFiltro.SelectedItem = null;
            cbxTurnoFiltro.SelectedItem = null;
            cbxChoferFiltro.SelectedItem = null;
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

            Modelo.Chofer oChoferF = null;
            if (cbxChoferFiltro.SelectedItem != null)
            {
                oChoferF = (Modelo.Chofer)bdsChoferes.Current;
            }

            //string Monto = txtMontoFiltro.Text;
            string Turno = "";
            if (cbxTurnoFiltro.Text != "")
            {
                Turno = cbxTurnoFiltro.Text.ToUpper();
            }
            //string Descripcion = txtDescripcionFiltro.Text.ToUpper();

            DateTime VenceDesde = dtpFechaDesdeFiltro.MinDate;
            DateTime VenceHasta = dtpFechaHastaFiltro.MaxDate;

            if (chkFechasFiltro.Checked == true)
            {
                VenceDesde = dtpFechaDesdeFiltro.Value.Date;
                VenceHasta = dtpFechaHastaFiltro.Value.Date;
            }


            //bdsTurnos.DataSource = ctrlTurnos.ListarTurnosFiltrados(Id, oVehiculoF, oTipodeTurnoF, Monto, Estado, Descripcion, VenceDesde, VenceHasta);

            if (bdsTurnos.Count == 0)
                lblSinResultados.Visible = true;
            // MessageBox.Show("No se encontraron resultados con los parámetros de busqueda introducidos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void frmGestTurnos_Load(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }


    }
}
