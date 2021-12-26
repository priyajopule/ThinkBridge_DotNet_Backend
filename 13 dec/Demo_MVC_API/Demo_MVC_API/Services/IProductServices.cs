using Demo_MVC_API.Model;
using System.Collections.Generic;

namespace Demo_MVC_API.Services
{
    public interface IProductServices
    {
        IEnumerable<Product> GetAllProducts();

        int AddProduct(Product prod);

        int Modifyproduct(Product prod); 
        int DeleteProduct(int id);
        object ModifyProduct(Product prod);
    }
}
