using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo.SEGURIDAD;
using System.Net.Mail;

namespace Controladora.SEGURIDAD
{
    public class ControladoraUsuarios
    {
        Encriptacion oEncriptar = new Encriptacion();

// ---- TEMPORAL INICIO ---- //
        public void CargaInicialBD()
        {

            if (Modelo.Seguridad.ObtenerInstancia().Usuarios.ToList().Count == 0)
            {
               
                Grupo oGrupo = new Grupo();
                oGrupo.IDgrupo = "Administrador";
                oGrupo.Descripcion = "Grupo de Administradores";
                Modelo.Seguridad.ObtenerInstancia().AddToGrupos(oGrupo);

                Grupo aGrupo = new Grupo();
                aGrupo.IDgrupo = "Invitado";
                aGrupo.Descripcion = "Grupo de Invitados";
                Modelo.Seguridad.ObtenerInstancia().AddToGrupos(aGrupo);


                Formulario oFormulario = new Formulario();
                oFormulario.IDformulario = "GestionGrupos";
                oFormulario.Descripcion = "Formulario de Gestion de Grupos";
                Modelo.Seguridad.ObtenerInstancia().AddToFormularios(oFormulario);

                Formulario aFormulario = new Formulario();
                aFormulario.IDformulario = "GestionPerfiles";
                aFormulario.Descripcion = "Formulario de Gestion de Perfiles";
                Modelo.Seguridad.ObtenerInstancia().AddToFormularios(aFormulario);

                Formulario cFormulario = new Formulario();
                cFormulario.IDformulario = "GestionUsuarios";
                cFormulario.Descripcion = "Formulario de Gestion de Usuarios";
                Modelo.Seguridad.ObtenerInstancia().AddToFormularios(cFormulario);

                Formulario dFormulario = new Formulario();
                dFormulario.IDformulario = "GestionGastos";
                dFormulario.Descripcion = "Formulario de Gestion de Gastos";
                Modelo.Seguridad.ObtenerInstancia().AddToFormularios(dFormulario);

                Formulario eFormulario = new Formulario();
                eFormulario.IDformulario = "GestionVehiculos";
                eFormulario.Descripcion = "Formulario de Gestion de Vehiculos";
                Modelo.Seguridad.ObtenerInstancia().AddToFormularios(eFormulario);

                Formulario fFormulario = new Formulario();
                fFormulario.IDformulario = "Monitor";
                fFormulario.Descripcion = "Formulario de Monitor";
                Modelo.Seguridad.ObtenerInstancia().AddToFormularios(fFormulario);

                Formulario gFormulario = new Formulario();
                gFormulario.IDformulario = "Informes";
                gFormulario.Descripcion = "Formulario de Informes";
                Modelo.Seguridad.ObtenerInstancia().AddToFormularios(gFormulario);

                Permiso oPermiso = new Permiso();
                oPermiso.IDpermiso = "ALTA";
                oPermiso.Descripcion = "Permisos de alta";
                Modelo.Seguridad.ObtenerInstancia().AddToPermisos(oPermiso);

                Permiso bPermiso = new Permiso();
                bPermiso.IDpermiso = "MODIFICACION";
                bPermiso.Descripcion = "Permisos de modificación";
                Modelo.Seguridad.ObtenerInstancia().AddToPermisos(bPermiso);

                Permiso aPermiso = new Permiso();
                aPermiso.IDpermiso = "BAJA";
                aPermiso.Descripcion = "Permisos de baja";
                Modelo.Seguridad.ObtenerInstancia().AddToPermisos(aPermiso);

                Permiso dPermiso = new Permiso();
                dPermiso.IDpermiso = "CONSULTA";
                dPermiso.Descripcion = "Permisos de consulta";
                Modelo.Seguridad.ObtenerInstancia().AddToPermisos(dPermiso);

                Permiso cPermiso = new Permiso();
                cPermiso.IDpermiso = "TOTAL";
                cPermiso.Descripcion = "Permisos totales sobre el formulario";
                Modelo.Seguridad.ObtenerInstancia().AddToPermisos(cPermiso);

                Usuario oUsuario = new Usuario();
                oUsuario.IDusuario = "admin";
                oUsuario.Contraseña = "admin";
                oUsuario.Email = "guillermo.cejas@admin.com";
                oUsuario.Activo = false;
                oUsuario.Habilitado = true;
                oUsuario.NombreApellido = "Guillermo Cejas";
                oUsuario.PrimerVez = false;
                oUsuario.Grupo.Add(oGrupo);
                oUsuario.Contraseña = oEncriptar.encriptar(oUsuario.Contraseña);

                Modelo.Seguridad.ObtenerInstancia().AddToUsuarios(oUsuario);
                Modelo.Seguridad.ObtenerInstancia().SaveChanges();
            }
        }

// ---- TEMPORAL FIN ---- //

        public void AgregarUsuario(Usuario oUsuario)
        {
            oUsuario.Contraseña = oEncriptar.encriptar(oUsuario.Contraseña);

            Modelo.Seguridad.ObtenerInstancia().AddToUsuarios(oUsuario);
            Modelo.Seguridad.ObtenerInstancia().SaveChanges();
        }
        
        public  void EliminarUsuario(Usuario oUsuario)
        {
            oUsuario.Grupo.Clear();
            //foreach (Grupo g in oUsuario.Grupo)
            //    g.Usuario.Remove(oUsuario);

                //foreach (Usuario u in g.Usuario)
                //    if (u.IDusuario == oUsuario.IDusuario)
                //    {
                //        g.Usuario.Remove(u);
                //    }

            Modelo.Seguridad.ObtenerInstancia().DeleteObject(oUsuario);
            Modelo.Seguridad.ObtenerInstancia().SaveChanges();
        }
        
        public void ModificarUsuario(Usuario oUsuario)
        {
            Modelo.Seguridad.ObtenerInstancia().Usuarios.ApplyCurrentValues(oUsuario);
            Modelo.Seguridad.ObtenerInstancia().SaveChanges();
        }

        public Usuario BuscarUsuario(string IDusuario)
        {
            Usuario user = Modelo.Seguridad.ObtenerInstancia().Usuarios.FirstOrDefault(oUsu => oUsu.IDusuario == IDusuario);
            if (user != null)
            {
                return user;
            }
            return null;
        }
        
        public  List<Usuario> ListarUsuarios()
        {
            return Modelo.Seguridad.ObtenerInstancia().Usuarios.ToList();
        }

        public  bool VerificarUsuario(Usuario oUsuario)
        {
            List<Usuario> Lista = Modelo.Seguridad.ObtenerInstancia().Usuarios.Where(oUsu => oUsu.IDusuario == oUsuario.IDusuario).ToList();

            if (Lista.Count > 0)
            {
                return false;
            }
            return true;
        }

        public  List<Usuario> ListarUsuariosFiltrados(string IDusuario, string NombApe, string Estado)
        {
            List<Usuario> Filtrado = Modelo.Seguridad.ObtenerInstancia().Usuarios.ToList();
            if (IDusuario != "")
                Filtrado = Filtrado.Where(oUsu => oUsu.IDusuario.Contains(IDusuario)).ToList();
            if (NombApe != "")
                Filtrado = Filtrado.Where(oUsu => oUsu.NombreApellido.Contains(NombApe)).ToList();
            if (Estado != "Todos")
            {
                if (Estado == "Habilitado")
                    Filtrado = Filtrado.Where(oUsu => oUsu.Habilitado == true).ToList();
                if (Estado == "Inhabilitado")
                    Filtrado = Filtrado.Where(oUsu => oUsu.Habilitado == false).ToList();
            }
                return Filtrado;
            
        }


        public void CambiarContraseña(Usuario oUsuario)
        {
            string nuevoPass = CrearRandomPassword(8);

            //try
            //{
                MailMessage correo = new MailMessage();
                correo.IsBodyHtml = true;
                correo.From = new MailAddress("trypep.sisflotaxis@gmail.com");
                correo.To.Add(oUsuario.Email.ToString());
                correo.Subject = "Nueva contraseña. Sistema Flota de Taxis";
                correo.Body = "<h2>SISTEMA GESTION FLOTA DE TAXIS</h2><br>"+oUsuario.NombreApellido.ToString() +",<br><br>Su nueva contraseña es " + nuevoPass + "<br><br><br> <center><font color='grey' size='2'><hr> <br> La información que contiene este email, incluidos sus archivos adjuntos, es confidencial, y sólo para conocimiento y uso de las personas a las cuales está dirigida. La Trypep Sistemas no se hace responsable de las alteraciones que pudiera sufrir el mensaje una vez enviado.Si por error recibe este correo, le rogamos aceptar nuestras disculpas y, al mismo tiempo, le solicitamos notificarlo a la persona que lo envió, abstenerse de divulgar su contenido y borrarlo de inmediato. <br> <b><i>TRYPEP SISTEMAS</i></b></font></center><br>";



                SmtpClient cliente = new SmtpClient("smtp.gmail.com");
                cliente.Port = 587;
                cliente.Credentials = new System.Net.NetworkCredential("trypep.sisflotaxis@gmail.com", "trypeptaxis");
                cliente.EnableSsl = true;
                cliente.Send(correo);

            //}
            //catch
            //{
            //    return;
            //}
            
            oUsuario.Contraseña = oEncriptar.encriptar(nuevoPass);
            oUsuario.PrimerVez = true;
            ModificarUsuario(oUsuario);

        }

        private static string CrearRandomPassword(int passwordLength)
        {
            string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@$?";
            char[] chars = new char[passwordLength];
            Random rd = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }

    }
}
