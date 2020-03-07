using BackEndComedores.DataACCESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Logic
{
    public class ComedorBL
    {
        public string InsertarComedor(DiningRoom comedor)
        {
            ComedorDAL comedordal = new ComedorDAL();
            return comedordal.InsertarComedor(comedor);
        }

        public DiningRoom GetComedor(string code)
        {
            ComedorDAL comedordal = new ComedorDAL();
            return comedordal.GetComedor(code);
        }
        public DiningRoom GetComedorByID(long id)
        {
            ComedorDAL comedordal = new ComedorDAL();
            return comedordal.GetComedorByID(id);
        }



        
        public string UpdateDinner(DiningRoom code)
        {
            ComedorDAL comedordal = new ComedorDAL();
            return comedordal.UpdateDinner(code);
        }
        public string Delete(long code)
        {
            ComedorDAL comedordal = new ComedorDAL();
            return comedordal.Delete(code);
        }
        public List<DiningRoom> GettAllDinners()
        {
            ComedorDAL comedordal = new ComedorDAL();
            return comedordal.GettAllDinners();
        }


        
    }
}
