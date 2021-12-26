using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;


namespace demo_on_dll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class1 class1 = new Class1();
            Assembly assembly = Assembly.LoadForm("C: \Users\PRIYA\source\repos\day3\demo_on_dll\MathLibrary\bin\Debug\net5.0\ref");
            
           
        }
    }
}
