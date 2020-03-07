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

    [RoutePrefix("api/ingredient")]

    public class IngredientController : ApiController
    {
        [HttpPost]
        [Route("Insert")]
        public string Insert(Ingredient ingredient)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.InsertIngredient(ingredient);

        }
        [HttpGet]
        [Route("GetIngredient")]
        public IngredientReturnEntity GetIngredient(long idproduct,long idrecipe)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GetIngredient(idproduct,idrecipe);

        }
        [HttpGet]
        [Route("GetAll")]
        public List<IngredientReturnEntity> ExtractAll()
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractAllIngredients();

        }
        [HttpPut]
        [Route("Modify")]
        public string Modify(Ingredient ingredient)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ModifyIngredient(ingredient);

        }
        [HttpDelete]
        [Route("Delete")]
        public string Delete(long idproduct, long idrecipe)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.DeleteIngredient(idproduct,idrecipe);

        }
    }
}
