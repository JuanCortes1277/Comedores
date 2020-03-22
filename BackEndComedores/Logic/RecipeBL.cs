using BackEndComedores.DataACCESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Logic
{
    public class RecipeBL
    {
        public string Insert(Recipe user)
        {
            RecipeDAL userdal = new RecipeDAL();
            return userdal.Insertar(user);
        }
        public Recipe Get(string code)
        {
            RecipeDAL userdal = new RecipeDAL();
            return userdal.Get(code);
        }
        public Recipe GetByID(long  ID)
        {
            RecipeDAL userdal = new RecipeDAL();
            return userdal.GetByID(ID);
        }

        
        public List<Recipe> GetAll()
        {
            RecipeDAL userdal = new RecipeDAL();
            return userdal.GetAll();
        }

        public List<Recipe> GetRecomendedRecipes()
        {
            RecipeDAL userdal = new RecipeDAL();
            return userdal.GetRecomendedRecipes();
        }
        
        public string Update(Recipe user)
        {
            RecipeDAL userdal = new RecipeDAL();


            return userdal.Update(user);

        }
        public string Delete(long code)
        {
            RecipeDAL userdal = new RecipeDAL();


            return userdal.Delete(code);

        }

        public Recipe GetById(long? code)
        {
            RecipeDAL userdal = new RecipeDAL();
            return userdal.GetById(code);

        }

    }
}