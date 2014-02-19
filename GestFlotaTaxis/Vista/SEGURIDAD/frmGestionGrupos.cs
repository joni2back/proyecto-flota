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
    public partial class frmGestionGrupos : Form
    {
        Usuario oUsuarioActual;
        Grupo oGrupo;
        Controladora.SEGURIDAD.ControladoraGrupos ctrlGrupos = new Controladora.SEGURIDAD.ControladoraGrupos();
        Controladora.SEGURIDAD.ControladoraPerfiles ctrlPerfiles = new Controladora.SEGURIDAD.ControladoraPerfiles();

        public frmGestionGrupos(Usuario oUsuario)
        {
            oUsuarioActual = oUsuario;
            InitializeComponent();

            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void frmGestGrupos_Load(object sender, EventArgs e)
        {
            ArmarPerfil();
            ArmarGrilla();
        }

        private void ArmarGrilla()
        {
            lblSinResultados.Visible = false;
            bdsGrupos.Sort = null;
            bdsGrupos.DataSource = null;
            bdsGrupos.Clear();
            bdsGrupos.DataSource = ctrlGrupos.ListarGrupos();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblSinResultados.Visible = false;
            string Nombre = txtNombre.Text.ToUpper();

            bdsGrupos.DataSource = ctrlGrupos.ListarGruposFiltrados(Nombre);

            if (bdsGrupos.Count == 0)
                lblSinResultados.Visible = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            ArmarGrilla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGrupo ofrmGrupo = new frmGrupo();

            DialogResult drABIERTO = ofrmGrupo.ShowDialog();
            if (drABIERTO == DialogResult.OK)
            {
                ArmarGrilla();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if (bdsGrupos.Current != null)
            {
                oGrupo = (Grupo)bdsGrupos.Current;

                frmGrupo ofrmGrupo = new frmGrupo("CONSULTA", oGrupo);
                DialogResult drABIERTO = ofrmGrupo.ShowDialog();
                if (drABIERTO == DialogResult.OK)
                {
                   ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Grupo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (bdsGrupos.Current != null)
            {
                oGrupo = (Grupo)bdsGrupos.Current;

                frmGrupo ofrmGrupo = new frmGrupo("MODIFICACION", oGrupo);
                DialogResult drABIERTO = ofrmGrupo.ShowDialog();
                if (drABIERTO == DialogResult.OK)
                {
                    ArmarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Grupo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (bdsGrupos.Current != null)
            {
                oGrupo = (Grupo)bdsGrupos.Current;
                string Grupoid = oGrupo.IDgrupo;

                if (oGrupo.IDgrupo == "Administrador")
                {
                    MessageBox.Show("El grupo Administrador no puede ser eliminado ya que es reservado del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el Grupo: " + Grupoid + " ?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {


                    int usuarios = oGrupo.Usuario.Count;

                    if (usuarios > 0)
                    {
                        DialogResult result2 = MessageBox.Show("El Grupo: " + Grupoid + " tiene " + usuarios + " usuarios asignados.\n ¿Desea eliminarlo de todas formas?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result2 == System.Windows.Forms.DialogResult.Yes)
                        {
                            ctrlGrupos.EliminarGrupo(oGrupo);
                            MessageBox.Show("El Grupo: " + Grupoid + " ha sido eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ArmarGrilla();
                        }
                    }
                    else
                    {
                        ctrlGrupos.EliminarGrupo(oGrupo);
                        MessageBox.Show("El Grupo: " + Grupoid + " ha sido eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ArmarGrilla();
                    }

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Grupo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
