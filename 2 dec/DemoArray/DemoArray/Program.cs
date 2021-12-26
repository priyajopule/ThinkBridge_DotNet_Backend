using System;

namespace DemoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array implementation");
            string[] arr = { "one", "two", "three", "four", "five" };
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine("----------------------");
            arr[0] = "zero";
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
