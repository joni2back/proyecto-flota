using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo.SEGURIDAD;
using Modelo.AUDITORIA;
using System.Data;

namespace Controladora.SEGURIDAD
{
    public class ControladoraLogin
    {
        Usuario oUsuario;
        Controladora.SEGURIDAD.ControladoraUsuarios ctrlUsuarios = new ControladoraUsuarios();
        Controladora.AUDITORIA.ControladoraAudLog ctrlAudLog = new Controladora.AUDITORIA.ControladoraAudLog();


        public  object IniciarSesion(string IDUsuario, string clave) // es de tipo object ya que puede devolver distintos valores
        {
            int nroError;
            Encriptacion oEncriptacion = new Encriptacion();
     
            Usuario oUsuario; //declaracion de la variable Usuario
            oUsuario = ctrlUsuarios.BuscarUsuario(IDUsuario); //Se asigna a usuario el valor devuelto por BuscarUsuario()
            string password = oEncriptacion.encriptar(clave);

            if (oUsuario == null) //Si no se encontró ningún usuario con ese ID....
            {
                nroError = 1;
                return nroError;
            }
            if (oUsuario.Contraseña != password) //Si la contraseña ingresada no coincide con la del usuario..
            {
                nroError = 2;
                return nroError;
            }
            if (oUsuario.Habilitado == false) //si el usuario no está habilitado para iniciar sesión
            {
                nroError = 3;
                return nroError;
            }

            oUsuario.Activo = true;

            ctrlUsuarios.ModificarUsuario(oUsuario);
            ctrlAudLog.AuditarLogIn(oUsuario);
            //ENTIDADES.Auditoria.AuditoríaLog oAuLog = new ENTIDADES.Auditoria.AuditoríaLog();
            //oAuLog.IDusuario = oUsuario.IDusuario;
            //oAuLog.Operación = "Login";
            //oAuLog.FechaHora = DateTime.Now;

            //MODELO.Auditoría.AuditoriaLogs modAudit = new MODELO.Auditoría.AuditoriaLogs();
            //modAudit.Auditar(oAuLog);

            return oUsuario; //si está todo OK devuelve el usuario encontrado
        }

        public object ResetearContraseña(string IDUsuario)
        {
            int nroError;
            Encriptacion oEncriptacion = new Encriptacion();

            Usuario oUsuario; //declaracion de la variable Usuario
            oUsuario = ctrlUsuarios.BuscarUsuario(IDUsuario); //Se asigna a usuario el valor devuelto por BuscarUsuario()

            if (oUsuario == null) //Si no se encontró ningún usuario con ese ID....
            {
                nroError = 1;
                return nroError;
            }
            if (oUsuario != null) //Si se encontro el usuario...
            {
                ctrlUsuarios.CambiarContraseña(oUsuario);
            }

            oUsuario.Activo = true;

            ctrlUsuarios.ModificarUsuario(oUsuario);
            ctrlAudLog.AuditarLogIn(oUsuario);

            return oUsuario; //si está todo OK devuelve el usuario encontrado
        }

        public void CerrarSesion(Usuario oUsuario)
        {
            oUsuario.Activo = false;
            
            ctrlUsuarios.ModificarUsuario(oUsuario);

            ctrlAudLog.AuditarLogOut(oUsuario);
            //ENTIDADES.Auditoria.AuditoríaLog oAuLog = new ENTIDADES.Auditoria.AuditoríaLog();
            //oAuLog.IDusuario = oUSUARIO.IDusuario;
            //oAuLog.Operación = "Logout";
            //oAuLog.FechaHora = DateTime.Now;

            //MODELO.Auditoría.AuditoriaLogs modAudit = new MODELO.Auditoría.AuditoriaLogs();
            //modAudit.Auditar(oAuLog);
        }

        //public DataTable RecuperarPerfil(List<Grupo> Grupos)
        //{
        //    return null;
        //    //return MODELO.Seguridad.CatálogoPerfiles.Instancia.ObtenerModulos(GRUPOS);
        //}


    }
}
