using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista.SISTFLOTA
{
    public partial class frmEmpresa : Form
    {
        string frmModo;
        Modelo.Empresa oEmpresa;
        Controladora.ControladoraEmpresas ctrlEmpresa = Controladora.ControladoraEmpresas.getINSTANCIA;

        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {

        }

        public bool ValidarCampos()
        {
            if (txtRazonSocial.Text == "")
            {
                txtRazonSocial.Focus();
                MessageBox.Show("Complete la Razón Social de la Empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

         
            if (txtCuil.Text == "")
            {
                txtCuil.Focus();
                MessageBox.Show("Complete el CUIL de la Empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

          
            if (txtLocalidad.Text == "")
            {
                txtLocalidad.Focus();
                MessageBox.Show("Complete la localidad de la Empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtDomicilio.Text == "")
            {
                txtDomicilio.Focus();
                MessageBox.Show("Complete el domicilio de la Empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTelefono.Text == "")
            {
                txtTelefono.Focus();
                MessageBox.Show("Complete el teléfono de la Empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                oEmpresa = new Modelo.Empresa();

                oEmpresa.RazonSocial = txtRazonSocial.Text;
                oEmpresa.Localidad = txtLocalidad.Text;
                oEmpresa.Correo = txtCorreoElectronico.Text;
                oEmpresa.Domicilio = txtDomicilio.Text;
                oEmpresa.Telefono = txtTelefono.Text;

                if (txtCorreoElectronico.Text != "")
                {
                    oEmpresa.Correo = txtCorreoElectronico.Text;
                }

                if (frmModo == "ALTA")
                {
                    if (ctrlEmpresa.VerificarEmpresa(oEmpresa))
                    {
                            ctrlEmpresa.AgregarEmpresa(oEmpresa);
                            this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("El Cuil introducido pertenece a otra Empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (frmModo == "MODIFICACION")
                {
                    
                    ctrlEmpresa.ModificarEmpresa(oEmpresa);
                        this.DialogResult = DialogResult.OK;

                }

            }
        }
    }
}
