using Demo_MVC_API.Model;
using Demo_MVC_API.Repositories;
using System.Collections.Generic;

namespace Demo_MVC_API.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepository _iProductRepo;
       
        public ProductServices(IProductRepository iProductRepo)
        {
            _iProductRepo = iProductRepo;
        }

        public int AddProduct(Product prod)
        {
            return _iProductRepo.AddProduct(prod);
        }

        public int DeleteProduct(int id)
        {
            return _iProductRepo.DeleteProduct(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _iProductRepo.GetAllProducts();
        }

        public int Modifyproduct(Product prod)
        {
           return _iProductRepo.Modifyproduct(prod);
        }

        public object ModifyProduct(Product prod)
        {
            throw new System.NotImplementedException();
        }
    }
}
