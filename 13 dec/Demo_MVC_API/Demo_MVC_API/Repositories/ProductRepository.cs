using Demo_MVC_API.Entities;
using Demo_MVC_API.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_MVC_API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        RepositoriesContext context;
        public ProductRepository(RepositoriesContext context)
        {
            this.context = context;
        }

        public int AddProduct(Product prod)
        {
            context.Products.Add(prod);
            context.SaveChanges();
            return 1;
        }

        public int DeleteProduct(int id)
        {
            var prod = context.Products.Where(p => p.PID == id).SingleOrDefault();
            if (prod != null)
            {
                context.Products.Remove(prod);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return context.Products.ToList();
        }

        public int Modifyproduct(Product prod)
        {
            var product = context.Products.Where(p => p.PID == prod.PID).SingleOrDefault();
            if (product != null)
            {
                product.Pname = prod.Pname;
                product.PPrice = prod.PPrice;
                context.SaveChanges();
                return 1;
            }
            else
            
                return 0;
            }

        }
 }


