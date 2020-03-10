using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.DataACCESS
{
    public class ProviderDAL
    {
        public Provider ExtractById(long? code)
        {

            using (var context = new ProyectoMaestriaEntities())
            {
                // Query for all blogs with names starting with B
                //var ComedorExtracted = from b in context.Comedor
                //            where b.ID.Equals(id)
                //            select b;
                var proveedor = context.Provider.SingleOrDefault(x => x.ID == code);
                if (proveedor != null)
                {
                    return new Provider
                    {


                          //   public long ID { get; set; }
                          ID= proveedor.ID,
                          Code= proveedor.Code,
                          Name=proveedor.Name,
                          Address=proveedor.Address,
                          Neiborhood=proveedor.Neiborhood,
                          City=proveedor.City,
                          Phone=proveedor.Phone,
                          Contact=proveedor.Contact,
                          ContactPhone=proveedor.ContactPhone,
                          ContactMail=proveedor.ContactMail,
                          EnterpriseMail=proveedor.EnterpriseMail,
                          NIT=proveedor.NIT,
                          Type=proveedor.Type


                    };
                }
                else return null;
                //// Query for the Blog named ADO.NET Blog
                //var blog = context.Blogs
                //                .Where(b => b.Name == "ADO.NET Blog")
                //                .FirstOrDefault();




            }
         



        }
        public string InsertProvider(Provider provider)
        {
            int result;

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {
                    var repetido = context.Provider.SingleOrDefault(x => x.Code == provider.Code);
                    if (repetido == null)
                    {

                        var std = new Provider()
                        {

   
                            Code = provider.Code,
                            Name = provider.Name,
                            Address = provider.Address,
                            Neiborhood = provider.Neiborhood,
                            City = provider.City,
                            Phone = provider.Phone,
                            Contact = provider.Contact,
                            ContactMail = provider.ContactMail,
                            ContactPhone = provider.ContactPhone,
                            EnterpriseMail = provider.EnterpriseMail,
                            NIT = provider.NIT,
                            Type = provider.Type


                        };
                        context.Provider.Add(std);

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
        public Provider Extractprovider(string code)
        {

            using (var context = new ProyectoMaestriaEntities())
            {
                // Query for all blogs with names starting with B
                //var ComedorExtracted = from b in context.Comedor
                //            where b.ID.Equals(id)
                //            select b;
                var comedor = context.Provider.SingleOrDefault(x => x.Code == code);
                if (comedor != null)
                {
                    return new Provider
                    {
                        ID=comedor.ID,
                        Code = comedor.Code,
                        Name = comedor.Name,
                        Address = comedor.Address,
                        Neiborhood = comedor.Neiborhood,
                        City = comedor.City,
                        Phone = comedor.Phone,
                        Contact = comedor.Contact,
                        ContactMail = comedor.ContactMail,
                        ContactPhone = comedor.ContactPhone,
                        EnterpriseMail = comedor.EnterpriseMail,
                        NIT = comedor.NIT,
                        Type = comedor.Type
                    };
                }
                else return null;
                //// Query for the Blog named ADO.NET Blog
                //var blog = context.Blogs
                //                .Where(b => b.Name == "ADO.NET Blog")
                //                .FirstOrDefault();




            }



        }



        
        public Provider ExtractproviderByID(long code)
        {

            using (var context = new ProyectoMaestriaEntities())
            {
                // Query for all blogs with names starting with B
                //var ComedorExtracted = from b in context.Comedor
                //            where b.ID.Equals(id)
                //            select b;
                var comedor = context.Provider.SingleOrDefault(x => x.ID == code);
                if (comedor != null)
                {
                    return new Provider
                    {
                        ID = comedor.ID,
                        Code = comedor.Code,
                        Name = comedor.Name,
                        Address = comedor.Address,
                        Neiborhood = comedor.Neiborhood,
                        City = comedor.City,
                        Phone = comedor.Phone,
                        Contact = comedor.Contact,
                        ContactMail = comedor.ContactMail,
                        ContactPhone = comedor.ContactPhone,
                        EnterpriseMail = comedor.EnterpriseMail,
                        NIT = comedor.NIT,
                        Type = comedor.Type
                    };
                }
                else return null;
                //// Query for the Blog named ADO.NET Blog
                //var blog = context.Blogs
                //                .Where(b => b.Name == "ADO.NET Blog")
                //                .FirstOrDefault();




            }



        }
        public List<Provider> ExtractAllProviders()
        {
            List<Provider> Providers = new List<Provider>();

            using (var context = new ProyectoMaestriaEntities())
            {

                var result = context.Provider.ToList();


                if (result != null)
                {

                    foreach (var temp in result)
                    {
                        Provider provider = new Provider();
                        provider.ID = temp.ID;

                        provider.Code = temp.Code;
                        provider.Name = temp.Name;
                        provider.Address = temp.Address;
                        provider.Neiborhood = temp.Neiborhood;
                        provider.City = temp.City;
                        provider.Phone = temp.Phone;
                        provider.Contact = temp.Contact;
                        provider.ContactMail = temp.ContactMail;
                        provider.ContactPhone = temp.ContactPhone;
                        provider.EnterpriseMail = temp.EnterpriseMail;
                        provider.NIT = temp.NIT;
                        provider.Type = temp.Type;
                       Providers.Add(provider);
                    }

                    return Providers;
                }
                else
                    return Providers;




            }


        }
        public string ModifyProvider(Provider provider)
        {

            int modify = 0;
            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.Provider.SingleOrDefault(b => b.ID == provider.ID);
                    if (result != null)
                    {

                        result.Code = provider.Code;
                        result.Name = provider.Name;
                        result.Address = provider.Address;
                        result.Neiborhood = provider.Neiborhood;
                        result.City = provider.City;
                        result.Phone = provider.Phone;
                        result.Contact = provider.Contact;
                        result.ContactMail = provider.ContactMail;
                        result.ContactPhone = provider.ContactPhone;
                        result.EnterpriseMail = provider.EnterpriseMail;
                        result.NIT = provider.NIT;
                        result.Type = provider.Type;


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
        public string DeleteProvider(long code)
        {

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.Provider.SingleOrDefault(b => b.ID == code);
                    if (result != null)
                    {
                        context.Provider.Remove(result);
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