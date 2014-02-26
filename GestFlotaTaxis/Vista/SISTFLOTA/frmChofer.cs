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
        //int ChapaTaxi;
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

            //ChapaTaxi = Convert.ToInt32(oVehiculo.PatenteTaxi);
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
            if (txtPatente.Text == "")
            {
                txtPatente.Focus();
                MessageBox.Show("Complete la patente del vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if ((txtPatente.Text).ToString().Length != 7 /*|| (Convert.ToInt32(txtPatente.Text)).ToString().Length != 3*/)
            {
                txtPatente.Focus();
                MessageBox.Show("La patente del vehiculo debe contener 3 letras y 3 números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtPatenteTaxi.Text != "")
            {
                try
                {
                    Convert.ToInt32(txtPatenteTaxi.Text);
                }
                catch
                {
                    txtPatenteTaxi.Focus();
                    MessageBox.Show("La patente de Taxi debe ser numérica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (txtDocumento.Text == "")
            {
                txtDocumento.Focus();
                MessageBox.Show("Complete la marca del vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtLicencia.Text == "")
            {
                txtLicencia.Focus();
                MessageBox.Show("Complete el modelo del vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtAño.Text == "")
            {
                txtAño.Focus();
                MessageBox.Show("Complete el año del vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((txtAño.Text).ToString().Length != 4)
            {
                txtAño.Focus();
                MessageBox.Show("El año del vehiculo debe estar conformado 4 números. Ej: 2010", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtFechaNacimiento.Text == "")
            {
                txtFechaNacimiento.Focus();
                MessageBox.Show("Complete el color del vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtLocalidad.Text == "")
            {
                txtLocalidad.Focus();
                MessageBox.Show("Complete el kilometraje del vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                Convert.ToInt32(txtLocalidad.Text);
            }
            catch
            {
                txtLocalidad.Focus();
                MessageBox.Show("El kilometraje debe ser numérico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                oVehiculo = new Modelo.Vehiculo();


                oVehiculo.Patente = txtPatente.Text.ToUpper();
                if (txtPatenteTaxi.Text != "")
                {
                    oVehiculo.PatenteTaxi = Convert.ToInt32(txtPatenteTaxi.Text);
                }
                oVehiculo.Marca = txtDocumento.Text.ToUpper();
                oVehiculo.Modelo = txtLicencia.Text.ToUpper();
                oVehiculo.Año = Convert.ToInt32(txtAño.Text);
                oVehiculo.Color = txtFechaNacimiento.Text.ToUpper();
                oVehiculo.Kilometraje = Convert.ToInt32(txtLocalidad.Text);

                if (frmModo == "ALTA")
                {
                    if (ctrlVehiculos.VerificarVehiculo(oVehiculo))
                    {
                        if (ctrlVehiculos.VerificarPatenteTaxi(oVehiculo))
                        {
                            ctrlVehiculos.AgregarVehiculo(oVehiculo);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("La patente de taxi solicitada se encuentra activa en otro vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("La patente solicitada ya pertenece a otro vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (frmModo == "MODIFICACION")
                {
                    if (ChapaTaxi != oVehiculo.PatenteTaxi)
                    {
                        if (ctrlVehiculos.VerificarPatenteTaxi(oVehiculo))
                        {
                            ctrlVehiculos.ModificarVehiculo(oVehiculo);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("La patente de taxi solicitada se encuentra activa en otro vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        ctrlVehiculos.ModificarVehiculo(oVehiculo);
                        this.DialogResult = DialogResult.OK;
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

        private void checkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkActivo.Checked == true)
            {
                txtPatenteTaxi.Enabled = true;
            }
            else
            {
                txtPatenteTaxi.Enabled = false;
                txtPatenteTaxi.Clear();
            }
        }


    
    }
}
