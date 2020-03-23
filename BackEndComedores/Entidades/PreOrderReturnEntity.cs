using System;
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
    }
}