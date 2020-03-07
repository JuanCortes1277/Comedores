using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Entidades
{
    public class IngredientReturnEntity
    {
        public long Id { get; set; }
        public Recipe IDRecipe { get; set; }
        public Product IDProduct { get; set; }
        public Nullable<int> Quantity { get; set; }
    }
}