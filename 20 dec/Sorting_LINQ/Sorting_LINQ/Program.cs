using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---sorting with LINQ----");
            string[] words = {"the", "red", "zoo", "hello", "zello" };

            IEnumerable<string> qry = from word in words
                                     orderby word.Length, word.Substring(0, 1) descending
                                     select word;

            foreach(string item in qry)
            {
                Console.WriteLine(item);
            }
        }
    }
}
