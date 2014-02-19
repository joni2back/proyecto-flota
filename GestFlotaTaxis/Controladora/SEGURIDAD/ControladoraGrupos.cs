using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo.SEGURIDAD;

namespace Controladora.SEGURIDAD
{
    public class ControladoraGrupos
    {

        public  List<Grupo> ListarGrupos()
        {
            return Modelo.Seguridad.ObtenerInstancia().Grupos.OrderBy(c => c.IDgrupo).ToList();
        }


        public  void AgregarGrupo(Grupo oGrupo)
        {
            Modelo.Seguridad.ObtenerInstancia().AddToGrupos(oGrupo);
            Modelo.Seguridad.ObtenerInstancia().SaveChanges();
        }

        public  void EliminarGrupo(Grupo oGrupo)
        {
            oGrupo.Usuario.Clear();
            while (oGrupo.Perfil.Count > 0)
            {
                Modelo.Seguridad.ObtenerInstancia().DeleteObject(oGrupo.Perfil.FirstOrDefault());
            }

            Modelo.Seguridad.ObtenerInstancia().DeleteObject(oGrupo);
            Modelo.Seguridad.ObtenerInstancia().SaveChanges();
        }

        public  void ModificarGrupo(Grupo oGrupo)
        {
            Modelo.Seguridad.ObtenerInstancia().Grupos.ApplyCurrentValues(oGrupo);
            Modelo.Seguridad.ObtenerInstancia().SaveChanges();
        }

        public  bool VerificarGrupo(Grupo oGrupo)
        {
            List<Grupo> Lista = Modelo.Seguridad.ObtenerInstancia().Grupos.Where(oGru => oGru.IDgrupo == oGrupo.IDgrupo).ToList();
            if (Lista.Count > 0)
            {
                return false;
            }
            return true;
        }

        public  List<Grupo> ListarGruposFiltrados(string IDgrupo)
        {
            return Modelo.Seguridad.ObtenerInstancia().Grupos.Where(oGru => oGru.IDgrupo.Contains(IDgrupo)).OrderBy(c => c.IDgrupo).ToList();
        }


    }
}
