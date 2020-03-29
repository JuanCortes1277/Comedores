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
        public List<RecipeProductModelEntity> GetRecomendedProducts()
        {
            ProductBL ProductBL = new ProductBL();
            return ProductBL.GetRecomendedProducts();
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
        public Provider ExtractproviderByID(long Code)
        {
            ProviderBL providerBL = new ProviderBL();
            return providerBL.ExtractproviderByID(Code);

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
        public string DeleteProvider(long code)
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
        public TransportReturnEntity ExtractTransportByID(long Code)
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
        public string DeleteTransport(long code)
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
        public string DeleteUser(long code)
        {
            SystemUserBL userBL = new SystemUserBL();
            return userBL.Delete(code);

        }



        public string InsertRecipe(Recipe user)
        {
            RecipeBL userBL = new RecipeBL();
            return userBL.Insert(user);

        }
        public Recipe GetRecipeByCode(string Code)
        {
            RecipeBL userBL = new RecipeBL();
            return userBL.Get(Code);

        }
        public Recipe GetRecipeByID(long Code)
        {
            RecipeBL userBL = new RecipeBL();
            return userBL.GetByID(Code);

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
        public string DeleteRecipe(long code)
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
        public IngredientReturnEntity GetIngredient(long ID)
        {
            IngredientBL ingredientbl = new IngredientBL();
            Ingredient ingredientr = ingredientbl.GetIngredient(ID);

            RecipeBL recipebl = new RecipeBL();
            Recipe reciper = recipebl.GetById(ingredientr.IDRecipe);

            ProductBL productbl = new ProductBL();
            Product productr = productbl.ExtractById(ingredientr.IDProduct);

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
            return ingredient.Delete(idproduct, idrecipe);

        }
        public string DeleteIngredient(long ID)
        {
            IngredientBL ingredient = new IngredientBL();
            return ingredient.Delete(ID);

        }

        public List<Ingredient> GetByRecipe(long idrecipe)
        {
            IngredientBL ingredient = new IngredientBL();
            return ingredient.GetByRecipe(idrecipe);

        }
        public CompleteRecipeReturnEntity GetAllIngredientsFromRecipe(string recipeCode)
        {
            IngredientBL ingredientdal = new IngredientBL();
            RecipeBL recipebl = new RecipeBL();

            Recipe recipe = recipebl.Get(recipeCode);

            CompleteRecipeReturnEntity complete = new CompleteRecipeReturnEntity();
            List<IngredientWithoutRecipeEntity> ingredientsinrecipe = new List<IngredientWithoutRecipeEntity>();
            List<Ingredient> ingredients = ingredientdal.GetByRecipe(recipe.ID);
            ProductBL productBL = new ProductBL();
            foreach (Ingredient ingr in ingredients)
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
        public List<Recipe> GetRecomendedRecipes()
        {
            RecipeBL userBL = new RecipeBL();
            return userBL.GetRecomendedRecipes();

        }




        public string InsertDisponibility(Disponibility user)
        {
            DisponibilityBL disponibilityBL = new DisponibilityBL();
            return disponibilityBL.Insert(user);

        }
        public DisponibilityReturnEntity GetDisponibility(long Code)
        {
            DisponibilityBL userBL = new DisponibilityBL();
            ProviderBL providerbl = new ProviderBL();
            Disponibility systemu = userBL.GetByID(Code);
            Provider provider = new Provider();
            provider = providerbl.ExtractById(systemu.IDProvider);
            Product product = new Product();
            ProductBL productBL = new ProductBL();
            product = productBL.ExtractById(systemu.IDProduct);



            //     public Nullable<long> IDProvider { get; set; }
            //public long ID { get; set; }
            //public Nullable<long> IDProduct { get; set; }
            //public Nullable<int> Quantity { get; set; }
            //public Nullable<decimal> UnitValue { get; set; }
            //public Nullable<System.DateTime> ExpirationDate { get; set; }

            DisponibilityReturnEntity dis = new DisponibilityReturnEntity();
            dis.ID = systemu.ID;
            dis.IDProduct = product;
            dis.IDProvider = provider;
            dis.Quantity = systemu.Quantity;
            dis.UnitValue = systemu.UnitValue;








            return dis;

        }
        public List<DisponibilityReturnEntity> GetAllDisponibility()
        {
            List<DisponibilityReturnEntity> sysreturn = new List<DisponibilityReturnEntity>();
            DisponibilityBL disponibilityBL = new DisponibilityBL();
            ProviderBL providerbl = new ProviderBL();
            ProductBL productBL = new ProductBL();

            List<Disponibility> users = disponibilityBL.GettAll();
            foreach (Disponibility s in users)
            {

                DisponibilityReturnEntity dis = new DisponibilityReturnEntity();
                Provider provider = new Provider();
                provider = providerbl.ExtractById(s.IDProvider);
                Product product = new Product();
                product = productBL.GetByID(s.IDProduct);

                dis.ID = s.ID;
                dis.IDProduct = product;
                dis.IDProvider = provider;
                dis.Quantity = s.Quantity;
                dis.UnitValue = s.UnitValue;
                dis.ExpirationDate = s.ExpirationDate;




                sysreturn.Add(dis);

            }
            return sysreturn;


        }
        public string UpdateDisponibility(Disponibility provider)
        {
            DisponibilityBL userBL = new DisponibilityBL();
            return userBL.Update(provider);

        }
        public string DeleteDisponibility(long code)
        {
            DisponibilityBL userBL = new DisponibilityBL();
            return userBL.Delete(code);

        }



        public List<PreOrderReturnEntity> GetPreorderByDinningRoom(long ID)
        {
            PreOrderBL preorderdal = new PreOrderBL();
            List<PreOrder> preorders = preorderdal.GetByDinningRoom(ID);
            List<PreOrderReturnEntity> preordersforeturn = new List<PreOrderReturnEntity>();
            ProductBL productbl = new ProductBL();
            //RecipeBL recipebl = new RecipeBL();
            PreOrderItemBL ingredientBL = new PreOrderItemBL();

            foreach (PreOrder pre in preorders)
            {
                long id = pre.ID;
                // long id =long.Parse( pre.IDRecipe);
                List<PreOrderItem> ingredients = ingredientBL.GetByOrder(id);
                List<ProductReturnEntity> products = new List<ProductReturnEntity>();

                foreach (PreOrderItem ing in ingredients)
                {
                    Product product = productbl.GetByID(ing.IDProduct);
                    ProductReturnEntity pr = new ProductReturnEntity();
                    pr.ID = product.ID;
                    pr.MeasurementUnit = product.MeasurementUnit;
                    pr.Name = product.Name;
                    pr.Code = product.Code;
                    pr.Preservation = product.Preservation;
                    pr.Quantity = ing.Quantity;
                    pr.Description = product.Description;
                    products.Add(pr);
                }
                PreOrderReturnEntity preordernew = new PreOrderReturnEntity();
                preordernew.ID = pre.ID;
                preordernew.IDDiningRoom = pre.IDDiningRoom;
                preordernew.IDRecipe = pre.IDRecipe;
                preordernew.PreOrderDate = pre.PreOrderDate;
                preordernew.Accepted = pre.Accepted;
                

                preordernew.IDProduct = products;
                preordersforeturn.Add(preordernew);

            }
            return preordersforeturn;
        }
 



        public PreOrderReturnEntity GetPreorderByD(long ID)
        {
            PreOrderBL preorderdal = new PreOrderBL();
            PreOrder preorders = preorderdal.GetById(ID);
            List<PreOrderReturnEntity> preordersforeturn = new List<PreOrderReturnEntity>();
            ProductBL productbl = new ProductBL();
            //RecipeBL recipebl = new RecipeBL();
            PreOrderItemBL ingredientBL = new PreOrderItemBL();


            long id = preorders.ID;
            // long id =long.Parse( pre.IDRecipe);

            List<PreOrderItem> ingredients = ingredientBL.GetByOrder(id);
            List<ProductReturnEntity> products = new List<ProductReturnEntity>();

            foreach (PreOrderItem ing in ingredients)
            {

                Product product = productbl.GetByID(ing.IDProduct);
                ProductReturnEntity pr = new ProductReturnEntity();
                pr.ID = product.ID;
                pr.MeasurementUnit = product.MeasurementUnit;
                pr.Name = product.Name;
                pr.Code = product.Code;
                pr.Preservation = product.Preservation;
                pr.Quantity = ing.Quantity;
                pr.Description = product.Description;
                products.Add(pr);

            }


            PreOrderReturnEntity preordernew = new PreOrderReturnEntity();
            preordernew.ID = preorders.ID;
            preordernew.IDDiningRoom = preorders.IDDiningRoom;
            preordernew.IDRecipe = preorders.IDRecipe;
            preordernew.PreOrderDate = preorders.PreOrderDate;
            preordernew.Accepted = preorders.Accepted;

            preordernew.IDProduct = products;
            preordersforeturn.Add(preordernew);


            return preordernew;
        }
    
    
        public List<PreOrderReturnEntity> GetAllPreOrders()
        {
            PreOrderBL preorderdal = new PreOrderBL();
            List<PreOrder> preorders = preorderdal.GetAll();
            List<PreOrderReturnEntity> preordersforeturn = new List<PreOrderReturnEntity>();
            ProductBL productbl = new ProductBL();
            //RecipeBL recipebl = new RecipeBL();
            PreOrderItemBL ingredientBL = new PreOrderItemBL();

            
            foreach (PreOrder pre in preorders)
            {
                long id = pre.ID;
                // long id =long.Parse( pre.IDRecipe);
                List<PreOrderItem> ingredients = ingredientBL.GetByOrder(id);
                List<ProductReturnEntity> products = new List<ProductReturnEntity>();

                foreach (PreOrderItem ing in ingredients)
                {
                    Product product = productbl.GetByID(ing.IDProduct);
                    ProductReturnEntity pr = new ProductReturnEntity();
                    pr.ID = product.ID;
                    pr.MeasurementUnit = product.MeasurementUnit;
                    pr.Name = product.Name;
                    pr.Code = product.Code;
                    pr.Preservation = product.Preservation;
                    pr.Quantity = ing.Quantity;
                    pr.Description = product.Description;
                    products.Add(pr);
                }
                PreOrderReturnEntity preordernew = new PreOrderReturnEntity();
                preordernew.ID = pre.ID;
                preordernew.IDDiningRoom = pre.IDDiningRoom;
                preordernew.IDRecipe = pre.IDRecipe;
                preordernew.PreOrderDate = pre.PreOrderDate;
                preordernew.Accepted = pre.Accepted;

                preordernew.IDProduct = products;
                preordersforeturn.Add(preordernew);

            }
            return preordersforeturn;

        }
        public List<PreOrderReturnEntity> GetPreOrderByDate(DateTime date)
        {
            PreOrderBL preorderdal = new PreOrderBL();
            List<PreOrder> preorders = preorderdal.GetPreorderByDate(date);
            List<PreOrderReturnEntity> preordersforeturn = new List<PreOrderReturnEntity>();
            ProductBL productbl = new ProductBL();
            //RecipeBL recipebl = new RecipeBL();
            PreOrderItemBL ingredientBL = new PreOrderItemBL();


            foreach (PreOrder pre in preorders)
            {
                long id = pre.ID;
                // long id =long.Parse( pre.IDRecipe);
                List<PreOrderItem> ingredients = ingredientBL.GetByOrder(id);
                List<ProductReturnEntity> products = new List<ProductReturnEntity>();

                foreach (PreOrderItem ing in ingredients)
                {
                    Product product = productbl.GetByID(ing.IDProduct);
                    ProductReturnEntity pr = new ProductReturnEntity();
                    pr.ID = product.ID;
                    pr.MeasurementUnit = product.MeasurementUnit;
                    pr.Name = product.Name;
                    pr.Code = product.Code;
                    pr.Preservation = product.Preservation;
                    pr.Quantity = ing.Quantity;
                    pr.Description = product.Description;
                    products.Add(pr);
                }
                PreOrderReturnEntity preordernew = new PreOrderReturnEntity();
                preordernew.ID = pre.ID;
                preordernew.IDDiningRoom = pre.IDDiningRoom;
                preordernew.IDRecipe = pre.IDRecipe;

                preordernew.IDProduct = products;
                preordersforeturn.Add(preordernew);

            }
            return preordersforeturn;

        }
        public string insertPreoRder(PreOrderReturnEntity preorder)
        {
            PreOrderBL preorderbl = new PreOrderBL();
            PreOrder preord = new PreOrder();
            preord.IDDiningRoom = preorder.IDDiningRoom;
            preord.IDRecipe = preorder.IDRecipe;
            PreOrderItemBL preOrderItemBL = new PreOrderItemBL();
            List<PreOrderItem> preitems = new List<PreOrderItem>();
            
            string responseString = "";
            int respons = 0;
            responseString = preorderbl.insert(preord);

            if (responseString.Length < 6)
            {
                respons = int.Parse(responseString);

            }
            if (respons > 0)
            {
                foreach (ProductReturnEntity produc in preorder.IDProduct)
                {
                    PreOrderItem pritem = new PreOrderItem();
                    pritem.IDPreOrder = respons;
                    pritem.IDProduct = produc.ID;
                    pritem.Quantity = produc.Quantity;
                    preitems.Add(pritem);
                }
                string resultitems=(preOrderItemBL.InsertList(preitems));
                int resultitemsNum = int.Parse(resultitems);
                if (resultitemsNum > 0)
                {
                    return "registros insertados";

                }
                else
                {
                    return "no se ha podido insertar los registros";
                }

            }
            return "no se ha podido insertar los registros";

        }



        public PreOrderReturnEntity ProcessOrder(long ID)
        {

            /*ELEMENTO FINAL*/
            PreOrderReturnEntity order = new PreOrderReturnEntity();
            /*ELEMENTO FINAL*/


            PreOrderBL preorderdal = new PreOrderBL();
            PreOrder preorders = preorderdal.GetById(ID);


            List<PreOrderReturnEntity> preordersforeturn = new List<PreOrderReturnEntity>();
            ProductBL productbl = new ProductBL();

            PreOrderItemBL lstPreOrderItemBL = new PreOrderItemBL();
            DisponibilityBL disponibilityBL = new DisponibilityBL();
            DiningRoom diningRoom = GetComedorByID((long)preorders.IDDiningRoom);

            long id = preorders.ID;
            List<PreOrderItem> ingredients = lstPreOrderItemBL.GetByOrder(id);
           

            foreach (PreOrderItem ing in ingredients)
            {
               Product product = productbl.GetByID(ing.IDProduct);
               List<Disponibility> lstDisponbilityHigher = disponibilityBL.GetByProduct(product.ID).Where(x => x.Quantity >= (ing.Quantity * diningRoom.ChildNumber)).ToList();
               List<Disponibility> lstDisponbilityMinimum = disponibilityBL.GetByProduct(product.ID).Where(x => x.Quantity < (ing.Quantity * diningRoom.ChildNumber)).ToList();

               if (lstDisponbilityHigher.Count > 0)
                {
                    createArrayProvider(lstDisponbilityHigher, ing, ref diningRoom);

                } else
                {
                    createArrayProvider(lstDisponbilityHigher, ing, ref diningRoom);
                }
             }

            
            return order;
        }

         public object[] createArrayProvider(List<Disponibility> lstdisponibilities,  PreOrderItem ing, ref DiningRoom diningRoom)
        {
            object[] ArrayEfficiency = new object[lstdisponibilities.Count + 1];
            int[] objLamda = new int[lstdisponibilities.Count + 1];
            long[] objProvider = new long[lstdisponibilities.Count + 1];
            object[][] ArrayProvider = new object[lstdisponibilities.Count + 1][];
            int countProveedor = 0;

            foreach (Disponibility dis in lstdisponibilities)
            {
                if (countProveedor > 0)
                {
                    TimeSpan dayExperied = ((DateTime)dis.ExpirationDate - DateTime.Now);
                    double quantity = (double)(ing.Quantity * diningRoom.ChildNumber);
                    double cost = (quantity * (double)dis.UnitValue);
                    ArrayProvider[countProveedor] = new object[] { cost, dayExperied, 15000, quantity }; /*COSTO,DIAS DE VENCIMIENTO,DISTANCIA,COSTO*/
                    objLamda[countProveedor] = 0;
                    objProvider[countProveedor] = (long)dis.IDProvider;
                }
                else
                {
                    /*PROVEEDOR IDEAL*/
                    ArrayProvider[0] = new object[] { 0, 3, 15000, ing.Quantity };  /*COSTO,DIAS DE VENCIMIENTO,DISTANCIA,COSTO*/
                    objProvider[0] = -1;
                    objLamda[countProveedor] = 1;
                }

                countProveedor++;
            }
            return ArrayEfficiency;

        }

    }

}