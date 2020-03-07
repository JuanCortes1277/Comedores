using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Entidades
{
    public class CompleteRecipeReturnEntity
    {
        public long ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
       public  List<IngredientWithoutRecipeEntity> ingrdients;

    }
}