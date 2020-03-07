using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.DataACCESS
{
    public class ComedorDAL
    {
        public string InsertarComedor(DiningRoom comedor)
        {
            int result;

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {
                    var repetido = context.DiningRoom.SingleOrDefault(x => x.Code == comedor.Code);
                    if (repetido == null)
                    { 

                        var std = new DiningRoom()
                    {

                        //    ID = comedor.ID,
                        Code = comedor.Code,
                        Name = comedor.Name,
                        Address = comedor.Address,
                        Phone = comedor.Phone,
                        Email = comedor.Email,
                        Neiborhood = comedor.Neiborhood,
                        City = comedor.City,
                        Contact = comedor.Contact,
                        ContactEmail = comedor.ContactEmail,
                        ContactPhone = comedor.ContactPhone,
                        ChildNumber = comedor.ChildNumber,
                        ScheduleReception = comedor.ScheduleReception

                    };
                    context.DiningRoom.Add(std);

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

        public DiningRoom Extract(string code)
        {
        
                using (var context = new ProyectoMaestriaEntities())
                {
                    // Query for all blogs with names starting with B
                    //var ComedorExtracted = from b in context.Comedor
                    //            where b.ID.Equals(id)
                    //            select b;
                var comedor = context.DiningRoom.SingleOrDefault(x => x.Code == code);
                if (comedor != null)
                {
                    return new DiningRoom
                    {
                        ID = comedor.ID,
                        Code = comedor.Code,
                        Name = comedor.Name,
                        Address = comedor.Address,
                        Phone = comedor.Phone,
                        Email = comedor.Email,
                        Neiborhood = comedor.Neiborhood,
                        City = comedor.City,
                        Contact = comedor.Contact,
                        ContactEmail = comedor.ContactEmail,
                        ContactPhone = comedor.ContactPhone,
                        ChildNumber = comedor.ChildNumber,
                        ScheduleReception = comedor.ScheduleReception
                    };
                }
                else return null;
                //// Query for the Blog named ADO.NET Blog
                //var blog = context.Blogs
                //                .Where(b => b.Name == "ADO.NET Blog")
                //                .FirstOrDefault();


                

            }



        }


        public string Modify(DiningRoom comedor)
        {

            int modify=0;
            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.DiningRoom.SingleOrDefault(b => b.Code == comedor.Code);
                    if (result != null)
                    {

                        result.Code = comedor.Code;
                        result.Name = comedor.Name;
                        result.Address = comedor.Address;
                        result.Phone = comedor.Phone;
                        result.Email = comedor.Email;
                        result.Neiborhood = comedor.Neiborhood;
                        result.City = comedor.City;
                        result.Contact = comedor.Contact;
                        result.ContactEmail = comedor.ContactEmail;
                        result.ContactPhone = comedor.ContactPhone;
                        result.ChildNumber = comedor.ChildNumber;
                        result.ScheduleReception = comedor.ScheduleReception;


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

                    var result = context.DiningRoom.SingleOrDefault(b => b.Code == code);
                    if (result != null)
                    {
                        context.DiningRoom.Remove(result);
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
        public List<DiningRoom> ExtractAll()
        {
            List<DiningRoom> diningRooms = new List<DiningRoom>();
           
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.DiningRoom.ToList();


                    if (result != null)
                    {

                        foreach(var temp in result)
                        {
                            DiningRoom diningRoom = new DiningRoom();
                        diningRoom.ID = temp.ID;
                            diningRoom.Code = temp.Code;
                            diningRoom.Name = temp.Name;
                            diningRoom.Address = temp.Address;
                            diningRoom.Phone = temp.Phone;
                            diningRoom.Email = temp.Email;
                            diningRoom.Neiborhood = temp.Neiborhood;
                            diningRoom.City = temp.City;
                            diningRoom.Contact = temp.Contact;
                            diningRoom.ContactEmail = temp.ContactEmail;
                            diningRoom.ContactPhone = temp.ContactPhone;
                            diningRoom.ChildNumber = temp.ChildNumber;
                            diningRoom.ScheduleReception = temp.ScheduleReception;
                            diningRooms.Add(diningRoom);
                        }
                       
                        return diningRooms;
                    }
                    else
                        return diningRooms;




                }


            }


         


        


    }
    

}



