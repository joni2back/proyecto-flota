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
    public partial class frmPerfil : Form
    {
        Usuario USUactual;
        Perfil oPerfil;
        Controladora.SEGURIDAD.ControladoraGrupos ctrlGrupos = new Controladora.SEGURIDAD.ControladoraGrupos();
        Controladora.SEGURIDAD.ControladoraPermisos ctrlPermisos = new Controladora.SEGURIDAD.ControladoraPermisos();
        Controladora.SEGURIDAD.ControladoraFormularios ctrlFormularios = new Controladora.SEGURIDAD.ControladoraFormularios();
        Controladora.SEGURIDAD.ControladoraPerfiles ctrlPerfiles = new Controladora.SEGURIDAD.ControladoraPerfiles();
        
        public frmPerfil(Usuario oUsuario)
        {
            InitializeComponent();
            CargarCombos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            oPerfil = new Perfil();
            oPerfil.Grupo = (Grupo)bdsGrupos.Current;
            oPerfil.Permiso = (Permiso)bdsPermisos.Current;
            oPerfil.Formulario = (Formulario)bdsFormularios.Current;

            if (ctrlPerfiles.VerificarPerfil(oPerfil))
            {
                ctrlPerfiles.AgregarPerfil(oPerfil);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("El perfil ingresado ya existe. Ingrese una configuracion diferente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
 

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCombos()
        {
            bdsGrupos.Sort = null;
            bdsGrupos.DataSource = null;
            bdsGrupos.Clear();
            bdsGrupos.DataSource = ctrlGrupos.ListarGrupos();

            bdsFormularios.Sort = null;
            bdsFormularios.DataSource = null;
            bdsFormularios.Clear();
            bdsFormularios.DataSource = ctrlFormularios.ListarFormularios();

            bdsPermisos.Sort = null;
            bdsPermisos.DataSource = null;
            bdsPermisos.Clear();
            bdsPermisos.DataSource = ctrlPermisos.ListarPermisos();
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {

        }

    }
}
