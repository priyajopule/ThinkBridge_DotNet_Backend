using System;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your name is: " + name);
            Console.WriteLine("your age is: " + age);
            if (age>=18)
            {
                Console.WriteLine("you are eligible for voting");
            }
            else
            {
                Console.WriteLine("you are not eligible");
            }

        }
    }
}
