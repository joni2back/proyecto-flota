using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo.SEGURIDAD;

namespace Controladora.SEGURIDAD
{
    public class ControladoraPerfiles
    {

        public  List<Perfil> ListarPerfiles()
        {
            return Modelo.Seguridad.ObtenerInstancia().Perfiles.ToList();
        }


        public  void AgregarPerfil(Perfil oPerfil)
        {
            Modelo.Seguridad.ObtenerInstancia().AddToPerfiles(oPerfil);
            Modelo.Seguridad.ObtenerInstancia().SaveChanges();

            //modAuPerfiles.Auditar(oPerfil);
        }

        public  void EliminarPerfil(Perfil oPerfil)
        {
            Modelo.Seguridad.ObtenerInstancia().DeleteObject(oPerfil);
            Modelo.Seguridad.ObtenerInstancia().SaveChanges();

            //modAuPerfiles.Auditar(oPerfil);
        }

        public  void ModificarPerfil(Perfil oPerfil)
        {
            Modelo.Seguridad.ObtenerInstancia().Perfiles.ApplyCurrentValues(oPerfil);
            Modelo.Seguridad.ObtenerInstancia().SaveChanges();
        }

        // ------------------------------------------ //

        //MODELO.Auditoría.AuditoriaPerfiles modAuPerfiles = new MODELO.Auditoría.AuditoriaPerfiles();

        public  List<Permiso> ObtenerPermisos(string IDform, Usuario oUsuario)
        {
            //return MODELO.Seguridad.CatálogoPerfiles.Instancia.ObtenerPermisos(IDform, oUsuario.Grupo);

            List<Permiso> permisos = new List<Permiso>();

            foreach (Grupo g in oUsuario.Grupo)
            {
              List<Perfil> ps = g.Perfil.ToList();
              foreach (Perfil p in ps)
              {
                  if (p.Formulario.IDformulario == IDform)
                  {
                      permisos.Add(p.Permiso);
                  }
              }
            }
            return permisos;
        }

        public List<Formulario> ObtenerPermisos(Usuario oUsuario)
        {
            //return MODELO.Seguridad.CatálogoPerfiles.Instancia.ObtenerPermisos(IDform, oUsuario.Grupo);

            List<Formulario> permisos = new List<Formulario>();

            foreach (Grupo g in oUsuario.Grupo)
            {
                List<Perfil> ps = g.Perfil.ToList();
                foreach (Perfil p in ps)
                {
                        permisos.Add(p.Formulario);
                }
            }
            return permisos;
        }



        public  bool VerificarPerfil(Perfil oPerfil)
        {
            List<Perfil> Lista = Modelo.Seguridad.ObtenerInstancia().Perfiles.Where(oGru => oGru.Permiso.IDpermiso == oPerfil.Permiso.IDpermiso && oGru.Grupo.IDgrupo == oPerfil.Grupo.IDgrupo && oGru.Formulario.IDformulario == oPerfil.Formulario.IDformulario).ToList();
            if (Lista.Count > 0)
            {
                return false;
            }
            return true;
        }



        public  List<Perfil> FiltrarPerfiles(string GRUPO, string PERMISO, string FORM)
        {
            List<Perfil> Filtrado = Modelo.Seguridad.ObtenerInstancia().Perfiles.ToList();
            if (GRUPO != null)
                Filtrado = Filtrado.Where(oPer => oPer.Grupo.IDgrupo.Contains(GRUPO)).ToList();
            if (PERMISO != null)
                Filtrado = Filtrado.Where(oPer => oPer.Permiso.IDpermiso.Contains(PERMISO)).ToList();
            if (FORM != null)
                Filtrado = Filtrado.Where(oPer => oPer.Formulario.IDformulario.Contains(FORM)).ToList();
 

            return Filtrado;

        }

        //public List<ENTIDADES.Seguridad.Grupo> LlenarComboGrupos2()
        //{
        //    return MODELO.Seguridad.CatálogoGrupos.Instancia.ListarGrupos();
        //}

        //public List<ENTIDADES.Seguridad.Formulario> LlenarComboFormularios2()
        //{
        //    return MODELO.Seguridad.CatálogoFormularios.Instancia.ListarFormularios();

        //}

        //public List<ENTIDADES.Seguridad.Permiso> LlenarComboPermisos2()
        //{
        //    return MODELO.Seguridad.CatálogoPermisos.Instancia.ListarPermisos();
        //}


    }
}
