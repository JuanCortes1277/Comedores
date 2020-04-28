using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.DataACCESS
{
    public class TransportDAL
    {
        public string InsertarTransport(Transport transport)
        {
            int result;

            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {
                    var repetido = context.Transport.SingleOrDefault(x => x.Code == transport.Code);
                    if (repetido == null)
                    {

                        var std = new Transport()
                        {

                              Code = transport.Code,
                            CarPlate = transport.CarPlate,
                            Brand = transport.Brand,
                            Year = transport.Year,
                            PersonInCharge = transport.PersonInCharge,
                            PhonePersonInCharge = transport.PhonePersonInCharge,
                            MailPersonInCharge = transport.MailPersonInCharge,
                            PaymentUnity = transport.PaymentUnity,
                            PaymentMeasurement = transport.PaymentMeasurement,
                            PaymentValue = transport.PaymentValue,
                            Availability = transport.Availability,
                            TransportType = transport.TransportType,
                            IDProvider=transport.IDProvider

                        };
                        context.Transport.Add(std);

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

        public Transport Extract(string code)
        {

            using (var context = new ProyectoMaestriaEntities())
            {
                // Query for all blogs with names starting with B
                //var ComedorExtracted = from b in context.Comedor
                //            where b.ID.Equals(id)
                //            select b;
                var transport = context.Transport.SingleOrDefault(x => x.Code == code);
                if (transport != null)
                {
                    return new Transport
                    {
                        ID= transport.ID,
                        Code = transport.Code,
                            CarPlate = transport.CarPlate,
                            Brand = transport.Brand,
                            Year = transport.Year,
                            PersonInCharge = transport.PersonInCharge,
                            PhonePersonInCharge = transport.PhonePersonInCharge,
                            MailPersonInCharge = transport.MailPersonInCharge,
                            PaymentUnity = transport.PaymentUnity,
                            PaymentMeasurement = transport.PaymentMeasurement,
                            PaymentValue = transport.PaymentValue,
                            Availability = transport.Availability,
                            TransportType = transport.TransportType,
                            IDProvider=transport.IDProvider
                    };
                }
                else return null;
                //// Query for the Blog named ADO.NET Blog
                //var blog = context.Blogs
                //                .Where(b => b.Name == "ADO.NET Blog")
                //                .FirstOrDefault();




            }



        }


        public Transport Extract(long code)
        {

            using (var context = new ProyectoMaestriaEntities())
            {
                // Query for all blogs with names starting with B
                //var ComedorExtracted = from b in context.Comedor
                //            where b.ID.Equals(id)
                //            select b;
                var transport = context.Transport.SingleOrDefault(x => x.ID == code);
                if (transport != null)
                {
                    return new Transport
                    {
                        ID = transport.ID,
                        Code = transport.Code,
                        CarPlate = transport.CarPlate,
                        Brand = transport.Brand,
                        Year = transport.Year,
                        PersonInCharge = transport.PersonInCharge,
                        PhonePersonInCharge = transport.PhonePersonInCharge,
                        MailPersonInCharge = transport.MailPersonInCharge,
                        PaymentUnity = transport.PaymentUnity,
                        PaymentMeasurement = transport.PaymentMeasurement,
                        PaymentValue = transport.PaymentValue,
                        Availability = transport.Availability,
                        TransportType = transport.TransportType,
                        IDProvider = transport.IDProvider
                    };
                }
                else return null;
                //// Query for the Blog named ADO.NET Blog
                //var blog = context.Blogs
                //                .Where(b => b.Name == "ADO.NET Blog")
                //                .FirstOrDefault();




            }



        }
        public Transport GetMostSuitableTransport(long? type,double distancia)
        {
           
                List<Transport> transports = new List<Transport>();

                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.Transport.Where(x => x.TransportType == type && x.Availability==true).ToList();


                    if (result != null)
                    {

                        foreach (var temp in result)
                        {
                            Transport transport = new Transport();
                            transport.ID = temp.ID;
                            transport.Code = temp.Code;
                            transport.CarPlate = temp.CarPlate;
                            transport.Brand = temp.Brand;
                            transport.Year = temp.Year;
                            transport.PersonInCharge = temp.PersonInCharge;
                            transport.PhonePersonInCharge = temp.PhonePersonInCharge;
                            transport.MailPersonInCharge = temp.MailPersonInCharge;
                            transport.PaymentUnity = temp.PaymentUnity;
                            transport.PaymentMeasurement = temp.PaymentMeasurement;
                            transport.PaymentValue = temp.PaymentValue;
                            transport.Availability = temp.Availability;
                            transport.TransportType = temp.TransportType;
                            transport.IDProvider = temp.IDProvider;
                            transports.Add(transport);
                        }
                    Transport MostEffectiveTransport=new Transport();
                    decimal? effectivityTotal = 10000000000000000000;
                    decimal? effectivityActual = 0;
                        foreach(Transport T in transports)
                    {
                        if(T.PaymentUnity!=null && T.PaymentUnity != null)
                        {
                            double transportcost = Convert.ToDouble(((Convert.ToDecimal(distancia)/1000) * T.PaymentValue) / T.PaymentUnity);
                            
                            if (effectivityActual < effectivityTotal)
                            {
                                effectivityTotal = effectivityActual;
                                MostEffectiveTransport = T;
                            }
                        }

                    }
                    return MostEffectiveTransport;

                    }
                    else
                        return null;




                }


            }




            public Transport ExtractById(long code)
        {

            using (var context = new ProyectoMaestriaEntities())
            {
                // Query for all blogs with names starting with B
                //var ComedorExtracted = from b in context.Comedor
                //            where b.ID.Equals(id)
                //            select b;
                var transport = context.Transport.SingleOrDefault(x => x.ID == code);
                if (transport != null)
                {
                    return new Transport
                    {
                        ID = transport.ID,
                        Code = transport.Code,
                        CarPlate = transport.CarPlate,
                        Brand = transport.Brand,
                        Year = transport.Year,
                        PersonInCharge = transport.PersonInCharge,
                        PhonePersonInCharge = transport.PhonePersonInCharge,
                        MailPersonInCharge = transport.MailPersonInCharge,
                        PaymentUnity = transport.PaymentUnity,
                        PaymentMeasurement = transport.PaymentMeasurement,
                        PaymentValue = transport.PaymentValue,
                        Availability = transport.Availability,
                        TransportType = transport.TransportType,
                        IDProvider = transport.IDProvider
                    };
                }
                else return null;
                //// Query for the Blog named ADO.NET Blog
                //var blog = context.Blogs
                //                .Where(b => b.Name == "ADO.NET Blog")
                //                .FirstOrDefault();




            }



        }



        public string Modify(Transport transport)
        {

            int modify = 0;
            try
            {
                using (var context = new ProyectoMaestriaEntities())
                {

                    var result = context.Transport.SingleOrDefault(b => b.ID == transport.ID);
                    if (result != null)
                    {
                        result.Code = transport.Code;
                        result.CarPlate = transport.CarPlate;
                        result.Brand = transport.Brand;
                        result.Year = transport.Year;
                        result.PersonInCharge = transport.PersonInCharge;
                        result.PhonePersonInCharge = transport.PhonePersonInCharge;
                        result.MailPersonInCharge = transport.MailPersonInCharge;
                        result.PaymentUnity = transport.PaymentUnity;
                        result.PaymentMeasurement = transport.PaymentMeasurement;
                        result.PaymentValue = transport.PaymentValue;
                        result.Availability = transport.Availability;
                        result.TransportType = transport.TransportType;
                        result.IDProvider = transport.IDProvider;


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

                    var result = context.Transport.SingleOrDefault(b => b.ID == code);
                    if (result != null)
                    {
                        context.Transport.Remove(result);
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
        public List<Transport> ExtractAll()
        {
            List<Transport> transports = new List<Transport>();

            using (var context = new ProyectoMaestriaEntities())
            {

                var result = context.Transport.ToList();


                if (result != null)
                {

                    foreach (var temp in result)
                    {
                        Transport transport = new Transport();
                        transport.ID = temp.ID;
                        transport.Code = temp.Code;
                        transport.CarPlate = temp.CarPlate;
                        transport.Brand = temp.Brand;
                        transport.Year = temp.Year;
                        transport.PersonInCharge = temp.PersonInCharge;
                        transport.PhonePersonInCharge = temp.PhonePersonInCharge;
                        transport.MailPersonInCharge = temp.MailPersonInCharge;
                        transport.PaymentUnity = temp.PaymentUnity;
                        transport.PaymentMeasurement = temp.PaymentMeasurement;
                        transport.PaymentValue = temp.PaymentValue;
                        transport.Availability = temp.Availability;
                        transport.TransportType = temp.TransportType;
                        transport.IDProvider = temp.IDProvider;
                        transports.Add(transport);
                    }

                    return transports;
                }
                else
                    return transports;




            }


        }


    }
}