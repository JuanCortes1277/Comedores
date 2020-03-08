using BackEndComedores.DataACCESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Logic
{
    public class SystemUserBL
    {

        public SystemUser GetByID(long code)
        {
            SystemUserDAL userdal = new SystemUserDAL();
            return userdal.GetByID(code);
        }
        public string Insert(SystemUser user)
        {
            SystemUserDAL userdal = new SystemUserDAL();
            return userdal.Insertar(user);
        }
        public SystemUser Get(string user)
        {
            SystemUserDAL userdal = new SystemUserDAL();
            return userdal.Get(user);
        }
        public List<SystemUser> ExtractAll()
        {
            SystemUserDAL userdal = new SystemUserDAL();
            return userdal.GetAll();
        }
        public string Update(SystemUser user)
        {
            SystemUserDAL userdal = new SystemUserDAL();


            return userdal.Update(user);

        }
        public string Delete(long code)
        {
            SystemUserDAL userdal = new SystemUserDAL();


            return userdal.Delete(code);

        }

    }
}