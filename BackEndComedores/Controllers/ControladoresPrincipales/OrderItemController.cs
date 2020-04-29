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
    [RoutePrefix("api/OrderItem")]
    public class OrderItemController : ApiController
    {
        [HttpPost]
        [Route("InsertOrderItem")]
        public string InsertOrderItem(List<OrderItem> lstorderItem)
        {
            LogicBL orderItemDAL = new LogicBL();
            return orderItemDAL.InsertOrderItem(lstorderItem);
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
        public List<OrderReturnEntity> GetOrderItemByTransport(long Id, DateTime Date)
        {
            LogicBL orderItemDAL = new LogicBL();
            return orderItemDAL.GetOrderItemByTransport(Id,Date);
        }
        [HttpGet]
        [Route("GetOrderItemByProvider")]
        public List<OrderReturnEntity> GetOrderItemByProvider(long Id, DateTime Date)
        {
            LogicBL orderItemDAL = new LogicBL();
            return orderItemDAL.GetOrderItemByProvider(Id, Date);
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


        [HttpPost]
        [Route("ResponseProvider")]
        public string ResponseProviders(ResponseProvider response)
        {
            LogicBL orderItemDAL = new LogicBL();
            return orderItemDAL.ResponseProviders(response);


        }

        [HttpPost]
        [Route("ResponseTransport")]
        public string ResponseTransport(ResponseProvider response)
        {
            LogicBL orderItemDAL = new LogicBL();
            return orderItemDAL.ResponseTransport(response);


        }
    }
    }
