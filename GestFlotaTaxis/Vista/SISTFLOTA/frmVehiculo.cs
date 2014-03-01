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
    public partial class frmVehiculo : Form
    {
        string frmModo;
        int ChapaTaxi;
        Modelo.Vehiculo oVehiculo;
        Controladora.ControladoraVehiculos ctrlVehiculos = Controladora.ControladoraVehiculos.getINSTANCIA;

        public frmVehiculo()
        {
            InitializeComponent();
            frmModo = "ALTA";
        }

        public frmVehiculo(string modo, Modelo.Vehiculo oVehiculo)
        {
            InitializeComponent();
            frmModo = modo;
 
            if (frmModo == "MODIFICACION")
            {
                txtPatente.Enabled = false;
            }

            if (frmModo == "CONSULTA")
            {
                grpDetalle.Enabled = false;
                btnGuardar.Enabled = false;
            }

            ChapaTaxi = Convert.ToInt32(oVehiculo.PatenteTaxi);
            LlenarCampos(oVehiculo);

        }

        private void LlenarCampos(Modelo.Vehiculo oVehiculo)
        {
            txtPatente.Text = oVehiculo.Patente;
            txtPatenteTaxi.Text = oVehiculo.PatenteTaxi.ToString();
            txtMarca.Text = oVehiculo.Marca;
            txtModelo.Text = oVehiculo.Modelo;
            txtAño.Text = oVehiculo.Año.ToString();
            txtColor.Text = oVehiculo.Color;
            txtKilometraje.Text = oVehiculo.Kilometraje.ToString();
           
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

            if (txtMarca.Text == "")
            {
                txtMarca.Focus();
                MessageBox.Show("Complete la marca del vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtModelo.Text == "")
            {
                txtModelo.Focus();
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
            if (txtColor.Text == "")
            {
                txtColor.Focus();
                MessageBox.Show("Complete el color del vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtKilometraje.Text == "")
            {
                txtKilometraje.Focus();
                MessageBox.Show("Complete el kilometraje del vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                Convert.ToInt32(txtKilometraje.Text);
            }
            catch
            {
                txtKilometraje.Focus();
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
                oVehiculo.Marca = txtMarca.Text.ToUpper();
                oVehiculo.Modelo = txtModelo.Text.ToUpper();
                oVehiculo.Año = Convert.ToInt32(txtAño.Text);
                oVehiculo.Color = txtColor.Text.ToUpper();
                oVehiculo.Kilometraje = Convert.ToInt32(txtKilometraje.Text);

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

        private void frmVehiculo_Load(object sender, EventArgs e)
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

        private void grpDetalle_Enter(object sender, EventArgs e)
        {

        }


    
    }
}
