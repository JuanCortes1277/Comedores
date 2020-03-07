using BackEndComedores.Entidades;
using BackEndComedores.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackEndComedores.Controllers
{
    [Authorize]
    [RoutePrefix("api/transport")]


    public class TransportController : ApiController
    {
        // GET: api/Transport
        [HttpPost]
        [Route("Insert")]
        public string Insert(Transport transport)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.InsertTransport(transport);

        }
        [HttpGet]
        [Route("Extract")]
        public TransportReturnEntity Extract(string code)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractTransport(code);

        }
        [HttpGet]
        [Route("ExtractAll")]
        public List<TransportReturnEntity> ExtractAll()
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractAllTransports();

        }
        [HttpPut]
        [Route("Modify")]
        public string Modify(Transport transport)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ModifyTransport(transport);

        }
        [HttpDelete]
        [Route("Delete")]
        public string Delete(string code)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.DeleteTransport(code);

        }
    }
}
