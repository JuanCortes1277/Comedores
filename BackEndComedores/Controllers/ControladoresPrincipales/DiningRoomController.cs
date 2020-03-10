using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BackEndComedores.Logic;

namespace BackEndComedores.Controllers
{
 [Authorize]
    [RoutePrefix("api/DiningRoom")]
    public class DiningRoomController : ApiController
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
        [Route("GetByCode")]
        public DiningRoom GetByCode(string code)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GetComedor(code);

        }
        [HttpGet]
        [Route("GetByID")]
        public DiningRoom GetByID(long ID)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GetComedorByID(ID);

        }
     
        [HttpPut]
        [Route("Update")]
        public string Update(DiningRoom comedor)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.UpdateDinner(comedor);

        }
        [HttpDelete]
        [Route("Delete")]
        public string Delete(long ID)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.DeleteComedor(ID);

        }
        [HttpGet]
        [Route("GetAll")]
        public List<DiningRoom> GetAll()
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GettAllDinners();

        }
    }
}