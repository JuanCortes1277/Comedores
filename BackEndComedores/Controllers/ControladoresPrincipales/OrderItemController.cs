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
    //[Authorize]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/OrderItem")]
    public class OrderItemController : ApiController
    {
        [HttpPost]
        [Route("InsertOrderItem")]
        public string InsertOrderItem(OrderItem orderItem)
        {
            LogicBL orderItemDAL = new LogicBL();
            return orderItemDAL.InsertOrderItem(orderItem);
        }
        [HttpGet]
        [Route("GetOrderItemById")]
        public OrderItem GetOrderItemById(long Id)
        {
            LogicBL orderItemDAL = new LogicBL();
            return orderItemDAL.GetOrderItemById(Id);
        }
        [HttpGet]
        [Route("GetOrderItemByTransport")]
        public List<OrderItem> GetOrderItemByTransport(long Id)
        {
            LogicBL orderItemDAL = new LogicBL();
            return orderItemDAL.GetOrderItemByTransport(Id);
        }
        [HttpGet]
        [Route("GetOrderItemByProvider")]
        public List<OrderItem> GetOrderItemByProvider(long Id)
        {
            LogicBL orderItemDAL = new LogicBL();
            return orderItemDAL.GetOrderItemByProvider(Id);
        }
        [HttpGet]
        [Route("GetOrderItemByPreorder")]
        public List<OrderItem> GetOrderItemByPreorder(long Id)
        {
            LogicBL orderItemDAL = new LogicBL();
            return orderItemDAL.GetOrderItemByPreorder(Id);
        }
        [HttpPut]
        [Route("UpdateOrderItem")]
        public string UpdateOrderItem(OrderItem orderItem)
        {
            LogicBL orderItemDAL = new LogicBL();
            return orderItemDAL.UpdateOrderItem(orderItem);
        }
        [HttpDelete]
        [Route("Delete")]
        public string Delete(long Id)
        {

            LogicBL orderItemDAL = new LogicBL();
            return orderItemDAL.DeleteOrderItem(Id);
        }
        [HttpGet]
        [Route("getAllOrderItems")]
        public List<OrderItem> getAllOrderItems()
        {
            LogicBL orderItemDAL = new LogicBL();
            return orderItemDAL.GettAllOrderItems();
        }

    }
}
