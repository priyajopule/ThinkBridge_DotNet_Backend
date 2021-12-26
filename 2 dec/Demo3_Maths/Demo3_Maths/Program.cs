using System;

namespace Demo3_Maths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("demonstrating Maths packages");
            Console.WriteLine("min value: "+Math.Min(100,999));
            Console.WriteLine("max value: "+Math.Max(100, 200));
            Console.WriteLine("pie value: "+Math.PI);
            Console.WriteLine("absolute value: "+Math.Abs(-500.333));
            Console.WriteLine("It will print round of value: "+Math.Round(5.6));

        }
    }
}
