using BackEndComedores.Models.ProcessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Entidades
{
    public class CostSummaryEntity
    {
        public double? TotalCost { get; set; }
        public List<DisponibilityProcess>DisponibilityProcesses{get;set;}
    }

    public class CostSummaryRejectedEntity
    {
        public double? TotalCost { get; set; }
        public List<OrderItem> DisponibilityProcesses { get; set; }
    }
}