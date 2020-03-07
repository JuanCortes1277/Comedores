using BackEndComedores.DataACCESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Logic
{
    public class ProductBL
    {

        public string InsertarProducto(Product producto)
        {

            ProductDAL productDAL = new ProductDAL();
            return productDAL.InsertarProducto(producto);
        }

        public Product Extract(string Code)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.Extract(Code);

        }
        public List<Product> ExtractAllProducts()
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.ExtractAllProducts();

        }
        public string Modify(Product product)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.Modify(product);

        }
        public string Delete(string Code)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.Delete(Code);

        }
        public Product ExtractById(long? code)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.ExtractById(code);
        }



    }
}