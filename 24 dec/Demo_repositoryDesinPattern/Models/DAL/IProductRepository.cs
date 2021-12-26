using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_repositoryDesinPattern.Models.DAL
{
    interface IProductRepository
    {
        IEnumerable<Product_Table> GetProducts();
        Product_Table getproductbyID(int PID);

        void InsertProduct(Product_Table product_);

        void UpdateProduct(Product_Table product,int productID);
        void DeleteProduct(int PID);

        void SaveChanges();

        
    }
}
