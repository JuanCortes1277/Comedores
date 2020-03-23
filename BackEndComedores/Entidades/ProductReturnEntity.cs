using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Entidades
{
    public class ProductReturnEntity
    {
        public long ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string Description { get; set; }
        public Nullable<int> Preservation { get; set; }
        public Nullable<int> MeasurementUnit { get; set; }
    }
}