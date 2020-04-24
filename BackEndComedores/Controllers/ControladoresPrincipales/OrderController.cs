using BackEndComedores.Entidades;
using BackEndComedores.Logic;
using BackEndComedores.Models.ProcessModel;
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
    [RoutePrefix("api/Order")]
    public class OrderController : ApiController
    {

        [HttpGet]
        [Route("ProcessOrder")]
        public CostSummaryEntity ProcessOrder(long ID)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ProcessOrder(ID); ;

        }


        [HttpGet]
        [Route("DistanceMatrix")]
        public Object DistanceMatrix(string origin, string destination)
        {

            return Utils.Utils.getDistanceMatrix(origin, destination);

        }

    }
}
