using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_repositoryDesinPattern.Models.DAL
{
    public class ProductRepository : IProductRepository
    {

        private Product_Table _dataContext;

        public ProductRepository(Product_Table dataContext)
        {
            this._dataContext = dataContext;
        }

        public void DeleteProduct(int PID)
        {
          
        }

        public Product_Table getproductbyID(int PID)
        {
           
        }

        public IEnumerable<Product_Table> GetProducts()
        {
            throw new NotImplementedException();
        }

        public void InsertProduct(Product_Table product_)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product_Table product, int productID)
        {
            throw new NotImplementedException();
        }
    }
}