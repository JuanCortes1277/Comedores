using BackEndComedores.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BackEndComedores.Controllers
{
    [Authorize]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Product")]

    public class ProductController : ApiController
    {
        [HttpPost]
        [Route("Insert")]
        public string Insert(Product Producto)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.InsertProduct(Producto);

        }
        [HttpGet]
        [Route("GetByCode")]
        public Product GetByCode(string code)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GetProducto(code);

        }
        [HttpGet]
        [Route("GetById")]
        public Product GetById(long? Id)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GetProductoByID(Id);

        }
       
        [HttpGet]
        [Route("GetAll")]
        public List<Product> GetAll()
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.GettAllProducts();

        }
        [HttpPut]
        [Route("Update")]
        public string Update(Product product)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.UpdateProduct(product);

        }
        [HttpDelete]
        [Route("Delete")]
        public string Delete(long Id)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.DeleteProduct(Id);

        }
    }
}
