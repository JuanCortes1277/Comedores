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

        public DiningRoom Extract(string code)
        {
            ComedorDAL comedordal = new ComedorDAL();
            return comedordal.Extract(code);
        }
        public string Modify(DiningRoom code)
        {
            ComedorDAL comedordal = new ComedorDAL();
            return comedordal.Modify(code);
        }
        public string Delete(string code)
        {
            ComedorDAL comedordal = new ComedorDAL();
            return comedordal.Delete(code);
        }
        public List<DiningRoom> ExtractAll()
        {
            ComedorDAL comedordal = new ComedorDAL();
            return comedordal.ExtractAll();
        }


        
    }
}
