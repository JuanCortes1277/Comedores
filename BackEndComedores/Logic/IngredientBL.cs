using BackEndComedores.DataACCESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Logic
{
    public class IngredientBL
    {
        public string Insert(Ingredient user)
        {
            IngredientDAL userdal = new IngredientDAL();
            return userdal.Insertar(user);
        }
        public Ingredient Extract(long idproduct,long Idrecipe)
        {
            IngredientDAL userdal = new IngredientDAL();
            return userdal.Extract( idproduct,  Idrecipe);
        }
        public List<Ingredient> ExtractAll()
        {
            IngredientDAL userdal = new IngredientDAL();
            return userdal.ExtractAll();
        }
        public string Modify(Ingredient user)
        {
            IngredientDAL userdal = new IngredientDAL();


            return userdal.Modify(user);

        }
        public string Delete(long idproduct, long Idrecipe)
        {
            IngredientDAL userdal = new IngredientDAL();


            return userdal.Delete(idproduct,Idrecipe);

        }
        public List<Ingredient> ExtractAllFromRecipe(long IDRecipe)
        {
            IngredientDAL userdal = new IngredientDAL();


            return userdal.ExtractAllFromRecipe(IDRecipe);

        }

    }
}