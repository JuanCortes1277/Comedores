using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.DataACCESS
{
    public class DisponibilityDAL
    {


        public string Insert(Disponibility disponibility)
        {
            int result;

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {
                    var repetido = context.Disponibility.SingleOrDefault(x => x.ID == disponibility.ID);
                    if (repetido == null)
                    {

                        var std = new Disponibility()
                        {
                            //                     public Nullable<long> IDProvider { get; set; }
                            //public long ID { get; set; }
                            //public Nullable<long> IDProduct { get; set; }
                            //public Nullable<int> Quantity { get; set; }
                            //public Nullable<decimal> UnitValue { get; set; }
                            //public Nullable<System.DateTime> ExpirationDate { get; set; }

                            //    ID = comedor.ID,
                            IDProduct = disponibility.IDProduct,
                            IDProvider = disponibility.IDProvider,
                            Quantity = disponibility.Quantity,
                            UnitValue = disponibility.UnitValue,
                            ExpirationDate = disponibility.ExpirationDate


                        };
                        context.Disponibility.Add(std);

                        result = context.SaveChanges();
                        if (result == 0)
                        {
                            return "no se ha podido ingresar el registro";
                        }
                        else return std.ID.ToString();
                    }
                    else
                    {
                        return "el registro ya se encuentra en la base de datos";
                    }
                }
            }
            catch (Exception e)
            {
                return e.Message;

            }

        }

        public Disponibility GetByID(long code)
        {

            using (var context = new ProyectoMaestriaEntities())
            {
                // Query for all blogs with names starting with B
                //var ComedorExtracted = from b in context.Comedor
                //            where b.ID.Equals(id)
                //            select b;
                var comedor = context.Disponibility.FirstOrDefault(x => x.ID == code);
                if (comedor != null)
                {
                    return new Disponibility
                    {
                        ID = comedor.ID,
                        IDProduct = comedor.IDProduct,
                        IDProvider = comedor.IDProvider,
                        Quantity = comedor.Quantity,
                        UnitValue = comedor.UnitValue,
                        ExpirationDate = comedor.ExpirationDate
                    };
                }
                else return null;
                //// Query for the Blog named ADO.NET Blog
                //var blog = context.Blogs
                //                .Where(b => b.Name == "ADO.NET Blog")
                //                .FirstOrDefault();




            }



        }


     
        public List<Disponibility> GetByProduct(long IDProduct)
        {
            List<Disponibility> results = new List<Disponibility>();

            using (var context = new ProyectoMaestriaEntities())
            {

                var result = context.Disponibility.Where(x => x.IDProduct == IDProduct);
                if (result != null)
                {

                    foreach (var temp in result)
                    {
                        Disponibility temp1 = new Disponibility();
                        temp1.ID = temp.ID;
                        temp1.IDProvider = temp.IDProvider;
                        temp1.IDProduct = temp.IDProduct;
                        temp1.Quantity = temp.Quantity;
                        temp1.UnitValue = temp.UnitValue;
                        temp1.ExpirationDate = temp.ExpirationDate;
                        results.Add(temp1);
                    }

                    return results;
                }
                else
                    return results;




            }
        }






        public string Update(Disponibility disponibility)
        {

            int modify = 0;
            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.Disponibility.SingleOrDefault(b => b.ID == disponibility.ID);
                    if (result != null)
                    {


                        result.IDProvider = disponibility.IDProvider;
                        result.Quantity = disponibility.Quantity;
                        result.UnitValue = disponibility.UnitValue;
                        result.IDProduct = disponibility.IDProduct;
                        result.ExpirationDate = disponibility.ExpirationDate;
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
        public string Delete(long code)
        {

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.Disponibility.SingleOrDefault(b => b.ID == code);
                    if (result != null)
                    {
                        context.Disponibility.Remove(result);
                        context.SaveChanges();
                        return "Registro eliminado satisfactroriamente";
                    }
                    else return "no se ha encontrado el registro a eliminar";



                }


            }

            catch (Exception e)
            {
                return e.Message;
            }


        }
        public List<Disponibility> GettAll()
        {
            List<Disponibility> results = new List<Disponibility>();

            using (var context = new ProyectoMaestriaEntities())
            {

                var result = context.Disponibility.ToList();


                if (result != null)
                {

                    foreach (var temp in result)
                    {
                        Disponibility temp1 = new Disponibility();
                        temp1.ID = temp.ID;
                        temp1.IDProvider = temp.IDProvider;
                        temp1.IDProduct = temp.IDProduct;
                        temp1.Quantity = temp.Quantity;
                        temp1.UnitValue = temp.UnitValue;
                        temp1.ExpirationDate = temp.ExpirationDate;
                        results.Add(temp1);
                    }

                    return results;
                }
                else
                    return results;




            }
        }
    }
}