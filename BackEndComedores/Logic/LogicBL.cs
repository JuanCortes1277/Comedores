using BackEndComedores.DataACCESS;
using BackEndComedores.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace BackEndComedores.Logic
{
    public class LogicBL
    {
        public string InsertComedor(DiningRoom comedor)
        {
            ComedorBL comedorbl = new ComedorBL();
            return comedorbl.InsertarComedor(comedor);

        }
        public DiningRoom GetComedor(string code)
        {
            ComedorBL comedorbl = new ComedorBL();
            return comedorbl.GetComedor(code);


        }
        public DiningRoom GetComedorByID(long Id)
        {
            ComedorBL comedorbl = new ComedorBL();
            return comedorbl.GetComedorByID(Id);


        }

   
        public string UpdateDinner(DiningRoom comedor)
        {
            ComedorBL comedorbl = new ComedorBL();
            return comedorbl.UpdateDinner(comedor);


        }
        public string DeleteComedor(long code)
        {
            ComedorBL comedorbl = new ComedorBL();
            return comedorbl.Delete(code);


        }
        public List<DiningRoom> GettAllDinners()
        {
            ComedorBL comedorbl = new ComedorBL();
            return comedorbl.GettAllDinners();


        }
        public SystemUser LoginCredentialsJWT(string username, string password)
        {
            LoginBL loginbl = new LoginBL();
            return loginbl.LoginCredentialsJWT(username, password);


        }
        public Provider ExtractByIdProvider(long? id)
        {
            ProviderBL providerBL = new ProviderBL();
            return providerBL.ExtractById(id);
        }


        public string InsertProduct(Product comedor)
        {
            ProductBL ProductBL = new ProductBL();
            return ProductBL.InsertarProducto(comedor);

        }
        public Product GetProducto(string code)
        {
            ProductBL ProductBL = new ProductBL();
            return ProductBL.Get(code);


        }
        public Product GetProductoByID(long? code)
        {
            ProductBL ProductBL = new ProductBL();
            return ProductBL.GetByID(code);


        }

        

        public List<Product> GettAllProducts()
        {
            ProductBL ProductBL = new ProductBL();
            return ProductBL.GetAllProducts();


        }
        public string UpdateProduct(Product product)
        {
            ProductBL ProductBL = new ProductBL();
            return ProductBL.Modify(product);


        }
        public string DeleteProduct(long code)
        {
            ProductBL ProductBL = new ProductBL();
            return ProductBL.Delete(code);


        }

        public string InsertProvider(Provider provider)
        {
            ProviderBL providerBL = new ProviderBL();
            return providerBL.InsertProvider(provider);

        }
        public Provider Extractprovider(string Code)
        {
            ProviderBL providerBL = new ProviderBL();
            return providerBL.Extractprovider(Code);

        }
        public List<Provider> ExtractAllProviders()
        {
            ProviderBL providerBL = new ProviderBL();
            return providerBL.ExtractAllProviders();

        }
        public string ModifyProvider(Provider provider)
        {
            ProviderBL providerBL = new ProviderBL();
            return providerBL.ModifyProvider(provider);

        }
        public string DeleteProvider(string code)
        {
            ProviderBL providerBL = new ProviderBL();
            return providerBL.DeleteProvider(code);

        }



        public string InsertTransport(Transport transport)
        {
            TransportBL Transport = new TransportBL();
            return Transport.InsertTrasnport(transport);

        }
        public TransportReturnEntity ExtractTransport(string Code)
        {
            TransportBL transport = new TransportBL();

            Transport transportr = transport.ExtractTransport(Code);

            ProviderBL providerbl = new ProviderBL();
            Provider provider = new Provider();
            provider = providerbl.ExtractById(transportr.IDProvider);
            TransportReturnEntity transportret = new TransportReturnEntity();
            transportret.ID = transportr.ID;
            transportret.Code = transportr.Code;
            transportret.CarPlate = transportr.CarPlate;
            transportret.Brand = transportr.Brand;
            transportret.Year = transportr.Year;
            transportret.PersonInCharge = transportr.PersonInCharge;
            transportret.PhonePersonInCharge = transportr.PhonePersonInCharge;
            transportret.MailPersonInCharge = transportr.MailPersonInCharge;
            transportret.PaymentValue = transportr.PaymentValue;
            transportret.Availability = transportr.Availability;
            transportret.TransportType = transportr.TransportType;
            transportret.PaymentUnity = transportr.PaymentUnity;
            transportret.PaymentMeasurement = transportr.PaymentMeasurement;
            transportret.IDProvider = provider;


            return transportret;

        }
        public List<TransportReturnEntity> ExtractAllTransports()
        {
            ProviderBL providerbl = new ProviderBL();
            TransportBL transportBL = new TransportBL();
            List<Transport> transports = new List<Transport>();
            transports = transportBL.ExtractAllTransports();
            List<TransportReturnEntity> transportsRet = new List<TransportReturnEntity>();

            foreach (Transport t in transports)
            {
                Provider provider = new Provider();
                provider = providerbl.ExtractById(t.IDProvider);
                TransportReturnEntity transportret = new TransportReturnEntity();
                transportret.ID = t.ID;
                transportret.Code = t.Code;
                transportret.CarPlate = t.CarPlate;
                transportret.Brand = t.Brand;
                transportret.Year = t.Year;
                transportret.PersonInCharge = t.PersonInCharge;
                transportret.PhonePersonInCharge = t.PhonePersonInCharge;
                transportret.MailPersonInCharge = t.MailPersonInCharge;
                transportret.PaymentValue = t.PaymentValue;
                transportret.Availability = t.Availability;
                transportret.TransportType = t.TransportType;
                transportret.PaymentUnity = t.PaymentUnity;
                transportret.PaymentMeasurement = t.PaymentMeasurement;
                transportret.IDProvider = provider;
                transportsRet.Add(transportret);
            }
            return transportsRet;

        }
        public string ModifyTransport(Transport provider)
        {
            TransportBL transportBL = new TransportBL();
            return transportBL.ModifyTransport(provider);

        }
        public string DeleteTransport(string code)
        {
            TransportBL trasnport = new TransportBL();
            return trasnport.DeleteTransport(code);

        }



        public string InsertUser(SystemUser user)
        {
            SystemUserBL userBL = new SystemUserBL();
            return userBL.Insert(user);

        }
        public SystemUserReturnEntity GetUser(long Code)
        {
            SystemUserBL userBL = new SystemUserBL();
            ProviderBL providerbl = new ProviderBL();
            SystemUser systemu = userBL.GetByID(Code);
            Provider provider = new Provider();
            provider = providerbl.ExtractById(systemu.ProviderID);

            SystemUserReturnEntity systemReturn = new SystemUserReturnEntity();
            systemReturn.ID = systemu.ID;
            systemReturn.LastName = systemu.LastName;
            systemReturn.Name = systemu.Name;
            systemReturn.Username = systemu.Username;
            systemReturn.UserType = systemu.UserType;
            systemReturn.Provider = provider;







            return systemReturn;

        }
        public List<SystemUserReturnEntity> GetAllUsers()
        {
            List<SystemUserReturnEntity> sysreturn = new List<SystemUserReturnEntity>();
            SystemUserBL userBL = new SystemUserBL();
            ProviderBL providerbl = new ProviderBL();

            List<SystemUser> users = userBL.ExtractAll();
            foreach (SystemUser s in users)
            {

                SystemUserReturnEntity systemReturn = new SystemUserReturnEntity();
                systemReturn.ID = s.ID;
                systemReturn.LastName = s.LastName;
                systemReturn.Name = s.Name;
                systemReturn.Username = s.Username;

                systemReturn.Username = s.Username;
                systemReturn.UserType = s.UserType;
                Provider provider = new Provider();
                provider = providerbl.ExtractById(s.ProviderID);
                systemReturn.Provider = provider;

                sysreturn.Add(systemReturn);

            }
            return sysreturn;


        }
        public string UpdateUser(SystemUser provider)
        {
            SystemUserBL userBL = new SystemUserBL();
            return userBL.Update(provider);

        }
        public string DeleteUser(string code)
        {
            SystemUserBL userBL = new SystemUserBL();
            return userBL.Delete(code);

        }



        public string InsertRecipe(Recipe user)
        {
            RecipeBL userBL = new RecipeBL();
            return userBL.Insert(user);

        }
        public Recipe ExtractRecipe(string Code)
        {
            RecipeBL userBL = new RecipeBL();
            return userBL.Get(Code);

        }
        public List<Recipe> ExtractAllRecipes()
        {
            RecipeBL userBL = new RecipeBL();
            return userBL.GetAll();

        }
        public string ModifyRecipe(Recipe provider)
        {
            RecipeBL userBL = new RecipeBL();
            return userBL.Update(provider);

        }
        public string DeleteRecipe(string code)
        {
            RecipeBL userBL = new RecipeBL();
            return userBL.Delete(code);

        }










        public string InsertIngredient(Ingredient ingredient)
        {
            IngredientBL ingredientbl = new IngredientBL();
            return ingredientbl.Insert(ingredient);

        }
        public IngredientReturnEntity GetIngredient(long idproduct, long idrecipe)
        {
            IngredientBL ingredientbl = new IngredientBL();
            Ingredient ingredientr = ingredientbl.GetIngredient(idproduct, idrecipe);

            RecipeBL recipebl = new RecipeBL();
            Recipe reciper = recipebl.GetById(idrecipe);

            ProductBL productbl = new ProductBL();
            Product productr = productbl.ExtractById(idproduct);

            IngredientReturnEntity ingredientret = new IngredientReturnEntity();
            ingredientret.Id = ingredientr.Id;
            ingredientret.IDProduct = productr;
            ingredientret.IDRecipe = reciper;



            return ingredientret;

        }
        public List<IngredientReturnEntity> ExtractAllIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            IngredientBL ingredientbl = new IngredientBL();
             ingredients = ingredientbl.GetAll();
            RecipeBL recipebl = new RecipeBL();
            ProductBL productbl = new ProductBL();
            List<IngredientReturnEntity> ingredientsRet = new List<IngredientReturnEntity>();






            foreach (Ingredient i in ingredients)
            {
                IngredientReturnEntity ingredientret = new IngredientReturnEntity();

                Recipe reciper = new Recipe();
                reciper = recipebl.GetById(i.IDRecipe);
                Product productr = new Product();
                productr = productbl.ExtractById(i.IDProduct);
                ingredientret.Quantity = i.Quantity;
                ingredientret.IDProduct = productr;
                ingredientret.IDRecipe = reciper;
                ingredientret.Id = i.Id;
                ingredientsRet.Add(ingredientret);

            }

            return ingredientsRet;

       
        }
        public string ModifyIngredient(Ingredient ingredient)
        {
            IngredientBL userBL = new IngredientBL();
            return userBL.Modify(ingredient);

        }
        public string DeleteIngredient(long idproduct, long idrecipe)
        {
            IngredientBL ingredient = new IngredientBL();
            return ingredient.Delete(idproduct,idrecipe);

        }
        public CompleteRecipeReturnEntity GetAllIngredientsFromRecipe(string recipeCode)
        {
            IngredientDAL ingredientdal = new IngredientDAL();
            RecipeBL recipebl = new RecipeBL();

            Recipe recipe = recipebl.Get(recipeCode);

            CompleteRecipeReturnEntity complete = new CompleteRecipeReturnEntity();
            List<IngredientWithoutRecipeEntity> ingredientsinrecipe = new List<IngredientWithoutRecipeEntity>();
            List<Ingredient> ingredients = ingredientdal.GetAllFromRecipe(recipe.ID);
            ProductBL productBL = new ProductBL();
            foreach(Ingredient ingr in ingredients)
            {
                IngredientWithoutRecipeEntity ingredientresult = new IngredientWithoutRecipeEntity();
                Product product = productBL.ExtractById(ingr.IDProduct);
                Recipe recipe1 = recipebl.GetById(ingr.IDRecipe);

                ingredientresult.Id = ingr.Id;
                ingredientresult.IDProduct = product;
                ingredientresult.Quantity = ingr.Quantity;
                

                ingredientsinrecipe.Add(ingredientresult);


            }

            complete.ingrdients = ingredientsinrecipe;
            complete.ID = recipe.ID;
            complete.Name = recipe.Name;
            complete.Code = recipe.Code;
            return complete;


        }
    }
}