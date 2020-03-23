using BackEndComedores.DataACCESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Logic
{
    public class PreOrderBL
    {
        public List<PreOrder> GetByDinningRoom(long ID)
        {
            PreOrderDAL preorderdal = new PreOrderDAL();
            return preorderdal.GetByDinningRoom( ID);
        }
        public PreOrder GetById(long ID)
        {
            PreOrderDAL preorderdal = new PreOrderDAL();
            return preorderdal.GetById(ID);
        }
        public List<PreOrder> GetAll()
        {
            PreOrderDAL preorderdal = new PreOrderDAL();
            return preorderdal.GettAll();
        }
        public List<PreOrder> GetPreorderByDate(DateTime date)
        {
            PreOrderDAL preorderdal = new PreOrderDAL();
            return preorderdal.GetPreorderByDate(date);
        }
        public string insert (PreOrder preorder)
        {
            PreOrderDAL preorderdal = new PreOrderDAL();
            return preorderdal.InsertarPreorder(preorder);
        }


    }
}