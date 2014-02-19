using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo.SEGURIDAD;

namespace Controladora.SEGURIDAD
{
    public class ControladoraFormularios
    {
        public List<Formulario> ListarFormularios()
        {
            return Modelo.Seguridad.ObtenerInstancia().Formularios.OrderBy(c => c.IDformulario).ToList();
        }
    }
}
