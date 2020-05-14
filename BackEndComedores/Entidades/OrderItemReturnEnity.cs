using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Entidades
{
    public class OrderItemReturnEnity
    {
        public long ID { get; set; }
        public Nullable<long> IDPreOrder { get; set; }
        public Nullable<long> IDProduct { get; set; }
        public string Code { get; set; }
        public string NameProduct { get; set; }
        public Nullable<long> IDProvider { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> UnitValue { get; set; }
        public Nullable<decimal> ExpirationDays { get; set; }
        public Nullable<int> UnitMeasure { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public string DurationText { get; set; }
        public string DistanceText { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string NameProv { get; set; }
         public Nullable<long> IDTransport { get; set; }
        public Nullable<decimal> CostTransport { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<bool> AcceptedProvider { get; set; }
        public Nullable<bool> AcceptedTransport { get; set; }
        public Nullable<System.TimeSpan> TimeOrderItem { get; set; }
        public string CarPlate { get; set; }
    }
}