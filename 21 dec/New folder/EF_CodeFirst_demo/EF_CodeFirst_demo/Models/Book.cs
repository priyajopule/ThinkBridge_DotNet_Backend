using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace EF_CodeFirst_demo.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public decimal Price { get; set; }
    }

    public class BookDBContext : DbContext
    {
        public DbSet <Book> Book { get; set; }
    }
}