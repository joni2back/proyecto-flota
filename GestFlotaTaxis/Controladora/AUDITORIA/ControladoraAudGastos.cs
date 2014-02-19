using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo.SEGURIDAD;
using Modelo.AUDITORIA;

namespace Controladora.AUDITORIA
{
    public class ControladoraAudGastos
    {
        public void AuditarGastosMOD(Modelo.AUDITORIA.AudGastos oGastoAUDI)
        {
            //AudGastos oGastoAUDI = new AudGastos();

            //oGastoAUDI.IdGasto = oGasto.Id;
            //oGastoAUDI.Descripcion = oGasto.Descripcion;
            //oGastoAUDI.Monto = oGasto.Monto;
            //oGastoAUDI.Estado = oGasto.Estado;
            //oGastoAUDI.FechaVencimiento = oGasto.FechaVencimiento;
            //oGastoAUDI.HoraEmision = oGasto.HoraEmision;
            //oGastoAUDI.FechaEmision = oGasto.FechaEmision;
            //oGastoAUDI.TipodeGasto = oGasto.TipodeGasto.Id;
            //oGastoAUDI.Vehiculo = oGasto.Vehiculo.Patente;
            //oGastoAUDI.Usuario = oGasto.Usuario;
            //oGastoAUDI.FechayHora = oGasto.FechayHora;
            //oGastoAUDI.Operacion = oGasto.Operacion;

            Modelo.Auditoria.ObtenerInstancia().AddToAudGastosSet(oGastoAUDI);
            Modelo.Auditoria.ObtenerInstancia().SaveChanges();


        }

        public void AuditarGastosBAJA(Modelo.Gasto oGasto)
        {
            AudGastos oGastoAUDI = new AudGastos();

            oGastoAUDI.IdGasto = oGasto.Id;
            oGastoAUDI.Descripcion = oGasto.Descripcion;
            oGastoAUDI.Monto = oGasto.Monto;
            oGastoAUDI.Estado = oGasto.Estado;
            oGastoAUDI.FechaVencimiento = oGasto.FechaVencimiento;
            oGastoAUDI.HoraEmision = oGasto.HoraEmision;
            oGastoAUDI.FechaEmision = oGasto.FechaEmision;
            oGastoAUDI.TipodeGasto = oGasto.TipodeGasto.Id;
            oGastoAUDI.Vehiculo = oGasto.Vehiculo.Patente;
            oGastoAUDI.Usuario = oGasto.Usuario;
            oGastoAUDI.FechayHora = oGasto.FechayHora;
            oGastoAUDI.Operacion = oGasto.Operacion;

            Modelo.Auditoria.ObtenerInstancia().AddToAudGastosSet(oGastoAUDI);
            Modelo.Auditoria.ObtenerInstancia().SaveChanges();

            AudGastos oGastoAUDIBaja = new AudGastos();

            oGastoAUDIBaja.IdGasto = oGastoAUDI.IdGasto;
            oGastoAUDIBaja.Descripcion = oGastoAUDI.Descripcion;
            oGastoAUDIBaja.Monto = oGastoAUDI.Monto;
            oGastoAUDIBaja.Estado = oGastoAUDI.Estado;
            oGastoAUDIBaja.FechaVencimiento = oGastoAUDI.FechaVencimiento;
            oGastoAUDIBaja.HoraEmision = oGastoAUDI.HoraEmision;
            oGastoAUDIBaja.FechaEmision = oGastoAUDI.FechaEmision;
            oGastoAUDIBaja.TipodeGasto = oGastoAUDI.TipodeGasto;
            oGastoAUDIBaja.Vehiculo = oGastoAUDI.Vehiculo;
            oGastoAUDIBaja.Usuario = oGastoAUDI.Usuario;
            oGastoAUDIBaja.FechayHora = oGastoAUDI.FechayHora;
            oGastoAUDIBaja.Operacion = "BAJA";

            Modelo.Auditoria.ObtenerInstancia().AddToAudGastosSet(oGastoAUDIBaja);
            Modelo.Auditoria.ObtenerInstancia().SaveChanges();




        }


        public List<AudGastos> ListarGastos()
        {
            return Modelo.Auditoria.ObtenerInstancia().AudGastosSet.ToList();
        }


        public List<AudGastos> FiltrarAudGastos(string User, DateTime Fecha, string Operacion)
        {
            List<AudGastos> Filtrado = Modelo.Auditoria.ObtenerInstancia().AudGastosSet.ToList();
             if (User != "")
                Filtrado = Filtrado.Where(oLog => oLog.Usuario.Contains(User)).ToList();
            //if (Fecha != null)
            Filtrado = Filtrado.Where(oLog => oLog.FechayHora.Date == Fecha.Date).ToList();
            if (Operacion != null)
                if (Operacion != "Todos")
                    Filtrado = Filtrado.Where(oLog => oLog.Operacion.Contains(Operacion)).ToList();


            return Filtrado;

        }

    }
}
