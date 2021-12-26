using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo_join_LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---joins using LINQ---");
            
            List<Product> products = new List<Product>
            {
                new Product { PName = "Cola", CategoryID = 0 },
                new Product { PName = "Tea", CategoryID = 0 },
                new Product { PName = "Apple", CategoryID = 1 },
                new Product { PName = "Banana", CategoryID = 1 },
                new Product { PName = "Tomato", CategoryID = 2 },
                new Product { PName = "Carrot", CategoryID = 2 },

            };

            List<Category> categories = new List<Category>
            {
                new Category { CID=0, CategoryName="Beverage" },
                new Category { CID=1, CategoryName="Fruit" },
                new Category { CID=2, CategoryName="Vegetable" },

            };

            var qry = from Product in products
                      join Category in categories on
                      Product.CategoryID equals Category.CID
                      select new { Product.PName, Category.CategoryName };

          
                       
        
        
            foreach (var item in qry)
            {
                Console.WriteLine($"{item.PName} ---> {item.CategoryName}");
            }
        
        
        }

    }

}

