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
        public Recipe Get(string code)
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

        public Recipe GetByID(long code)
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

        

        public Recipe GetById(long? code)
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
        public List<Recipe> GetAll()
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
        public List<Recipe> GetRecomendedRecipes(int countChildren)
        {
            List<Recipe> recipes = new List<Recipe>();

            using (var context = new ProyectoMaestriaEntities())
            {

               var result =(
               from R in context.Recipe
               join I in context.Ingredient on R.ID equals I.IDRecipe
               join D in context.Disponibility on I.IDProduct equals D.IDProduct
               where D.Quantity >= countChildren
               group R by new { R.Code, R.ID, R.Name } into g
               select new
               {
                ID = g.Key.ID,
                Code = g.Key.Code,
                Name= g.Key.Name,

             

            }).ToList();
  



                if (result != null)
                {

                    foreach (var temp in result)
                    {
                        Recipe recipe = new Recipe();
                        recipe.ID = temp.ID;
                        recipe.Code = temp.Code;
                        recipe.Name = temp.Name;
                        recipes.Add(recipe);
                    }

                    return recipes;
                }
                else
                    return recipes;




            }



        }
        public string Update(Recipe producto)
        {

            int modify = 0;
            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.Recipe.SingleOrDefault(b => b.ID == producto.ID);
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
        public string Delete(long code)
        {

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.Recipe.SingleOrDefault(b => b.ID == code);
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