using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.DataACCESS
{
    public class SystemUserDAL
    {
        public string Insertar(SystemUser systemUser)
        {
            int result;

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {
                    var repetido = context.SystemUser.SingleOrDefault(x => x.Username == systemUser.Name);
                    if (repetido == null)
                    {

                        var std = new SystemUser()
                        {
                         //public long ID { get; set; }
                         //       public string Username { get; set; }
                         //       public string Password { get; set; }
                         //       public string Name { get; set; }
                         //       public string LastName { get; set; }
                         //       public string UserType { get; set; }
                         //       public Nullable<long> ProviderID { get; set; }
                         Username= systemUser.Username,
                         Password= systemUser.Password,
                         Name=systemUser.Name,
                         LastName=systemUser.LastName,
                         UserType=systemUser.UserType,
                         ProviderID=systemUser.ProviderID
                        };
                        context.SystemUser.Add(std);

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

        public SystemUser Extract(string username)
        {

            using (var context = new ProyectoMaestriaEntities())
            {
                // Query for all blogs with names starting with B
                //var ComedorExtracted = from b in context.Comedor
                //            where b.ID.Equals(id)
                //            select b;
                var systemuser = context.SystemUser.SingleOrDefault(x => x.Username == username);
                if (systemuser != null)
                {
                    return new SystemUser
                    {
                        ID= systemuser.ID,
                        Username = systemuser.Username,
                        Password = systemuser.Password,
                        Name = systemuser.Name,
                        LastName = systemuser.LastName,
                        UserType = systemuser.UserType,
                        ProviderID = systemuser.ProviderID
                    };
                }
                else return null;
                //// Query for the Blog named ADO.NET Blog
                //var blog = context.Blogs
                //                .Where(b => b.Name == "ADO.NET Blog")
                //                .FirstOrDefault();




            }



        }


        public string Modify(SystemUser systemuser)
        {

            int modify = 0;
            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.SystemUser.SingleOrDefault(b => b.Username == systemuser.Username);
                    if (result != null)
                    {
                        //public long ID { get; set; }
                        //       public string Username { get; set; }
                        //       public string Password { get; set; }
                        //       public string Name { get; set; }
                        //       public string LastName { get; set; }
                        //       public string UserType { get; set; }
                        //       public Nullable<long> ProviderID { get; set; }
                        result.Password = systemuser.Password;
                        result.Name = systemuser.Name;

                        result.LastName = systemuser.LastName;
                        result.UserType = systemuser.UserType;
                        result.ProviderID = systemuser.ProviderID;
                       


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

                    var result = context.SystemUser.SingleOrDefault(b => b.Username == code);
                    if (result != null)
                    {
                        context.SystemUser.Remove(result);
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
        public List<SystemUser> ExtractAll()
        {
            List<SystemUser> transports = new List<SystemUser>();

            using (var context = new ProyectoMaestriaEntities())
            {

                var result = context.SystemUser.ToList();


                if (result != null)
                {

                    foreach (var temp in result)
                    {
                        //result.Password = systemuser.Password;
                        //result.Name = systemuser.Name;
                        //result.LastName = systemuser.LastName;
                        //result.UserType = systemuser.UserType;
                        //result.ProviderID = systemuser.ProviderID;
                        SystemUser systemuser = new SystemUser();
                        systemuser.ID = temp.ID;
                        systemuser.Username = temp.Username;

                        systemuser.Name = temp.Name;
                        systemuser.LastName = temp.LastName;
                        systemuser.UserType = temp.UserType;
                        systemuser.ProviderID = temp.ProviderID;
                       
                        transports.Add(systemuser);
                    }

                    return transports;
                }
                else
                    return transports;




            }


        }

    }
}