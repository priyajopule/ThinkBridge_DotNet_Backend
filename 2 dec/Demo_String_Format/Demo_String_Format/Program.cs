using System;

namespace Demo_String_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo on String formatting");
            Decimal price = 25.20m;
            String str = String.Format("The current prices is {0} per ounce", price);
            Console.WriteLine(str);
            String str1 = String.Format("It is now {0:d} at {0:t}", DateTime.Now);
            Console.WriteLine(str1);



            Console.WriteLine("-------------------------------");
            int[] years = { 2019, 2020, 2021 };
            int[] population = {12549, 8456971, 512364 };
            var sb = new System.Text.StringBuilder();
            sb.Append(String.Format("{0,6} {1,15}\n\n","year", "popuation"));

            for (int i = 0;i<years.Length;i++)
            {
                sb.Append(String.Format("{0,6} {1,15:N1}\n", years[i], population[i]));
            }

            Console.WriteLine(sb);




        }
    }
}
