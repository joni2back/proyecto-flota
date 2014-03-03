using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class ControladoraEmpresas
    {
        private static volatile ControladoraEmpresas instancia;

        private ControladoraEmpresas()
        {
        }
        public static ControladoraEmpresas getINSTANCIA
        {
            get
            {
                if (instancia == null) instancia = new ControladoraEmpresas();
                return instancia;
            }
        }

        public void AgregarEmpresa(Modelo.Empresa oEmpresa)
        {
            Modelo.Datos.ObtenerInstancia().AddToEmpresas(oEmpresa);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public void EliminarEmpresa(Modelo.Empresa oEmpresa)
        {
            Modelo.Datos.ObtenerInstancia().DeleteObject(oEmpresa);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public void ModificarEmpresa(Modelo.Empresa oEmpresa)
        {
            Modelo.Datos.ObtenerInstancia().Empresas.ApplyCurrentValues(oEmpresa);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public List<Modelo.Empresa> ListarEmpresas()
        {
            return Modelo.Datos.ObtenerInstancia().Empresas.ToList();

        }

        public bool VerificarEmpresa(Modelo.Empresa oEmpresa)
        {
            List<Modelo.Empresa> Lista = Modelo.Datos.ObtenerInstancia().Empresas.Where(oEmpr => oEmpr.CUIL == oEmpresa.CUIL).ToList();

            if (Lista.Count > 0)    
            {
                return false;
            }
            return true;
        }

       
      }
}
