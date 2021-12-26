using System;

namespace DelegateEvent
{
    public delegate void mytestDel(string name);
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---demo on delegate and event---");
            //GetFname("Priya");
           // GetLname("Jopule");

            mytestDel mytestDel = new mytestDel(GetFname);
            mytestDel("i am priyanka");
            mytestDel mytestDel1 = new mytestDel(GetLname);
           
            mytestDel = new mytestDel(GetLname);
            mytestDel("Jopule");
        }


        public static void GetFname(string fname)
        {
            Console.WriteLine("name: "+fname);
        }

        public static void GetLname(string lname)
        {
            Console.WriteLine("name: " + lname);
        }
    }
}
