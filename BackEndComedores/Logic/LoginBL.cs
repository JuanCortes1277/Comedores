using BackEndComedores.DataACCESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Logic
{
    public class LoginBL
    {
        public SystemUser LoginCredentialsJWT(string user, string password)
        {
            LoginDAL logindal = new LoginDAL();
            return logindal.LoginCredentialsJWT(user, password);
        }
    }
}