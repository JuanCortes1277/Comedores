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
        public Recipe Extract(string user)
        {
            RecipeDAL userdal = new RecipeDAL();
            return userdal.Extract(user);
        }
        public List<Recipe> ExtractAll()
        {
            RecipeDAL userdal = new RecipeDAL();
            return userdal.ExtractAll();
        }
        public string Modify(Recipe user)
        {
            RecipeDAL userdal = new RecipeDAL();


            return userdal.Modify(user);

        }
        public string Delete(string code)
        {
            RecipeDAL userdal = new RecipeDAL();


            return userdal.Delete(code);

        }

        public Recipe ExtractById(long? code)
        {
            RecipeDAL userdal = new RecipeDAL();
            return userdal.ExtractById(code);

        }

    }
}