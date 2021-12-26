using Demo_MVC_API.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo_MVC_API.Entities
{
    public class RepositoriesContext:DbContext         //database context
    {
        public RepositoriesContext(DbContextOptions options):base(options)
        { }

        public DbSet<Product> Products { get; set; }                             //prop
       
    }
}
