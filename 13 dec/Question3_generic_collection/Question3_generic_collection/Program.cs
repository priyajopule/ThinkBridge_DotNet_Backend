using System;
using System.Collections.Generic;

namespace Question3_generic_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---list of all students---");

            List<Student> stu = new List<Student>();
            stu.Add(new Student() { Rollno = 01, Name = " john ", Grade = 'A' });
            stu.Add(new Student() { Rollno = 02, Name = " shyam ", Grade = 'B' });
            stu.Add(new Student() { Rollno = 03, Name = " ram ", Grade = 'A' });
            stu.Add(new Student() { Rollno = 04, Name = " aditya ", Grade = 'A' });
            stu.Add(new Student() { Rollno = 05, Name = " amit ", Grade = 'C' });

            foreach (var item in stu)
            {
                Console.WriteLine(item);
            }



            
            
            Console.WriteLine("---list of students whose grade is A---");

            foreach (var item in stu)
            {
                //Console.WriteLine(item.Grade == 'A');
                if(item.Grade=='A')
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
