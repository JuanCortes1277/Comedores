using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.DataACCESS
{
    public class ProductDAL
    {
        public string InsertarProducto(Product product)
        {
            int result;

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {
                    var repetido = context.Product.SingleOrDefault(x => x.Code == product.Code);
                    if (repetido == null)
                    {

                        var std = new Product()
                        {

                            //    ID = comedor.ID,
                            Code = product.Code,
                            Name = product.Name,
                            Description = product.Description,
                            Preservation = product.Preservation,
                            MeasurementUnit = product.MeasurementUnit



                        };
                        context.Product.Add(std);

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
        public Product Get(string code)
        {

            using (var context = new ProyectoMaestriaEntities())
            {
             
                var product = context.Product.SingleOrDefault(x => x.Code == code);
                if (product != null)
                {
                    return new Product
                    {
                        ID= product.ID,
                        Code = product.Code,
                        Name = product.Name,
                        Description = product.Description,
                        Preservation = product.Preservation
                    };
                }
                else return null;
               
            }



        }
        public Product GetById(long? code)
        {

            using (var context = new ProyectoMaestriaEntities())
            {

                var product = context.Product.SingleOrDefault(x => x.ID == code);
                if (product != null)
                {
                    return new Product
                    {
                        ID = product.ID,
                        Code = product.Code,
                        Name = product.Name,
                        Description = product.Description,
                        Preservation = product.Preservation,
                                                MeasurementUnit = product.MeasurementUnit

                    };
                }
                else return null;

            }



        }
        public List<Product> GetAllProducts()
        {
            List<Product> Products = new List<Product>();

            using (var context = new ProyectoMaestriaEntities())
            {

                var result = context.Product.ToList();


                if (result != null)
                {

                    foreach (var temp in result)
                    {
                        Product product = new Product();
                        product.ID = temp.ID;
                        product.Code = temp.Code;
                        product.Name = temp.Name;
                        product.Description = temp.Description;
                        product.Preservation = temp.Preservation;
                        product.MeasurementUnit = temp.MeasurementUnit;
                      //  product.Disponibility = temp.Disponibility;

                        Products.Add(product);
                    }

                    return Products;
                }
                else
                    return Products;




            }


        }
        public string Update(Product producto)
        {

            int modify = 0;
            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.Product.SingleOrDefault(b => b.Code == producto.Code);
                    if (result != null)
                    {

                        result.Code = producto.Code;
                        result.Name = producto.Name;
                        result.Description = producto.Description;
                        result.Preservation = producto.Preservation;
                        result.MeasurementUnit = producto.MeasurementUnit;
                        //  result.Disponibility = producto.Disponibility;


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
        public string Delete(string code)
        {

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.Product.SingleOrDefault(b => b.Code == code);
                    if (result != null)
                    {
                        context.Product.Remove(result);
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






    }
}