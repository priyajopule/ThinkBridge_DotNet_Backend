using System;

namespace Demo_NULLable_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....Demo on Nullable type....");
            bool? flag = null;
            Console.WriteLine(flag);
            int? num = null;
            if (num.HasValue)
            {
                Console.WriteLine($"b is: {num.Value}");
            }
            else
            {
                Console.WriteLine("num dose not contain any value");
            }



            Console.WriteLine("---using float---");
            float? num2 = 25.2f;
            if(num2.HasValue)
            {
                Console.WriteLine($"num2 has: {num2.Value}"); ;
            }
            else
            {
                Console.WriteLine("num2 dose not contain any value");
            }


            char? name = 'A';
            if(name.HasValue)
            {
                Console.WriteLine($"name has: {name.Value}");

            }
            else
            {
                Console.WriteLine("it as no value");
            }

     
        }
    }
}
