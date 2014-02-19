﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace Modelo.AUDITORIA
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class SistFlota_Auditoria_ModeloContainer : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto SistFlota_Auditoria_ModeloContainer usando la cadena de conexión encontrada en la sección 'SistFlota_Auditoria_ModeloContainer' del archivo de configuración de la aplicación.
        /// </summary>
        public SistFlota_Auditoria_ModeloContainer() : base("name=SistFlota_Auditoria_ModeloContainer", "SistFlota_Auditoria_ModeloContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto SistFlota_Auditoria_ModeloContainer.
        /// </summary>
        public SistFlota_Auditoria_ModeloContainer(string connectionString) : base(connectionString, "SistFlota_Auditoria_ModeloContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto SistFlota_Auditoria_ModeloContainer.
        /// </summary>
        public SistFlota_Auditoria_ModeloContainer(EntityConnection connection) : base(connection, "SistFlota_Auditoria_ModeloContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<LoginLogout> LogInsOuts
        {
            get
            {
                if ((_LogInsOuts == null))
                {
                    _LogInsOuts = base.CreateObjectSet<LoginLogout>("LogInsOuts");
                }
                return _LogInsOuts;
            }
        }
        private ObjectSet<LoginLogout> _LogInsOuts;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<AudGastos> AudGastosSet
        {
            get
            {
                if ((_AudGastosSet == null))
                {
                    _AudGastosSet = base.CreateObjectSet<AudGastos>("AudGastosSet");
                }
                return _AudGastosSet;
            }
        }
        private ObjectSet<AudGastos> _AudGastosSet;

        #endregion
        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet LogInsOuts. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToLogInsOuts(LoginLogout loginLogout)
        {
            base.AddObject("LogInsOuts", loginLogout);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet AudGastosSet. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToAudGastosSet(AudGastos audGastos)
        {
            base.AddObject("AudGastosSet", audGastos);
        }

        #endregion
    }
    

    #endregion
    
    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SistFlota_Auditoria_Modelo", Name="AudGastos")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class AudGastos : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto AudGastos.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad Id.</param>
        /// <param name="idGasto">Valor inicial de la propiedad IdGasto.</param>
        /// <param name="descripcion">Valor inicial de la propiedad Descripcion.</param>
        /// <param name="monto">Valor inicial de la propiedad Monto.</param>
        /// <param name="estado">Valor inicial de la propiedad Estado.</param>
        /// <param name="fechaVencimiento">Valor inicial de la propiedad FechaVencimiento.</param>
        /// <param name="tipodeGasto">Valor inicial de la propiedad TipodeGasto.</param>
        /// <param name="vehiculo">Valor inicial de la propiedad Vehiculo.</param>
        /// <param name="usuario">Valor inicial de la propiedad Usuario.</param>
        /// <param name="fechayHora">Valor inicial de la propiedad FechayHora.</param>
        /// <param name="operacion">Valor inicial de la propiedad Operacion.</param>
        public static AudGastos CreateAudGastos(global::System.Int32 id, global::System.Int32 idGasto, global::System.String descripcion, global::System.Decimal monto, global::System.String estado, global::System.DateTime fechaVencimiento, global::System.Int32 tipodeGasto, global::System.String vehiculo, global::System.String usuario, global::System.DateTime fechayHora, global::System.String operacion)
        {
            AudGastos audGastos = new AudGastos();
            audGastos.Id = id;
            audGastos.IdGasto = idGasto;
            audGastos.Descripcion = descripcion;
            audGastos.Monto = monto;
            audGastos.Estado = estado;
            audGastos.FechaVencimiento = fechaVencimiento;
            audGastos.TipodeGasto = tipodeGasto;
            audGastos.Vehiculo = vehiculo;
            audGastos.Usuario = usuario;
            audGastos.FechayHora = fechayHora;
            audGastos.Operacion = operacion;
            return audGastos;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdGasto
        {
            get
            {
                return _IdGasto;
            }
            set
            {
                OnIdGastoChanging(value);
                ReportPropertyChanging("IdGasto");
                _IdGasto = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IdGasto");
                OnIdGastoChanged();
            }
        }
        private global::System.Int32 _IdGasto;
        partial void OnIdGastoChanging(global::System.Int32 value);
        partial void OnIdGastoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                OnDescripcionChanging(value);
                ReportPropertyChanging("Descripcion");
                _Descripcion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Descripcion");
                OnDescripcionChanged();
            }
        }
        private global::System.String _Descripcion;
        partial void OnDescripcionChanging(global::System.String value);
        partial void OnDescripcionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Monto
        {
            get
            {
                return _Monto;
            }
            set
            {
                OnMontoChanging(value);
                ReportPropertyChanging("Monto");
                _Monto = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Monto");
                OnMontoChanged();
            }
        }
        private global::System.Decimal _Monto;
        partial void OnMontoChanging(global::System.Decimal value);
        partial void OnMontoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Estado
        {
            get
            {
                return _Estado;
            }
            set
            {
                OnEstadoChanging(value);
                ReportPropertyChanging("Estado");
                _Estado = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Estado");
                OnEstadoChanged();
            }
        }
        private global::System.String _Estado;
        partial void OnEstadoChanging(global::System.String value);
        partial void OnEstadoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime FechaVencimiento
        {
            get
            {
                return _FechaVencimiento;
            }
            set
            {
                OnFechaVencimientoChanging(value);
                ReportPropertyChanging("FechaVencimiento");
                _FechaVencimiento = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FechaVencimiento");
                OnFechaVencimientoChanged();
            }
        }
        private global::System.DateTime _FechaVencimiento;
        partial void OnFechaVencimientoChanging(global::System.DateTime value);
        partial void OnFechaVencimientoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> HoraEmision
        {
            get
            {
                return _HoraEmision;
            }
            set
            {
                OnHoraEmisionChanging(value);
                ReportPropertyChanging("HoraEmision");
                _HoraEmision = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("HoraEmision");
                OnHoraEmisionChanged();
            }
        }
        private Nullable<global::System.DateTime> _HoraEmision;
        partial void OnHoraEmisionChanging(Nullable<global::System.DateTime> value);
        partial void OnHoraEmisionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> FechaEmision
        {
            get
            {
                return _FechaEmision;
            }
            set
            {
                OnFechaEmisionChanging(value);
                ReportPropertyChanging("FechaEmision");
                _FechaEmision = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FechaEmision");
                OnFechaEmisionChanged();
            }
        }
        private Nullable<global::System.DateTime> _FechaEmision;
        partial void OnFechaEmisionChanging(Nullable<global::System.DateTime> value);
        partial void OnFechaEmisionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TipodeGasto
        {
            get
            {
                return _TipodeGasto;
            }
            set
            {
                OnTipodeGastoChanging(value);
                ReportPropertyChanging("TipodeGasto");
                _TipodeGasto = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TipodeGasto");
                OnTipodeGastoChanged();
            }
        }
        private global::System.Int32 _TipodeGasto;
        partial void OnTipodeGastoChanging(global::System.Int32 value);
        partial void OnTipodeGastoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Vehiculo
        {
            get
            {
                return _Vehiculo;
            }
            set
            {
                OnVehiculoChanging(value);
                ReportPropertyChanging("Vehiculo");
                _Vehiculo = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Vehiculo");
                OnVehiculoChanged();
            }
        }
        private global::System.String _Vehiculo;
        partial void OnVehiculoChanging(global::System.String value);
        partial void OnVehiculoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Usuario
        {
            get
            {
                return _Usuario;
            }
            set
            {
                OnUsuarioChanging(value);
                ReportPropertyChanging("Usuario");
                _Usuario = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Usuario");
                OnUsuarioChanged();
            }
        }
        private global::System.String _Usuario;
        partial void OnUsuarioChanging(global::System.String value);
        partial void OnUsuarioChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime FechayHora
        {
            get
            {
                return _FechayHora;
            }
            set
            {
                OnFechayHoraChanging(value);
                ReportPropertyChanging("FechayHora");
                _FechayHora = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FechayHora");
                OnFechayHoraChanged();
            }
        }
        private global::System.DateTime _FechayHora;
        partial void OnFechayHoraChanging(global::System.DateTime value);
        partial void OnFechayHoraChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Operacion
        {
            get
            {
                return _Operacion;
            }
            set
            {
                OnOperacionChanging(value);
                ReportPropertyChanging("Operacion");
                _Operacion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Operacion");
                OnOperacionChanged();
            }
        }
        private global::System.String _Operacion;
        partial void OnOperacionChanging(global::System.String value);
        partial void OnOperacionChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SistFlota_Auditoria_Modelo", Name="LoginLogout")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class LoginLogout : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto LoginLogout.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad Id.</param>
        /// <param name="usuario">Valor inicial de la propiedad Usuario.</param>
        /// <param name="fechayHora">Valor inicial de la propiedad FechayHora.</param>
        /// <param name="operacion">Valor inicial de la propiedad Operacion.</param>
        public static LoginLogout CreateLoginLogout(global::System.Int32 id, global::System.String usuario, global::System.DateTime fechayHora, global::System.String operacion)
        {
            LoginLogout loginLogout = new LoginLogout();
            loginLogout.Id = id;
            loginLogout.Usuario = usuario;
            loginLogout.FechayHora = fechayHora;
            loginLogout.Operacion = operacion;
            return loginLogout;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Usuario
        {
            get
            {
                return _Usuario;
            }
            set
            {
                OnUsuarioChanging(value);
                ReportPropertyChanging("Usuario");
                _Usuario = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Usuario");
                OnUsuarioChanged();
            }
        }
        private global::System.String _Usuario;
        partial void OnUsuarioChanging(global::System.String value);
        partial void OnUsuarioChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime FechayHora
        {
            get
            {
                return _FechayHora;
            }
            set
            {
                OnFechayHoraChanging(value);
                ReportPropertyChanging("FechayHora");
                _FechayHora = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FechayHora");
                OnFechayHoraChanged();
            }
        }
        private global::System.DateTime _FechayHora;
        partial void OnFechayHoraChanging(global::System.DateTime value);
        partial void OnFechayHoraChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Operacion
        {
            get
            {
                return _Operacion;
            }
            set
            {
                OnOperacionChanging(value);
                ReportPropertyChanging("Operacion");
                _Operacion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Operacion");
                OnOperacionChanged();
            }
        }
        private global::System.String _Operacion;
        partial void OnOperacionChanging(global::System.String value);
        partial void OnOperacionChanged();

        #endregion
    
    }

    #endregion
    
}
