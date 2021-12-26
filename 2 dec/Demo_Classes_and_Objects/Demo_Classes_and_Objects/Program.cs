using System;

namespace Demo_Classes_and_Objects
{
    internal class Program
    {
        String name;
        static void Main(string[] args)
        {
            Console.WriteLine("-----demo on classes and objects-----");
            Program myobj=new Program();
            myobj.name = "priya";
            Console.WriteLine(myobj.name);

            Console.WriteLine("------------");
            Program newobj = myobj;
            Console.WriteLine(newobj.name);

            

         
            

        }
    }
}
