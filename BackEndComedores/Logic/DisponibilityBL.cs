using BackEndComedores.DataACCESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Logic
{
    public class DisponibilityBL
    {

      
            public string Insert(Disponibility disponibility)
            {
            DisponibilityDAL comedordal = new DisponibilityDAL();
                return comedordal.Insert(disponibility);
            }

        
            public Disponibility GetByID(long id)
            {
            DisponibilityDAL comedordal = new DisponibilityDAL();
                return comedordal.GetByID(id);
            }




            public string Update(Disponibility code)
            {
            DisponibilityDAL comedordal = new DisponibilityDAL();
                return comedordal.Update(code);
            }
            public string Delete(long code)
            {
            DisponibilityDAL comedordal = new DisponibilityDAL();
                return comedordal.Delete(code);
            }
            public List<Disponibility> GettAll()
            {
            DisponibilityDAL comedordal = new DisponibilityDAL();
                return comedordal.GettAll();
            }

        }
    }