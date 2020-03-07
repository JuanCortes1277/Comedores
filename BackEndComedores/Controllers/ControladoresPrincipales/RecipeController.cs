using BackEndComedores.Entidades;
using BackEndComedores.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackEndComedores.Controllers.ControladoresPrincipales
{
    [Authorize]
    [RoutePrefix("api/recipe")]


    public class RecipeController : ApiController
    {
        [HttpPost]
        [Route("Insert")]
        public string Insert(Recipe transport)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.InsertRecipe(transport);

        }
        [HttpGet]
        [Route("Extract")]
        public Recipe Extract(string code)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractRecipe(code);

        }
        [HttpGet]
        [Route("ExtractAll")]
        public List<Recipe> ExtractAll()
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractAllRecipes();

        }
        [HttpPut]
        [Route("Modify")]
        public string Modify(Recipe transport)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ModifyRecipe(transport);

        }
        [HttpDelete]
        [Route("Delete")]
        public string Delete(string code)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.DeleteRecipe(code);

        }
        [HttpGet]
        [Route("GetAllIngredientsFromRecipe")]
        public CompleteRecipeReturnEntity GetAllIngredientsFromRecipe(string Recipecode)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GetAllIngredientsFromRecipe(Recipecode);

        }
    }
}
