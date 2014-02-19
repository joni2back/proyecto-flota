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
    public partial class frmCambiarContraseña : Form
    {
        Usuario oUsuarioActual;
        Controladora.Encriptacion oEncriptacion = new Controladora.Encriptacion();
        Controladora.SEGURIDAD.ControladoraUsuarios crtlUsuarios = new Controladora.SEGURIDAD.ControladoraUsuarios();

        public frmCambiarContraseña(Usuario oUsuario)
        {
            oUsuarioActual = oUsuario;
            InitializeComponent();

            if (oUsuario.PrimerVez == true)
            {
                btnCancelar.Visible = false;
                //this.FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void frmCambiarContraseña_Load(object sender, EventArgs e)
        {
            grbCambioContaseña.Text = "Usuario: " + oUsuarioActual.IDusuario;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string nuevo = oEncriptacion.encriptar(txtContraseñaNueva.Text);
                string actual = oEncriptacion.encriptar(txtContraseñaActual.Text);
                if (oUsuarioActual.Contraseña == actual)
                {
                    if (txtContraseñaNueva.Text == txtConfirmarContraseña.Text)
                    {
                        oUsuarioActual.Contraseña = nuevo;
                        oUsuarioActual.PrimerVez = false;
                        crtlUsuarios.ModificarUsuario(oUsuarioActual);
                        MessageBox.Show("La constraseña se cambió correctamente", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("La nueva contraseña no coincide con su confirmación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña actual errónea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validarCampos()
        {
            if (txtContraseñaActual.Text == "" || txtContraseñaNueva.Text == "" || txtConfirmarContraseña.Text == "")
                return false;
            else
                return true;
        }
    }
}
