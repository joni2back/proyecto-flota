using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo.SEGURIDAD;
using Controladora;

namespace Vista
{
    public partial class frmGestionChoferes : Form
    {
        private Controladora.SISTFLOTA.Adapter.Target target;
        private ControladoraVehiculos miGestVehiculos;
        private Modelo.Vehiculo oChofer;
        private Usuario oUsuarioActual;
        Controladora.ControladoraVehiculos ctrlVehiculos = Controladora.ControladoraVehiculos.getINSTANCIA;
        Controladora.ControladoraGastos ctrlGastos = new Controladora.ControladoraGastos();

        public frmGestionChoferes(Usuario oUsuario)
        {
            target = new Controladora.SISTFLOTA.Adapter.Adapter();
            miGestVehiculos = target.OBTENER_INSTANCIA();

            oUsuarioActual = oUsuario;
            InitializeComponent();

            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }


        private void ArmarGrilla()
        {
            lblSinResultados.Visible = false;
            bdsChoferes.Sort = null;
            bdsChoferes.DataSource = null;
            bdsChoferes.Clear();
            bdsChoferes.DataSource = ctrlVehiculos.ListarVehiculos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmChofer ofrmChofer = new frmChofer();

            DialogResult drABIERTO = ofrmChofer.ShowDialog();
            if (drABIERTO == DialogResult.OK)
            {
                ArmarGrilla();
                MessageBox.Show("El Chofer se agregó correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (bdsChoferes.Current != null)
            {
                oChofer = (Modelo.Vehiculo)bdsChoferes.Current;
                
                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar al Chofer " + oChofer.Patente + "?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (oChofer.Gasto.Count < 1)
                    {
                        ctrlVehiculos.EliminarVehiculo(oChofer);
                       
                    }
                    else                  
                    {

                        DialogResult result2 = MessageBox.Show("El Chofer seleccionado tiene gastos asignados en su historial.\n ¿Desea eliminarlo de todas formas junto a sus gastos relacionados?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result2 == System.Windows.Forms.DialogResult.Yes)
                        {
                            foreach (Modelo.Gasto oGasto in oChofer.Gasto.ToList())
                            {
                                ctrlGastos.EliminarGasto(oGasto);
                            }
                            ctrlVehiculos.EliminarVehiculo(oChofer);
                            
                        }
                    }
                    ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar a un Chofer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (bdsChoferes.Current != null)
            {
                oChofer = (Modelo.Vehiculo)bdsChoferes.Current;

                frmChofer ofrmChofer = new frmChofer("MODIFICACION", oChofer);
                DialogResult drABIERTO = ofrmChofer.ShowDialog();
                if (drABIERTO == DialogResult.OK)
                {
                    MessageBox.Show("El Chofer ha sido modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar a un Chofer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (bdsChoferes.Current != null)
            {
                oChofer = (Modelo.Vehiculo)bdsChoferes.Current;

                frmChofer ofrmChofer = new frmChofer("CONSULTA", oChofer);
                DialogResult drABIERTO = ofrmChofer.ShowDialog();
                if (drABIERTO == DialogResult.OK)
                {
                    ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar a un Chofer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreFiltro.Clear();
            txtApellidoFiltro.Clear();
            txtDocumentoFiltro.Clear();
            txtLicenciaFiltro.Clear();

            ArmarGrilla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblSinResultados.Visible = false;
            string Patente = "";
            if ((txtPatenteFiltro.Text.Trim()).ToString().Length > 1)
             Patente = (txtPatenteFiltro.Text).ToString().ToUpper();
            string PatenteTaxi = txtPatenteTaxiFiltro.Text;
            string Marca = txtNombreFiltro.Text.ToUpper();
            string Año = txtAñoFiltro.Text.ToString();

            bdsChoferes.DataSource = ctrlVehiculos.ListarVehiculosFiltrados(Patente, PatenteTaxi, Marca, Año);

            if (bdsChoferes.Count == 0)
                lblSinResultados.Visible = true;
        }

        private void frmGestVehiculos_Load(object sender, EventArgs e)
        {
            ArmarGrilla();
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
