using System;
using System.Collections;

namespace GenericArraylist
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---generic arraylist-----");
            Test<int> list = new Test<int>();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }






        }
    }
}
