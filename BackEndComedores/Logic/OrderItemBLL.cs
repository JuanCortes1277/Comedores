using BackEndComedores.DataACCESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Logic
{
    public class OrderItemBLL
    {
        public string InsertOrderItem(OrderItem orderItem)
        {
            OrderItemDAL orderItemDAL = new OrderItemDAL();
            return orderItemDAL.InsertOrderItem(orderItem);
        }
        public OrderItem GetOrderItemById(long Id)
        {
            OrderItemDAL orderItemDAL = new OrderItemDAL();
            return orderItemDAL.GetOrderItemById(Id);
        }
        public List<OrderItem> GetOrderItemByTransport(long Id)
        {
            OrderItemDAL orderItemDAL = new OrderItemDAL();
            return orderItemDAL.GetOrderItemByTransport(Id);
        }
        public List<OrderItem> GetOrderItemByProvider(long Id)
        {
            OrderItemDAL orderItemDAL = new OrderItemDAL();
            return orderItemDAL.GetOrderItemByProvider(Id);
        }
        public List<OrderItem> GetOrderItemByPreorder(long Id)
        {
            OrderItemDAL orderItemDAL = new OrderItemDAL();
            return orderItemDAL.GetOrderItemByPreorder(Id);
        }
        public string UpdateOrderItem(OrderItem orderItem)
        {
            OrderItemDAL orderItemDAL = new OrderItemDAL();
            return orderItemDAL.UpdateOrderItem(orderItem);
        }
        public string Delete(long Id)
        {

            OrderItemDAL orderItemDAL = new OrderItemDAL();
            return orderItemDAL.Delete(Id);
        }
        public List<OrderItem> GettAllOrderItems()
        {
            OrderItemDAL orderItemDAL = new OrderItemDAL();
            return orderItemDAL.GettAllOrderItems();
        }
        }
}