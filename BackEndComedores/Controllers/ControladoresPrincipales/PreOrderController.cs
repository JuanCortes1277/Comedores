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
[RoutePrefix("api/Preorder")]
public class PreOrderController : ApiController
    {
        // GET: api/PreOrder
        [HttpGet]
        [Route("GetPreorderByDinningRoom")]
        public List<PreOrderReturnEntity> GetPreorderByDinningRoom(long IdDinner)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GetPreorderByDinningRoom(IdDinner);

        }
        [HttpGet]
        [Route("GetAll")]
        public List<PreOrderReturnEntity> GetAll()
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GetAllPreOrders();

        }
        [HttpGet]
        [Route("GetByID")]
        public PreOrderReturnEntity GetByID(long Id)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GetPreorderByD( Id);

        }
        [HttpGet]
        [Route("GetByDate")]
        public List<PreOrderReturnEntity> GetByDate(DateTime Date)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GetPreOrderByDate(Date);

        }
        [HttpPost]
        [Route("Insert")]
        public string Insert(PreOrderReturnEntity preorder)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.insertPreoRder(preorder);

        }
    }
}
