using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.DataACCESS
{
    public class PreOrerItemDAL
    {
        public List<PreOrderItem> GetByOrder(long Preorder)
        {
            List<PreOrderItem> ingredients = new List<PreOrderItem>();

            using (var context = new ProyectoMaestriaEntities())
            {
                // Query for all blogs with names starting with B
                //var ComedorExtracted = from b in context.Comedor
                //            where b.ID.Equals(id)
                //            select b;
                var repetido = context.PreOrderItem.Where(x => x.IDPreOrder == Preorder);
                foreach (PreOrderItem ing in repetido)
                {
                    PreOrderItem ingr = new PreOrderItem();
                    ingr.ID = ing.ID;
                    ingr.IDPreOrder = ing.IDPreOrder;
                    ingr.IDProduct = ing.IDProduct;
                    ingr.Quantity = ing.Quantity;

                    ingredients.Add(ingr);

                }
                return ingredients;
            }
        }
        public string InsertList(List<PreOrderItem> items)
        {
            int result=0;

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {
                    foreach (PreOrderItem poi in items)
                    {


                        var std = new PreOrderItem
                        {
                            //  ID=poi.ID,
                            IDProduct = poi.IDProduct,
                            IDPreOrder = poi.IDPreOrder,
                            Quantity = poi.Quantity

                        };
                        context.PreOrderItem.Add(std);

                        result = context.SaveChanges();
                        if (result == 0)
                        {
                            return "no se ha podido ingresar el registro";
                        }
                        else result=int.Parse( std.ID.ToString());

                    }

                    return result.ToString();
                    
                }
            }
            catch (Exception e)
            {
                return e.Message;

            }


        }

    }

      




    
}