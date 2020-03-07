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

        public Product Get(string Code)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.Get(Code);

        }
        public Product GetByID(long? Code)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.GetById(Code);

        }


        
        public List<Product> GetAllProducts()
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.GetAllProducts();

        }
        public string Modify(Product product)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.Update(product);

        }
        public string Delete(string Code)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.Delete(Code);

        }
        public Product ExtractById(long? code)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.GetById(code);
        }



    }
}