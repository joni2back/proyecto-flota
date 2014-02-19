using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo.SEGURIDAD;

namespace Vista.SEGURIDAD
{
    public partial class frmGestionUsuarios : Form
    {
        Modelo.SEGURIDAD.Usuario oUsuarioActual;
        Usuario oUsuario;
        Controladora.SEGURIDAD.ControladoraPerfiles ctrlPerfiles = new Controladora.SEGURIDAD.ControladoraPerfiles();
        Controladora.SEGURIDAD.ControladoraUsuarios ctrlUsuarios = new Controladora.SEGURIDAD.ControladoraUsuarios();

        public frmGestionUsuarios(Modelo.SEGURIDAD.Usuario miUsuario)
        {
            oUsuarioActual = miUsuario;
            InitializeComponent();

            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void ArmarGrilla()
        {
            lblSinResultados.Visible = false;
            bdsUsuarios.Sort = null;
            bdsUsuarios.DataSource = null;
            bdsUsuarios.Clear();
            bdsUsuarios.DataSource = ctrlUsuarios.ListarUsuarios();
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

        private void frmGestUsuarios_Load(object sender, EventArgs e)
        {
            cbxEstado.SelectedIndex = 0;
            ArmarGrilla();
            ArmarPerfil();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmUsuario ofrmUsuario = new frmUsuario();

            DialogResult drABIERTO = ofrmUsuario.ShowDialog();
            if (drABIERTO == DialogResult.OK)
            {
                MessageBox.Show("El Usuario ha sido creado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ArmarGrilla();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (bdsUsuarios.Current != null)
            {
                oUsuario = (Usuario)bdsUsuarios.Current;

                frmUsuario ofrmUsuario = new frmUsuario("CONSULTA", oUsuario);
                DialogResult drABIERTO = ofrmUsuario.ShowDialog();
                if (drABIERTO == DialogResult.OK)
                {
                    ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (bdsUsuarios.Current != null)
            {
                oUsuario = (Usuario)bdsUsuarios.Current;

                frmUsuario ofrmUsuario = new frmUsuario("MODIFICACION", oUsuario);
                DialogResult drABIERTO = ofrmUsuario.ShowDialog();
                if (drABIERTO == DialogResult.OK)
                {
                    MessageBox.Show("El Usuario ha sido midificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (bdsUsuarios.Current != null)
            {
                oUsuario = (Usuario)bdsUsuarios.Current;

                if (oUsuarioActual != oUsuario)
                {

                    string user = oUsuario.IDusuario;


                    DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el Usuario: " + user + " ?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        ctrlUsuarios.EliminarUsuario(oUsuario);
                        MessageBox.Show("El Usuario: " + user + " ha sido eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bdsUsuarios.Remove(oUsuario);

                        //ArmarGrilla();
                    }
                }
                else
                {
                    MessageBox.Show("No puede eliminar su propio usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un Usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblSinResultados.Visible = false;

            bdsUsuarios.DataSource = ctrlUsuarios.ListarUsuariosFiltrados(txtUsuario.Text, txtNombreApellido.Text, cbxEstado.SelectedItem.ToString());

            if (bdsUsuarios.Count == 0)
                lblSinResultados.Visible = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreApellido.Clear();
            txtUsuario.Clear();
            cbxEstado.SelectedIndex = 0;
            ArmarGrilla();
        }
    }
}
