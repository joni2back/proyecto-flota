using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista.SEGURIDAD
{
    public partial class frmLogin : Form
    {
        Controladora.SEGURIDAD.ControladoraLogin ctrlLogin = new Controladora.SEGURIDAD.ControladoraLogin();
        Controladora.SEGURIDAD.ControladoraUsuarios ctrlUsuarios = new Controladora.SEGURIDAD.ControladoraUsuarios();

        public frmLogin()
        {
            InitializeComponent();
            ctrlUsuarios.CargaInicialBD();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese el nombre de usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsuario.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Ingrese la contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtContraseña.Focus();
                return false;
            }
            return true;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
                if (this.ValidarCampos())
                {
                    //Controladora.SEGURIDAD.ControladoraLogin oLogin = new Controladora.SEGURIDAD.ControladoraLogin();
                    object UsuarioActual = new Modelo.SEGURIDAD.Usuario();
                    UsuarioActual = ctrlLogin.IniciarSesion(txtUsuario.Text, txtContraseña.Text);

                    Type tipo = UsuarioActual.GetType();

                    if (tipo.Name == "Usuario")
                    {
                        Modelo.SEGURIDAD.Usuario oUsuario = (Modelo.SEGURIDAD.Usuario)UsuarioActual;
                        this.Hide();

                        if (oUsuario.PrimerVez == true)
                        {
                            frmCambiarContraseña ofrmCambiarContraseña = new frmCambiarContraseña(oUsuario);
                            ofrmCambiarContraseña.ShowDialog();
                        }
                        

                        frmPrincipal ofrmPrincipal = new frmPrincipal(oUsuario);
                        
                        DialogResult drABIERTO = ofrmPrincipal.ShowDialog();
                        if (drABIERTO == DialogResult.Abort)
                        {
                            this.Show();
                            txtContraseña.Clear();
                            txtUsuario.Clear();
                            txtUsuario.Focus();
                        }
                        else
                        {
                            Application.Exit();
                        }
                        
                    }
                    else
                    {
                        int error = (int)UsuarioActual;
                        switch (error)
                        {
                            case 1:
                                MessageBox.Show("Usuario Inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.txtUsuario.Text = null;
                                this.txtContraseña.Text = null;
                                this.txtUsuario.Focus();
                                break;
                            case 2:
                                MessageBox.Show("Contraseña Erronea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.txtContraseña.Text = null;
                                this.txtContraseña.Focus();
                                break;
                            case 3:
                                MessageBox.Show("El usuario no se encuentra habilitado para iniciar sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.txtUsuario.Text = null;
                                this.txtContraseña.Text = null;
                                this.txtUsuario.Focus();
                                break;
                            default:
                                break;
                        }
                    }
                }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAceptar_Click(null,null);  
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtContraseña.Focus();
            }
        }

        private void linkResetearContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese el nombre de usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsuario.Focus();
                return;
            }
            if (txtUsuario.Text == "admin")
            {
                MessageBox.Show("El administrador es un usuario reservado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsuario.Focus();
                return;
            }

            object UsuarioPass = new Modelo.SEGURIDAD.Usuario();
            UsuarioPass = ctrlLogin.ResetearContraseña(txtUsuario.Text);

            if (UsuarioPass.GetType().Name != "Usuario")
            {
                int error = (int)UsuarioPass;
                if (error == 1)
                {
                    MessageBox.Show("Nombre de usuario incorrecto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtUsuario.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("La nueva contraseña ha sido enviado a su casilla de correo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUsuario.Focus();
                return;
            }
        }

    }
}
