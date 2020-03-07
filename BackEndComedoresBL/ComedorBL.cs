using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEndComedoresEntities;
using BackEndComedoresDAL;
namespace BackEndComedoresBL
{
   public  class ComedorBL
    {
         public bool InsertarComedor(Comedor comedor)
        {
            ComedorDAL comedorDAL = new ComedorDAL();
           return comedorDAL.InsertarComedor(comedor);

        }
    }
}
