using System;

namespace Student
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("demo on student details");
            StudentDetails std = new StudentDetails();
            std.SetData();
            Console.WriteLine(std.GetData());

        }
    }
}
