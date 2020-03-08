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
        public Ingredient GetIngredient(long idproduct,long Idrecipe)
        {
            IngredientDAL userdal = new IngredientDAL();
            return userdal.GetIngredient( idproduct,  Idrecipe);
        }

        public Ingredient GetIngredient(long ID)
        {
            IngredientDAL userdal = new IngredientDAL();
            return userdal.GetIngredient(ID);
        }
        public List<Ingredient> GetAll()
        {
            IngredientDAL userdal = new IngredientDAL();
            return userdal.GettAll();
        }
        public string Modify(Ingredient user)
        {
            IngredientDAL userdal = new IngredientDAL();


            return userdal.Update(user);

        }
        public string Delete(long idproduct, long Idrecipe)
        {
            IngredientDAL userdal = new IngredientDAL();


            return userdal.Delete(idproduct,Idrecipe);

        }
        public string Delete(long ID)
        {
            IngredientDAL userdal = new IngredientDAL();


            return userdal.Delete(ID);

        }
        public List<Ingredient> GetByRecipe( long Idrecipe)
        {
            IngredientDAL userdal = new IngredientDAL();


            return userdal.GetByRecipe( Idrecipe);

        }



        
        public List<Ingredient> ExtractAllFromRecipe(long IDRecipe)
        {
            IngredientDAL userdal = new IngredientDAL();


            return userdal.GetAllFromRecipe(IDRecipe);

        }

    }
}