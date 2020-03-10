using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.DataACCESS
{
    public class IngredientDAL
    {
        public string Insertar(Ingredient ingredient)
        {
            int result;

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {
                    var repetido = context.Ingredient.SingleOrDefault(x => x.IDProduct == ingredient.IDProduct && x.IDRecipe==ingredient.IDRecipe);
                    if (repetido == null)
                    {

                        var std = new Ingredient()
                        {
                            //public long ID { get; set; }
                            //       public string Username { get; set; }
                            //       public string Password { get; set; }
                            //       public string Name { get; set; }
                            //       public string LastName { get; set; }
                            //       public string UserType { get; set; }
                            //                    //       public Nullable<long> ProviderID { get; set; }
                            //              public Nullable<long> IDRecipe { get; set; }
                            //public Nullable<long> IDProduct { get; set; }
                            //public Nullable<int> Quantity { get; set; }
                            IDRecipe = ingredient.IDRecipe,
                            IDProduct= ingredient.IDProduct,
                            Quantity=ingredient.Quantity
                        };
    
                        context.Ingredient.Add(std);

                        result = context.SaveChanges();
                        if (result == 0)
                        {
                            return "no se ha podido ingresar el registro";
                        }
                        else return std.Id.ToString();
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

        public Ingredient GetIngredient(long IDProduct, long IDRecipe)
        {

            using (var context = new ProyectoMaestriaEntities())
            {
                // Query for all blogs with names starting with B
                //var ComedorExtracted = from b in context.Comedor
                //            where b.ID.Equals(id)
                //            select b;
                var repetido = context.Ingredient.SingleOrDefault(x => x.IDProduct == IDProduct && x.IDRecipe == IDRecipe);
                if (repetido != null)
                {
                    return new Ingredient
                    {
                        Id=repetido.Id,
                        IDRecipe = repetido.IDRecipe,
                        IDProduct = repetido.IDProduct,
                        Quantity = repetido.Quantity
                    };
                }
                else return null;
                //// Query for the Blog named ADO.NET Blog
                //var blog = context.Blogs
                //                .Where(b => b.Name == "ADO.NET Blog")
                //                .FirstOrDefault();




            }



        }
        public Ingredient GetIngredient(long ID)
        {

            using (var context = new ProyectoMaestriaEntities())
            {
                // Query for all blogs with names starting with B
                //var ComedorExtracted = from b in context.Comedor
                //            where b.ID.Equals(id)
                //            select b;
                var repetido = context.Ingredient.SingleOrDefault(x => x.Id == ID);
                if (repetido != null)
                {
                    return new Ingredient
                    {
                        Id = repetido.Id,
                        IDRecipe = repetido.IDRecipe,
                        IDProduct = repetido.IDProduct,
                        Quantity = repetido.Quantity
                    };
                }
                else return null;
                //// Query for the Blog named ADO.NET Blog
                //var blog = context.Blogs
                //                .Where(b => b.Name == "ADO.NET Blog")
                //                .FirstOrDefault();




            }



        }


        public List<Ingredient> GetAllFromRecipe( long IDRecipe)
        {

            using (var context = new ProyectoMaestriaEntities())
            {
                // Query for all blogs with names starting with B
                //var ComedorExtracted = from b in context.Comedor
                //            where b.ID.Equals(id)

                //            select b;
                List<Ingredient> ingredientsret = new List<Ingredient>();
                var repetido = context.Ingredient.Where(x =>  x.IDRecipe == IDRecipe);
                if (repetido != null)
                {
                    foreach(Ingredient  i in repetido)
                    {
                        Ingredient ingredient = new Ingredient();
                        ingredient.Id = i.Id;
                        ingredient.IDRecipe = i.IDRecipe;
                        ingredient.IDProduct = i.IDProduct;
                        ingredient.Quantity = i.Quantity;
                        ingredientsret.Add(ingredient);

                    }
                    return ingredientsret;
                  
                }
                else return null;
                //// Query for the Blog named ADO.NET Blog
                //var blog = context.Blogs
                //                .Where(b => b.Name == "ADO.NET Blog")
                //                .FirstOrDefault();




            }



        }
        public List<Ingredient> GetByRecipe( long IDRecipe)
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            using (var context = new ProyectoMaestriaEntities())
            {
                // Query for all blogs with names starting with B
                //var ComedorExtracted = from b in context.Comedor
                //            where b.ID.Equals(id)
                //            select b;
                var repetido = context.Ingredient.Where(x => x.IDRecipe == IDRecipe);
                foreach (Ingredient ing in repetido)
                {
                    Ingredient ingr = new Ingredient();
                    ingr.Id = ing.Id;
                    ingr.IDRecipe = ing.IDRecipe;
                    ingr.IDProduct = ing.IDProduct;
                    ingr.Quantity = ing.Quantity;

                    ingredients.Add(ingr);

                }
            }



            return ingredients;



            



        }

        


        public string Update(Ingredient ingredient)
        {

            int modify = 0;
            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.Ingredient.SingleOrDefault(x => x.IDProduct == ingredient.IDProduct && x.IDRecipe == ingredient.IDRecipe);
                    if (result != null)
                    {
                        //public long ID { get; set; }
                        //       public string Username { get; set; }
                        //       public string Password { get; set; }
                        //       public string Name { get; set; }
                        //       public string LastName { get; set; }
                        //       public string UserType { get; set; }
                        //       public Nullable<long> ProviderID { get; set; }
                        result.IDProduct = ingredient.IDProduct;
                        result.IDRecipe = ingredient.IDRecipe;

                        result.Quantity = ingredient.Quantity;
                      



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
        public string Delete(long IDProduct,long IDRecipe)
        {

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.Ingredient.SingleOrDefault(x => x.IDProduct == IDProduct && x.IDRecipe == IDRecipe);
                    if (result != null)
                    {
                        context.Ingredient.Remove(result);
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


        public string Delete(long ID)
        {

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.Ingredient.SingleOrDefault(x => x.Id == ID);
                    if (result != null)
                    {
                        context.Ingredient.Remove(result);
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

        public List<Ingredient> GettAll()
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            using (var context = new ProyectoMaestriaEntities())
            {

                var result = context.Ingredient.ToList();


                if (result != null)
                {

                    foreach (var temp in result)
                    {
                        //result.Password = systemuser.Password;
                        //result.Name = systemuser.Name;
                        //result.LastName = systemuser.LastName;
                        //result.UserType = systemuser.UserType;
                        //result.ProviderID = systemuser.ProviderID;
                        Ingredient ingredient = new Ingredient();
                        ingredient.Id = temp.Id;
                        ingredient.IDProduct = temp.IDProduct;

                        ingredient.IDRecipe = temp.IDRecipe;
                        ingredient.Quantity = temp.Quantity;
                      

                        ingredients.Add(ingredient);
                    }

                    return ingredients;
                }
                else
                    return ingredients;




            }


        }

    }
}