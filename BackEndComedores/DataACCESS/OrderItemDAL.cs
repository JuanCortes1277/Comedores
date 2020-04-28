using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.DataACCESS
{
    public class OrderItemDAL
    {
        public string InsertOrderItem(OrderItem orderItem)
        {
            int result;

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {


                    var std = new OrderItem()
                    {

                    //    ID = orderItem.ID;
                       IDPreOrder=orderItem.IDPreOrder,
                        IDProduct= orderItem.IDProduct,
                        IDProvider=orderItem.IDProvider,
                        IDTransport=orderItem.IDTransport,
                        Quantity=orderItem.Quantity,
                        UnitValue=orderItem.UnitValue,
                        ExpirationDays=orderItem.ExpirationDays,
                        Cost=orderItem.Cost,
                        DurationText=orderItem.DurationText,
                        DistanceText=orderItem.DistanceText,
                        CostTransport=orderItem.CostTransport,
                        Total=orderItem.Total,
                        AcceptedProvider=orderItem.AcceptedProvider,
                        AcceptedTransport=orderItem.AcceptedTransport,
                        TimeOrderItem=orderItem.TimeOrderItem
                      

                    };
                        context.OrderItem.Add(std);

                        result = context.SaveChanges();
                        if (result == 0)
                        {
                            return "no se ha podido ingresar el registro";
                        }
                        else return std.ID.ToString();
                    }
                 
                
            }
            catch (Exception e)
            {
                return e.Message;

            }

        }

        public OrderItem GetOrderItemById(long Id)
        {

            using (var context = new ProyectoMaestriaEntities())
            {
                // Query for all blogs with names starting with B
                //var ComedorExtracted = from b in context.Comedor
                //            where b.ID.Equals(id)
                //            select b;
                var orderItem = context.OrderItem.FirstOrDefault(x => x.ID == Id);
                if (orderItem != null)
                {
                    return new OrderItem
                    {
                        ID = orderItem.ID,
                        IDPreOrder = orderItem.IDPreOrder,
                        IDProduct = orderItem.IDProduct,
                        IDProvider = orderItem.IDProvider,
                        IDTransport = orderItem.IDTransport,
                        Quantity = orderItem.Quantity,
                        UnitValue = orderItem.UnitValue,
                        ExpirationDays = orderItem.ExpirationDays,
                        Cost = orderItem.Cost,
                        DurationText = orderItem.DurationText,
                        DistanceText = orderItem.DistanceText,
                        CostTransport = orderItem.CostTransport,
                        Total = orderItem.Total,
                        AcceptedProvider = orderItem.AcceptedProvider,
                        AcceptedTransport = orderItem.AcceptedTransport,
                        TimeOrderItem = orderItem.TimeOrderItem
                    };
                }
                else return null;
                //// Query for the Blog named ADO.NET Blog
                //var blog = context.Blogs
                //                .Where(b => b.Name == "ADO.NET Blog")
                //                .FirstOrDefault();




            }



        }

        public List<OrderItem> GetOrderItemByTransport(long Id)
        {

            List<OrderItem> diningRooms = new List<OrderItem>();

            using (var context = new ProyectoMaestriaEntities())
            {

                var result = context.OrderItem.Where(x => x.IDTransport == Id).ToList();


                if (result != null)
                {

                    foreach (var temp in result)
                    {

                        OrderItem orderitem = new OrderItem();
                        orderitem.ID = temp.ID;
                        orderitem.IDPreOrder = temp.IDPreOrder;
                        orderitem.IDProduct = temp.IDProduct;
                        orderitem.IDProvider = temp.IDProvider;
                        orderitem.IDTransport = temp.IDTransport;
                        orderitem.Quantity = temp.Quantity;
                        orderitem.UnitValue = temp.UnitValue;
                        orderitem.ExpirationDays = temp.ExpirationDays;
                        orderitem.Cost = temp.Cost;
                        orderitem.DurationText = temp.DurationText;
                        orderitem.DistanceText = temp.DistanceText;
                        orderitem.CostTransport = temp.CostTransport;
                        orderitem.Total = temp.Total;
                        orderitem.AcceptedProvider = temp.AcceptedProvider;
                        orderitem.AcceptedTransport = temp.AcceptedTransport;
                        orderitem.TimeOrderItem = temp.TimeOrderItem;
                        diningRooms.Add(orderitem);
                    }

                    return diningRooms;
                }
                else
                    return diningRooms;




            }



        }
        public List<OrderItem> GetOrderItemByProvider(long Id)
        {
            List<OrderItem> diningRooms = new List<OrderItem>();

            using (var context = new ProyectoMaestriaEntities())
            {

                var result = context.OrderItem.Where(x => x.IDProvider == Id).ToList();


                if (result != null)
                {

                    foreach (var temp in result)
                    {

                        OrderItem orderitem = new OrderItem();
                        orderitem.ID = temp.ID;
                        orderitem.IDPreOrder = temp.IDPreOrder;
                        orderitem.IDProduct = temp.IDProduct;
                        orderitem.IDProvider = temp.IDProvider;
                        orderitem.IDTransport = temp.IDTransport;
                        orderitem.Quantity = temp.Quantity;
                        orderitem.UnitValue = temp.UnitValue;
                        orderitem.ExpirationDays = temp.ExpirationDays;
                        orderitem.Cost = temp.Cost;
                        orderitem.DurationText = temp.DurationText;
                        orderitem.DistanceText = temp.DistanceText;
                        orderitem.CostTransport = temp.CostTransport;
                        orderitem.Total = temp.Total;
                        orderitem.AcceptedProvider = temp.AcceptedProvider;
                        orderitem.AcceptedTransport = temp.AcceptedTransport;
                        orderitem.TimeOrderItem = temp.TimeOrderItem;
                        diningRooms.Add(orderitem);
                    }

                    return diningRooms;
                }
                else
                    return diningRooms;




            }


        }
        public List<OrderItem> GetOrderItemByPreorder(long Id)
        {

            List<OrderItem> diningRooms = new List<OrderItem>();

            using (var context = new ProyectoMaestriaEntities())
            {

                var result = context.OrderItem.Where(x=>x.IDPreOrder==Id).ToList();


                if (result != null)
                {

                    foreach (var temp in result)
                    {

                        OrderItem orderitem = new OrderItem();
                        orderitem.ID = temp.ID;
                        orderitem.IDPreOrder = temp.IDPreOrder;
                        orderitem.IDProduct = temp.IDProduct;
                        orderitem.IDProvider = temp.IDProvider;
                        orderitem.IDTransport = temp.IDTransport;
                        orderitem.Quantity = temp.Quantity;
                        orderitem.UnitValue = temp.UnitValue;
                        orderitem.ExpirationDays = temp.ExpirationDays;
                        orderitem.Cost = temp.Cost;
                        orderitem.DurationText = temp.DurationText;
                        orderitem.DistanceText = temp.DistanceText;
                        orderitem.CostTransport = temp.CostTransport;
                        orderitem.Total = temp.Total;
                        orderitem.AcceptedProvider = temp.AcceptedProvider;
                        orderitem.AcceptedTransport = temp.AcceptedTransport;
                        orderitem.TimeOrderItem = temp.TimeOrderItem;
                        diningRooms.Add(orderitem);
                    }

                    return diningRooms;
                }
                else
                    return diningRooms;




            }


        }





        public string UpdateOrderItem(OrderItem orderItem)
        {

            int modify = 0;
            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.OrderItem.SingleOrDefault(b => b.ID == orderItem.ID);
                    if (result != null)
                    {

                        result.IDPreOrder = orderItem.IDPreOrder;
                        result.IDProduct = orderItem.IDProduct;
                        result.IDProvider = orderItem.IDProvider;
                        result.IDTransport = orderItem.IDTransport;
                        result.Quantity = orderItem.Quantity;
                        result.UnitValue = orderItem.UnitValue;
                        result.ExpirationDays = orderItem.ExpirationDays;
                        result.Cost = orderItem.Cost;
                        result.DurationText = orderItem.DurationText;
                        result.DistanceText = orderItem.DistanceText;
                        result.CostTransport = orderItem.CostTransport;
                        result.Total = orderItem.Total;
                        result.AcceptedProvider = orderItem.AcceptedProvider;
                        result.AcceptedTransport = orderItem.AcceptedTransport;
                        result.TimeOrderItem = orderItem.TimeOrderItem;


                        modify = context.SaveChanges();
                        if (modify == 0)
                        {
                            return "no se ha podido modificar el registro";
                        }
                        else
                        {
                            return "se ha modificado el registro satisfactoriamente";
                        }
                    }
                    else
                    {
                        return "no se ha encontrado coincidencia en la base de datos";

                    }

                }


            }

            catch (Exception e)
            {
                return e.Message;
            }


        }
        public string Delete(long Id)
        {

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.OrderItem.Where(x => x.IDPreOrder == Id).ToList();
                    if (result != null)
                    {
                        foreach (var temp in result)
                        {
                            context.OrderItem.Remove(temp);
                            context.SaveChanges();
                        }
                        return "Registro eliminado satisfactroriamente";

                    }
                    else return "no se ha encontrado el registro a eliminar";



                }
                return  "";


            }

            catch (Exception e)
            {
                return e.Message;
            }


        }
        public List<OrderItem> GettAllOrderItems()
        {
            List<OrderItem> diningRooms = new List<OrderItem>();

            using (var context = new ProyectoMaestriaEntities())
            {

                var result = context.OrderItem.ToList();


                if (result != null)
                {

                    foreach (var temp in result)
                    {

                        OrderItem orderitem = new OrderItem();
                        orderitem.ID = temp.ID;
                        orderitem.IDPreOrder = temp.IDPreOrder;
                        orderitem.IDProduct = temp.IDProduct;
                        orderitem.IDProvider = temp.IDProvider;
                        orderitem.IDTransport = temp.IDTransport;
                        orderitem.Quantity = temp.Quantity;
                        orderitem.UnitValue = temp.UnitValue;
                        orderitem.ExpirationDays = temp.ExpirationDays;
                        orderitem.Cost = temp.Cost;
                        orderitem.DurationText = temp.DurationText;
                        orderitem.DistanceText = temp.DistanceText;
                        orderitem.CostTransport = temp.CostTransport;
                        orderitem.Total = temp.Total;
                        orderitem.AcceptedProvider = temp.AcceptedProvider;
                        orderitem.AcceptedTransport = temp.AcceptedTransport;
                        orderitem.TimeOrderItem = temp.TimeOrderItem;
                        diningRooms.Add(orderitem);
                    }

                    return diningRooms;
                }
                else
                    return diningRooms;




            }


        }








    }


}

