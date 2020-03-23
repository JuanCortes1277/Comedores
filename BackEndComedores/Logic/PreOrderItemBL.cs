using BackEndComedores.DataACCESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Logic
{
    public class PreOrderItemBL
    {
        public List<PreOrderItem> GetByOrder(long Preorder)
        {
            PreOrerItemDAL preorderdal = new PreOrerItemDAL();
            return preorderdal.GetByOrder(Preorder);
        }
        public string InsertList(List<PreOrderItem> items)
        {
            PreOrerItemDAL preorderdal = new PreOrerItemDAL();
            return preorderdal.InsertList(items);
        }

    }
}