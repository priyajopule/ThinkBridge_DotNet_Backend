using System;
using System.Linq;

namespace OutKeyword_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("----out keyword----");

            int a;                                         // declare variable without initialization

            OutParamExample(out a);                        // calling method with out keyword

            Console.Write(a);                              // accessing out parameter value

            OutParamExample(out int b);                    // declare out variable while calling method
            Console.Write(b);                              // accessing out parameter value

            int random1, random2;
            GetMultipleRandomValue(out random1, out random2);

            Console.WriteLine($"{random1}, {random2}");*/


            Console.WriteLine("----property defination----");
            Person person = new("Nancy", "Davolio");
            Console.WriteLine(person);

        }
        
        /*
        public static void OutParamExample(out int x)
        {
            x = 100;
        }*/

        public static void GetMultipleRandomValue(out int x, out int y)
        {
            var random = new Random();
            x = random.Next();
            y = random.Next();
        }


        //records in c#
        public record Person(string FirstName, string LastName);

        /* public record Person
         {
             public string FirstName { get; init; } = default!;       // record types with multiple properties
             public string LastName { get; init; } = default!;
         };*/


    




}
}
