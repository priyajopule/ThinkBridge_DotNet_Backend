using System;

namespace demo1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---demo on get and set method---");
            //creating object for date class
            Date mydate=new Date();
            mydate.SetData();
            Console.WriteLine(mydate.GetData());
        }
    }
}
