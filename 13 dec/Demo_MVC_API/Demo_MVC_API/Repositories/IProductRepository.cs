using Demo_MVC_API.Model;
using System.Collections.Generic;

namespace Demo_MVC_API.Repositories
{
    public interface IProductRepository
    {

        IEnumerable<Product> GetAllProducts();

        int AddProduct(Product prod);

        int Modifyproduct(Product prod);
        int DeleteProduct(int id);
    }
}
