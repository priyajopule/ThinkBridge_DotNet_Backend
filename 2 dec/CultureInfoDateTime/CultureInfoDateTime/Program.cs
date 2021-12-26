using System;
using System.Globalization;

namespace CultureInfoDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating culture info using datetime namespace");
            CultureInfo myculture = new CultureInfo();
            DateTime datetimeObj = Convert.ToDateTime("02/12/221",myculture);
            
            
            
            Console.WriteLine("date acc to US: "+datetimeObj.ToString());
            Calendar calenderObj = new Calendar();
            DateTime dt1 = new DateTime(2021,12,02,calenderObj);
            Console.WriteLine("yers:"+dt1.Year);
            Console.WriteLine("month:" + dt1.Month);
            Console.WriteLine("final date:" + dt1.ToString("d"));


        }
    }
}
