using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class ControladoraTurnos
    {
        private static volatile ControladoraTurnos instancia;

        private ControladoraTurnos()
        {
        }
        public static ControladoraTurnos getINSTANCIA
        {
            get
            {
                if (instancia == null) instancia = new ControladoraTurnos();
                return instancia;
            }
        }

        public void AgregarTurno(Modelo.Turno oTurno)
        {
            Modelo.Datos.ObtenerInstancia().AddToTurnos(oTurno);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public void EliminarTurno(Modelo.Turno oTurno)
        {
            Modelo.Datos.ObtenerInstancia().DeleteObject(oTurno);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public void ModificarTurno(Modelo.Turno oTurno)
        {
            Modelo.Datos.ObtenerInstancia().Turnos.ApplyCurrentValues(oTurno);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public List<Modelo.Turno> ListarTurnos()
        {
            return Modelo.Datos.ObtenerInstancia().Turnos.ToList();

        }

        //public List<Modelo.Turno> ListarTurnosFiltrados(string Id, Modelo.Vehiculo oVehiculoF, Modelo.TipodeTurno oTipodeTurnoF, string Monto, string Estado, string Descripcion, DateTime VenceDesde, DateTime VenceHasta)
        //{
        //    List<Modelo.Turno> Filtrado = Modelo.Datos.ObtenerInstancia().Turnos.ToList();
        //    if (Id.ToString() != "")
        //        Filtrado = Filtrado.Where(oTur => oTur.Id == Convert.ToInt32(Id)).ToList();
        //    if (oVehiculoF != null)
        //        Filtrado = Filtrado.Where(oTur => oTur.Vehiculo == oVehiculoF).ToList();
        //    if (oTipodeTurnoF != null)
        //        Filtrado = Filtrado.Where(oTur => oTur.TipodeTurno == oTipodeTurnoF).ToList();
        //    if (Monto.ToString() != "")
        //        Filtrado = Filtrado.Where(oTur => oTur.Monto == Convert.ToDecimal(Monto)).ToList();
        //    if (Estado != "")
        //        Filtrado = Filtrado.Where(oTur => oTur.Estado == Estado).ToList();
        //    if (Descripcion != "")
        //        Filtrado = Filtrado.Where(oTur => oTur.Descripcion.Contains(Descripcion)).ToList();
        //    if (VenceDesde.ToString() != null)
        //        Filtrado = Filtrado.Where(oTur => oTur.FechaVencimiento > VenceDesde).ToList();
        //    if (VenceHasta.ToString() != null)
        //        Filtrado = Filtrado.Where(oTur => oTur.FechaVencimiento < VenceHasta).ToList();
           
        //    return Filtrado;
        //}


    }
}
