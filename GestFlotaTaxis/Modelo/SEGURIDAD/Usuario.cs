using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.SEGURIDAD
{
    public partial class Usuario
    {
        public string estaHabilitado
        {
            get
            {
                if (this.Habilitado == true)
                    return "SI";
                else
                    return "NO";
            }
        }

        public void AgregaGrupo(Grupo oGrupo)
        {
            this.Grupo.Add(oGrupo);
        }
    }
}
