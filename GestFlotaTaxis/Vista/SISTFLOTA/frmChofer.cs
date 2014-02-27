using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmChofer : Form
    {
        string frmModo;
        Modelo.Chofer oChofer;
        Controladora.ControladoraChoferes ctrlChoferes = Controladora.ControladoraChoferes.getINSTANCIA;

        public frmChofer()
        {
            InitializeComponent();
            frmModo = "ALTA";
        }

        public frmChofer(string modo, Modelo.Chofer oChofer)
        {
            InitializeComponent();
            frmModo = modo;
 
            if (frmModo == "MODIFICACION")
            {
                txtDocumento.Enabled = false;
            }

            if (frmModo == "CONSULTA")
            {
                grpDetalle.Enabled = false;
                btnGuardar.Enabled = false;
            }

            LlenarCampos(oChofer);

        }

        private void LlenarCampos(Modelo.Chofer oChofer)
        {
            txtNombre.Text = oChofer.Nombre;
            txtApellido.Text = oChofer.Apellido;
            txtDocumento.Text = oChofer.Documento.ToString();
            txtLicencia.Text = oChofer.Licencia;
            txtFechaNacimiento.Text = oChofer.FechaNacimiento.ToString();
            txtLocalidad.Text = oChofer.Localidad;
            txtCorreoElectronico.Text = oChofer.Correo;
            txtDomicilio.Text = oChofer.Domicilio;
            txtTelefono.Text = oChofer.Telefono;

            //imgFotoChofer.Image = (System.Drawing.Image)oChofer.Foto;

            
           
        }


        public bool ValidarCampos()
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Focus();
                MessageBox.Show("Complete la patente del chofer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtApellido.Text == "")
            {
                txtApellido.Focus();
                MessageBox.Show("Complete la patente del chofer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                                  
            if (txtDocumento.Text == "")
            {
                txtDocumento.Focus();
                MessageBox.Show("Complete documento del chofer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtLicencia.Text == "")
            {
                txtLicencia.Focus();
                MessageBox.Show("Complete la licencia de conductor del chofer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtFechaNacimiento.Text == "")
            {
                txtFechaNacimiento.Focus();
                MessageBox.Show("Complete la fecha de nacimiento del chofer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtLocalidad.Text == "")
            {
                txtLocalidad.Focus();
                MessageBox.Show("Complete la localidad del chofer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtDomicilio.Text == "")
            {
                txtDomicilio.Focus();
                MessageBox.Show("Complete el domicilio del chofer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTelefono.Text == "")
            {
                txtTelefono.Focus();
                MessageBox.Show("Complete el telefono del chofer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                oChofer = new Modelo.Chofer();

                oChofer.Nombre = txtNombre.Text;
                oChofer.Apellido = txtApellido.Text;
                oChofer.Documento = Convert.ToInt32(txtDocumento.Text);
                oChofer.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
                oChofer.Licencia = txtLicencia.Text.ToUpper();

                oChofer.Localidad = txtLocalidad.Text;
                oChofer.Correo = txtCorreoElectronico.Text;
                oChofer.Domicilio = txtDomicilio.Text;
                oChofer.Telefono = txtTelefono.Text;

                if (txtCorreoElectronico.Text != "")
                {
                    oChofer.Correo = txtCorreoElectronico.Text;
                }

                if (frmModo == "ALTA")
                {
                    if (ctrlChoferes.VerificarChofer(oChofer))
                    {
                        if (ctrlChoferes.VerificarLicencia(oChofer))
                        {
                            ctrlChoferes.AgregarChofer(oChofer);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("La licencia introducida pertenece a otro chofer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("El documento introducido pertenece a otro chofer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (frmModo == "MODIFICACION")
                {
                        if (ctrlChoferes.VerificarLicencia(oChofer))
                        {
                            ctrlChoferes.ModificarChofer(oChofer);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("La licencia introducida pertenece a otro chofer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    

                }

            }


        }
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChofer_Load(object sender, EventArgs e)
        {

        }
    
    }
}
