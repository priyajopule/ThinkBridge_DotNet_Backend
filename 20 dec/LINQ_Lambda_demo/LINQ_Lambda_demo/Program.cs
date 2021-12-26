using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ_Lambda_demo
{

    class student
    {
        public int age { get; set; }
        public int StuId { get; internal set; }
        public string StuName { get; internal set; }

        public override string ToString()
        {
            return "name:"+StuName + "  age:" + age + "  id:" + StuId;
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("----LINQ using lambda epression----");

            student[] studentArray =
            {
                new student() { StuId = 1, StuName = "priya", age = 20 },
                new student() { StuId = 2, StuName = "priyanka",age = 18 },
                new student() { StuId = 3, StuName = "aditya",age = 21 },
                new student() { StuId = 4, StuName = "adi",age = 25 },
            };

            
            Console.WriteLine("\n---youngest one---");
            student[] youngestOne=studentArray.Where(s => s.age > 12 && s.age < 20).ToArray();   //finding youngest

            foreach (var item in youngestOne)
            {
                Console.WriteLine(item);
            }



            //Find priya
            Console.WriteLine("\n---finding by name---");
            student name = studentArray.Where(s => s.StuName == "priya").FirstOrDefault();
            Console.WriteLine(name);

            Console.WriteLine("\n---finding by id=4---");
            student id = studentArray.Where(s => s.StuId == 4).FirstOrDefault();
            Console.WriteLine(id);

           

        }
    }


 
}
