using System;
using System.Collections.Generic;

namespace Question6_BookDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---books details whose price is less than 500---");
            List<Book> books = new List<Book>(); 
            books.Add(new Book() { BookName = "English", AuthorName = "Smith", Price = 200 });
            books.Add(new Book() { BookName = "Maths", AuthorName = "Patel", Price = 2000 });
            books.Add(new Book() { BookName = "History", AuthorName = "Joshi", Price = 450 });
            books.Add(new Book() { BookName = "biology", AuthorName = "Vivek", Price = 1500 });
            books.Add(new Book() { BookName = "Art", AuthorName = "Amit", Price = 400 });
            books.Add(new Book() { BookName = "Geography", AuthorName = "Krishna", Price = 1800 });

            foreach (var item in books)
            {
                if (item.Price<=500) 
                {
                    Console.WriteLine(item);
                }
            
            }
        }
    }
}
