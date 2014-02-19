using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo.SEGURIDAD;

namespace Controladora.SEGURIDAD
{
    public class ControladoraPermisos
    {
        public List<Permiso> ListarPermisos()
        {
            return Modelo.Seguridad.ObtenerInstancia().Permisos.OrderBy(c => c.IDpermiso).ToList();
        }
    }
}
