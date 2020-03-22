using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Entidades
{
    public class RecipeProductModelEntity
    {
        public long ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Preservation { get; set; }
        public Nullable<int> MeasurementUnit { get; set; }
        public Nullable <int> disponibility { get; set; }

    }
}