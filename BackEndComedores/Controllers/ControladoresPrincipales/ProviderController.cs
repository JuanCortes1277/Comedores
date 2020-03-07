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
        [Route("Extract")]
        public Provider Extract(string code)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.Extractprovider(code);

        }
        [HttpGet]
        [Route("ExtractAll")]
        public List<Provider> ExtractAll()
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractAllProviders();

        }
        [HttpPut]
        [Route("Modify")]
        public string Modify(Provider provider)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ModifyProvider(provider);

        }
        [HttpDelete]
        [Route("Delete")]
        public string Delete(string code)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.DeleteProvider(code);

        }
        
    }
}
