using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.DataACCESS
{
    public class RecipeDAL
    {
        public string Insertar(Recipe recipe)
        {
            int result;

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {
                    var repetido = context.Recipe.SingleOrDefault(x => x.Code == recipe.Code);
                    if (repetido == null)
                    {

                        var std = new Recipe()
                        {

                            //    ID = comedor.ID,
                            Code = recipe.Code,
                            Name = recipe.Name




                        };
                        context.Recipe.Add(std);

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
        public Recipe Extract(string code)
        {

            using (var context = new ProyectoMaestriaEntities())
            {

                var product = context.Recipe.SingleOrDefault(x => x.Code == code);
                if (product != null)
                {
                    return new Recipe
                    {
                        ID = product.ID,
                        Code = product.Code,
                        Name = product.Name

                    };
                }
                else return null;

            }



        }

        public Recipe ExtractById(long? code)
        {

            using (var context = new ProyectoMaestriaEntities())
            {

                var product = context.Recipe.SingleOrDefault(x => x.ID == code);
                if (product != null)
                {
                    return new Recipe
                    {
                        ID = product.ID,
                        Code = product.Code,
                        Name = product.Name

                    };
                }
                else return null;

            }



        }
        public List<Recipe> ExtractAll()
        {
            List<Recipe> Products = new List<Recipe>();

            using (var context = new ProyectoMaestriaEntities())
            {

                var result = context.Recipe.ToList();


                if (result != null)
                {

                    foreach (var temp in result)
                    {
                        Recipe product = new Recipe();
                        product.ID = temp.ID;
                        product.Code = temp.Code;
                        product.Name = temp.Name;

                        //  product.Disponibility = temp.Disponibility;

                        Products.Add(product);
                    }

                    return Products;
                }
                else
                    return Products;




            }


        }
        public string Modify(Recipe producto)
        {

            int modify = 0;
            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.Recipe.SingleOrDefault(b => b.Code == producto.Code);
                    if (result != null)
                    {

                        result.Code = producto.Code;
                        result.Name = producto.Name;

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

                    var result = context.Recipe.SingleOrDefault(b => b.Code == code);
                    if (result != null)
                    {
                        context.Recipe.Remove(result);
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