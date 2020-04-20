using BackEndComedores.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BackEndComedores.Controllers.ControladoresPrincipales
{
    [Authorize]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Eficiencia")]
    public class EficienciaController : ApiController
    {
        // GET: api/Eficiencia
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Eficiencia/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Eficiencia
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Eficiencia/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Eficiencia/5
        public void Delete(int id)
        {
        }
        //[HttpGet]
        //[Route("GeteficienciaPorPedido")]
        //public void GeteficienciaPorPedido(long Id)
        //{
        //    LogicBL logic = new LogicBL();
        //    logic.MostSuitableProvidersSimplex(Id);
        //}
    }
}
