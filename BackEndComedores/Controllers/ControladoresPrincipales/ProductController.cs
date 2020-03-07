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
        [Route("Extract")]
        public Product Extract(string code)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractProducto(code);

        }
        [HttpGet]
        [Route("ExtractAll")]
        public List<Product> ExtractAll()
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ExtractAllProducts();

        }
        [HttpPut]
        [Route("Modify")]
        public string Modify(Product product)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.ModifyProduct(product);

        }
        [HttpDelete]
        [Route("Delete")]
        public string Delete(string code)
        {
            LogicBL logicBL = new LogicBL();
            return logicBL.DeleteProduct(code);

        }
    }
}
