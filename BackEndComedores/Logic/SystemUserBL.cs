using BackEndComedores.DataACCESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Logic
{
    public class SystemUserBL
    {

        public SystemUser ExtractById(string code)
        {
            SystemUserDAL userdal = new SystemUserDAL();
            return userdal.Extract(code);
        }
        public string Insert(SystemUser user)
        {
            SystemUserDAL userdal = new SystemUserDAL();
            return userdal.Insertar(user);
        }
        public SystemUser Extract(string user)
        {
            SystemUserDAL userdal = new SystemUserDAL();
            return userdal.Extract(user);
        }
        public List<SystemUser> ExtractAll()
        {
            SystemUserDAL userdal = new SystemUserDAL();
            return userdal.ExtractAll();
        }
        public string Modify(SystemUser user)
        {
            SystemUserDAL userdal = new SystemUserDAL();


            return userdal.Modify(user);

        }
        public string Delete(string code)
        {
            SystemUserDAL userdal = new SystemUserDAL();


            return userdal.Delete(code);

        }

    }
}