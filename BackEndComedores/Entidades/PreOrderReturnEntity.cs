﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Entidades
{
    public class PreOrderReturnEntity
    {
        public long ID { get; set; }
        public Nullable<long> IDDiningRoom { get; set; }
        public Nullable<long> IDRecipe { get; set; }
        public List<ProductReturnEntity> IDProduct;
        public Nullable<System.DateTime> PreOrderDate { get; set; }
        public Nullable<bool> Accepted { get; set; }
        public Nullable <double> NumKids { get; set; }
    }

    public class OrderReturnEntity
    {
        public long ID { get; set; }
        public Nullable<long> IDDiningRoom { get; set; }
        public Nullable<long> IDRecipe { get; set; }
        public List<OrderItemReturnEnity> IDProduct;
        public Nullable<System.DateTime> PreOrderDate { get; set; }
        public Nullable<bool> Accepted { get; set; }
        public Nullable<double> NumKids { get; set; }
    }
}