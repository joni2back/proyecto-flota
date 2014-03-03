using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class ControladoraClientes
    {
        private static volatile ControladoraClientes instancia;

        private ControladoraClientes()
        {
        }
        public static ControladoraClientes getINSTANCIA
        {
            get
            {
                if (instancia == null) instancia = new ControladoraClientes();
                return instancia;
            }
        }

        public void AgregarCliente(Modelo.Cliente oCliente)
        {
            Modelo.Datos.ObtenerInstancia().AddToClientes(oCliente);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public void EliminarCliente(Modelo.Cliente oCliente)
        {
            Modelo.Datos.ObtenerInstancia().DeleteObject(oCliente);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public void ModificarCliente(Modelo.Cliente oCliente)
        {
            Modelo.Datos.ObtenerInstancia().Clientes.ApplyCurrentValues(oCliente);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public List<Modelo.Cliente> ListarClientes()
        {
            return Modelo.Datos.ObtenerInstancia().Clientes.ToList();

        }

        /*public bool VerificarCliente(Modelo.Cliente oCliente)
        {
            List<Modelo.Cliente> Lista = Modelo.Datos.ObtenerInstancia().Empresa.Where(oClie => oClie.CUIL == oCliente.CUIL).ToList();

            if (Lista.Count > 0)    
            {
                return false;
            }
            return true;
        }*/

        /*public bool VerificarCuil(Modelo.Empresa oEmpresa)
        {
            List<Modelo.Empresa> Lista = Modelo.Datos.ObtenerInstancia().Empresa.Where(oEmpr => oEmpr.CUIL == oEmpresa.CUIL).ToList();

            if (Lista.Count > 0)
            {
                return false;
            }
            return true;
        }*/



      }
}
