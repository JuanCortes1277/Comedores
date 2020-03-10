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
    [RoutePrefix("api/disponibility")]

    public class DisponibilityController : ApiController
    {
        [HttpPost]
        [Route("Insert")]
        public string Insert(Disponibility disponibility)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.InsertDisponibility(disponibility);

        }
       
        [HttpGet]
        [Route("GetById")]
        public DisponibilityReturnEntity GetById(long Id)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GetDisponibility(Id);

        }

        [HttpGet]
        [Route("GetAll")]
        public List<DisponibilityReturnEntity> GetAll()
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GetAllDisponibility();

        }
        [HttpPut]
        [Route("Update")]
        public string Update(Disponibility product)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.UpdateDisponibility(product);

        }
        [HttpDelete]
        [Route("Delete")]
        public string Delete(long Id)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.DeleteDisponibility(Id);

        }
    }
}
