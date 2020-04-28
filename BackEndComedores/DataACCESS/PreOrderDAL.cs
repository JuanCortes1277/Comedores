using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.DataACCESS
{
    public class PreOrderDAL
    {
        public List<PreOrder> GettAll()
        {
            List<PreOrder> preOrders = new List<PreOrder>();

            using (var context = new ProyectoMaestriaEntities())
            {

                var result = context.PreOrder.ToList();


                if (result != null)
                {

                    foreach (var temp in result)
                    {
                        PreOrder preorder = new PreOrder();
                        preorder.ID = temp.ID;
                        preorder.IDDiningRoom = temp.IDDiningRoom;
                        preorder.IDRecipe = temp.IDRecipe;
                        preorder.PreOrderDate = temp.PreOrderDate;
                        preorder.Accepted = temp.Accepted;

                        preOrders.Add(preorder);
                    }

                    return preOrders;
                }
                else
                    return preOrders;




            }


        }
        public PreOrder GetById(long ID)
        {

            using (var context = new ProyectoMaestriaEntities())
            {
                //var comedor = context.DiningRoom.SingleOrDefault(x => x.ID == id);

                var result = context.PreOrder.SingleOrDefault(x => x.ID == ID);


                if (result != null)
                {

                  
                        PreOrder preorder = new PreOrder();
                        preorder.ID = result.ID;
                        preorder.IDDiningRoom = result.IDDiningRoom;
                        preorder.IDRecipe = result.IDRecipe;
                        preorder.PreOrderDate = result.PreOrderDate;
                        preorder.Accepted = result.Accepted;

                    

                    return preorder;
                }
                else
                    return null;




            }


        }
        public List<PreOrder> GetByDinningRoom(long ID)
        {
            List<PreOrder> preOrders = new List<PreOrder>();

            using (var context = new ProyectoMaestriaEntities())
            {
                //var comedor = context.DiningRoom.SingleOrDefault(x => x.ID == id);

                var result = context.PreOrder.Where(x => x.IDDiningRoom == ID);


                if (result != null)
                {

                    foreach (var temp in result)
                    {
                        PreOrder preorder = new PreOrder();
                        preorder.ID = temp.ID;
                        preorder.IDDiningRoom = temp.IDDiningRoom;
                        preorder.IDRecipe = temp.IDRecipe;
                        preorder.PreOrderDate = temp.PreOrderDate;
                        preorder.Accepted = temp.Accepted;

                        preOrders.Add(preorder);
                    }

                    return preOrders;
                }
                else
                    return preOrders;


            }



        }
        public List<PreOrder> GetPreorderByDate(DateTime ID)
        {
            List<PreOrder> preOrders = new List<PreOrder>();

            using (var context = new ProyectoMaestriaEntities())
            {
                //var comedor = context.DiningRoom.SingleOrDefault(x => x.ID == id);

                var result = context.PreOrder.Where(x => x.PreOrderDate == ID && x.Accepted != false);


                if (result != null)
                {

                    foreach (var temp in result)
                    {
                        PreOrder preorder = new PreOrder();
                        preorder.ID = temp.ID;
                        preorder.IDDiningRoom = temp.IDDiningRoom;
                        preorder.IDRecipe = temp.IDRecipe;
                        preorder.PreOrderDate = temp.PreOrderDate;
                        preorder.Accepted = temp.Accepted;

                        preOrders.Add(preorder);
                    }

                    return preOrders;
                }
                else
                    return preOrders;


            }



        }

        public string InsertarPreorder(PreOrder preorder)
        {
            int result;

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {
                  
                    if(preorder.PreOrderDate==null )
                    {
                        preorder.PreOrderDate = DateTime.Now;
                    }

                        var std = new PreOrder()
                        {
                            IDDiningRoom=preorder.IDDiningRoom,
                            IDRecipe= preorder.IDRecipe,
                            PreOrderDate=preorder.PreOrderDate,
                            Accepted=preorder.Accepted
                            
                            

                         

                        };
                        context.PreOrder.Add(std);

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

        public string UpdatePreorder(PreOrder preorder)
        {

            int modify = 0;
            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.PreOrder.SingleOrDefault(b => b.ID == preorder.ID);
                    if (result != null)
                    {

                        result.IDDiningRoom = preorder.IDDiningRoom;
                        result.IDRecipe = preorder.IDRecipe;
                        result.PreOrderDate = preorder.PreOrderDate;
                        result.Accepted = preorder.Accepted;
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



    }
}