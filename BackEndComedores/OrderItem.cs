//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackEndComedores
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderItem
    {
        public long ID { get; set; }
        public Nullable<long> IDPreOrder { get; set; }
        public Nullable<long> IDProduct { get; set; }
        public Nullable<long> IDProvider { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> UnitValue { get; set; }
        public Nullable<decimal> ExpirationDays { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public string DurationText { get; set; }
        public string DistanceText { get; set; }
        public Nullable<long> IDTransport { get; set; }
        public Nullable<decimal> CostTransport { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<bool> AcceptedProvider { get; set; }
        public Nullable<bool> AcceptedTransport { get; set; }
        public Nullable<System.TimeSpan> TimeOrderItem { get; set; }
    }
}
