namespace EF_CodeFirst_demo.Migrations
{
    using EF_CodeFirst_demo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    

    internal sealed class Configuration : DbMigrationsConfiguration<EF_CodeFirst_demo.Models.BookDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EF_CodeFirst_demo.Models.BookDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Book.AddOrUpdate(
                p=>p.Title,
                new Book {Id=101,Title="C#.NET",Price=500},
                new Book{ Id = 102,Title = "ASp.NET", Price = 750 },
                new Book { Id = 103, Title = "MVC-5", Price = 1000 }
                );
        }
    }
}
