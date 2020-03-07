﻿using BackEndComedores.Entidades;
using BackEndComedores.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackEndComedores.Controllers.ControladoresPrincipales
{
    [Authorize]
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
        public SystemUserReturnEntity Extract(long ID)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GetUser(ID);

        }
        [HttpGet]
        [Route("GetAll")]
        public List<SystemUserReturnEntity> GeAll()
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GetAllUsers();

        }
        [HttpPut]
        [Route("Modify")]
        public string Update(SystemUser transport)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.UpdateUser(transport);

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
