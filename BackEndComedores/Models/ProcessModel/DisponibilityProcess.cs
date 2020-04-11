﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Models.ProcessModel
{
    public class DisponibilityProcess
    {
        public Nullable<long> IDProvider { get; set; }
        public long ID { get; set; }
        public Nullable<long> IDProduct { get; set; }
        public double Quantity { get; set; }
        public double UnitValue { get; set; }
        public double Cost { get; set; }
        public double ExpirationDays { get; set; }
        public double DurationValue { get; set; }
        public string DurationText { get; set; }
        public double DistanceValue { get; set; }
        public string DistanceText { get; set; }
        public string Effectiveness { get; set; }
    
    }
}