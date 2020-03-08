using BackEndComedores.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackEndComedores.Controllers
{
    [Authorize]
    [RoutePrefix("api/Provider")]
   
    public class ProviderController : ApiController
    {
        // GET: api/Provider

        [HttpPost]
        [Route("Insert")]
        public string Insert(Provider comedor)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.InsertProvider(comedor);

        }
        [HttpGet]
        [Route("GetByCode")]
        public Provider GetByCode(string code)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.Extractprovider(code);

        }
        [HttpGet]
        [Route("GetByID")]
        public Provider GetByID(long ID)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractproviderByID(ID);

        }
        [HttpGet]
        [Route("GetAll")]
        public List<Provider> GetAll()
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractAllProviders();

        }
        [HttpPut]
        [Route("Update")]
        public string Update(Provider provider)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ModifyProvider(provider);

        }
        [HttpDelete]
        [Route("Delete")]
        public string Delete(long ID)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.DeleteProvider(ID);

        }
        
    }
}
