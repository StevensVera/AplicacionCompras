//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicacionCompras.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleRequisicion
    {
        public int idDReq { get; set; }
        public Nullable<int> preRequisicion { get; set; }
        public string requisicion { get; set; }
        public Nullable<short> partida { get; set; }
        public Nullable<short> departamento { get; set; }
        public Nullable<int> material { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public string detalle { get; set; }
        public Nullable<int> ejercicio { get; set; }
        public Nullable<decimal> costoU { get; set; }
        public Nullable<decimal> costoTotal { get; set; }
        public Nullable<decimal> existencia { get; set; }
        public Nullable<System.DateTime> FechaUltimaEntrada { get; set; }
        public string descripcion { get; set; }
        public string uMedida { get; set; }
    
        public virtual Solicitud_Requisiciones Solicitud_Requisiciones { get; set; }
    }
}
