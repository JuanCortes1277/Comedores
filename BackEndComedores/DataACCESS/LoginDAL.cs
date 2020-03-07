using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.DataACCESS
{
    public class LoginDAL
    {
      public SystemUser LoginCredentialsJWT(string user, string password)
        {
            
             
                using (var context = new ProyectoMaestriaEntities())
                {
                    // Query for all blogs with names starting with B
                    //var ComedorExtracted = from b in context.Comedor
                    //            where b.ID.Equals(id)
                    //            select b;
                  //  var comedor = context.DiningRoom.SingleOrDefault(x => x.Code == code);


                    var result = context.SystemUser.SingleOrDefault(b => b.Password == password );
                    if (result != null)
                    {
                        SystemUser usere = new SystemUser();

                        usere.ID=result.ID ;
                        usere.LastName = result.LastName;
                        usere.Name = result.Name;
                        usere.Password = result.Password;
                        usere.Username = result.Username;
                        usere.UserType = result.UserType;
                    usere.ProviderID = result.ProviderID;

                        return usere;

                    }
                    else
                    {
                        return null;
                    }

                }

            }
            

         


        
    }
}