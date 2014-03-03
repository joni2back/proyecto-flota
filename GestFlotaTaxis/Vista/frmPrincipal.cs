using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vista.SistFlota;
using Vista.SISTFLOTA;
using Vista.SEGURIDAD;
using Vista.AUDITORIA;
using Modelo.SEGURIDAD;

namespace Vista
{
    public partial class frmPrincipal : Form
    {
        Modelo.SEGURIDAD.Usuario oUsuarioActual;
        Controladora.SEGURIDAD.ControladoraLogin ctrlLogin = new Controladora.SEGURIDAD.ControladoraLogin();
         Controladora.ControladoraTiposdeGasto ctrlTipoGastos = new  Controladora.ControladoraTiposdeGasto();

        public frmPrincipal(Modelo.SEGURIDAD.Usuario oUsuario)
        {
            oUsuarioActual = oUsuario;
            InitializeComponent();

            // --- TEMPORAL INICIO --- //
            ctrlTipoGastos.CargarTiposdeGasto();
            // ---- TEMPORAL FIN ---- //

            menuAdmGrupos.Visible = false;
            menuAdministrar.Visible = false;
            menuAuditoria.Visible = false;
            menuAdmPerfiles.Visible = false;
            menuAdmUsuarios.Visible = false;
            menuGestGastos.Visible = false;
            menuGestionar.Visible = false;
            menuGestVehiculos.Visible = false;
            menuInformes.Visible = false;
            menuMonitores.Visible = false;

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrlLogin.CerrarSesion(oUsuarioActual);

            oUsuarioActual = null;
            lblUsuarioActual.Text = "";
            lblNomyApeActual.Text = "";
            this.Close();
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionGastos ofrmGestGastos = new frmGestionGastos(oUsuarioActual);
            ofrmGestGastos.ShowDialog();
        }

        private void vehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionVehiculos ofrmGestVehiculos = new frmGestionVehiculos(oUsuarioActual);
            ofrmGestVehiculos.ShowDialog();
        }

        private void gastosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMonitorGastos ofrmMonitorGastos = new frmMonitorGastos(oUsuarioActual);
            ofrmMonitorGastos.ShowDialog();
        }

        private void menuGestChoferes_Click(object sender, EventArgs e)
        {
            frmGestionChoferes ofrmGestChoferes = new frmGestionChoferes(oUsuarioActual);
            ofrmGestChoferes.ShowDialog();
        }
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblUsuarioActual.Text = oUsuarioActual.IDusuario;
            lblNomyApeActual.Text = oUsuarioActual.NombreApellido;
            ArmarPerfil();


        }
        
        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInforme ofrmInforme = new frmInforme(oUsuarioActual);
            ofrmInforme.ShowDialog();
        }

        private void acercaDeSGFTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcerca ofrmAcerca = new frmAcerca();
            ofrmAcerca.ShowDialog();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CONTROLADORA.Auditoria.CtrlAuditoria oCtrlAu = new CONTROLADORA.Auditoria.CtrlAuditoria();
            //ENTIDADES.Auditoria.AuditoríaLog oAuLog = new ENTIDADES.Auditoria.AuditoríaLog();
            //oAuLog.IDusuario = oUsuarioActual.IDusuario;
            //oAuLog.Operación = "Logout";
            //oAuLog.FechaHora = DateTime.Now;

            //oCtrlAu.Cierre_Sesion(oAuLog);

            ctrlLogin.CerrarSesion(oUsuarioActual);

            oUsuarioActual = null;
            lblUsuarioActual.Text = "";
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ctrlLogin.CerrarSesion(oUsuarioActual);

            oUsuarioActual = null;
            lblUsuarioActual.Text = "";
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionUsuarios ofrmGestUsuarios = new frmGestionUsuarios(oUsuarioActual);
            ofrmGestUsuarios.ShowDialog();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionGrupos ofrmGestGrupos = new frmGestionGrupos(oUsuarioActual);
            ofrmGestGrupos.ShowDialog();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionPerfiles ofrmGestPerfiles = new frmGestionPerfiles(oUsuarioActual);
            ofrmGestPerfiles.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //CONTROLADORA.Auditoria.CtrlAuditoria oCtrlAu = new CONTROLADORA.Auditoria.CtrlAuditoria();
            //ENTIDADES.Auditoria.AuditoríaLog oAuLog = new ENTIDADES.Auditoria.AuditoríaLog();
            //oAuLog.IDusuario = oUsuarioActual.IDusuario;
            //oAuLog.Operación = "Logout";
            //oAuLog.FechaHora = DateTime.Now;

            //oCtrlAu.Cierre_Sesion(oAuLog);

            ctrlLogin.CerrarSesion(oUsuarioActual);

            oUsuarioActual = null;
            lblUsuarioActual.Text = "";
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña ofrmCambiarContraseña = new frmCambiarContraseña(oUsuarioActual);
            ofrmCambiarContraseña.ShowDialog();
        }

        private void ArmarPerfil()
        {
            Controladora.SEGURIDAD.ControladoraPerfiles ctrlPerfiles = new Controladora.SEGURIDAD.ControladoraPerfiles();
            bool admin = false;

            foreach (Grupo g in oUsuarioActual.Grupo)
                if (g.IDgrupo == "Administrador")
                {
                    admin = true;
                }

            if (admin)
            {
                menuAdministrar.Visible = true;
                menuAuditoria.Visible = true;

                menuAdmGrupos.Visible = true;
                menuAdmPerfiles.Visible = true;
                menuAdmUsuarios.Visible = true;
                menuGestionar.Visible = true;
                menuGestGastos.Visible = true;
                menuGestVehiculos.Visible = true;
                menuInformes.Visible = true;
                menuMonitores.Visible = true;
           
            }
            else
            {

                List<Modelo.SEGURIDAD.Formulario> _PERMISOS = new List<Modelo.SEGURIDAD.Formulario>();
                _PERMISOS = ctrlPerfiles.ObtenerPermisos(oUsuarioActual);

                foreach (Modelo.SEGURIDAD.Formulario oPERMISO in _PERMISOS)
                {
                    switch (oPERMISO.IDformulario)
                    {
                        case "GestionGrupos": menuAdministrar.Visible = true; menuAdmGrupos.Visible = true; break;
                        case "GestionPerfiles": menuAdministrar.Visible = true; menuAdmPerfiles.Visible = true; break;
                        case "GestionUsuarios": menuAdministrar.Visible = true; menuAdmUsuarios.Visible = true; break;
                        case "GestionGastos": menuGestionar.Visible = true; menuGestGastos.Visible = true; break;
                        case "GestionVehiculos": menuGestionar.Visible = true; menuGestVehiculos.Visible = true; break;
                        case "Informes": menuInformes.Visible = true; break;
                        case "Monitor": menuMonitores.Visible = true; break;

                    }
                }
            }
        }

        private void menuAudLogs_Click(object sender, EventArgs e)
        {
            frmAudLogs ofrmAudLogs = new frmAudLogs(oUsuarioActual);
            ofrmAudLogs.ShowDialog();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void gastosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAudGastos ofrmAudGastos = new frmAudGastos(oUsuarioActual);
            ofrmAudGastos.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmGestionClientes ofrmGestClientes = new frmGestionClientes(oUsuarioActual);
            ofrmGestClientes.ShowDialog();*/
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionEmpresas ofrmGestClientes = new frmGestionEmpresas(oUsuarioActual);
            ofrmGestClientes.ShowDialog();
        }


        

    }
}
