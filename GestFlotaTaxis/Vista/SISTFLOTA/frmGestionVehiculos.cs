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
    public partial class frmGestionVehiculos : Form
    {
        private Controladora.SISTFLOTA.Adapter.Target target;
        private ControladoraVehiculos miGestVehiculos;
        private Modelo.Vehiculo oVehiculo;
        private Usuario oUsuarioActual;
        Controladora.ControladoraVehiculos ctrlVehiculos = Controladora.ControladoraVehiculos.getINSTANCIA;
        Controladora.ControladoraGastos ctrlGastos = new Controladora.ControladoraGastos();

        public frmGestionVehiculos(Usuario oUsuario)
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
            bdsVehiculos.Sort = null;
            bdsVehiculos.DataSource = null;
            bdsVehiculos.Clear();
            bdsVehiculos.DataSource = ctrlVehiculos.ListarVehiculos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmVehiculo ofrmVehiculo = new frmVehiculo();

            DialogResult drABIERTO = ofrmVehiculo.ShowDialog();
            if (drABIERTO == DialogResult.OK)
            {
                ArmarGrilla();
                MessageBox.Show("El Vehículo se agregó correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (bdsVehiculos.Current != null)
            {
                oVehiculo = (Modelo.Vehiculo)bdsVehiculos.Current;
                
                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el Vehículo " + oVehiculo.Patente + "?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (oVehiculo.Gasto.Count < 1)
                    {
                        ctrlVehiculos.EliminarVehiculo(oVehiculo);
                       
                    }
                    else                  
                    {

                        DialogResult result2 = MessageBox.Show("El Vehículo seleccionado tiene gastos asignados en su historial.\n ¿Desea eliminarlo de todas formas junto a sus gastos relacionados?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result2 == System.Windows.Forms.DialogResult.Yes)
                        {
                            foreach (Modelo.Gasto oGasto in oVehiculo.Gasto.ToList())
                            {
                                ctrlGastos.EliminarGasto(oGasto);
                            }
                            ctrlVehiculos.EliminarVehiculo(oVehiculo);
                            
                        }
                    }
                    ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Vehículo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (bdsVehiculos.Current != null)
            {
                oVehiculo = (Modelo.Vehiculo)bdsVehiculos.Current;

                frmVehiculo ofrmVehiculo = new frmVehiculo("MODIFICACION", oVehiculo);
                DialogResult drABIERTO = ofrmVehiculo.ShowDialog();
                if (drABIERTO == DialogResult.OK)
                {
                    MessageBox.Show("El Vehiculo ha sido modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Vehículo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (bdsVehiculos.Current != null)
            {
                oVehiculo = (Modelo.Vehiculo)bdsVehiculos.Current;

                frmVehiculo ofrmVehiculo = new frmVehiculo("CONSULTA", oVehiculo);
                DialogResult drABIERTO = ofrmVehiculo.ShowDialog();
                if (drABIERTO == DialogResult.OK)
                {
                    ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Vehículo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPatenteFiltro.Clear();
            txtPatenteTaxiFiltro.Clear();
            txtMarcaFiltro.Clear();
            txtAñoFiltro.Clear();

            ArmarGrilla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblSinResultados.Visible = false;
            string Patente = "";
            if ((txtPatenteFiltro.Text.Trim()).ToString().Length > 1)
             Patente = (txtPatenteFiltro.Text).ToString().ToUpper();
            string PatenteTaxi = txtPatenteTaxiFiltro.Text;
            string Marca = txtMarcaFiltro.Text.ToUpper();
            string Año = txtAñoFiltro.Text.ToString();

            bdsVehiculos.DataSource = ctrlVehiculos.ListarVehiculosFiltrados(Patente, PatenteTaxi, Marca, Año);

            if (bdsVehiculos.Count == 0)
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
