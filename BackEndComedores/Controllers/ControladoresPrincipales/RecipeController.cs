using BackEndComedores.Entidades;
using BackEndComedores.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BackEndComedores.Controllers.ControladoresPrincipales
{
    [Authorize]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
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
        [Route("GetByCode")]
        public Recipe GetByCode(string code)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GetRecipeByCode(code);

        }
        [HttpGet]
        [Route("GetByID")]
        public Recipe GetByID(long ID)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GetRecipeByID(ID);

        }
        [HttpGet]
        [Route("GetAll")]
        public List<Recipe> GetAll()
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractAllRecipes();

        }
        [HttpPut]
        [Route("Update")]
        public string Update(Recipe transport)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ModifyRecipe(transport);

        }
        [HttpDelete]
        [Route("Delete")]
        public string Delete(long ID)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.DeleteRecipe(ID);

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
