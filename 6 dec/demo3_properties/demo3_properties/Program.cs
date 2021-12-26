using System;

namespace demo3_properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Demo on creating property and object initialization---");
            Student student = new Student();
            //student.RollNo = 10;                                    //property initialization
            //student.Name = "priya";
            //Console.WriteLine(student);

            Student student2 = new Student {RollNo=05, Name="priyanka", percentage=80};  // object initialization 
            Console.WriteLine(student2);

        }
    }
}
