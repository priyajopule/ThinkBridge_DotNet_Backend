using System;

namespace Demo_on_Abstract
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("---area of rectangle-----");
            Rectangle rect = new Rectangle(5,5);
            rect.CalArea();
            Console.WriteLine(rect);
            



            Console.WriteLine("-----interfaces-------");
            ICustomer c = new Transaction();
            c.Printdetails();
            Console.WriteLine();

            IOrder o = new Transaction();
            o.Printdetails();
            Console.WriteLine();
        }
    }
}
