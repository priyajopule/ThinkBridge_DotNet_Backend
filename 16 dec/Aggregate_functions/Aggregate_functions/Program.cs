using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---using aggregate function----");
            string[] myskills = { "html", "css", "java", "c#" };
            var commaSeperatedstring = myskills.Aggregate((s1, s2) => s1 + "," + s2);
            Console.WriteLine("MySkills : "+commaSeperatedstring);


            int[] Addition = { 1, 2, 3, 4, 5 };
            int sum = Addition.Aggregate(func: add);
            Console.WriteLine("sum is: "+sum);

        }

        private static int add(int a,int b)
        {
            return a + b;
        }
    }
}
