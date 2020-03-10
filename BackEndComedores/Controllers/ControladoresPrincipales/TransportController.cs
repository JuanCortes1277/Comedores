using BackEndComedores.Entidades;
using BackEndComedores.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BackEndComedores.Controllers
{
    [Authorize]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
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
        [Route("GetByCode")]
        public TransportReturnEntity GetByCode(string code)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractTransport(code);

        }
        [HttpGet]
        [Route("GetByID")]
        public TransportReturnEntity GetByID(long ID)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractTransportByID(ID);

        }
        [HttpGet]
        [Route("GetAll")]
        public List<TransportReturnEntity> GetAll()
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractAllTransports();

        }
        [HttpPut]
        [Route("Update")]
        public string Update(Transport transport)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ModifyTransport(transport);

        }
        [HttpDelete]
        [Route("Delete")]
        public string Delete(long Id)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.DeleteTransport(Id);

        }
    }
}
