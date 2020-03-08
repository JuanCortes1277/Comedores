using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Entidades
{
    public class DisponibilityReturnEntity
    {

        public Provider IDProvider { get; set; }
        public long ID { get; set; }
        public Product IDProduct { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> UnitValue { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
    }
}