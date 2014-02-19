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
    public partial class frmGestionPerfiles : Form
    {
        Usuario oUsuarioActual;
        Perfil oPerfil;
        Controladora.SEGURIDAD.ControladoraGrupos ctrlGrupos = new Controladora.SEGURIDAD.ControladoraGrupos();
        Controladora.SEGURIDAD.ControladoraPermisos ctrlPermisos = new Controladora.SEGURIDAD.ControladoraPermisos();
        Controladora.SEGURIDAD.ControladoraFormularios ctrlFormularios = new Controladora.SEGURIDAD.ControladoraFormularios();
        Controladora.SEGURIDAD.ControladoraPerfiles ctrlPerfiles = new Controladora.SEGURIDAD.ControladoraPerfiles();

        public frmGestionPerfiles(Usuario oUsuario)
        {
            InitializeComponent();
            oUsuarioActual = oUsuario;
            CargarCombos();

            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            
        }

        private void frmGestPerfiles_Load(object sender, EventArgs e)
        {
            ArmarGrilla();
            ArmarPerfil();
        }

        private void CargarCombos()
        {
            bdsGrupos.Sort = null;
            bdsGrupos.DataSource = null;
            bdsGrupos.Clear();
            bdsGrupos.DataSource = ctrlGrupos.ListarGrupos();
            cbxGrupo.SelectedItem = null;

            bdsFormularios.Sort = null;
            bdsFormularios.DataSource = null;
            bdsFormularios.Clear();
            bdsFormularios.DataSource = ctrlFormularios.ListarFormularios();
            cbxFormulario.SelectedItem = null;

            bdsPermisos.Sort = null;
            bdsPermisos.DataSource = null;
            bdsPermisos.Clear();
            bdsPermisos.DataSource = ctrlPermisos.ListarPermisos();
            cbxPermiso.SelectedItem = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmPerfil ofrmPerfil = new frmPerfil(oUsuarioActual);

            DialogResult drABIERTO = ofrmPerfil.ShowDialog();
            if (drABIERTO == DialogResult.OK)
            {
                ArmarGrilla();
            }
        }

        private void ArmarGrilla()
        {
            lblSinResultados.Visible = false;
            bdsPerfiles.Sort = null;
            bdsPerfiles.DataSource = null;
            bdsPerfiles.Clear();
            bdsPerfiles.DataSource = ctrlPerfiles.ListarPerfiles();
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
                        case "TOTAL": btnNuevo.Enabled = true; btnEliminar.Enabled = true; break;
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (bdsPerfiles.Current != null)
            {
                oPerfil = (Perfil)bdsPerfiles.Current;


                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el Perfil seleccionado?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    ctrlPerfiles.EliminarPerfil(oPerfil);
                    MessageBox.Show("El Perfil ha sido eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Perfil", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbxFormulario.SelectedItem = null;
            cbxGrupo.SelectedItem = null;
            cbxPermiso.SelectedItem = null;
            ArmarGrilla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblSinResultados.Visible = false;

            Grupo oGrupoF = new Grupo();
            if (cbxGrupo.SelectedItem != null)
            {
                oGrupoF = (Grupo)bdsGrupos.Current;
            }
            
            Permiso oPermisoF = new Permiso();
            if (cbxPermiso.SelectedItem != null)
            {
                oPermisoF = (Permiso)bdsPermisos.Current;
            }
            
            Formulario oFormularioF = new Formulario();
            if (cbxFormulario.SelectedItem != null)
            {
                oFormularioF = (Formulario)bdsFormularios.Current;
            }

            bdsPerfiles.DataSource = ctrlPerfiles.FiltrarPerfiles(oGrupoF.IDgrupo, oPermisoF.IDpermiso, oFormularioF.IDformulario);

            if (bdsPerfiles.Count == 0)
                lblSinResultados.Visible = true;
        }
    }
}
