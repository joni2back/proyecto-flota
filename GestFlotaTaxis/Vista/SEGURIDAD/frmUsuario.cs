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
    public partial class frmUsuario : Form
    {
        Usuario USUactual;
        Usuario miUsuario = new Usuario();
        string frmModo;
        Controladora.SEGURIDAD.ControladoraUsuarios ctrlUsuarios = new Controladora.SEGURIDAD.ControladoraUsuarios();
        Controladora.SEGURIDAD.ControladoraGrupos ctrlGrupos = new Controladora.SEGURIDAD.ControladoraGrupos();
        Controladora.Encriptacion oEncriptacion = new Controladora.Encriptacion();

        public frmUsuario()
        {
            InitializeComponent();
            frmModo = "ALTA";
            ListarGrupos();
        }

        public frmUsuario(string modo, Usuario oUsuario)
        {
            InitializeComponent();
            frmModo = modo;
            ListarGrupos();

            miUsuario = oUsuario;

            txtUsuario.Text = oUsuario.IDusuario;
            txtNombreApellido.Text = oUsuario.NombreApellido;
            txtEmail.Text = oUsuario.Email;
            //txtContraseña.Text = oUsuario.Contraseña;
            //txtConfirmarContraseña.Text = oUsuario.Contraseña;
            if (oUsuario.Habilitado == true) chkEstado.Checked = true;
            else chkEstado.Checked = false;

            chlbGrupos.ClearSelected();

            Grupo _grupo;

            for (int i = 0; i < chlbGrupos.Items.Count; i++)
            {
                _grupo = (Grupo)chlbGrupos.Items[i];
                foreach (Grupo miGrupo in oUsuario.Grupo)
                {
                    if (miGrupo.IDgrupo == _grupo.IDgrupo)
                        chlbGrupos.SetItemChecked(i, true);
                }
            }

            if (frmModo == "MODIFICACION")
            {
                txtUsuario.Enabled = false;
            }

            if (frmModo == "CONSULTA")
            {
                gbDatos.Enabled = false;
                btnGuardar.Enabled = false;
            }

        }


        private bool ValidarCampos()
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un ID de Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return false;
            }

            if (txtNombreApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar el Nombre y Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreApellido.Focus();
                return false;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Debe ingresar el Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            if (chlbGrupos.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chlbGrupos.Focus();
                return false;
            }

            //if (txtContraseña.Text == "")
            //{
            //    MessageBox.Show("Debe ingresar una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtContraseña.Focus();
            //    return false;
            //}

            //if (txtConfirmarContraseña.Text == "")
            //{
            //    MessageBox.Show("Debe confirmar la contraseña ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtConfirmarContraseña.Focus();
            //    return false;
            //}

            //if (txtContraseña.Text != txtConfirmarContraseña.Text)
            //{
            //    MessageBox.Show("La nueva contraseña no coincide con su confirmación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtConfirmarContraseña.Text = "";
            //    txtConfirmarContraseña.Focus();
            //    return false;
            //}
            return true;
        }


        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarGrupos()
        {
            chlbGrupos.DataSource = ctrlGrupos.ListarGrupos();
            chlbGrupos.DisplayMember = "IDgrupo";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                miUsuario.IDusuario = txtUsuario.Text;
                miUsuario.NombreApellido = txtNombreApellido.Text;
                miUsuario.Email = txtEmail.Text;
                if (chkEstado.Checked == true) miUsuario.Habilitado = true;
                else miUsuario.Habilitado = false;

                miUsuario.Grupo.Clear();

                foreach (object item in chlbGrupos.CheckedItems)
                {
                   // int NUM = 0;
                    miUsuario.AgregaGrupo((Grupo)item);
                   // NUM = NUM + 1;
                }

                if (frmModo == "ALTA")
                {
                    miUsuario.Contraseña = "newuser";
                    miUsuario.PrimerVez = true;

                    if (ctrlUsuarios.VerificarUsuario(miUsuario))
                    {
                        ctrlUsuarios.AgregarUsuario(miUsuario);
                        ctrlUsuarios.CambiarContraseña(miUsuario);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("No se puede crear un usuario con un nombre de usuario ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    } 

                }

                if (frmModo == "MODIFICACION")
                {
                    //if (miUsuario.Contraseña != txtContraseña.Text)
                    //    miUsuario.Contraseña = oEncriptacion.encriptar(txtContraseña.Text);

                    ctrlUsuarios.ModificarUsuario(miUsuario);
                    this.DialogResult = DialogResult.OK;
                }

            }
        }
    }
}
