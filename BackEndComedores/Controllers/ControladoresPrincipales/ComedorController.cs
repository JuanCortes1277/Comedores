using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BackEndComedores.Logic;

namespace BackEndComedores.Controllers
{
//   [Authorize]
    [RoutePrefix("api/comedor")]
    public class ComedorController : ApiController
    {
        // GET api/<controller>
  
        [HttpPost]
        [Route("Insert")]
        public string Insert(DiningRoom comedor)
        {
            LogicBL logicBL = new LogicBL(); 
            return logicBL.InsertComedor(comedor);

        }
        [HttpGet]
        [Route("Extract")]
        public DiningRoom Extract(string code)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractComedor(code);

        }
        [HttpGet]
        [Route("ExtractAll")]
        public List<DiningRoom> ExtractAll()
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractAllComedores();

        }
        [HttpPut]
        [Route("Modify")]
        public string Modify(DiningRoom comedor)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ModifyComedor(comedor);

        }
        [HttpDelete]
        [Route("Delete")]
        public string Delete(string code)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.DeleteComedor(code);

        }
        [HttpGet]
        [Route("ExtractAllDiners")]
        public List<DiningRoom> ExtractAllDiners()
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractAllComedores();

        }
    }
}