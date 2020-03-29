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
    [AllowAnonymous]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Order")]
    public class OrderController : ApiController
    {

        [HttpPost]
        [Route("ProcessOrder")]
        public PreOrderReturnEntity ProcessOrder(long ID)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ProcessOrder(ID); ;

        }
        
    }
}
