using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using Modelo.SEGURIDAD;

namespace Vista.SistFlota
{
    public partial class frmInforme : Form
    {
        Usuario oUsuarioActual;
        private Controladora.SISTFLOTA.Strategy.Contexto miCONTEXTO;
        private Controladora.SISTFLOTA.Strategy.IStrategy strategy;
        Controladora.ControladoraVehiculos ctrlVehiculos = Controladora.ControladoraVehiculos.getINSTANCIA;

        public frmInforme(Usuario oUsuario)
        {
            oUsuarioActual = oUsuario;
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {

            if (ctrlVehiculos.ListarVehiculosGastos().Count != 0)
            {

                switch (cbTipo.SelectedItem.ToString())
                {
                    case "HTML":
                        {
                            strategy = new Controladora.SISTFLOTA.Strategy.DOCStrategy();
                            break;
                        }
                    case "PDF":
                        {
                            strategy = new Controladora.SISTFLOTA.Strategy.PDFStrategy();
                            break;
                        }
                }

                miCONTEXTO = Controladora.SISTFLOTA.Strategy.Contexto.getINSTANCIA(strategy);
                miCONTEXTO.Hacer_Reporte("Reporte_Gastos");
            }
            else
            {
                MessageBox.Show("No hay vehiculos cargados al sistema", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

      

        private void frmInforme_Load(object sender, EventArgs e)
        {
            cbTipo.SelectedItem = cbTipo.Items[0];
        }

        private void btnVehiculosActivos_Click(object sender, EventArgs e)
        {


            if (ctrlVehiculos.ListarVehiculosActivos().Count != 0)
            {

                switch (cbTipo.SelectedItem.ToString())
                {
                    case "HTML":
                        {
                            strategy = new Controladora.SISTFLOTA.Strategy.DOCStrategy();
                            break;
                        }
                    case "PDF":
                        {
                            strategy = new Controladora.SISTFLOTA.Strategy.PDFStrategy();
                            break;
                        }
                }

                miCONTEXTO = Controladora.SISTFLOTA.Strategy.Contexto.getINSTANCIA(strategy);
                miCONTEXTO.Hacer_Reporte("Reporte_VehiculosActivos");

            }
            else
            {
                MessageBox.Show("No hay vehiculos cargados al sistema", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaHastaFiltro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaDesdeFiltro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
      
    }
}
