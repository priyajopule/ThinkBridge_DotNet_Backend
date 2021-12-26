using System;

namespace Type__casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data types in c#");
            String message = "hello I am priya";
            Console.WriteLine(message);
            Console.WriteLine("data type of message is: "+ message.GetType());
            int age = 25;
            Console.WriteLine(age);
            Console.WriteLine("data type of age is: " + age.GetType());
            double averageSal = 50.3D;
            Console.WriteLine(averageSal);
            Console.WriteLine("data type of avergeSal is: " + averageSal.GetType());
            char choice = 'P';
            Console.WriteLine(choice);
            Console.WriteLine("data type of choice is: " + choice.GetType());
            bool onlineCashback = false;
            Console.WriteLine(onlineCashback);
            Console.WriteLine("data type of onlineCashback is: " + onlineCashback.GetType());

        }
    }
}
