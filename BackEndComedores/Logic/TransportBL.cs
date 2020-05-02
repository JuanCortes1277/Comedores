using BackEndComedores.DataACCESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Logic
{
    public class TransportBL
    {

        public string InsertTrasnport(Transport trasnport)
        {
            TransportDAL transportDSAL = new TransportDAL();
            return transportDSAL.InsertarTransport(trasnport);
        }
        public Transport ExtractTransport(string provider)
        {
            TransportDAL providerdal = new TransportDAL();
            return providerdal.Extract(provider);
        }
        public Transport ExtractTransport(long provider)
        {
            TransportDAL providerdal = new TransportDAL();
            return providerdal.Extract(provider);
        }
        public Transport ExtractTransportByID(long provider)
        {
            TransportDAL providerdal = new TransportDAL();
            return providerdal.ExtractById(provider);
        }
        public List<Transport> ExtractAllTransports()
        {
            TransportDAL providerdal = new TransportDAL();
            return providerdal.ExtractAll();
        }
        public string ModifyTransport(Transport provider)
        {
            TransportDAL providerdal = new TransportDAL();


            return providerdal.Modify(provider);

        }
        public string DeleteTransport(long code)
        {
            TransportDAL providerdal = new TransportDAL();


            return providerdal.Delete(code);

        }
        public Transport GetMostSuitableTransport(long? type,double distancia)
        {
            TransportDAL providerdal = new TransportDAL();


            return providerdal.GetMostSuitableTransport(type,distancia);

        }
        public Transport GetMostSuitableTransportByRejection(long? type, double distancia, long? idtransportRejected)
        {
            TransportDAL providerdal = new TransportDAL();


            return providerdal.GetMostSuitableTransportByRejection( type,  distancia,  idtransportRejected);

        }




    }
}