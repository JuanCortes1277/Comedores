using BackEndComedores.Entidades;
using BackEndComedores.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackEndComedores.Controllers.ControladoresPrincipales
{
    [RoutePrefix("api/systemUser")]
    public class SystemUserController : ApiController
    {
        [HttpPost]
        [Route("Insert")]
        public string Insert(SystemUser user)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.InsertUser(user);

        }
        [HttpGet]
        [Route("Extract")]
        public SystemUserReturnEntity Extract(string username)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractUser(username);

        }
        [HttpGet]
        [Route("ExtractAll")]
        public List<SystemUserReturnEntity> ExtractAll()
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractAllUsers();

        }
        [HttpPut]
        [Route("Modify")]
        public string Modify(SystemUser transport)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ModifyUser(transport);

        }
        [HttpDelete]
        [Route("Delete")]
        public string Delete(string username)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.DeleteUser(username);

        }
    }
}
