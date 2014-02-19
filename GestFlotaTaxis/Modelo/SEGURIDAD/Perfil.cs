using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.SEGURIDAD
{
    public partial class Perfil
    {
        public string IDgrupo
        {
            get
            {
                return this.Grupo.IDgrupo;
            }
        }

        public string IDpermiso
        {
            get
            {
                return this.Permiso.IDpermiso;
            }
        }

        public string IDformulario
        {
            get
            {
                return this.Formulario.IDformulario;
            }
        }
    }
}
